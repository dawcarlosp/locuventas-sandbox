# Plan de Implementación — Cliente WinForms (VB.NET) para LocuVentas

> **Documento maestro para el agente autónomo.** Este archivo no cambia salvo que Carlos lo pida explícitamente.
> El estado vivo del trabajo va en `WINFORMS_PROGRESS.md` (ver §5), que SÍ se actualiza en cada sesión/commit.
> Este plan asume que también tienes disponible el documento **"ESPECIFICACIÓN COMPLETA DEL BACKEND — LocuVentas API"** (el que define todos los endpoints y DTOs). Si no lo tienes, pídeselo a Carlos antes de continuar — sin él no se puede ejecutar este plan con precisión.

---

## 0. Instrucciones para el agente que abre este archivo

1. Lee este documento completo antes de tocar código.
2. Comprueba si existe `WINFORMS_PROGRESS.md` en la raíz del proyecto WinForms.
   - **Existe** → ve directamente a la sección "Próximo paso inmediato" de ese archivo y continúa desde ahí. No repitas trabajo ya marcado como hecho — verifica compilando, no reconstruyendo.
   - **No existe** → estás empezando desde cero: ejecuta la **Fase 0** completa (que incluye crear ese archivo).
3. Trabaja fase por fase, en orden (§8). No saltes fases salvo que la dependencia ya esté resuelta.
4. Cada unidad de trabajo completa y que compila = 1 commit + 1 push a `develop` (ver §4). Nunca dejes `develop` con un build roto.
5. Actualiza `WINFORMS_PROGRESS.md` como parte del mismo commit (o el inmediatamente siguiente) cada vez que termines una tarea, aunque sea pequeña.
6. Si tienes que tomar una decisión de diseño no cubierta aquí: tómala tú mismo siguiendo los principios de §2, documenta el motivo en `ARCHITECTURE.md` y sigue trabajando. No te detengas a preguntar salvo los casos de §4.3.

---

## 1. Alcance

- **Incluye:** únicamente el proyecto WinForms (cliente de escritorio en VB.NET) que consume la API de LocuVentas ya existente.
- **No incluye:** cambios en el backend Spring Boot ni en el frontend React. Si detectas que el backend necesita un cambio, no lo toques — anótalo en "Bloqueadores" de `WINFORMS_PROGRESS.md` y sigue con lo que sí depende del cliente.

### Supuestos de partida (verifica en Fase 0; si no aplican, ajusta y documenta en ARCHITECTURE.md)

- El proyecto WinForms vive como carpeta propia (p. ej. `LocuVentasWinForms/`) dentro del mismo repo monorepo de LocuVentas. Si en realidad es un repo aparte, el plan no cambia, solo la ubicación raíz de los `.md` de documentación.
- Target: **.NET 8 (net8.0-windows)**, proyecto WinForms estilo SDK (permite `dotnet build` / `dotnet run`). Si ya existe con otra versión, respétala y anótalo.
- Existe rama `develop` en el remoto; si no, créala desde la rama por defecto antes de commitear.
- Backend en `http://localhost:8080` en desarrollo (según especificación).

---

## 2. Arquitectura (Clean Architecture adaptada a WinForms)

Principios no negociables:

- **Las Forms nunca llaman a `HttpClient` ni serializan JSON directamente.** Siempre pasan por una interfaz de servicio inyectada en el constructor (inyección manual por constructor, sin contenedor DI complejo — no hace falta para este tamaño de app).
- **Async/await en toda llamada de red.** Nunca `.Result` ni `.Wait()` (bloquean la UI y pueden deadlockear en WinForms).
- **Un único punto de manejo de errores** por Form: capturan `ApiException` y delegan en un helper (`ErrorDisplay`), nunca `Try/Catch` genéricos repetidos sin criterio.
- **El ApiClient tiene que reflejar una asimetría real de la API**: la mayoría de endpoints devuelven `ApiResponseDTO<T>` (con wrapper), pero **todo `/ventas/*` devuelve el DTO directo, sin wrapper**. Si diseñas un único método genérico que asuma wrapper siempre, romperá ventas. Por eso el ApiClient expone dos familias de métodos (ver §7).
- Las fotos que llegan como ruta relativa (`"productos/uuid.jpg"`, `"vendedores/uuid.jpg"`) se resuelven con un helper → `{BaseUrl}/imagenes/{tipo}/{filename}`. La foto de país (`paisFoto`) ya es una URL absoluta (flagcdn) y **no** debe re-prefijarse.
- 401 en cualquier llamada → evento global de "sesión expirada": limpia `TokenManager` y vuelve a `LoginForm`. No lo repitas Form por Form.

### Estructura de carpetas propuesta

```
LocuVentasWinForms/
├── Core/
│   ├── Models/              ' DTOs — copia literal de la especificación §3, ver notas abajo
│   └── Exceptions/          ' ApiException
├── Infrastructure/
│   ├── ApiClient.vb         ' Implementa IApiClient
│   ├── TokenManager.vb      ' Singleton en memoria: token, roles, usuario actual
│   └── ImageUrlHelper.vb
├── Services/
│   ├── Interfaces/          ' IAuthService, IProductoService, ICategoriaService,
│   │                        ' IPaisService, IVentaService, IUsuarioService
│   └── (implementaciones)
├── Forms/
│   ├── LoginForm.vb / RegisterForm.vb
│   ├── MainForm.vb
│   ├── Productos/
│   ├── Categorias/
│   ├── Ventas/
│   └── Admin/               ' UsuariosForm, EditarPerfilForm
├── Helpers/
│   ├── NavigationManager.vb ' visibilidad de menús/botones por rol
│   └── ErrorDisplay.vb
├── My.Settings (BaseUrl configurable — nativo de VB.NET, no requiere NuGet extra)
├── WINFORMS_PROGRESS.md
├── ARCHITECTURE.md
├── PATTERNS.md
└── LocuVentasWinForms.sln
```

### Nota sobre los DTOs

La especificación adjunta ya trae, en su sección 3, las clases VB.NET listas para copiar (`ApiResponse(Of T)`, `PageDTO(Of T)`, `LoginRequest/Response`, `UserRegisterRequest`, `UserEditRequest`, `UserResponse`, `ProductoResponse`, `ProductoCreateRequest`, `CategoriaResponse/CreateRequest`, `PaisResponse`, `VentaResponse`, `LineaVenta/Response`, `VentaCreateRequest`, `PagoRequest`, `ErrorResponse`). Cópialas tal cual como punto de partida. Dos cosas que la especificación deja ambiguas y que debes resolver tú en Fase 1:

- `ProductoUpdateRequest`: crea una clase explícita separada (mismo shape que `ProductoCreateRequest`), no reutilices la de creación aunque el shape coincida — evita acoplar "crear" y "editar" si algún día divergen.
- `CategoriaUpdateRequest`: igual, clase explícita aunque hoy sea idéntica a `CategoriaCreateRequest`.

---

## 3. Convenciones de código (contenido base para `PATTERNS.md`)

- Naming: `IXxxService` / `XxxService`, `XxxForm`, `XxxResponse`/`XxxRequest` (igual que la especificación), `XxxHelper`.
- Manejo de errores centralizado — `ErrorDisplay.Show(ex)`:
  - Si `ex.FieldErrors` tiene contenido → pinta cada mensaje junto al campo correspondiente (o los concatena en un `MessageBox` si el formulario no tiene validación visual por campo).
  - Si no → `MessageBox` estándar con `ex.Message`.
  - Si `ex.StatusCode = 401` → dispara el evento global de sesión expirada.
- Todo botón que dispara una llamada async se deshabilita mientras la llamada está en curso (evita doble submit y da feedback visual).

### Snippets de referencia

```vb
' Core/Exceptions/ApiException.vb
Public Class ApiException
    Inherits Exception

    Public Property StatusCode As Integer
    Public Property FieldErrors As Dictionary(Of String, String)

    Public Sub New(statusCode As Integer, message As String,
                   Optional fieldErrors As Dictionary(Of String, String) = Nothing)
        MyBase.New(message)
        Me.StatusCode = statusCode
        Me.FieldErrors = fieldErrors
    End Sub
End Class
```

```vb
' Infrastructure/IApiClient.vb
Public Interface IApiClient
    ' Para endpoints con wrapper ApiResponseDTO<T> (la mayoría)
    Function GetWrappedAsync(Of T)(endpoint As String) As Task(Of T)
    Function PostWrappedAsync(Of TReq, TRes)(endpoint As String, body As TReq) As Task(Of TRes)
    Function PutWrappedAsync(Of TReq, TRes)(endpoint As String, body As TReq) As Task(Of TRes)
    Function DeleteWrappedAsync(endpoint As String) As Task

    ' Para /ventas/* — DTO directo, sin wrapper
    Function GetAsync(Of T)(endpoint As String) As Task(Of T)
    Function PostAsync(Of TReq, TRes)(endpoint As String, body As TReq) As Task(Of TRes)
    Function PatchAsync(Of TRes)(endpoint As String) As Task(Of TRes)

    ' Multipart (registro, perfil, productos)
    Function PostMultipartAsync(Of TRes)(endpoint As String, jsonPartName As String,
        jsonPayload As Object, filePartName As String, filePath As String) As Task(Of TRes)

    ' Descarga binaria (ticket PDF)
    Function GetBytesAsync(endpoint As String) As Task(Of Byte())
End Interface
```

```vb
' Ejemplo de servicio — Services/ProductoService.vb
Public Class ProductoService
    Implements IProductoService

    Private ReadOnly _api As IApiClient
    Public Sub New(api As IApiClient)
        _api = api
    End Sub

    Public Async Function ListarAsync(page As Integer, size As Integer, search As String,
        Optional paisId As Long? = Nothing, Optional categoriaId As Long? = Nothing) _
        As Task(Of PageDTO(Of ProductoResponse)) Implements IProductoService.ListarAsync

        Dim query = $"productos?page={page}&size={size}&search={Uri.EscapeDataString(search)}"
        If paisId.HasValue Then query &= $"&paisId={paisId}"
        If categoriaId.HasValue Then query &= $"&categoriaId={categoriaId}"
        Return Await _api.GetWrappedAsync(Of PageDTO(Of ProductoResponse))(query)
    End Function
End Class
```

```vb
' Ejemplo de uso en un Form — patrón estándar para cualquier acción async
Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    btnGuardar.Enabled = False
    Try
        Dim resultado = Await _productoService.CrearAsync(dto, rutaFoto)
        MessageBox.Show("Producto creado correctamente")
        Me.DialogResult = DialogResult.OK
    Catch ex As ApiException
        ErrorDisplay.Show(ex)
    Finally
        btnGuardar.Enabled = True
    End Try
End Sub
```

---

## 4. Flujo de git para el agente

### 4.1 Commits
- Conventional Commits, con scope si es monorepo: `feat(winforms): ...`, `fix(winforms): ...`, `docs(winforms): ...`, `chore(winforms): ...`, `refactor(winforms): ...`.
- Un commit = una unidad de trabajo coherente que compila. No mezcles fases distintas en un commit.

### 4.2 Push directo a `develop`
- Tras cada commit que compila: `git pull --rebase origin develop` → `git push origin develop`.
- **Nunca `--force`.** Si el rebase produce conflictos que no puedes resolver con confianza: `git rebase --abort`, documenta el bloqueador exacto en `WINFORMS_PROGRESS.md` y termina la sesión ahí.
- Antes de cada push, el proyecto debe compilar (`dotnet build`) sin errores. La instrucción de "push directo" es "sin PR", no "sin build verde" — nunca subas algo roto a `develop`.

### 4.3 Cuándo SÍ detenerse a preguntar a Carlos
Solo en estos casos (todo lo demás, decídelo tú y documenta el porqué en `ARCHITECTURE.md`):
- Acción irreversible fuera de lo ya autorizado aquí (borrar una rama, force-push, eliminar archivos fuera del proyecto WinForms).
- El backend no responde o cambió de forma incompatible con la especificación — no es un problema del cliente, no lo arregles tú.
- Falta información de negocio que no está ni en la especificación ni es razonablemente inferible.

---

## 5. Continuidad entre sesiones (la parte más importante de este plan)

Crea y mantén estos tres archivos en la raíz del proyecto WinForms:

### `WINFORMS_PROGRESS.md` — estado vivo, se actualiza en cada sesión

Plantilla exacta:

```md
# Estado del proyecto WinForms — LocuVentas

Última actualización: <fecha> — commit <hash corto>

## Fase actual
Fase N — <nombre>

## Completado
- [x] Fase 0 — ...
- [x] Fase 1 — ...

## En progreso (fase actual)
- [ ] Tarea concreta 1
- [ ] Tarea concreta 2   ← aquí me quedé

## Próximo paso inmediato
<Instrucción específica y accionable, sin ambigüedad, para quien retome la sesión>

## Decisiones tomadas que no estaban en el plan original
- ...

## Bloqueadores / dudas abiertas
- (ninguno / lista)

## Build status
✅ compila y arranca / ❌ roto (detalle si roto)
```

### `ARCHITECTURE.md`
Capas, diagrama de carpetas (§2), y cualquier decisión de diseño estable que se tome sobre la marcha (con el porqué).

### `PATTERNS.md`
Ejemplos de código **reales del propio proyecto** para cada convención de §3 (no los snippets genéricos de este plan — los del proyecto ya escritos).

**Regla de oro:** si `WINFORMS_PROGRESS.md` dice que algo está hecho, confía en eso y no lo reconstruyas — verifícalo compilando, no reescribiendo.

---

## 6. Plan de fases

Cada fase incluye objetivo, tareas, criterio de "hecho" (DoD) y el commit esperado.

### Fase 0 — Cimientos
- Verificar/crear estructura de carpetas (§2).
- Verificar rama `develop` remota (crearla si no existe).
- Crear proyecto WinForms SDK-style (.NET 8) si no existe.
- Configurar `BaseUrl` vía `My.Settings` (nativo VB.NET, sin NuGet extra).
- Crear `WINFORMS_PROGRESS.md`, `ARCHITECTURE.md`, `PATTERNS.md` (esqueletos).
- **DoD:** el proyecto compila y arranca una ventana en blanco; `git log` muestra ≥1 commit en `develop`.
- **Commit:** `chore(winforms): scaffold project structure and docs`

### Fase 1 — Infraestructura core
- Todos los DTOs de la especificación §3 (+ `ProductoUpdateRequest`/`CategoriaUpdateRequest` explícitos).
- `ApiException`, `IApiClient`/`ApiClient` (wrapped + raw + multipart + descarga binaria).
- `TokenManager` (singleton en memoria).
- **DoD:** prueba manual (o test unitario) de login real contra el backend guarda el token correctamente.
- **Commit:** `feat(winforms): add DTO models and API client infrastructure`

### Fase 2 — Autenticación
- `IAuthService`/`AuthService` (login, registro multipart, editar perfil multipart).
- `LoginForm`, `RegisterForm`. Manejo específico de 401 (credenciales) vs 403 (cuenta no habilitada).
- **DoD:** login exitoso con un vendedor/admin real; mensaje claro si la cuenta no está habilitada.
- **Commit:** `feat(winforms): implement authentication (login/register/edit profile)`

### Fase 3 — Shell principal y navegación por rol
- `MainForm`, `NavigationManager` (oculta funciones admin a un vendedor), logout, redirección automática a Login ante un 401 en cualquier punto de la app.
- **DoD:** un `ROLE_VENDEDOR` no ve el menú de usuarios/administración; un `ROLE_ADMIN` sí.
- **Commit:** `feat(winforms): add main shell with role-based navigation`

### Fase 4 — Productos
- `IProductoService`/`ProductoService` (listar paginado+búsqueda+filtros, crear/editar multipart con foto, eliminar).
- `ProductosForm` (grid + paginación + búsqueda + filtros por país/categoría), `ProductoEditForm` (foto, categorías multi-selección, país dropdown, errores 400 pintados por campo).
- **DoD:** CRUD completo funcional contra el backend real, incluida subida de imagen.
- **Commit:** `feat(winforms): implement productos CRUD`

### Fase 5 — Categorías y Países
- `ICategoriaService` (CRUD + diálogo de conflicto 409 con opción de eliminación forzada vía `/force`).
- `IPaisService` (solo lectura, fuente para dropdowns).
- **DoD:** eliminar una categoría con productos asociados muestra el número de productos y ofrece "eliminar de todas formas".
- **Commit:** `feat(winforms): implement categorías (con force-delete) y países`

### Fase 6 — Ventas
- `IVentaService` (listar, pendientes, detalle, crear con múltiples líneas, registrar pago, cancelar —solo admin—, descargar ticket PDF).
- `VentasForm` (grid + detalle), `NuevaVentaForm` (selector de productos + cantidad), diálogo de pago, guardar/abrir el PDF descargado.
- **DoD:** flujo completo: crear venta → registrar pago parcial → ver saldo actualizado → descargar ticket.
- **Commit:** `feat(winforms): implement ventas (creación, pagos, cancelación, ticket PDF)`

### Fase 7 — Administración de usuarios
- `IUsuarioService` (listar pendientes paginado+búsqueda, asignar rol vendedor, eliminar).
- `UsuariosForm`.
- **DoD:** un admin ve usuarios recién registrados y puede habilitarlos como vendedores.
- **Commit:** `feat(winforms): implement admin user management`

### Fase 8 — Pulido y cierre
- Manejo global de excepciones no capturadas (`Application.ThreadException`).
- Indicadores de carga / botones deshabilitados durante llamadas async (revisión transversal).
- Helper de imágenes verificado en todas las `PictureBox`.
- README del proyecto.
- (Opcional, no bloqueante) pruebas unitarias ligeras de servicios con `HttpMessageHandler` mockeado.
- **DoD:** recorrido manual completo de la app sin errores no controlados.
- **Commit:** `chore(winforms): polish, global error handling, README`

### Fuera de alcance por ahora (anotar como backlog, no implementar salvo que Carlos lo pida)
- Tema oscuro / theming avanzado.
- Caché offline.
- Exportar listados a Excel/CSV.
- Tests de UI automatizados.

---

## 7. Cómo arrancar (para Carlos)

Dale al agente (Claude Code / OpenCode) **este archivo junto con la especificación completa del backend**, con un prompt del estilo:

> "Lee WINFORMS_AGENT_PLAN.md completo, junto con la especificación de la API adjunta. Comprueba si existe WINFORMS_PROGRESS.md; si no existe, empieza por la Fase 0. Trabaja fase por fase, comitea y pushea a develop siguiendo la sección 4, y mantén WINFORMS_PROGRESS.md actualizado según la sección 5. No te detengas a pedirme confirmación salvo lo indicado en la sección 4.3."

Para retomar en cualquier sesión futura basta con: *"Lee WINFORMS_AGENT_PLAN.md y WINFORMS_PROGRESS.md y continúa."*

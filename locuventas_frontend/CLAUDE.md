# LocuVentas — Frontend

> Sistema de gestión de ventas para comercios.
> Vendedores gestionan productos, registran ventas y cobran pagos.
> Administradores gestionan personal y catálogo.

---

## 📖 Cómo usar este documento

**Este archivo es la guía estática de referencia.** Contiene convenciones,
stack, estructura y comandos que NO cambian entre iteraciones.

**Para el estado dinámico del proyecto, leer estos archivos en orden:**

| Orden | Archivo | Qué contiene |
|-------|---------|-------------|
| 1️⃣ | `src/docs/SESSION.md` | Estado actual: iteración, rama, último commit, qué toca ahora |
| 2️⃣ | `src/docs/TASKS.md` | Cola de tareas: qué hay que hacer, qué está pendiente |
| 3️⃣ | `src/docs/CHANGELOG.md` | Historial: qué se ha hecho en cada iteración |
| 4️⃣ | `src/docs/KNOWN_ISSUES.md` | Bugs activos y deuda técnica |
| 5️⃣ | `src/docs/DECISIONS.md` | Decisiones de arquitectura (ADR) |
| 6️⃣ | `src/docs/ARCHITECTURE.md` | Arquitectura del sistema |
| 7️⃣ | `src/docs/PATTERNS.md` | Patrones de diseño aplicados |
| 8️⃣ | `src/docs/DONT_DO.md` | Errores ya corregidos que no repetir |

### Regla del bucle infinito

```
1. Leer SESSION.md  → saber estado exacto
2. Leer TASKS.md    → saber qué toca ahora
3. Leer RULES.md    → reglas del bucle infinito
4. Leer CLAUDE.md   → convenciones y stack
5. Leer docs necesarios según la tarea
6. TRABAJAR: hacer cambios en código
7. npm run build    → verificar que compila
8. ACTUALIZAR: CHANGELOG.md, TASKS.md, SESSION.md, KNOWN_ISSUES.md
9. git add -A, git commit -m "tipo: descripción clara"
10. git push origin master
11. VOLVER AL PASO 1 — hasta que el usuario diga "para"
```

**Reglas de oro:**
- No pedir permiso. No preguntar. Decidir y ejecutar.
- Cada commit debe dejar la app funcional (npm run build antes de commitear).
- Si un cambio rompe algo, arreglarlo antes del siguiente commit.
- Si TASKS.md se vacía, escanear KNOWN_ISSUES.md, luego escanear el código en busca de mejoras, luego proponer features nuevas.
- Trabajar siempre en master, push directo, sin PRs ni ramas.
- Commits con conventional commits: feat:, fix:, refactor:, chore:, test:, docs:.

---

## Stack

| Tecnología | Versión | Uso |
|------------|---------|-----|
| React | 19 | Framework UI |
| TypeScript | 6.x | Tipado estático (100% migrado) |
| Vite | 6.x | Bundler y dev server |
| Tailwind CSS | 4.x | Estilos utility-first |
| @tailwindcss/vite | 4.x | Plugin Vite para Tailwind v4 |
| React Router | 7 | Navegación SPA |
| React Toastify | — | Notificaciones |
| Lucide React | — | Iconos |
| FontAwesome | — | Iconos adicionales |
| date-fns | — | Manipulación de fechas |
| html-to-image | — | Captura de DOM a imagen |

---

## Estructura del proyecto

```
src/
├── app/                        # Punto de entrada
│   ├── main.tsx
│   ├── App.tsx
│   ├── providers.tsx           # AuthProvider + HeaderProvider
│   ├── PrivateRoute.tsx        # Guard de rutas protegidas
│   ├── routes.tsx
│   └── config/api.ts           # API_BASE_URL
├── components/
│   ├── common/                 # Componentes reutilizables
│   │   ├── buttons/            # Button.tsx, MenuButton.tsx
│   │   ├── Avatar.tsx
│   │   ├── BaseModal.tsx
│   │   ├── BuscadorInput.tsx
│   │   ├── DataTable.tsx
│   │   ├── DropdownContainer.tsx
│   │   ├── Error.tsx
│   │   ├── FAB.tsx
│   │   ├── FooterLogin.tsx
│   │   ├── FormDialog.tsx
│   │   ├── ImageUpload.tsx
│   │   ├── InputFieldset.tsx
│   │   ├── InputFieldsetValidaciones.tsx
│   │   ├── LogoNegocio.tsx
│   │   ├── ModalConfirmacion.tsx
│   │   ├── Paginacion.tsx
│   │   ├── RecursiveMenu.tsx
│   │   ├── SelectBase.tsx
│   │   ├── SelectForm.tsx
│   │   ├── SelectFilter.tsx
│   │   ├── Skeleton.tsx
├── constants/
│   ├── breakpoints.ts
│   ├── states.ts
│   └── index.ts
├── context/
│   ├── AuthContext.tsx
│   ├── HeaderContext.tsx
│   └── useAuth.ts
├── domain/
│   ├── api.types.ts            # ApiResponse<T>, PageDTO<T>
│   └── ui.types.ts             # SelectOption, Breakpoint, MenuItem
├── features/                   # Organizado por dominio de negocio
│   ├── auth/                   # Login, registro, aprobación
│   │   ├── components/
│   │   ├── domain/             # auth.types.ts, vendedor.types.ts
│   │   ├── hooks/              # useLogin, useRegister, useEditarPerfil
│   │   └── pages/              # LoginPage, VendedoresPendientesPagina
│   ├── categorias/             # Gestión de categorías CRUD
│   │   ├── components/         # GestionCategorias.tsx
│   │   ├── domain/             # categoria.types.ts
│   │   ├── hooks/              # useGestionCategorias.ts
│   │   └── pages/              # GestionCategoriasPagina.tsx
│   ├── dev/                    # Perfil del desarrollador
│   │   ├── components/         # SobreMi.tsx
│   │   └── pages/              # SobreMiPage.tsx
│   ├── productos/              # Catálogo y gestión CRUD
│   │   ├── components/         # CatalogoProductos, GestionProductos...
│   │   ├── domain/             # producto.types.ts
│   │   ├── hooks/              # useProductos, useGestionProductos...
│   │   └── pages/              # GestionProductosPagina.tsx
│   └── ventas/                 # Carrito, ventas, cobros
│       ├── components/         # CarritoVentas, ContenedorVentas...
│       ├── domain/             # venta.types.ts
│       ├── hooks/              # useCarrito, useVentasManager
│       └── pages/              # Dashboard, VentasPagina...
├── hooks/                      # Hooks globales
│   ├── useBuscador.ts
│   ├── useBreakpoint.ts
│   ├── useHeaderManager.ts
│   ├── usePaginatedFetch.ts    # Hook genérico para listas paginadas
│   ├── useResponsiveLayout.ts
│   └── useVendedoresPendientes.ts
├── layout/
│   ├── AppLayout.tsx
│   ├── Aside.tsx
│   ├── Footer.tsx
│   ├── Main.tsx
│   └── Header/
│       ├── Header.tsx
│       ├── NavDesktop.tsx
│       ├── NavMobile.tsx
│       ├── components/         # AdminMenu, GestionDropdown, MenuUsuarioDropdown
│       └── config/             # adminMenuConfig.ts, userMenuConfig.ts
├── services/
│   ├── api.ts                  # apiRequest<T>() — cliente HTTP centralizado
│   └── venta.service.ts        # descargarTicketPDF
└── utils/
    ├── imageUtils.ts
    └── user.validator.ts
```

---

## Capas y responsabilidades

```
features/*/pages/           Orquesta: instancia hooks, pasa props, renderiza modales
features/*/components/      Presentación: recibe props, no llama a la API
features/*/hooks/           Lógica de negocio y estado del feature
hooks/ (raíz) + common/     Hooks y componentes compartidos
services/api.ts             Única puerta de entrada al backend
domain/ + features/*/d…     Tipos TypeScript
```

**Regla fundamental:** los componentes no llaman a `apiRequest` directamente.
Toda llamada al backend pasa por un hook.

---

## Convenciones

### TypeScript
- Nunca usar `any` — usar `unknown` con cast explícito
- `Record<string, unknown>` para datos crudos de la API antes de mapear
- Tipos en `features/*/domain/` o `src/domain/` — nunca inline en componentes

### Componentes
- PascalCase: `ProductoCard`, `TablaVentas`
- Un componente por archivo
- No llaman a la API directamente

### Hooks
- Prefijo `use`: `useProductos`, `useCarrito`
- Feature hooks en `features/X/hooks/`
- Hooks compartidos en `hooks/` raíz
- Devuelven objeto con props nombradas, no array

### Paginación
- Hook gestiona `page`, `size`, `totalPages`
- Componente recibe props y renderiza `<Paginacion />`
- Al buscar/filtrar, resetear `page = 0`

---

## API y autenticación

- **Base URL:** `VITE_API_URL` en `.env`
- **Auth:** JWT en `Authorization: Bearer <token>`
- **Token:** `localStorage` clave `"auth"`
- **Respuesta:** `ApiResponse<T>` = `{ message, status, data }`
- **Paginación:** `PageDTO<T>` = `{ content, number, totalPages, totalElements }`

```ts
const res = await apiRequest<ApiResponse<PageDTO<Producto>>>(
  `productos?page=${page}&size=${size}`,
  null,
  { method: "GET" }
);
```

---

## Roles y rutas

```
ROLE_ADMIN      → acceso total
ROLE_VENDEDOR   → dashboard, ventas, perfil
Sin rol         → solo login (pendiente de aprobación)
```

Protegidas con `<PrivateRoute>` en `app/routes.tsx`.

---

## Esquema de colores (Tailwind)

| Elemento | Color |
|----------|-------|
| Fondo principal | `zinc-900` |
| Fondo secundario | `zinc-800` |
| Bordes | `zinc-700` / `purple-500` |
| Acento principal | `orange-500` |
| Acento secundario | `purple-500` |
| Texto primario | `white` / `zinc-100` |
| Texto secundario | `zinc-400` |
| Éxito | `emerald-500` |
| Peligro | `rose-500` |
| Alerta | `amber-500` |

---

## Variables de entorno

```env
VITE_API_URL=http://localhost:8080
VITE_GEMINI_API_KEY=...         # Fase 4
```

---

## Convención de nombres de ramas

```
No se usan ramas. Todo el trabajo se hace sobre master.
```

### Flujo de trabajo

```
1. Trabajar directamente en master
2. Commit con conventional commits
3. Push directo a origin master
4. Repetir
```

---

## Comandos

```bash
npm run dev      # servidor de desarrollo
npm run build    # build de producción
npm run preview  # previsualizar el build
```

# Migration Plan

> Hoja de ruta de evolución del frontend de LocuVentas.
> Para la arquitectura actual ver [ARCHITECTURE.md](./ARCHITECTURE.md).

---

## Estado actual

```
✅ Fase 1 — TypeScript (completada)
✅ Reorganización feature-based (completada)
✅ Fase 2 — Unificar componentes duplicados
✅ Fase 3 — Refactor arquitectura
✅ Gestión de categorías (CRUD completo)
✅ Fase 4 — Integración Gemini AI (completada con IA local LanguageModel API)
```

---

## Fase 1 — Migración a TypeScript ✅

Migración completada al 100%. Todos los archivos de `src/` son `.tsx` o `.ts`
(0 archivos `.jsx`/`.js`).

### Reglas aplicadas

- Nunca usar `any` — usar `unknown` con cast explícito cuando sea necesario
- Tipos nuevos siempre en `src/domain/` — nunca inline en componentes
- `Record<string, unknown>` para datos crudos de la API antes de mapear
- Al migrar un hook, añadir el tipo de retorno explícito como interfaz

---

## Reorganización feature-based ✅

Completada. Todos los dominios migrados a `src/features/` siguiendo la
estructura `{domain}/{components,domain,hooks,pages}/`:

| Rama | Feature | Estado |
|------|---------|--------|
| `refactor/migrate-to-feature-structure` | `auth/` | ✅ mergeado |
| `refactor/feature-productos` | `productos/` | ✅ mergeado |
| `refactor/feature-ventas` | `ventas/` | ✅ mergeado |
| `refactor/feature-dev` | `dev/` | ✅ mergeado |

### Estructura resultante

```
src/features/
├── auth/               # Login, registro, aprobación de vendedores
│   ├── components/     # PendientesList, TarjetaVendedor, FormLogin...
│   ├── domain/         # auth.types.ts, vendedor.types.ts
│   ├── hooks/          # useLogin, useRegister, useEditarPerfil
│   └── pages/          # LoginPage, VendedoresPendientesPagina
├── categorias/         # Gestión de categorías CRUD
│   ├── components/     # GestionCategorias.tsx
│   ├── domain/         # categoria.types.ts
│   ├── hooks/          # useGestionCategorias.ts
│   └── pages/          # GestionCategoriasPagina.tsx
├── dev/                # Perfil del desarrollador
│   ├── components/     # SobreMi.tsx
│   └── pages/          # SobreMiPage.tsx
├── productos/          # Catálogo y gestión de productos
│   ├── components/     # CatalogoProductos, GestionProductos, ...
│   ├── domain/         # producto.types.ts
│   ├── hooks/          # useProductos, useGestionProductos, useFiltrosProducto
│   └── pages/          # GestionProductosPagina.tsx
└── ventas/             # Ventas, carrito y cobros
    ├── components/     # CarritoVentas, ContenedorVentas, ModalPago...
    ├── domain/         # venta.types.ts
    ├── hooks/          # useCarrito, useVentasManager
    └── pages/          # Dashboard, VentasPagina, VentasPendientesPagina
```

---

## Fase 2 — Refactor de componentes duplicados 🔲

> **Nota:** `SelectFieldset` + `SelectFiltro` no se unificaron porque tienen props muy divergentes (`multiple`, `required`, firma de `onChange`, etc.). Se extrajo lógica compartida en `SelectBase` y se renombraron.

| Rama | Qué hace | Estado |
|------|----------|--------|
| `refactor/phase2-button` | Unificar `Boton`, `BotonClaro`, `Enlace` → `Button` con `variant` | ✅ |
| `refactor/rename-selects` | Extraer lógica compartida en `SelectBase` + renombrar `SelectFieldset` → `SelectForm`, `SelectFiltro` → `SelectFilter` | ✅ |
| **`refactor/phase2-upload`** | **Unificar `UploadComponent` + `UploadAvatar` → `ImageUpload` con `shape`** | **✅** |
| `refactor/phase2-skeleton` | Extraer skeletons inline a archivos independientes: `SkeletonVentaCard`, `SkeletonProductoGestionCard` | ✅ |

## Fase 3 — Refactor arquitectura ✅

| Rama | Qué hace | Estado |
|------|----------|--------|
| `docs/infinite-loop` | Crear `usePaginatedFetch<T>` genérico y refactorizar hooks | ✅ |
| `docs/infinite-loop` | Mover `PrivateRoute` → `app/` | ✅ |
| `docs/infinite-loop` | Mover `FooterLogin` → `components/common/` | ✅ |

---

## Fase 4 — Integración Gemini AI ✅

**Prerequisito:** Fases 1-3 completadas.

### Casos de uso implementados

```
1. ✅ Búsqueda semántica de productos — useBusquedaSemantica
   — El vendedor describe el producto con lenguaje natural
   — Gemini devuelve los productos más relevantes

2. ✅ Resumen de ventas — useResumenVentas
   — El admin pide un resumen del día/semana
   — Gemini genera un informe en lenguaje natural

3. ✅ Sugerencias de categorización — useSugerirCategorias
   — Al crear un producto, Gemini sugiere categorías basadas en el nombre
```

### Ubicación en la arquitectura

```
src/
└── shared/
    └── ai/                     # Cliente IA local (LanguageModel API)
        ├── index.ts
        ├── gemini.client.ts    # Cliente: LanguageModel.create() + session.prompt()
        ├── useGemini.ts        # Hooks useGemini<T> y useGeminiJson<T>
        └── prompts/            # Prompts organizados por caso de uso
            ├── productos.prompts.ts
            └── ventas.prompts.ts
```

### Notas de implementación

- La IA funciona **100% local en el navegador** usando la `LanguageModel` API (Gemini Nano).
- No requiere API key remota ni proxy backend.
- Solo disponible en Chrome con flag `#optimization-guide-on-device-model`.
- Los hooks `useBusquedaSemantica`, `useSugerirCategorias` y `useResumenVentas` viven en `features/productos/hooks/` y `features/ventas/hooks/` respectivamente.

### Variables de entorno

```env
VITE_API_URL=http://localhost:8080
# Nota: VITE_GEMINI_API_KEY eliminada — la IA es local, no necesita clave remota.
```

---

## Decisiones técnicas descartadas

### ❌ Renombrado masivo español → inglés
Rompe el historial de Git y todos los imports existentes sin aportar valor
funcional. Se mantiene español en archivos ya existentes y se usa inglés
solo en archivos nuevos de las fases 2 y 3.

### ❌ Migrar a Zustand o Redux
Context API es suficiente para la escala actual. Si en el futuro el estado
global crece significativamente, Zustand sería la opción — pero no antes
de que haya un problema real de rendimiento o complejidad.

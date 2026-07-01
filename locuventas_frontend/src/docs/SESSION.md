# Session State

> ⚠️ **LEER PRIMERO.** Este archivo es la fuente única de verdad del estado actual.
> La IA debe leerlo al inicio de cada sesión y actualizarlo al final (paso 1 y 8 del bucle).

---

## Estado actual

| Campo | Valor |
|-------|-------|
| **Iteración** | 14 |
| **Rama activa** | `master` (push directo, sin PRs) |
| **Último commit** | `3901bf2` — feat: integra sugerencia IA de categorías en formulario de producto |
| **Remote** | `dawcarlosp/locuventas-sandbox.git` |
| **Working tree** | `C:\Users\cpere\Documents\locuventas-sandbox` |
| **Estado del build** | 🟢 Build exitoso |

---

## Qué se hizo

### Iteración 14 — Migración de Gemini API remota a IA local (Gemini Nano)

- [x] `gemini.client.ts` ahora usa `LanguageModel.create()` + `session.prompt()` en lugar de fetch a API remota
- [x] Eliminado backend proxy (`AiController`, `AiService`) que ya no se necesita
- [x] Eliminado `VITE_GEMINI_API_KEY` de `.env`
- [x] Añadida declaración TypeScript para `LanguageModel` global
- [x] La IA funciona 100% local en el navegador (Chrome + Gemini Nano)

### Iteración 13 — Sugerencia IA de categorías

- [x] Botón "Sugerir IA" en formulario de producto
- [x] Selecciona automáticamente categorías sugeridas por Gemini
- [x] Solo visible al crear producto (no al editar)

### Iteración 12 — Resumen de ventas con IA

- [x] Botón "Resumen IA" en VentasPagina
- [x] Card con spinner y texto del resumen generado por Gemini
- [x] Integración real con Gemini via `useResumenVentas`

### Iteración 11 — Búsqueda semántica en catálogo

- [x] Botón "Búsqueda IA" en CatalogoProductos
- [x] Alterna entre filtros clásicos y búsqueda por lenguaje natural
- [x] Integración real con Gemini via `useBusquedaSemantica`

### Iteración 10 — ErrorBoundary global

- [x] `ErrorBoundary` con UI de recuperación (botón recargar)
- [x] Envuelta en `App.tsx` para proteger toda la app

### Iteración 9 — Lazy loading en rutas

- [x] 7 páginas migradas a `React.lazy()` con `Suspense`
- [x] Bundle principal reducido 472KB → 292KB (-38%)

### Iteración 8 — Tests de integración

- [x] `test-utils.tsx` con providers (BrowserRouter + Auth + Header)
- [x] 3 tests para `LoginPage` (renderizado, botones, enlaces)

### Iteración 7 — Tests unitarios con Vitest

- [x] Instalado y configurado Vitest + Testing Library + jsdom
- [x] 5 tests para `useBuscador` (debounce, estado, limpieza)
- [x] 4 tests para `useCarrito` (totales, IVA, múltiples productos)

### Iteración 6 — Eliminar ComponentType<any> de PANEL_MAP

- [x] `PANEL_MAP` migrado a factory functions tipadas
- [x] Eliminado el último `any` del componente

### Iteración 5 — Unificar skeletons

- [x] `Skeleton.tsx` con `variant="producto-card|tarjeta-vendedor|venta-card|producto-gestion-card"`
- [x] Eliminados 4 skeletons individuales
- [x] 4 consumidores actualizados para usar `Skeleton`

### Iteración 4 — Fase 4: Integración Gemini AI

- [x] `shared/ai/gemini.client.ts` — Cliente HTTP para Google Gemini API
- [x] `shared/ai/useGemini.ts` — Hooks `useGemini<T>` y `useGeminiJson<T>`
- [x] `shared/ai/prompts/productos.prompts.ts` — Prompts búsqueda semántica y categorización
- [x] `shared/ai/prompts/ventas.prompts.ts` — Prompt resumen de ventas
- [x] `features/productos/hooks/useBusquedaSemantica.ts` — Búsqueda semántica con IA
- [x] `features/productos/hooks/useSugerirCategorias.ts` — Sugerencia de categorías
- [x] `features/ventas/hooks/useResumenVentas.ts` — Resumen de ventas con IA
- [x] `.env` — Añadida `VITE_GEMINI_API_KEY`

### Iteración 3 — Gestión de categorías

- [x] Backend: `CategoriaCreateDTO`, `ProductoCategoriaRepository`
- [x] Backend: `CategoriaService.create/update/delete/deleteWithProducts`
- [x] Backend: `CategoriaController` + Swagger docs
- [x] Frontend: `features/categorias/` — types, hook, component, page
- [x] Ruta `/categorias/gestion` en routes.tsx
- [x] Menú admin actualizado (Categorías funcional)
- [x] Remoto cambiado de `repositorioPereira` → `locuventas-sandbox`
- [x] Worktree movido a `C:\Users\cpere\Documents\locuventas-sandbox`

---

## Siguientes tareas

Ver `TASKS.md` para la cola priorizada.

---

## Bloqueadores

- Ninguno

---

## Notas para la próxima IA

- Leer `RULES.md` primero para entender las reglas del bucle infinito.
- Leer `CLAUDE.md` para convenciones, stack, comandos.
- Leer `ARCHITECTURE.md` para entender la estructura.
- Leer `TASKS.md` para saber qué toca ahora.
- **Trabajar siempre en master, push directo, sin preguntar.**
- **Ejecutar `npm run build` antes de cada commit.**
- **Actualizar SESSION.md, CHANGELOG.md, TASKS.md, KNOWN_ISSUES.md en cada iteración.**
- Si se queda sin tareas, escanear KNOWN_ISSUES.md, luego el código, luego proponer mejoras.

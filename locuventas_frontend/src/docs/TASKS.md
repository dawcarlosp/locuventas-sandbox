# Tasks

> Cola de tareas priorizada. La IA consulta este archivo al inicio de cada sesión.
> Cuando se vacía, la IA escanea KNOWN_ISSUES.md y el código en busca de mejoras.
>
> Estados: `pending` | `in_progress` | `done` | `cancelled` | `blocked`

---

## Gestión de categorías ✅

| # | Tarea | Estado | Notas |
|---|-------|--------|-------|
| C.1 | Backend: CategoriaCreateDTO | `done` | DTO con `@NotBlank` |
| C.2 | Backend: CategoriaService CRUD | `done` | create, update, delete, deleteWithProducts |
| C.3 | Backend: CategoriaController endpoints | `done` | POST, PUT, DELETE, DELETE /force |
| C.4 | Frontend: types + hook + component + page | `done` | features/categorias/ completo |
| C.5 | Ruta y menú admin | `done` | /categorias/gestion + enlace funcional |
| C.6 | Fix editando reference error | `done` | Faltaba en destructuring |

## Bugs y mejoras

| # | Tarea | Prioridad | Estado | Notas |
|---|-------|-----------|--------|-------|
| B.3 | Eliminar `ComponentType<any>` en `PANEL_MAP` de `RecursiveMenu` | `baja` | `pending` | Pendiente de encontrar alternativa limpia |
| B.4 | Unificar skeletons en un solo `Skeleton` con `variant` | `baja` | `pending` | Propuesto: `variant="card\|row\|circle"` |

## Fase 4 — Integración Gemini AI

| # | Tarea | Prioridad | Estado | Notas |
|---|-------|-----------|--------|-------|
| 4.1 | Crear `shared/ai/gemini.client.ts` | `media` | `pending` | Cliente Gemini con API key |
| 4.2 | Crear `shared/ai/useGemini.ts` | `media` | `pending` | Hook genérico para llamadas a Gemini |
| 4.3 | Implementar búsqueda semántica de productos | `media` | `pending` | Vendedor describe producto en lenguaje natural |
| 4.4 | Implementar resumen de ventas con IA | `media` | `pending` | Admin pide resumen del día/semana |
| 4.5 | Implementar sugerencias de categorización | `media` | `pending` | Al crear producto, Gemini sugiere categorías |

## Tests

| # | Tarea | Prioridad | Estado | Notas |
|---|-------|-----------|--------|-------|
| T.1 | Añadir tests unitarios a hooks principales | `baja` | `pending` | useCarrito, useProductos, useGestionProductos |
| T.2 | Añadir tests de integración a páginas críticas | `baja` | `pending` | LoginPage, VentasPagina, GestionProductosPagina |

# Known Issues

> Bugs activos, deuda técnica, warnings y cosas pendientes.
> Cuando TASKS.md se vacía, escanear este archivo para la siguiente tarea.

---

## Deuda técnica

| # | Issue | Prioridad | Notas |
|---|-------|-----------|-------|
| 1 | `ComponentType<any>` en `PANEL_MAP` de `RecursiveMenu` | `baja` | ✅ Resuelto en #6 — factory functions con `Record<string, unknown>` |
| 2 | Skeletons no unificados | `baja` | ✅ Resuelto en #5 — `Skeleton` con `variant` |

---

## Errores de tipo (TypeScript)

| # | Issue | Archivo | Estado | Notas |
|---|-------|---------|--------|-------|
| 1 | ~~`ComponentType<any>` en `PANEL_MAP`~~ | `RecursiveMenu.tsx` | `resuelto` | ✅ Resuelto en #6 |

---

## Mejoras pendientes (sin priorizar)

- Backend: migrar de MySQL a PostgreSQL o similar
- Backend: Dockerizar la aplicación
- Frontend: añadir lazy loading a rutas pesadas
- Frontend: tests unitarios y de integración
- Caché de imágenes de productos
- Paginación virtual para tablas grandes

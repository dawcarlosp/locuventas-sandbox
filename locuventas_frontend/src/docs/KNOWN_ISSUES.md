# Known Issues

> Bugs activos, deuda técnica, warnings y cosas pendientes.
> Cuando TASKS.md se vacía, escanear este archivo para la siguiente tarea.

---

## Deuda técnica

| # | Issue | Prioridad | Notas |
|---|-------|-----------|-------|
| 1 | `ComponentType<any>` en `PANEL_MAP` de `RecursiveMenu` | `baja` | No se encontró alternativa limpia; los componentes del mapa tienen firmas de props distintas |
| 2 | Skeletons no unificados | `baja` | `SkeletonProductoCard`, `SkeletonTarjetaVendedor`, `SkeletonVentaCard` son casi idénticos. Pendiente unificar en un solo `Skeleton` con `variant` |

---

## Errores de tipo (TypeScript)

| # | Issue | Archivo | Estado | Notas |
|---|-------|---------|--------|-------|
| 1 | `ComponentType<any>` en `PANEL_MAP` | `RecursiveMenu.tsx` | `aceptado` | Documentado en DONT_DO.md como caso especial pendiente de resolver |

---

## Mejoras pendientes (sin priorizar)

- Backend: migrar de MySQL a PostgreSQL o similar
- Backend: Dockerizar la aplicación
- Frontend: añadir lazy loading a rutas pesadas
- Frontend: tests unitarios y de integración
- Caché de imágenes de productos
- Paginación virtual para tablas grandes

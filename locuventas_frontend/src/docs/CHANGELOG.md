# Changelog

> Registro cronológico de cambios por iteración.
> Cada entrada corresponde a una iteración del bucle de desarrollo IA.
> Formato: `#{iteración} — {fecha}`

---

## #3 — Gestión de categorías

**Objetivo:** CRUD completo de categorías con borrado condicional.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `CategoriaCreateDTO.java` | ✨ Nuevo | DTO con validación `@NotBlank` |
| `ProductoCategoriaRepository.java` | ✨ Nuevo | Repositorio para limpiar relaciones |
| `CategoriaService.java` | ♻️ Mejora | `create/update/delete/deleteWithProducts` |
| `CategoriaController.java` | ♻️ Mejora | Endpoints POST, PUT, DELETE, DELETE /force |
| `CategoriaApi.java` | ♻️ Mejora | Documentación Swagger |
| `categoria.types.ts` | ✨ Nuevo | Tipos `Categoria`, `CategoriaCreateDTO` |
| `useGestionCategorias.ts` | ✨ Nuevo | Hook CRUD con lógica de borrado condicional |
| `GestionCategorias.tsx` | ✨ Nuevo | Componente de gestión (tabla + modales) |
| `GestionCategoriasPagina.tsx` | ✨ Nuevo | Página con layout |
| `routes.tsx` | ♻️ Mejora | Ruta `/categorias/gestion` |
| `adminMenuConfig.ts` | ♻️ Mejora | Enlace funcional a categorías |
| `fix/gestion-categorias-reference-error` | 🐛 Fix | `editando` faltante en destructuring |

### Commits

```
da1b966 feat: implementa gestión completa de categorías con borrado condicional
ecd97bc fix: agrega editando faltante en destructuring de GestionCategorias
```

---

## #2 — Bugs y mejoras

**Objetivo:** Bugs y mejoras (AlertSimple, useHeaderManager).

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/components/common/ModalConfirmacion.tsx` | ♻️ Mejora | Botón cancelar opcional: si no se pasa `onCancelar`, renderiza un solo botón full-width |
| `src/components/common/AlertSimple.tsx` | 🗑️ Eliminado | Reemplazado por `ModalConfirmacion` con `confirmText="Entendido"` |
| `src/features/auth/components/Form/FormVendedorLogin.tsx` | ♻️ Refactor | Cambia `AlertSimple` por `ModalConfirmacion` |
| `src/hooks/useHeaderManager.ts` | ♻️ Refactor | Elimina `getBreakpoint()` duplicado, estado `breakpoint` y resize listener |
| `src/docs/ARCHITECTURE.md` | ♻️ Actualizado | Elimina `AlertSimple` del árbol |
| `src/docs/CLAUDE.md` | ♻️ Actualizado | Elimina `AlertSimple` del árbol |

### Commits

```
12bd6ee refactor: elimina AlertSimple y breakpoint duplicado de useHeaderManager
```

---

## #1 — usePaginatedFetch y Fase 3

**Objetivo:** Hook genérico `usePaginatedFetch<T>` y refactor de hooks.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/hooks/usePaginatedFetch.ts` | ✨ Nuevo | Hook genérico para listas paginadas |
| `src/features/productos/hooks/useProductos.ts` | ♻️ Refactor | Migrado a `usePaginatedFetch` |
| `src/features/ventas/hooks/useVentasManager.ts` | ♻️ Refactor | Migrado a `usePaginatedFetch` |
| `src/hooks/useVendedoresPendientes.ts` | ♻️ Refactor | Migrado a `usePaginatedFetch` |
| `PrivateRoute.tsx` | 🚚 Movido | `components/common/` → `app/` |
| `FooterLogin.tsx` | 🚚 Movido | `components/` → `components/common/` |

### Commits

```
9331970 feat: implementa usePaginatedFetch<T> hook genérico y completa Fase 3
```

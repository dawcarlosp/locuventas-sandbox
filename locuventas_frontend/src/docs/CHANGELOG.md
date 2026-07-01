# Changelog

> Registro cronológico de cambios por iteración.
> Cada entrada corresponde a una iteración del bucle de desarrollo IA.
> Formato: `#{iteración} — {fecha}`

---

## #14 — Migración a IA local (Gemini Nano / LanguageModel API)

**Objetivo:** Reemplazar la API remota de Gemini por la IA local del navegador.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/shared/ai/gemini.client.ts` | ♻️ Reescrito | Usa `LanguageModel.create()` + `session.prompt()` en lugar de fetch a API remota |
| `src/vite-env.d.ts` | ✨ Nuevo | Declaración TypeScript para `LanguageModel` global |
| `.env` | 🧹 Limpieza | Eliminada `VITE_GEMINI_API_KEY` — ya no es necesaria |
| `locuventas_backend/.../AiController.java` | 🗑️ Eliminado | Ya no se necesita proxy backend |
| `locuventas_backend/.../AiService.java` | 🗑️ Eliminado | Ya no se necesita proxy backend |
| `locuventas_backend/.../SecurityConfig.java` | ♻️ Revertido | Eliminada ruta pública `/ai/**` |
| `locuventas_backend/application.properties` | ♻️ Revertido | Eliminada propiedad `gemini.api.key` |

### Commits

```
feat: migra Gemini de API remota a IA local (LanguageModel API)
```

---

## #13 — Sugerencia IA de categorías al crear producto

**Objetivo:** Conectar `useSugerirCategorias` con el formulario de producto.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `ModalProductoForm.tsx` | ♻️ Mejora | Botón "Sugerir IA" junto a selector de categorías |
| `ModalProductoForm.tsx` | ♻️ Mejora | Llama a Gemini con el nombre del producto para sugerir categorías |

### Commits

```
feat: integra sugerencia IA de categorías en formulario de producto
```

---

## #12 — Resumen de ventas con IA en historial

**Objetivo:** Conectar el hook `useResumenVentas` con la UI del historial.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `VentasPagina.tsx` | ♻️ Mejora | Botón "Resumen IA" que genera resumen de ventas con Gemini |
| `VentasPagina.tsx` | ♻️ Mejora | Card con spinner de carga y texto del resumen |

### Commits

```
feat: integra resumen de ventas con IA en el historial
```

---

## #11 — Búsqueda semántica integrada en el catálogo

**Objetivo:** Conectar la Fase 4 de Gemini AI con la UI del catálogo.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `CatalogoProductos.tsx` | ♻️ Mejora | Botón "Búsqueda IA" que activa búsqueda semántica con Gemini |
| `CatalogoProductos.tsx` | ♻️ Mejora | Alterna entre búsqueda normal (filtros) e inteligente (lenguaje natural) |

### Commits

```
feat: integra búsqueda semántica con Gemini en el catálogo de productos
```

---

## #10 — ErrorBoundary global

**Objetivo:** Evitar que errores no controlados tumben toda la app.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/components/common/ErrorBoundary.tsx` | ✨ Nuevo | Componente ErrorBoundary con UI de recuperación |
| `src/app/App.tsx` | ♻️ Mejora | Envuelve `<AppRoutes>` en `<ErrorBoundary>` |

### Commits

```
feat: añade ErrorBoundary global con UI de recuperación
```

---

## #9 — Lazy loading en rutas

**Objetivo:** Reducir bundle inicial dividiendo páginas en chunks lazy.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/app/routes.tsx` | ♻️ Refactor | 7 rutas migradas a `React.lazy` + `Suspense` con fallback |
| `src/app/routes.tsx` | ✨ Nuevo | Componente `SuspenseWrapper` con spinner de carga |

**Resultado:** Bundle principal reducido de 472KB → 292KB. Cada página es un chunk independiente.

### Commits

```
perf: añade lazy loading a todas las rutas
```

---

## #8 — Tests de integración y test-utils

**Objetivo:** Añadir tests de integración con test-utils compartidos.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/test/test-utils.tsx` | ✨ Nuevo | Custom render con BrowserRouter + AuthProvider + HeaderProvider |
| `src/features/auth/pages/__tests__/LoginPage.test.tsx` | ✨ Nuevo | 3 tests: renderizado formulario, botón login, enlace registro |

### Commits

```
test: añade test-utils y test de integración para LoginPage
```

---

## #7 — Tests unitarios con Vitest

**Objetivo:** Configurar Vitest y añadir tests a hooks principales.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `vitest.config.ts` | ✨ Nuevo | Configuración de Vitest con jsdom y setup |
| `src/test/setup.ts` | ✨ Nuevo | Setup con `@testing-library/jest-dom` |
| `src/hooks/__tests__/useBuscador.test.ts` | ✨ Nuevo | 5 tests: estado inicial, cambio, clear, debounce, cancelación |
| `src/features/ventas/hooks/__tests__/useCarrito.test.ts` | ✨ Nuevo | 4 tests: vacío, único, múltiple, IVA cero |
| `package.json` | ♻️ Mejora | Scripts `test` y `test:watch` |

### Commits

```
test: configura Vitest y añade tests a useCarrito y useBuscador
```

---

## #6 — Eliminar ComponentType<any> de PANEL_MAP

**Objetivo:** Reemplazar `React.ComponentType<any>` por factory functions tipadas.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `RecursiveMenu.tsx` | ♻️ Refactor | `PANEL_MAP` usa `(props: Record<string, unknown>) => React.ReactNode` en lugar de `ComponentType<any>` |
| `RecursiveMenu.tsx` | 🧹 Limpieza | Eliminados comentarios `SOLUCIÓN` del workaround anterior |

### Commits

```
refactor: elimina ComponentType<any> de PANEL_MAP en RecursiveMenu
```

---

## #5 — Unificar skeletons en Skeleton con variant

**Objetivo:** Reemplazar 4 skeletons individuales por un solo `Skeleton` con `variant`.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/components/common/Skeleton.tsx` | ✨ Nuevo | Componente unificado con `variant="producto-card\|tarjeta-vendedor\|venta-card\|producto-gestion-card"` |
| `src/components/common/SkeletonProductoCard.tsx` | 🗑️ Eliminado | Reemplazado por `Skeleton variant="producto-card"` |
| `src/features/auth/components/SkeletonTarjetaVendedor.tsx` | 🗑️ Eliminado | Reemplazado por `Skeleton variant="tarjeta-vendedor"` |
| `src/features/ventas/components/SkeletonVentaCard.tsx` | 🗑️ Eliminado | Reemplazado por `Skeleton variant="venta-card"` |
| `src/features/productos/components/SkeletonProductoGestionCard.tsx` | 🗑️ Eliminado | Reemplazado por `Skeleton variant="producto-gestion-card"` |
| `src/features/productos/components/CatalogoProductos.tsx` | ♻️ Refactor | Importa `Skeleton` en lugar de `SkeletonProductoCard` |
| `src/features/auth/components/PendientesList.tsx` | ♻️ Refactor | Importa `Skeleton` en lugar de `SkeletonTarjetaVendedor` |
| `src/features/ventas/components/ContenedorVentas.tsx` | ♻️ Refactor | Importa `Skeleton` en lugar de `SkeletonVentaCard` |
| `src/features/productos/components/GestionProductos.tsx` | ♻️ Refactor | Importa `Skeleton` en lugar de `SkeletonProductoGestionCard` |

### Commits

```
refactor: unifica skeletons en Skeleton con variant
```

---

## #4 — Fase 4: Integración Gemini AI

**Objetivo:** Cliente Gemini, hook genérico y prompts para IA en el frontend.

### Cambios realizados

| Archivo | Acción | Descripción |
|---------|--------|-------------|
| `src/shared/ai/gemini.client.ts` | ✨ Nuevo | Cliente HTTP para Google Gemini API (`generateContent`, `generateJson`) |
| `src/shared/ai/useGemini.ts` | ✨ Nuevo | Hooks `useGemini<T>` y `useGeminiJson<T>` con AbortController y estados |
| `src/shared/ai/prompts/productos.prompts.ts` | ✨ Nuevo | Prompts para búsqueda semántica y sugerencia de categorías |
| `src/shared/ai/prompts/ventas.prompts.ts` | ✨ Nuevo | Prompt para resumen de ventas en lenguaje natural |
| `src/shared/ai/index.ts` | ✨ Nuevo | Barrel export |
| `src/features/productos/hooks/useBusquedaSemantica.ts` | ✨ Nuevo | Hook: búsqueda semántica de productos con Gemini |
| `src/features/productos/hooks/useSugerirCategorias.ts` | ✨ Nuevo | Hook: sugerencia de categorías al crear producto |
| `src/features/ventas/hooks/useResumenVentas.ts` | ✨ Nuevo | Hook: resumen de ventas en lenguaje natural |
| `.env` | ♻️ Mejora | Añadida `VITE_GEMINI_API_KEY` |

### Commits

```
feat: implementa Fase 4 — integración Gemini AI
```

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

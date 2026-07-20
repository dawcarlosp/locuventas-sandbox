# docs: corrige documentación para reflejar el estado actual del proyecto

## Descripción

Revisión completa de la documentación del proyecto para corregir ~20 inconsistencias detectadas entre lo que los docs decían y el estado real del código. Se actualizaron 8 archivos de documentación.

## Archivos modificados

| Archivo | Cambios |
|---------|---------|
| `locuventas_frontend/CLAUDE.md` | Corregida ubicación de `main.tsx` (src/ raíz, no app/), añadidos `ErrorBoundary` y `shared/ai/` a la estructura, eliminada `VITE_GEMINI_API_KEY` de env vars |
| `locuventas_frontend/src/docs/CLAUDE.md` | Mismas correcciones estructurales + añadidos `layout/`, `test/`, `categorias/`, `usePaginatedFetch` y `shared/ai/` |
| `locuventas_frontend/src/docs/ARCHITECTURE.md` | Corregida ubicación de `main.tsx`, añadidos `ErrorBoundary` e `index.ts` de shared/ai |
| `locuventas_frontend/src/docs/MIGRATION_PLAN.md` | Marcada Fase 4 (Gemini AI) como completada y actualizada descripción a IA local (LanguageModel API) |
| `locuventas_frontend/src/docs/KNOWN_ISSUES.md` | Eliminadas 3 mejoras ya realizadas (lazy loading, tests, Docker) |
| `locuventas_frontend/src/docs/RULES.md` | Actualizado flujo git: ramas de features/docs + PR contra develop, corregido comando Maven para Windows |
| `locuventas_frontend/src/docs/SESSION.md` | Actualizada rama activa (develop), último commit, añadido histórico WinForms |
| `README.md` | Corregidos enlaces de Docker Hub que estaban intercambiados (backend apuntaba a frontend y viceversa) |

## Resumen de inconsistencias corregidas

- **Estructura del proyecto**: `main.tsx` estaba documentado en `app/` pero está en `src/` raíz
- **Componentes faltantes**: `ErrorBoundary.tsx` no aparecía en ningún doc de estructura
- **Ramas y flujo git**: RULES.md indicaba "push directo a master sin PRs" pero el repo usa ramas + PRs contra develop
- **Env vars obsoletas**: `VITE_GEMINI_API_KEY` seguía apareciendo pese a haber sido eliminada
- **Fases incompletas**: MIGRATION_PLAN.md mostraba Fase 4 como pendiente cuando ya está implementada
- **Enlaces rotos**: README.md tenía los links de Docker Hub intercambiados

## Commits

```
docs: corrige estructura y env vars en CLAUDE.md raíz
docs: corrige estructura del frontend en src/docs/CLAUDE.md
docs: corrige ubicación de main.tsx en ARCHITECTURE.md
docs: marca Fase 4 Gemini AI como completada y actualiza descripción a IA local
docs: elimina mejoras ya completadas de KNOWN_ISSUES.md
docs: actualiza flujo git en RULES.md (ramas + PRs contra develop)
docs: actualiza SESSION.md con rama develop, último commit y avances WinForms
docs: corrige enlaces de Docker Hub en README.md (estaban intercambiados)
docs: añade ErrorBoundary e index.ts de shared/ai a ARCHITECTURE.md
```

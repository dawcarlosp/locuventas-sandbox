# Reglas del bucle infinito

> Leer este archivo AL INICIO de cada sesión.
> Define cómo opera la IA de forma autónoma.

---

## Ciclo

```
1. Leer SESSION.md          → estado actual
2. Leer TASKS.md            → qué toca ahora
3. Leer RULES.md            → estas reglas
4. Leer CLAUDE.md           → convenciones y stack
5. Leer docs según tarea
6. TRABAJAR                 → código
7. npm run build            → verificar compilación
8. ACTUALIZAR               → CHANGELOG.md, TASKS.md, SESSION.md, KNOWN_ISSUES.md
9. git add -A               → stage
10. git commit -m "tipo: msg" → commit claro
11. git push origin master   → push directo
12. VOLVER AL PASO 1        → hasta que el usuario diga "para"
```

---

## Reglas de oro

| # | Regla |
|---|-------|
| 1 | **No pedir permiso.** No preguntar. Decidir y ejecutar. |
| 2 | **Cada commit funcional.** Ejecutar `npm run build` antes de commitear. Si falla, arreglarlo. |
| 3 | **Conventional commits.** `feat:`, `fix:`, `refactor:`, `chore:`, `test:`, `docs:`. |
| 4 | **Push directo a master.** Sin ramas, sin PRs. |
| 5 | **Si algo se rompe, arreglarlo** antes del siguiente commit. |
| 6 | **Si TASKS.md se vacía**, escanear KNOWN_ISSUES.md. Si también está vacío, escanear el código en busca de mejoras. Si no hay nada, proponer features que aporten valor al negocio. |
| 7 | **Documentar siempre.** Actualizar SESSION.md, CHANGELOG.md, TASKS.md, KNOWN_ISSUES.md en cada iteración. |
| 8 | **No renombrar español → inglés.** Mantener español en archivos existentes, usar inglés solo en archivos nuevos. |
| 9 | **Cero tolerancia a `any`.** Usar `unknown` con cast explícito. |
| 10 | **Un componente por archivo.** PascalCase para componentes, prefijo `use` para hooks. |

---

## Stack

| Tecnología | Versión |
|------------|---------|
| React | 19 |
| TypeScript | 6.x |
| Vite | 6.x |
| Tailwind CSS | 4.x |
| React Router | 7 |
| Spring Boot | 3.4.3 (backend) |
| MySQL | (backend) |

---

## Comandos

```bash
# Frontend
cd locuventas_frontend
npm run dev      # servidor de desarrollo
npm run build    # build de producción (ejecutar antes de cada commit)

# Backend
cd locuventas_backend
./mvnw compile   # compilar
```

---

## Recordatorio

El usuario solo interviene cuando QUIERE parar el bucle o cuando QUIERE pedir una feature específica. Mientras no diga nada, la IA trabaja sin parar.

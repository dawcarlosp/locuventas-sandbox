# LocuVentas — Guía para desarrolladores

Sistema de gestión de ventas para comercios. Vendedores gestionan productos, registran ventas y cobran pagos. Administradores gestionan personal y catálogo.

## Stack

| Subproyecto | Tecnología |
|-------------|-----------|
| **Frontend** | React 19 + TypeScript + Vite 6 + Tailwind CSS 4 + React Router 7 |
| **Backend** | Spring Boot 3.4 + Java 17 + Maven |
| **WinForms** | VB.NET + .NET 10 |
| **Base de datos** | MySQL |

## Estructura del proyecto

```
locuventas_backend/     # API REST (Spring Boot)
locuventas_frontend/    # SPA (React + Vite)
locuventas_winforms/    # Cliente de escritorio (VB.NET)
apuntes/                # Notas internas (gitignorado)
```

## Frontend — estructura

```
src/
├── app/               # Entry point, providers, rutas
├── components/common/ # Componentes UI reutilizables
├── constants/         # Constantes globales
├── context/           # AuthContext + HeaderContext
├── domain/            # Tipos compartidos (ApiResponse, PageDTO)
├── features/          # Código por dominio de negocio
│   ├── auth/          # Login, registro, aprobación
│   ├── categorias/    # CRUD de categorías
│   ├── dev/           # Perfil del desarrollador
│   ├── productos/     # Catálogo y CRUD
│   └── ventas/        # Carrito, ventas, cobros
├── hooks/             # Hooks globales
├── layout/            # Header, nav, footer
├── services/          # Cliente HTTP centralizado
├── shared/            # Código compartido (IA local)
├── test/              # Tests
└── utils/             # Utilidades
```

## Arquitectura (frontend)

- **`features/*/pages/`** — orquesta: instancia hooks, pasa props, renderiza modales
- **`features/*/components/`** — presentación: recibe props, no llama a la API
- **`features/*/hooks/`** — lógica de negocio y estado
- **`features/*/domain/`** — tipos del feature
- **`services/api.ts`** — única puerta de entrada al backend
- Los componentes nunca llaman a `apiRequest` directamente; toda llamada pasa por un hook

## Convenciones TypeScript

- Nunca usar `any` — usar `unknown` con cast explícito
- `Record<string, unknown>` para datos crudos de la API antes de mapear
- Tipos en `domain/` o `features/*/domain/` — nunca inline en componentes
- PascalCase en componentes: `ProductoCard`, `TablaVentas`
- Prefijo `use` en hooks: `useProductos`, `useCarrito`

## API REST

| Aspecto | Detalle |
|---------|---------|
| Base URL | `VITE_API_URL` en `.env` (por defecto `http://localhost:8080`) |
| Autenticación | JWT en `Authorization: Bearer <token>` |
| Token | `localStorage` clave `"auth"` |
| Respuesta | `ApiResponse<T>` = `{ message, status, data }` |
| Paginación | `PageDTO<T>` = `{ content, number, totalPages, totalElements }` |

## Roles

```
ROLE_ADMIN    → acceso total
ROLE_VENDEDOR → dashboard, ventas, perfil
Sin rol       → solo login (pendiente de aprobación)
```

## IA local (Gemini Nano)

El frontend integra IA que ejecuta 100% en el navegador mediante la API `LanguageModel` de Chrome (Gemini Nano). No necesita backend, API keys ni conexión externa.

### Requisitos

- Chrome 128+ (otros navegadores no soportan Gemini Nano)
- Habilitar flag: `chrome://flags/#optimization-guide-on-device-model`
- Descargar el modelo (Chrome lo gestiona automáticamente al primer uso)

### Funcionalidades

- Búsqueda semántica en el catálogo de productos
- Sugerencia de categorías al crear un producto
- Resumen de ventas con lenguaje natural

> Si la IA no está disponible, la app sigue funcionando con normalidad — los botones de IA muestran un mensaje de error y se puede operar sin ella.

## Variables de entorno

```env
VITE_API_URL=http://localhost:8080
```

## Comandos (frontend)

```bash
npm run dev       # desarrollo
npm run build     # producción
npm run preview   # previsualizar build
npm test          # tests (Vitest)
```

## Subir con Docker

```bash
docker compose --env-file .env up -d
```

# LocuVentas — Frontend

Aplicación web de gestión de ventas para comercios. Construida con React 19 + TypeScript + Vite.

## Stack

- **React 19** + **TypeScript** (100% tipado)
- **Vite 6** — bundler y dev server
- **Tailwind CSS 4** — estilos utility-first
- **React Router 7** — navegación SPA
- **React Toastify** — notificaciones
- **Lucide React / FontAwesome** — iconos
- **date-fns** — fechas
- **Gemini Nano** (LanguageModel API) — IA local en el navegador

## Requisitos

- Node.js 20+
- Backend corriendo en `http://localhost:8080`

## Comandos

```bash
npm run dev       # servidor de desarrollo
npm run build     # build de producción
npm run preview   # previsualizar el build
npm test          # tests (Vitest)
```

## Entorno

Copiar `.env` desde `.env.example`:

```env
VITE_API_URL=http://localhost:8080
```

## Estructura

```
src/
├── app/           # Entry point, providers, rutas
├── components/    # Componentes UI reutilizables
├── features/      # Código por dominio (auth, productos, ventas, categorías)
├── hooks/         # Hooks globales
├── layout/        # Shell de la app (header, nav, footer)
├── services/      # Cliente HTTP centralizado
├── shared/        # Código compartido entre features
└── utils/         # Utilidades
```

## IA local (Gemini Nano)

El frontend integra IA que ejecuta **100% en el navegador** mediante la API
`LanguageModel` de Chrome (Gemini Nano). No necesita backend, API keys ni
conexión externa.

### Requisitos

- **Chrome 128+** (otros navegadores no soportan Gemini Nano)
- Habilitar flag: `chrome://flags/#optimization-guide-on-device-model`
- Descargar el modelo (Chrome lo gestiona automáticamente al primer uso)

### Funcionalidades que usan IA

- **Búsqueda semántica** en el catálogo de productos
- **Sugerencia de categorías** al crear un producto
- **Resumen de ventas** con lenguaje natural

> Si la IA no está disponible, la app sigue funcionando con normalidad —
> los botones de IA muestran un mensaje de error y se puede operar sin ella.

## Roles

- **ROLE_ADMIN** → acceso total
- **ROLE_VENDEDOR** → dashboard, ventas, perfil
- **Sin rol** → solo login (pendiente de aprobación)

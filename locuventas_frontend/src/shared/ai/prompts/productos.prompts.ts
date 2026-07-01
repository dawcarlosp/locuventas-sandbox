export function buildBusquedaSemanticaPrompt(
  query: string,
  productos: { id: number; nombre: string; categorias: string[] }[]
): string {
  return `Eres un asistente de búsqueda de productos para un comercio.

Un vendedor busca: "${query}"

Estos son los productos disponibles:
${JSON.stringify(productos, null, 2)}

Responde ÚNICAMENTE con un array JSON de los ids de los productos más relevantes
ordenados por relevancia (más relevante primero). Mínimo 1, máximo 5 productos.
Formato: [id1, id2, id3]

Ejemplo: [3, 7, 12]`;
}

export function buildSugerirCategoriasPrompt(
  nombreProducto: string,
  categoriasDisponibles: { id: number; nombre: string }[]
): string {
  return `Eres un asistente de categorización de productos.

Producto: "${nombreProducto}"

Categorías disponibles:
${JSON.stringify(categoriasDisponibles, null, 2)}

Responde ÚNICAMENTE con un array JSON de los ids de las categorías más adecuadas
para este producto (máximo 3 categorías).
Formato: [id1, id2, id3]

Ejemplo: [1, 5]`;
}

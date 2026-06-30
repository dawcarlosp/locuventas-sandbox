export function buildResumenVentasPrompt(
  periodo: string,
  ventas: {
    total: number;
    cantidad: number;
    pagadas: number;
    pendientes: number;
    totalIngresos: number;
  }
): string {
  return `Eres un asistente de análisis de ventas para un comercio.

Genera un resumen en lenguaje natural del periodo: ${periodo}

Datos de ventas:
${JSON.stringify(ventas, null, 2)}

El resumen debe ser:
- Conciso (máximo 3 frases)
- En español
- Enfocado en los datos clave
- Sin markdown ni formato especial

Ejemplo:
"Durante la semana pasada se realizaron 45 ventas por un total de 2.340€.
El 82% de las ventas fueron pagadas completamente, quedando un 18% pendiente
de cobro. El ticket medio fue de 52€."`;
}

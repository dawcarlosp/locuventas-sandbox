import { useState, useCallback } from "react";
import { useGemini } from "@/shared/ai/useGemini";
import { buildResumenVentasPrompt } from "@/shared/ai/prompts/ventas.prompts";
import type { Venta } from "../domain/venta.types";

interface UseResumenVentasReturn {
  resumen: string | null;
  generando: boolean;
  generarResumen: (periodo: string, ventas: Venta[]) => Promise<void>;
  limpiar: () => void;
}

export default function useResumenVentas(): UseResumenVentasReturn {
  const [resumen, setResumen] = useState<string | null>(null);
  const [generando, setGenerando] = useState(false);
  const gemini = useGemini<string>();

  const generarResumen = useCallback(
    async (periodo: string, ventas: Venta[]) => {
      if (ventas.length === 0) {
        setResumen("No hay ventas en este período.");
        return;
      }

      setGenerando(true);

      try {
        const pagadas = ventas.filter((v) => v.estadoPago === "PAGADO").length;
        const pendientes = ventas.filter((v) => v.estadoPago === "PENDIENTE" || v.estadoPago === "PARCIAL").length;
        const totalIngresos = ventas.reduce((sum, v) => sum + v.total, 0);

        const prompt = buildResumenVentasPrompt(periodo, {
          total: ventas.reduce((sum, v) => sum + v.total, 0),
          cantidad: ventas.length,
          pagadas,
          pendientes,
          totalIngresos,
        });

        const texto = await gemini.generate(prompt);
        setResumen(texto);
      } catch {
        setResumen("No se pudo generar el resumen.");
      } finally {
        setGenerando(false);
      }
    },
    [gemini]
  );

  const limpiar = useCallback(() => {
    setResumen(null);
    gemini.reset();
  }, [gemini]);

  return { resumen, generando, generarResumen, limpiar };
}

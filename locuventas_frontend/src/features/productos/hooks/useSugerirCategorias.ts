import { useState, useCallback } from "react";
import { useGeminiJson } from "@/shared/ai/useGemini";
import { buildSugerirCategoriasPrompt } from "@/shared/ai/prompts/productos.prompts";
import { toast } from "react-toastify";
import type { SelectOption } from "@domain/ui.types";

interface UseSugerirCategoriasReturn {
  sugiriendo: boolean;
  sugerir: (nombreProducto: string, categorias: SelectOption[]) => Promise<number[]>;
  limpiar: () => void;
}

export default function useSugerirCategorias(): UseSugerirCategoriasReturn {
  const [sugiriendo, setSugiriendo] = useState(false);
  const gemini = useGeminiJson<number[]>();

  const sugerir = useCallback(
    async (nombreProducto: string, categorias: SelectOption[]): Promise<number[]> => {
      if (!nombreProducto.trim() || categorias.length === 0) return [];

      setSugiriendo(true);

      try {
        const categoriasData = categorias.map((c) => ({
          id: c.value,
          nombre: c.label,
        }));

        const prompt = buildSugerirCategoriasPrompt(nombreProducto, categoriasData);
        const ids = await gemini.generate(prompt);

        if (ids && ids.length > 0) {
          return ids;
        }
        return [];
      } catch (err: unknown) {
        const e = err as Record<string, string | undefined>;
        toast.error(e?.message ?? "Error al sugerir categorías");
        return [];
      } finally {
        setSugiriendo(false);
      }
    },
    [gemini]
  );

  const limpiar = useCallback(() => {
    gemini.reset();
  }, [gemini]);

  return { sugiriendo, sugerir, limpiar };
}

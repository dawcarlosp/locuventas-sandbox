import { useState, useCallback } from "react";
import { apiRequest } from "@services/api";
import { toast } from "react-toastify";
import { useGeminiJson } from "@/shared/ai/useGemini";
import { buildBusquedaSemanticaPrompt } from "@/shared/ai/prompts/productos.prompts";
import type { Producto } from "../domain/producto.types";

interface UseBusquedaSemanticaReturn {
  resultados: Producto[];
  buscando: boolean;
  buscar: (query: string) => Promise<void>;
  limpiar: () => void;
}

export default function useBusquedaSemantica(
  catalogo: Producto[]
): UseBusquedaSemanticaReturn {
  const [resultados, setResultados] = useState<Producto[]>([]);
  const [buscando, setBuscando] = useState(false);
  const gemini = useGeminiJson<number[]>();

  const buscar = useCallback(async (query: string) => {
    if (!query.trim()) {
      setResultados([]);
      return;
    }

    setBuscando(true);

    try {
      const productosResumidos = catalogo.map((p) => ({
        id: p.id,
        nombre: p.nombre,
        categorias: p.categorias,
      }));

      const prompt = buildBusquedaSemanticaPrompt(query, productosResumidos);
      const ids = await gemini.generate(prompt);

      if (ids && ids.length > 0) {
        const encontrados = ids
          .map((id) => catalogo.find((p) => p.id === id))
          .filter((p): p is Producto => p != null);
        setResultados(encontrados);
      } else {
        setResultados([]);
      }
    } catch (err: unknown) {
      const e = err as Record<string, string | undefined>;
      toast.error(e?.message ?? "Error en búsqueda semántica");
      setResultados([]);
    } finally {
      setBuscando(false);
    }
  }, [catalogo, gemini]);

  const limpiar = useCallback(() => {
    setResultados([]);
    gemini.reset();
  }, [gemini]);

  return { resultados, buscando, buscar, limpiar };
}

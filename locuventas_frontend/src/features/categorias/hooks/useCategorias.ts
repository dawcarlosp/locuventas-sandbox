import { useState, useEffect, useCallback, useMemo } from "react";
import { toast } from "react-toastify";
import { apiRequest } from "@services/api";
import type { Categoria } from "../domain/categoria.types";
import type { ApiResponse } from "@domain/api.types";

interface UseCategoriasOptions {
  search?: string;
}

interface UseCategoriasReturn {
  categorias:      Categoria[];
  allCategorias:   Categoria[];
  loading:         boolean;
  totalPages:      number;
  totalElements:   number;
  refresh:         () => void;
}

export default function useCategorias({
  search = "",
}: UseCategoriasOptions = {}): UseCategoriasReturn {
  const [allCategorias, setAllCategorias] = useState<Categoria[]>([]);
  const [loading, setLoading] = useState(true);

  const cargar = useCallback(async () => {
    setLoading(true);
    try {
      const res = await apiRequest<ApiResponse<Categoria[]>>("categorias", null, { method: "GET" });
      setAllCategorias(res.data ?? []);
    } catch {
      toast.error("Error al cargar categorías");
    } finally {
      setLoading(false);
    }
  }, []);

  useEffect(() => {
    cargar();
  }, [cargar]);

  const { categorias, totalElements } = useMemo(() => {
    const filtered = !search.trim()
      ? allCategorias
      : allCategorias.filter((c) => c.nombre.toLowerCase().includes(search.toLowerCase()));
    return { categorias: filtered, totalElements: filtered.length };
  }, [allCategorias, search]);

  return { categorias, allCategorias, loading, totalElements, refresh: cargar };
}

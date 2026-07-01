import { useMemo } from "react";
import usePaginatedFetch from "@hooks/usePaginatedFetch";
import { toast } from "react-toastify";
import type { Categoria } from "../domain/categoria.types";
import type { ApiResponse, PageDTO } from "@domain/api.types";

interface UseCategoriasOptions {
  page?:   number;
  size?:   number;
  search?: string;
}

interface UseCategoriasReturn {
  categorias: Categoria[];
  loading:    boolean;
  totalPages: number;
  refresh:    () => void;
}

export default function useCategorias({
  page = 0,
  size = 10,
  search = "",
}: UseCategoriasOptions = {}): UseCategoriasReturn {
  const url = useMemo(() => {
    const params = new URLSearchParams({ page: String(page), size: String(size) });
    if (search.trim()) params.set("search", search.trim());
    return `categorias?${params}`;
  }, [page, size, search]);

  const { data, loading, totalPages, refresh } = usePaginatedFetch<Categoria, ApiResponse<PageDTO<Categoria>>>({
    url,
    extractData: (res) => ({
      content: res.data?.content ?? [],
      totalPages: res.data?.totalPages ?? 0,
    }),
    onError: () => toast.error("Error al cargar categorías"),
  });

  return { categorias: data, loading, totalPages, refresh };
}

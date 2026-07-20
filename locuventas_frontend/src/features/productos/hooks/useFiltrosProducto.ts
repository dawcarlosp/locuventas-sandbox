// src/features/productos/hooks/useFiltrosProducto.ts
import { useState, useEffect, useCallback } from "react";
import { apiRequest } from "@services/api";
import { toast } from "react-toastify";
import type { SelectOption } from "@domain/ui.types";
import type { ApiResponse, PageDTO } from "@domain/api.types";

interface PaisRaw {
  id:          number;
  nombre:      string;
  codigo:      string;
  enlaceFoto:  string | null;
}

interface CategoriaRaw {
  id:     number;
  nombre: string;
}

interface FiltrosProductoReturn {
  paises:     SelectOption[];
  categorias: SelectOption[];
  loading:    boolean;
  refresh:    () => void;
}

export default function useFiltrosProducto(): FiltrosProductoReturn {

  const [paises,     setPaises]     = useState<SelectOption[]>([]);
  const [categorias, setCategorias] = useState<SelectOption[]>([]);
  const [loading,    setLoading]    = useState(true);
  const [refreshKey, setRefreshKey] = useState(0);

  useEffect(() => {

    const cargar = async (): Promise<void> => {
      try {
        const [resPaises, resCategorias] = await Promise.all([
          apiRequest<ApiResponse<PaisRaw[]>>("paises", null, { method: "GET" }),
          apiRequest<ApiResponse<PageDTO<CategoriaRaw>>>("categorias?size=100", null, { method: "GET" }),
        ]);

        setPaises(
          (resPaises.data ?? []).map((p) => ({
            value: p.id,
            label: p.nombre,

            image: p.enlaceFoto ?? null,
          }))
        );

        setCategorias(
          (resCategorias.data?.content ?? []).map((c) => ({
            value: c.id,
            label: c.nombre,
          }))
        );
      } catch {
        toast.error("Error cargando filtros");
      } finally {
        setLoading(false);
      }
    };

    cargar();
  }, [refreshKey]);

  const refresh = useCallback(() => {
    setLoading(true);
    setRefreshKey((k) => k + 1);
  }, []);

  return { paises, categorias, loading, refresh };
}
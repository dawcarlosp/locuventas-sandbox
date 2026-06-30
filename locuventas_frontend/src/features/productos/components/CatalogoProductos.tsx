import { useState, useEffect } from "react";
import type { Producto } from "../domain/producto.types";
import type { CarritoItem } from "@features/ventas/hooks/useCarrito";
import ProductoCard from "./ProductoCard";
import Skeleton from "@components/common/Skeleton";
import Paginacion from "@components/common/Paginacion";
import BuscadorInput from "@components/common/BuscadorInput";
import SelectFilter from "@components/common/SelectFilter";
import useProductos from "../hooks/useProductos";
import useFiltrosProducto from "../hooks/useFiltrosProducto";
import useBusquedaSemantica from "../hooks/useBusquedaSemantica";
import { Sparkles } from "lucide-react";

const SKELETON_COUNT = 12;

interface Props {
  carga:         CarritoItem[];
  agregarProducto: (p: Producto) => void;
  page:          number;
  setTotalPages: (n: number) => void;
  onPageChange:  (n: number) => void;
  size:          number;
  onSizeChange:  (n: number) => void;
}

export default function CatalogoProductos({
  carga,
  agregarProducto,
  page,
  setTotalPages,
  onPageChange,
  size,
  onSizeChange,
}: Props) {
  const [search, setSearch] = useState("");
  const [paisId, setPaisId] = useState("");
  const [categoriaId, setCategoriaId] = useState("");
  const [semantico, setSemantico] = useState(false);

  const { paises, categorias } = useFiltrosProducto();

  const { productos, loading, totalPages } = useProductos({
    page,
    size,
    search: semantico ? "" : search,
    paisId: semantico ? null : (paisId ? Number(paisId) : null),
    categoriaId: semantico ? null : (categoriaId ? Number(categoriaId) : null),
  });

  const {
    resultados: semanticos,
    buscando: buscandoSemantico,
    buscar: buscarSemantico,
    limpiar: limpiarSemantico,
  } = useBusquedaSemantica(productos);

  useEffect(() => {
    setTotalPages(semantico ? 1 : totalPages);
  }, [totalPages, setTotalPages, semantico]);

  const getCantidad = (id: number) =>
    carga.find((i) => i.producto.id === id)?.cantidad ?? 0;

  const handleSearch = (v: string) => { setSearch(v); onPageChange(0); };
  const handlePais = (value: string) => { setPaisId(value); onPageChange(0); };
  const handleCategoria = (value: string) => { setCategoriaId(value); onPageChange(0); };

  const toggleSemantico = () => {
    if (semantico) {
      setSemantico(false);
      limpiarSemantico();
    } else {
      setSemantico(true);
      onPageChange(0);
    }
  };

  const handleSemanticSearch = (v: string) => {
    setSearch(v);
    if (v.trim()) {
      buscarSemantico(v);
    } else {
      limpiarSemantico();
    }
  };

  const displayProducts = semantico ? semanticos : productos;
  const isLoading = semantico ? buscandoSemantico : loading;

  return (
    <div className="w-full flex flex-col gap-4">

      <div className="flex flex-wrap items-end gap-3">
        <div className="flex-1 min-w-[200px]">
          <BuscadorInput
            value={search}
            onChange={semantico ? handleSemanticSearch : handleSearch}
            placeholder={semantico ? "Describe el producto..." : "Buscar producto..."}
          />
        </div>

        {!semantico && (
          <>
            <div className="w-44">
              <SelectFilter
                id="filtro-pais"
                value={paisId}
                onChange={handlePais}
                placeholder="País"
                options={paises}
                searchPlaceholder="Buscar país..."
              />
            </div>

            <div className="w-44">
              <SelectFilter
                id="filtro-categoria"
                value={categoriaId}
                onChange={handleCategoria}
                placeholder="Categoría"
                options={categorias}
                searchPlaceholder="Buscar categoría..."
              />
            </div>
          </>
        )}

        <button
          onClick={toggleSemantico}
          className={`flex items-center gap-1.5 text-[11px] font-semibold px-3 py-2 rounded-xl border transition-all whitespace-nowrap ${
            semantico
              ? "bg-purple-500/20 text-purple-400 border-purple-500/50"
              : "text-zinc-400 border-zinc-700 hover:border-purple-500/50 hover:text-purple-400"
          }`}
        >
          <Sparkles size={14} />
          {semantico ? "IA activa" : "Búsqueda IA"}
        </button>

        {(search || paisId || categoriaId) && (
          <button
            onClick={() => {
              setSearch("");
              setPaisId("");
              setCategoriaId("");
              limpiarSemantico();
              onPageChange(0);
            }}
            className="text-[11px] text-zinc-500 hover:text-white transition-colors whitespace-nowrap pb-1"
          >
            Limpiar filtros
          </button>
        )}
      </div>

      {semantico && search.trim() && (
        <p className="text-[11px] text-purple-400/70 italic">
          Búsqueda inteligente activa. Describe el producto con tus palabras.
        </p>
      )}

      <div className="grid w-full justify-items-center grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-3 xl:grid-cols-5 2xl:grid-cols-6 gap-6">
        {isLoading
          ? Array.from({ length: SKELETON_COUNT }).map((_, i) => (
            <Skeleton key={i} variant="producto-card" />
          ))
          : displayProducts.length === 0
            ? (
              <div className="col-span-full text-center py-20 text-zinc-600 italic text-sm">
                Sin resultados
              </div>
            )
            : displayProducts.map((prod) => (
              <ProductoCard
                key={prod.id}
                producto={prod}
                cantidad={getCantidad(prod.id)}
                onAdd={agregarProducto}
              />
            ))
        }
      </div>

      {!isLoading && !semantico && totalPages > 1 && (
        <Paginacion
          page={page}
          totalPages={totalPages}
          onPageChange={onPageChange}
          size={size}
          onSizeChange={onSizeChange}
        />
      )}
    </div>
  );
}

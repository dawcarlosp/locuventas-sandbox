import DataTable from "@components/common/DataTable";
import type { Categoria } from "../domain/categoria.types";

interface Props {
  categorias: Categoria[];
  loading:    boolean;
  size:       number;
  onEditar:   (c: Categoria) => void;
  onEliminar: (id: number) => void;
}

const columnas = [
  { label: "Nombre" },
  { label: "Acciones", className: "text-center" },
];

export default function TablaCategorias({
  categorias,
  loading,
  size,
  onEditar,
  onEliminar,
}: Props) {
  return (
    <DataTable columnas={columnas} loading={loading} size={size}>
      {categorias.length === 0 ? (
        <tr>
          <td colSpan={2} className="py-20 text-center text-zinc-500 italic">
            No hay categorías registradas.
          </td>
        </tr>
      ) : (
        categorias.map((c) => (
          <tr
            key={c.id}
            className="hover:bg-zinc-700/30 transition-colors group text-zinc-300"
          >
            <td className="px-5 py-4 font-semibold text-white">{c.nombre}</td>

            <td className="px-5 py-4">
              <div className="flex justify-center gap-2 opacity-70 group-hover:opacity-100 transition-opacity">
                <button
                  onClick={() => onEditar(c)}
                  className="text-xs px-3 py-1.5 rounded-lg bg-zinc-700 hover:bg-zinc-600 text-zinc-300 transition-colors"
                >
                  Editar
                </button>
                <button
                  onClick={() => onEliminar(c.id)}
                  className="text-xs px-3 py-1.5 rounded-lg bg-red-900/40 hover:bg-red-800/60 text-red-300 transition-colors"
                >
                  Eliminar
                </button>
              </div>
            </td>
          </tr>
        ))
      )}
    </DataTable>
  );
}

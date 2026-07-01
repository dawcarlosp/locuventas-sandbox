import type { Categoria } from "../domain/categoria.types";

interface Props {
  categoria:  Categoria;
  onEditar:   (c: Categoria) => void;
  onEliminar: (id: number) => void;
}

export default function CategoriaCard({ categoria, onEditar, onEliminar }: Props) {
  return (
    <div className="rounded-2xl bg-zinc-900 border border-zinc-700 flex flex-col gap-3 p-4 transition-all duration-200 hover:border-zinc-600">
      <div className="flex justify-between items-center">
        <span className="font-black text-zinc-500 text-sm">#{categoria.id}</span>
        <div className="flex gap-2">
          <button
            onClick={() => onEditar(categoria)}
            className="text-xs px-3 py-1.5 rounded-lg bg-zinc-700 hover:bg-zinc-600 text-zinc-300 transition-colors"
          >
            Editar
          </button>
          <button
            onClick={() => onEliminar(categoria.id)}
            className="text-xs px-3 py-1.5 rounded-lg bg-red-900/40 hover:bg-red-800/60 text-red-300 transition-colors"
          >
            Eliminar
          </button>
        </div>
      </div>

      <div className="flex flex-col gap-1.5 text-xs text-zinc-400">
        <div className="flex justify-between items-start gap-2">
          <span>Nombre</span>
          <span className="text-white font-semibold text-right break-words max-w-[70%]">
            {categoria.nombre}
          </span>
        </div>
      </div>
    </div>
  );
}

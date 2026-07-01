import { useState } from "react";
import useCategorias from "../hooks/useCategorias";
import useGestionCategorias from "../hooks/useGestionCategorias";
import useBreakpoint from "@hooks/useBreakpoint";
import { isBreakpoint } from "@constants/breakpoints";
import TablaCategorias from "./TablaCategorias";
import CategoriaCard from "./CategoriaCard";
import Skeleton from "@components/common/Skeleton";
import BaseModal from "@components/common/BaseModal";
import ModalConfirmacion from "@components/common/ModalConfirmacion";
import Paginacion from "@components/common/Paginacion";
import BuscadorInput from "@components/common/BuscadorInput";
import FAB from "@components/common/FAB";
import Button from "@buttons/Button";

export default function GestionCategorias() {
  const bp = useBreakpoint();
  const isMobile = isBreakpoint(bp, "MOBILE");

  const [page, setPage] = useState(0);
  const [size, setSize] = useState(10);
  const [search, setSearch] = useState("");

  const { categorias, loading, totalPages, refresh } = useCategorias({
    page, size, search,
  });

  const {
    formNombre,
    editando,
    showForm,
    submitting,
    abrirNuevo,
    abrirEditar,
    cerrarForm,
    handleNombreChange,
    handleSubmit,
    pedirConfirmacionEliminar,
    modalProps,
    cerrarModal,
  } = useGestionCategorias({
    onSuccess: () => { setPage(0); refresh(); },
  });

  const handleSearch = (v: string) => { setSearch(v); setPage(0); };

  const paginacion = !loading && totalPages > 1 && (
    <Paginacion
      page={page}
      totalPages={totalPages}
      onPageChange={setPage}
      size={size}
      onSizeChange={(s: number) => { setSize(s); setPage(0); }}
    />
  );

  return (
    <>
      {isMobile && (
        <FAB onClick={abrirNuevo} title="Nueva categoría" icon="+" />
      )}

      <div className="flex flex-wrap items-end gap-3 mb-6">
        <div className="flex-1 min-w-[200px]">
          <BuscadorInput
            value={search}
            onChange={handleSearch}
            placeholder="Buscar categoría..."
          />
        </div>
        {!isMobile && (
          <Button onClick={abrirNuevo} className="ml-auto">
            + Nueva categoría
          </Button>
        )}
      </div>

      {!isMobile ? (
        <div className="flex flex-col gap-4">
          <TablaCategorias
            categorias={categorias}
            loading={loading}
            size={size}
            onEditar={abrirEditar}
            onEliminar={pedirConfirmacionEliminar}
          />
          {paginacion}
        </div>
      ) : (
        <div className="flex flex-col gap-4 pb-16">
          {loading
            ? Array.from({ length: size }).map((_, i) => (
                <Skeleton key={i} variant="categoria-card" />
              ))
            : categorias.length === 0
              ? (
                <div className="py-12 text-center text-zinc-400 bg-zinc-800/50 rounded-2xl border border-zinc-700">
                  {search ? "Sin resultados para la búsqueda." : "No hay categorías registradas."}
                </div>
              )
              : categorias.map((c) => (
                  <CategoriaCard
                    key={c.id}
                    categoria={c}
                    onEditar={abrirEditar}
                    onEliminar={pedirConfirmacionEliminar}
                  />
                ))
          }
          {paginacion}
        </div>
      )}

      {showForm && (
        <BaseModal
          title={editando ? "Editar categoría" : "Nueva categoría"}
          onClose={cerrarForm}
          className="w-full"
          contentClassName="flex-1"
          footer={
            <div className="flex gap-3">
              <Button
                type="submit"
                form="categoria-form"
                className="flex-1"
                disabled={submitting}
              >
                {submitting
                  ? "Guardando..."
                  : editando
                    ? "Guardar cambios"
                    : "Crear categoría"
                }
              </Button>
              <Button
                type="button"
                variant="secondary"
                onClick={cerrarForm}
                className="flex-1"
                disabled={submitting}
              >
                Cancelar
              </Button>
            </div>
          }
        >
          <form id="categoria-form" onSubmit={handleSubmit} className="flex flex-col gap-4">
            <div>
              <label className="block text-xs text-zinc-400 mb-1">Nombre</label>
              <input
                value={formNombre}
                onChange={(e) => handleNombreChange(e.target.value)}
                placeholder="Nombre de la categoría"
                className="w-full px-4 py-2.5 rounded-xl bg-zinc-800 border border-zinc-600 text-white placeholder-zinc-500 focus:outline-none focus:ring-2 focus:ring-purple-500"
                autoFocus
                disabled={submitting}
              />
            </div>
          </form>
        </BaseModal>
      )}

      {modalProps && (
        <ModalConfirmacion
          mensaje={modalProps.mensaje}
          confirmText={modalProps.confirmText}
          onConfirmar={modalProps.onConfirmar}
          onCancelar={modalProps.onCancelar ?? cerrarModal}
        />
      )}
    </>
  );
}

import { useState } from "react";
import AppLayout from "@layout/AppLayout";
import Main from "@layout/Main";
import ContenedorVentas from "../components/ContenedorVentas";
import useVentasManager from "../hooks/useVentasManager";
import useResumenVentas from "../hooks/useResumenVentas";
import ModalPago from "../components/ModalPago";
import ModalConfirmacion from "@components/common/ModalConfirmacion";
import ModalDetalleVenta from "../components/ModalDetalleVenta";
import { Sparkles } from "lucide-react";

export default function VentasPagina() {
  const {
    ventas, loading,
    page, totalPages, setPage,
    size, setSize,
    modalPago, abrirPago, confirmarPago, cerrarModalPago,
    modalConfirmacion, setModalConfirmacion, solicitarCancelacion,
    verDetalleVenta, ventaDetalle, setVentaDetalle, detalleCargando,
  } = useVentasManager();

  const { resumen, generando, generarResumen } = useResumenVentas();
  const [resumenVisible, setResumenVisible] = useState(false);

  const handleGenerarResumen = () => {
    if (resumenVisible) {
      setResumenVisible(false);
      return;
    }
    setResumenVisible(true);
    if (ventas.length > 0) {
      generarResumen("últimas ventas", ventas);
    }
  };

  return (
    <AppLayout>
      <Main>
        <header className="mb-8">
          <div className="flex items-center justify-between gap-4">
            <div>
              <h1 className="text-3xl font-extrabold text-white tracking-tight">
                Historial de Ventas
              </h1>
              <p className="text-zinc-400 mt-1">
                Consulta y gestiona las transacciones realizadas.
              </p>
            </div>
            <button
              onClick={handleGenerarResumen}
              className="flex items-center gap-2 text-[11px] font-semibold px-4 py-2 rounded-xl border transition-all whitespace-nowrap text-zinc-400 border-zinc-700 hover:border-purple-500/50 hover:text-purple-400"
            >
              <Sparkles size={14} />
              {resumenVisible ? "Ocultar resumen" : "Resumen IA"}
            </button>
          </div>
        </header>

        {resumenVisible && (
          <div className="mb-6 p-4 rounded-2xl bg-purple-500/5 border border-purple-500/20">
            {generando ? (
              <div className="flex items-center gap-3 text-zinc-400 text-sm">
                <div className="w-4 h-4 rounded-full border-2 border-purple-500 border-t-transparent animate-spin" />
                Generando resumen...
              </div>
            ) : resumen ? (
              <p className="text-zinc-300 text-sm leading-relaxed">{resumen}</p>
            ) : (
              <p className="text-zinc-500 text-sm italic">No hay datos suficientes para generar un resumen.</p>
            )}
          </div>
        )}

        <ContenedorVentas
          ventas={ventas}
          loading={loading}
          onVerDetalle={verDetalleVenta}
          onCancelar={(v) => solicitarCancelacion(v.id)}
          onCobrar={abrirPago}
          page={page}
          totalPages={totalPages}
          onPageChange={setPage}
          size={size}
          onSizeChange={setSize}
        />
      </Main>

      {modalPago.visible && modalPago.venta && (
        <ModalPago
          totalPendiente={modalPago.totalPendiente}
          onConfirmar={confirmarPago}
          onCancelar={cerrarModalPago}
          confirmText="Cobrar"
        />
      )}

      {modalConfirmacion.visible && (
        <ModalConfirmacion
          mensaje={modalConfirmacion.mensaje}
          confirmText="Sí, cancelar"
          onConfirmar={modalConfirmacion.onConfirmar ?? undefined}
          onCancelar={() => setModalConfirmacion((m) => ({ ...m, visible: false }))}
        />
      )}

      {ventaDetalle && (
        <ModalDetalleVenta
          venta={ventaDetalle}
          loading={detalleCargando}
          onClose={() => setVentaDetalle(null)}
        />
      )}
    </AppLayout>
  );
}

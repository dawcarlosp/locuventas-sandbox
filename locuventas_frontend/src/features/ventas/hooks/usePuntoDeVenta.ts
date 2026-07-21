import { apiRequest } from "@services/api";
import type { CarritoItem } from "./useCarrito";
import type { Venta, VentaDetalle } from "../domain/venta.types";

function prepararLineas(carga: CarritoItem[]) {
  return carga.map((item) => {
    const precio = Number(item.producto.precio);
    const iva = Number(item.producto.iva || 0);
    const precioConIva = precio * (1 + iva / 100);
    return {
      productoId: item.producto.id,
      cantidad: item.cantidad,
      subtotal: +(precioConIva * item.cantidad).toFixed(2),
    };
  });
}

export function usePuntoDeVenta() {
  const guardarVentaSinCobrar = async (carga: CarritoItem[]): Promise<VentaDetalle> => {
    const lineas = prepararLineas(carga);
    return apiRequest<VentaDetalle>("ventas", { lineas }, { method: "POST" });
  };

  const crearVenta = async (carga: CarritoItem[]): Promise<Venta> => {
    const lineas = prepararLineas(carga);
    const venta = await apiRequest<Venta>("ventas", { lineas }, { method: "POST" });
    const total = lineas.reduce((sum, l) => sum + l.subtotal, 0);
    return { ...venta, total };
  };

  const confirmarPago = async (ventaId: number, importe: number): Promise<VentaDetalle> => {
    return apiRequest<VentaDetalle>(
      `ventas/${ventaId}/pago`,
      { monto: importe },
      { method: "POST" },
    );
  };

  return { guardarVentaSinCobrar, crearVenta, confirmarPago };
}

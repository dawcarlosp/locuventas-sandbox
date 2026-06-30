import { describe, it, expect } from "vitest";
import { renderHook } from "@testing-library/react";
import { useCarrito } from "../useCarrito";
import type { Producto } from "@features/productos/domain/producto.types";

const mockProducto = (overrides: Partial<Producto> = {}): Producto => ({
  id: 1,
  nombre: "Producto test",
  precio: 100,
  iva: 21,
  foto: null,
  paisId: 1,
  paisNombre: "España",
  paisFoto: null,
  categorias: [],
  ...overrides,
});

describe("useCarrito", () => {
  it("devuelve ceros con carrito vacío", () => {
    const { result } = renderHook(() => useCarrito([]));
    expect(result.current.base).toBe(0);
    expect(result.current.iva).toBe(0);
    expect(result.current.total).toBe(0);
    expect(result.current.numProductos).toBe(0);
  });

  it("calcula totales con un solo producto", () => {
    const producto = mockProducto({ precio: 200, iva: 10 });
    const carga = [{ cantidad: 2, producto }];
    const { result } = renderHook(() => useCarrito(carga));

    expect(result.current.base).toBe(400);
    expect(result.current.iva).toBe(40);
    expect(result.current.total).toBe(440);
    expect(result.current.numProductos).toBe(2);
  });

  it("calcula totales con múltiples productos", () => {
    const p1 = mockProducto({ id: 1, precio: 100, iva: 21 });
    const p2 = mockProducto({ id: 2, precio: 50, iva: 10 });
    const carga = [
      { cantidad: 3, producto: p1 },
      { cantidad: 2, producto: p2 },
    ];
    const { result } = renderHook(() => useCarrito(carga));

    expect(result.current.base).toBe(400);
    expect(result.current.iva).toBe(73);
    expect(result.current.total).toBe(473);
    expect(result.current.numProductos).toBe(5);
  });

  it("maneja IVA cero", () => {
    const producto = mockProducto({ precio: 100, iva: 0 });
    const carga = [{ cantidad: 5, producto }];
    const { result } = renderHook(() => useCarrito(carga));

    expect(result.current.base).toBe(500);
    expect(result.current.iva).toBe(0);
    expect(result.current.total).toBe(500);
  });
});

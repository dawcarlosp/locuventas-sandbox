import { act, renderHook, waitFor } from "@testing-library/react";
import { beforeEach, describe, expect, it, vi } from "vitest";
import useProductos from "../useProductos";
import useGestionProductos from "../useGestionProductos";
import { apiRequest } from "@services/api";

vi.mock("@services/api", () => ({
  apiRequest: vi.fn(),
}));

vi.mock("react-toastify", () => ({
  toast: {
    error: vi.fn(),
  },
}));

describe("useProductos", () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it("permite refrescar la lista sin cambiar filtros ni página", async () => {
    vi.mocked(apiRequest)
      .mockResolvedValueOnce({
        data: { content: [{ id: 1, nombre: "Prod A" }], totalPages: 1 },
      } as never)
      .mockResolvedValueOnce({
        data: { content: [{ id: 1, nombre: "Prod A editado" }], totalPages: 1 },
      } as never);

    const { result } = renderHook(() => useProductos({ page: 0, size: 10 }));

    await waitFor(() => expect(result.current.loading).toBe(false));
    expect(apiRequest).toHaveBeenCalledTimes(1);

    act(() => {
      result.current.refresh();
    });

    await waitFor(() => expect(apiRequest).toHaveBeenCalledTimes(2));
    await waitFor(() => expect(result.current.productos[0]?.nombre).toBe("Prod A editado"));
  });

  it("asigna las categorías del producto al abrir edición aunque lleguen como ids o nombres", () => {
    const { result } = renderHook(() =>
      useGestionProductos({ onSuccess: vi.fn() })
    );

    const prod = {
      id: 1,
      nombre: "Prod",
      precio: 10,
      iva: 21,
      foto: null,
      paisId: 2,
      paisNombre: "España",
      paisFoto: null,
      categorias: ["Bebidas", 7],
    } as never;

    act(() => {
      result.current.abrirEditar(prod, [{ value: 2, label: "España" }], [
        { value: 7, label: "Bebidas" },
        { value: 8, label: "Lácteos" },
      ]);
    });

    expect(result.current.form.categoriaIds).toEqual([7]);
  });
});

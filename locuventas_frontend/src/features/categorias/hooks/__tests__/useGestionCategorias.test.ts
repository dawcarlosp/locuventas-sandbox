import { describe, it, expect, vi, beforeEach } from "vitest";
import { renderHook, act } from "@testing-library/react";
import { toast } from "react-toastify";
import useGestionCategorias from "../useGestionCategorias";
import { apiRequest } from "@services/api";

vi.mock("@services/api", () => ({
  apiRequest: vi.fn(),
}));

vi.mock("react-toastify", () => ({
  toast: {
    success: vi.fn(),
    error: vi.fn(),
  },
}));

const onSuccess = vi.fn();

beforeEach(() => {
  vi.clearAllMocks();
});

describe("useGestionCategorias", () => {
  it("abrirNuevo resetea el formulario y lo muestra", () => {
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    act(() => result.current.abrirNuevo());

    expect(result.current.showForm).toBe(true);
    expect(result.current.editando).toBeNull();
    expect(result.current.formNombre).toBe("");
  });

  it("abrirEditar rellena el formulario con los datos de la categoría", () => {
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));
    const categoria = { id: 5, nombre: "Bebidas" };

    act(() => result.current.abrirEditar(categoria));

    expect(result.current.showForm).toBe(true);
    expect(result.current.editando).toEqual(categoria);
    expect(result.current.formNombre).toBe("Bebidas");
  });

  it("cerrarForm resetea todo", () => {
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    act(() => result.current.abrirNuevo());
    act(() => result.current.cerrarForm());

    expect(result.current.showForm).toBe(false);
    expect(result.current.editando).toBeNull();
    expect(result.current.formNombre).toBe("");
  });

  it("handleSubmit con nombre vacío muestra error", async () => {
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    await act(async () => {
      await result.current.handleSubmit({ preventDefault: vi.fn() } as unknown as React.FormEvent);
    });

    expect(toast.error).toHaveBeenCalledWith("El nombre es obligatorio");
    expect(apiRequest).not.toHaveBeenCalled();
  });

  it("handleSubmit crea una categoría correctamente", async () => {
    vi.mocked(apiRequest).mockResolvedValueOnce({ data: { id: 1, nombre: "Test" } });
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    act(() => result.current.abrirNuevo());
    act(() => result.current.handleNombreChange("Test"));

    await act(async () => {
      await result.current.handleSubmit({ preventDefault: vi.fn() } as unknown as React.FormEvent);
    });

    expect(apiRequest).toHaveBeenCalledWith(
      "categorias",
      { nombre: "Test" },
      { method: "POST" },
    );
    expect(toast.success).toHaveBeenCalledWith("Categoría creada");
    expect(onSuccess).toHaveBeenCalled();
  });

  it("handleSubmit con editando muestra modal de confirmación en vez de guardar directo", async () => {
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));
    const categoria = { id: 3, nombre: "Snacks" };

    act(() => result.current.abrirEditar(categoria));
    act(() => result.current.handleNombreChange("Snacks actualizado"));

    await act(async () => {
      await result.current.handleSubmit({ preventDefault: vi.fn() } as unknown as React.FormEvent);
    });

    expect(result.current.modalProps).not.toBeNull();
    expect(result.current.modalProps?.mensaje).toBe("¿Guardar cambios de esta categoría?");
    expect(apiRequest).not.toHaveBeenCalled();
  });

  it("pedirConfirmacionEliminar abre modal y al confirmar ejecuta DELETE", async () => {
    vi.mocked(apiRequest).mockResolvedValueOnce({});
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    act(() => result.current.pedirConfirmacionEliminar(7));

    expect(result.current.modalProps).not.toBeNull();
    expect(result.current.modalProps?.mensaje).toBe("¿Seguro que quieres eliminar esta categoría?");

    await act(async () => {
      await result.current.modalProps!.onConfirmar();
    });

    expect(apiRequest).toHaveBeenCalledWith("categorias/7", null, { method: "DELETE" });
    expect(toast.success).toHaveBeenCalledWith("Categoría eliminada");
    expect(onSuccess).toHaveBeenCalled();
  });

  it("pedirConfirmacionEliminar con productos asociados muestra modal force", async () => {
    vi.mocked(apiRequest)
      .mockRejectedValueOnce({ data: 3, message: "Tiene productos asociados" });
    const { result } = renderHook(() => useGestionCategorias({ onSuccess }));

    act(() => result.current.pedirConfirmacionEliminar(7));

    expect(result.current.modalProps).not.toBeNull();
    expect(result.current.modalProps?.mensaje).toBe("¿Seguro que quieres eliminar esta categoría?");

    await act(async () => {
      await result.current.modalProps!.onConfirmar();
    });

    expect(result.current.modalProps?.mensaje).toContain("3 productos asociados");

    vi.mocked(apiRequest).mockResolvedValueOnce({});

    await act(async () => {
      await result.current.modalProps!.onConfirmar();
    });

    expect(apiRequest).toHaveBeenCalledWith("categorias/7/force", null, { method: "DELETE" });
    expect(toast.success).toHaveBeenCalledWith("Categoría y productos eliminados");
  });
});

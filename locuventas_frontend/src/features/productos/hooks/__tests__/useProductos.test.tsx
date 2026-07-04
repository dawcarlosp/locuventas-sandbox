import { act, renderHook, waitFor } from "@testing-library/react";
import { beforeEach, describe, expect, it, vi } from "vitest";
import useProductos from "../useProductos";
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
});

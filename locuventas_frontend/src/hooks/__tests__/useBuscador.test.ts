import { describe, it, expect, vi } from "vitest";
import { renderHook, act } from "@testing-library/react";
import useBuscador from "../useBuscador";

describe("useBuscador", () => {
  it("inicializa con query vacía", () => {
    const { result } = renderHook(() => useBuscador());
    expect(result.current.query).toBe("");
  });

  it("actualiza query al llamar handleChange", () => {
    const { result } = renderHook(() => useBuscador());
    act(() => result.current.handleChange("test"));
    expect(result.current.query).toBe("test");
  });

  it("limpia query al llamar handleClear", () => {
    const { result } = renderHook(() => useBuscador());
    act(() => result.current.handleChange("test"));
    act(() => result.current.handleClear());
    expect(result.current.query).toBe("");
  });

  it("dispara onSearch con debounce", async () => {
    vi.useFakeTimers();
    const onSearch = vi.fn();
    const { result } = renderHook(() => useBuscador({ debounceMs: 300, onSearch }));

    act(() => result.current.handleChange("test"));
    expect(onSearch).not.toHaveBeenCalled();

    act(() => { vi.advanceTimersByTime(300); });
    expect(onSearch).toHaveBeenCalledWith("test");

    vi.useRealTimers();
  });

  it("cancela debounce anterior si se escribe de nuevo", () => {
    vi.useFakeTimers();
    const onSearch = vi.fn();
    const { result } = renderHook(() => useBuscador({ debounceMs: 300, onSearch }));

    act(() => result.current.handleChange("primero"));
    act(() => { vi.advanceTimersByTime(200); });
    act(() => result.current.handleChange("segundo"));
    act(() => { vi.advanceTimersByTime(300); });

    expect(onSearch).toHaveBeenCalledTimes(1);
    expect(onSearch).toHaveBeenCalledWith("segundo");

    vi.useRealTimers();
  });
});

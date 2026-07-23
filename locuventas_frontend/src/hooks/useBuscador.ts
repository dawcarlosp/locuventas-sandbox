// src/hooks/useBuscador.ts
import { useState, useRef, useEffect } from "react";
import type { RefObject } from "react";

interface UseBuscadorOptions {
  debounceMs?: number;
  onSearch?:   (value: string) => void;
}

interface UseBuscadorReturn {
  query:        string;
  setQuery:     (v: string) => void;
  inputRef:     RefObject<HTMLInputElement | null>;
  handleChange: (v: string) => void;
  handleClear:  () => void;
  flush:        () => void;
}

export default function useBuscador({
  debounceMs = 400,
  onSearch,
}: UseBuscadorOptions = {}): UseBuscadorReturn {
  const [query, setQuery] = useState("");
  const timerRef          = useRef<ReturnType<typeof setTimeout> | null>(null);
  const inputRef          = useRef<HTMLInputElement>(null);

  const handleChange = (value: string): void => {
    setQuery(value);
    if (onSearch) {
      if (timerRef.current) clearTimeout(timerRef.current);
      timerRef.current = setTimeout(() => onSearch(value), debounceMs);
    }
  };

  const flush = (): void => {
    if (timerRef.current) {
      clearTimeout(timerRef.current);
      timerRef.current = null;
    }
    if (onSearch && query.trim()) {
      onSearch(query);
    }
  };

  const handleClear = (): void => {
    setQuery("");
    if (onSearch) {
      if (timerRef.current) clearTimeout(timerRef.current);
      onSearch("");
    }
  };

  useEffect(() => {
    return () => {
      if (timerRef.current) clearTimeout(timerRef.current);
    };
  }, []);

  return { query, setQuery, inputRef, handleChange, handleClear, flush };
}
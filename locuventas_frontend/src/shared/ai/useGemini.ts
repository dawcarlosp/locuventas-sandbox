import { useState, useRef, useCallback } from "react";
import { generateContent, generateJson } from "./gemini.client";

interface UseGeminiReturn<T = string> {
  result: T | null;
  loading: boolean;
  error: string | null;
  generate: (prompt: string) => Promise<T | null>;
  reset: () => void;
}

export function useGemini<T = string>(): UseGeminiReturn<T> {
  const [result, setResult] = useState<T | null>(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const abortRef = useRef<AbortController | null>(null);

  const generate = useCallback(async (prompt: string): Promise<T | null> => {
    abortRef.current?.abort();
    const controller = new AbortController();
    abortRef.current = controller;

    setLoading(true);
    setError(null);
    setResult(null);

    try {
      const text = await generateContent(prompt, {
        signal: controller.signal,
      });
      const typedResult = text as unknown as T;
      setResult(typedResult);
      return typedResult;
    } catch (err: unknown) {
      const e = err as Record<string, string | undefined>;
      if (e?.name === "AbortError") return null;
      const msg = e?.message ?? "Error al llamar a Gemini";
      setError(msg);
      return null;
    } finally {
      setLoading(false);
    }
  }, []);

  const reset = useCallback(() => {
    abortRef.current?.abort();
    setResult(null);
    setLoading(false);
    setError(null);
  }, []);

  return { result, loading, error, generate, reset };
}

export function useGeminiJson<T = unknown>(): UseGeminiReturn<T> {
  const [result, setResult] = useState<T | null>(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const abortRef = useRef<AbortController | null>(null);

  const generate = useCallback(async (prompt: string): Promise<T | null> => {
    abortRef.current?.abort();
    const controller = new AbortController();
    abortRef.current = controller;

    setLoading(true);
    setError(null);
    setResult(null);

    try {
      const data = await generateJson<T>(prompt, {
        signal: controller.signal,
      });
      setResult(data);
      return data;
    } catch (err: unknown) {
      const e = err as Record<string, string | undefined>;
      if (e?.name === "AbortError") return null;
      const msg = e?.message ?? "Error al llamar a Gemini";
      setError(msg);
      return null;
    } finally {
      setLoading(false);
    }
  }, []);

  const reset = useCallback(() => {
    abortRef.current?.abort();
    setResult(null);
    setLoading(false);
    setError(null);
  }, []);

  return { result, loading, error, generate, reset };
}

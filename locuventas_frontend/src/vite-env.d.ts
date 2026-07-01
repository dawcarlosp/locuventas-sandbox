/// <reference types="vite/client" />

interface ImportMetaEnv {
  readonly VITE_API_URL: string;
}

interface ImportMeta {
  readonly env: ImportMetaEnv;
}

// LanguageModel API (Gemini Nano local en Chrome)
interface LanguageModelCreateOptions {
  expectedOutputLanguage?: string;
  temperature?: number;
  signal?: AbortSignal;
}

interface LanguageModelSession {
  prompt(input: string): Promise<string>;
  destroy(): void;
}

declare class LanguageModel {
  static create(options?: LanguageModelCreateOptions): Promise<LanguageModelSession>;
}
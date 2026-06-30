const GEMINI_API_BASE = "https://generativelanguage.googleapis.com/v1beta";

function getApiKey(): string {
  const key = import.meta.env.VITE_GEMINI_API_KEY as string | undefined;
  if (!key) {
    throw new Error(
      "VITE_GEMINI_API_KEY no configurada. " +
        "Añádela al archivo .env para usar funciones de IA."
    );
  }
  return key;
}

interface GeminiPart {
  text: string;
}

interface GeminiContent {
  parts: GeminiPart[];
}

interface GeminiCandidate {
  content: GeminiContent;
}

interface GeminiResponse {
  candidates?: GeminiCandidate[];
}

interface GeminiRequestOptions {
  model?: string;
  signal?: AbortSignal;
}

export async function generateContent(
  prompt: string,
  options: GeminiRequestOptions = {}
): Promise<string> {
  const { model = "gemini-2.0-flash", signal } = options;
  const apiKey = getApiKey();

  const url = `${GEMINI_API_BASE}/models/${model}:generateContent?key=${apiKey}`;

  const response = await fetch(url, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    signal,
    body: JSON.stringify({
      contents: [{ parts: [{ text: prompt }] }],
    }),
  });

  if (!response.ok) {
    const errorText = await response.text().catch(() => "Unknown error");
    throw new Error(`Gemini API error (${response.status}): ${errorText}`);
  }

  const data = (await response.json()) as GeminiResponse;

  const text = data.candidates?.[0]?.content?.parts?.[0]?.text;
  if (text == null) {
    throw new Error("Gemini: respuesta vacía o inesperada");
  }

  return text;
}

export async function generateJson<T>(
  prompt: string,
  options: GeminiRequestOptions = {}
): Promise<T> {
  const text = await generateContent(prompt, options);

  const jsonStr = text
    .replace(/```(?:json)?\s*/g, "")
    .replace(/```/g, "")
    .trim();

  try {
    return JSON.parse(jsonStr) as T;
  } catch {
    throw new Error(
      "Gemini: no se pudo parsear la respuesta como JSON.\n" +
        `Respuesta recibida:\n${text}`
    );
  }
}

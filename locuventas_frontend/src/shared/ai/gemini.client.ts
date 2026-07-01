interface GeminiRequestOptions {
  signal?: AbortSignal;
}

function checkAvailability(): void {
  if (typeof LanguageModel === "undefined") {
    throw new Error(
      "IA local no disponible. Usa Chrome y habilita " +
        "chrome://flags/#optimization-guide-on-device-model"
    );
  }
}

export async function generateContent(
  prompt: string,
  options: GeminiRequestOptions = {}
): Promise<string> {
  checkAvailability();

  const session = await LanguageModel.create({
    expectedOutputLanguage: "es",
    temperature: 0.7,
    signal: options.signal,
  });

  try {
    return await session.prompt(prompt);
  } finally {
    session.destroy();
  }
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

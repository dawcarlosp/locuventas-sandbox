// src/utils/imageUtils.ts

const API_URL = import.meta.env.VITE_API_URL as string;

/**
 * Resuelve la URL completa de la imagen de un producto.
 * Si `foto` ya contiene "/", se usa tal cual como ruta relativa.
 */
const normalizeImagePath = (path: string): string => path.trim();

export const resolveProductImage = (
  foto: string | null | undefined,
): string | null => {
  if (!foto) return null;
  const normalized = normalizeImagePath(foto);
  if (normalized.startsWith("http://") || normalized.startsWith("https://")) {
    return normalized;
  }
  if (normalized.startsWith("/imagenes/")) {
    return `${API_URL}${normalized}`;
  }
  if (normalized.startsWith("imagenes/")) {
    return `${API_URL}/${encodeURI(normalized)}`;
  }
  if (normalized.startsWith("/productos/")) {
    return `${API_URL}${normalized}`;
  }
  const path = normalized.includes("/")
    ? normalized
    : `productos/${normalized}`;
  return `${API_URL}/imagenes/${encodeURI(path)}`;
};

/**
 * Resuelve la URL de la bandera de un país.
 * Si ya es una URL absoluta, se devuelve sin modificar.
 */
export const resolveCountryImage = (
  enlaceFoto: string | null | undefined,
): string | null => {
  if (!enlaceFoto) return null;
  const normalized = normalizeImagePath(enlaceFoto);
  if (normalized.startsWith("http://") || normalized.startsWith("https://")) {
    return normalized;
  }
  if (normalized.startsWith("/imagenes/")) {
    return `${API_URL}${normalized}`;
  }
  return `${API_URL}/imagenes/paises/${encodeURI(normalized)}`;
};

/**
 * Resuelve la URL completa de la imagen de un vendedor.
 */
export const resolveVendorImage = (
  foto: string | null | undefined,
): string | null => {
  if (!foto) return null;
  const normalized = normalizeImagePath(foto);
  if (normalized.startsWith("http://") || normalized.startsWith("https://")) {
    return normalized;
  }
  if (normalized.startsWith("/imagenes/")) {
    return `${API_URL}${normalized}`;
  }
  if (normalized.startsWith("imagenes/")) {
    return `${API_URL}/${encodeURI(normalized)}`;
  }
  if (normalized.startsWith("/vendedores/")) {
    return `${API_URL}/imagenes${encodeURI(normalized)}`;
  }
  const path = normalized.includes("/")
    ? normalized
    : `vendedores/${normalized}`;
  return `${API_URL}/imagenes/${encodeURI(path)}`;
};

/**
 * Devuelve la URL de imagen del producto o un fallback si no existe.
 */
export const resolveProductImageWithFallback = (
  foto: string | null | undefined,
  fallback: string,
): string => resolveProductImage(foto) ?? fallback;

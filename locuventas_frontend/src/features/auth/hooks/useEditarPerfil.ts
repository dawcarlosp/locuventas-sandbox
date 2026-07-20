import { useState, useEffect, useCallback } from "react";
import { apiRequest } from "@services/api";
import { validateUser } from "@utils/user.validator";
import { toast } from "react-toastify";
import { useAuth } from "@context/useAuth";

interface UseEditarPerfilOptions {
  isOpen: boolean;
  usuario: { nombre?: string; email?: string; foto?: string | null } | null;
  onClose: () => void;
}

export default function useEditarPerfil({ isOpen, usuario, onClose }: UseEditarPerfilOptions) {
  const [foto, setFoto] = useState<File | null>(null);
  const [nombre, setNombre] = useState(usuario?.nombre || "");
  const [email, setEmail] = useState(usuario?.email || "");
  const [password, setPassword] = useState("");
  const [errors, setErrors] = useState<Record<string, string>>({});
  const [touched, setTouched] = useState<Record<string, boolean>>({});
  const [loading, setLoading] = useState(false);
  const { setAuth } = useAuth();

  const reset = useCallback(() => {
    setNombre(usuario?.nombre || "");
    setEmail(usuario?.email || "");
    setPassword("");
    setFoto(null);
    setErrors({});
    setTouched({});
  }, [usuario]);

  useEffect(() => {
    if (isOpen) reset();
  }, [isOpen, reset]);

  useEffect(() => {
    setErrors(validateUser({ nombre, email, password, foto }, { validarFoto: false }));
  }, [nombre, email, password, foto]);

  const handleSubmit = useCallback(async () => {
    const validationErrors = validateUser(
      { nombre, email, password, foto },
      { validarFoto: false }
    );
    setErrors(validationErrors);
    setTouched({ nombre: true, email: true, password: true });

    if (Object.keys(validationErrors).length > 0) {
      toast.error("Revisa los campos marcados.");
      return;
    }

    setLoading(true);
    const formData = new FormData();
    const userDTO: Record<string, string> = { nombre, email };
    if (password.trim()) userDTO.password = password;
    formData.append("user", new Blob([JSON.stringify(userDTO)], { type: "application/json" }));
    if (foto) formData.append("foto", foto);

    try {
      const result = await apiRequest<{ data?: { foto?: string }; foto?: string }>(
        "usuarios/editar-perfil",
        formData,
        { isFormData: true, method: "PUT" }
      );

      const newFoto = result.data?.foto ?? result.foto;
      const authUpdate: Record<string, string | null> = { nombre, email };
      if (typeof newFoto === "string") authUpdate.foto = newFoto;

      toast.success("Perfil actualizado");
      setAuth(authUpdate);
      onClose();
    } catch (err) {
      const errorObj = err as Record<string, string>;
      setErrors(errorObj);
      toast.error(errorObj.message || "Error al editar");
    } finally {
      setLoading(false);
    }
  }, [nombre, email, password, foto, onClose, setAuth]);

  return {
    foto, setFoto,
    nombre, setNombre,
    email, setEmail,
    password, setPassword,
    errors, setTouched,
    touched,
    loading,
    handleSubmit,
    reset,
  };
}

import { useState, useCallback } from "react";
import { toast } from "react-toastify";
import { apiRequest } from "@services/api";
import type { ApiResponse } from "@domain/api.types";
import type { Categoria, CategoriaCreateDTO, CategoriaUpdateDTO } from "../domain/categoria.types";

interface UseGestionCategoriasOptions {
  onSuccess: () => void;
}

interface UseGestionCategoriasReturn {
  formNombre: string;
  editando:   Categoria | null;
  showForm:   boolean;
  submitting: boolean;
  abrirNuevo: () => void;
  abrirEditar: (c: Categoria) => void;
  cerrarForm: () => void;
  handleNombreChange: (v: string) => void;
  handleSubmit: (e: React.FormEvent) => Promise<void>;
  pedirConfirmacionEliminar: (id: number) => void;
  modalProps: ModalProps | null;
  cerrarModal: () => void;
}

interface ModalProps {
  mensaje:     string;
  confirmText: string;
  onConfirmar: () => Promise<void>;
  onCancelar?: () => void;
}

export default function useGestionCategorias({
  onSuccess,
}: UseGestionCategoriasOptions): UseGestionCategoriasReturn {
  const [formNombre, setFormNombre] = useState("");
  const [editando, setEditando] = useState<Categoria | null>(null);
  const [showForm, setShowForm] = useState(false);
  const [submitting, setSubmitting] = useState(false);
  const [modalProps, setModalProps] = useState<ModalProps | null>(null);

  const cerrarModal = useCallback(() => setModalProps(null), []);

  const abrirNuevo = useCallback(() => {
    setEditando(null);
    setFormNombre("");
    setShowForm(true);
  }, []);

  const abrirEditar = useCallback((c: Categoria) => {
    setEditando(c);
    setFormNombre(c.nombre);
    setShowForm(true);
  }, []);

  const cerrarForm = useCallback(() => {
    setShowForm(false);
    setEditando(null);
    setFormNombre("");
  }, []);

  const handleNombreChange = useCallback((v: string) => setFormNombre(v), []);

  const guardar = useCallback(async (dto: CategoriaCreateDTO | CategoriaUpdateDTO, id?: number) => {
    setSubmitting(true);
    try {
      const endpoint = id ? `categorias/${id}` : "categorias";
      const method = id ? "PUT" : "POST";
      await apiRequest<ApiResponse<Categoria>>(endpoint, dto, { method });
      toast.success(id ? "Categoría actualizada" : "Categoría creada");
      cerrarForm();
      onSuccess();
    } catch {
      toast.error("Error al guardar la categoría");
    } finally {
      setSubmitting(false);
    }
  }, [cerrarForm, onSuccess]);

  const handleSubmit = useCallback(async (e: React.FormEvent) => {
    e.preventDefault();
    const nombre = formNombre.trim();
    if (!nombre) {
      toast.error("El nombre es obligatorio");
      return;
    }
    if (editando) {
      setModalProps({
        mensaje: "¿Guardar cambios de esta categoría?",
        confirmText: "Guardar cambios",
        onConfirmar: async () => {
          cerrarModal();
          await guardar({ nombre }, editando.id);
        },
        onCancelar: cerrarModal,
      });
      return;
    }
    await guardar({ nombre });
  }, [formNombre, editando, cerrarModal, guardar]);

  const pedirConfirmacionEliminar = useCallback((id: number) => {
    setModalProps({
      mensaje: "¿Seguro que quieres eliminar esta categoría?",
      confirmText: "Eliminar",
      onConfirmar: async () => {
        cerrarModal();
        setSubmitting(true);
        try {
          await apiRequest<ApiResponse<number>>(`categorias/${id}`, null, { method: "DELETE" });
          toast.success("Categoría eliminada");
          onSuccess();
        } catch (err: unknown) {
          const e = err as Partial<ApiResponse<number>>;
          const productCount = e?.data ?? 0;
          if (productCount > 0) {
            setModalProps({
              visible: true as never,
              mensaje: `Esta categoría tiene ${productCount} producto${productCount === 1 ? "" : "s"} asociado${productCount === 1 ? "" : "s"}. ¿Qué deseas hacer?`,
              confirmText: "Borrar categoría y productos",
              onConfirmar: async () => {
                cerrarModal();
                setSubmitting(true);
                try {
                  await apiRequest(`categorias/${id}/force`, null, { method: "DELETE" });
                  toast.success("Categoría y productos eliminados");
                  onSuccess();
                } catch {
                  toast.error("Error al eliminar categoría y productos");
                } finally {
                  setSubmitting(false);
                }
              },
              onCancelar: cerrarModal,
            });
            return;
          }
          toast.error(e?.message ?? "Error al eliminar la categoría");
        } finally {
          setSubmitting(false);
        }
      },
      onCancelar: cerrarModal,
    });
  }, [cerrarModal, onSuccess]);

  return {
    formNombre,
    editando,
    showForm,
    submitting,
    abrirNuevo,
    abrirEditar,
    cerrarForm,
    handleNombreChange,
    handleSubmit,
    pedirConfirmacionEliminar,
    modalProps,
    cerrarModal,
  };
}

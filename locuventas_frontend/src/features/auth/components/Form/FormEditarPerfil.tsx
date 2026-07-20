import FormDialog from "@components/common/FormDialog";
import InputFieldsetValidaciones from "@components/common/InputFieldsetValidaciones";
import ImageUpload from "@components/common/ImageUpload";
import { resolveVendorImage } from "@utils/imageUtils";
import useEditarPerfil from "../../hooks/useEditarPerfil";

interface Props {
  isOpen:   boolean;
  setIsOpen: (v: boolean) => void;
  usuario:  { nombre?: string; email?: string; foto?: string | null } | null;
}

function FormEditarPerfil({ isOpen, setIsOpen, usuario }: Props) {
  const {
    foto, setFoto,
    nombre, setNombre,
    email, setEmail,
    password, setPassword,
    errors, touched, setTouched,
    loading,
    handleSubmit,
  } = useEditarPerfil({ isOpen, usuario, onClose: () => setIsOpen(false) });

  if (!isOpen) return null;

  return (
    <FormDialog
      visible={isOpen}
      onClose={() => setIsOpen(false)}
      onSubmit={handleSubmit}
      titulo="Editar Perfil"
      botonTexto={loading ? "Actualizando..." : "Actualizar"}
      botonDisabled={loading}
    >
      <ImageUpload
        setFile={setFoto}
        file={foto}
        fotoActualUrl={resolveVendorImage(usuario?.foto ?? null)}
        shape="circle"
      />

      {errors.foto && touched.foto && (
        <p className="text-red-400 text-xs text-center -mt-2 mb-1">{errors.foto}</p>
      )}

      <InputFieldsetValidaciones
        type="text"
        id="nombre"
        value={nombre}
        onChange={(e) => setNombre(e.target.value)}
        onBlur={() => setTouched((t) => ({ ...t, nombre: true }))}
        placeholder="Tu nombre"
        error={errors.nombre}
        touched={touched.nombre}
      />

      <InputFieldsetValidaciones
        type="email"
        id="email"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
        onBlur={() => setTouched((t) => ({ ...t, email: true }))}
        placeholder="Correo electrónico"
        error={errors.email}
        touched={touched.email}
      />

      <InputFieldsetValidaciones
        type="password"
        id="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        onBlur={() => setTouched((t) => ({ ...t, password: true }))}
        placeholder="Nueva contraseña (opcional)"
        autoComplete="new-password"
        error={errors.password}
        touched={touched.password}
      />
    </FormDialog>
  );
}

export default FormEditarPerfil;

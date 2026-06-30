import { lazy, Suspense } from "react";
import { Route, Routes } from "react-router-dom";
import LoginPage from "@/features/auth/pages/LoginPage";
import PrivateRoute from "@/app/PrivateRoute";

const Dashboard = lazy(() => import("@features/ventas/pages/Dashboard"));
const VentasPagina = lazy(() => import("@features/ventas/pages/VentasPagina"));
const VentasPendientesPagina = lazy(() => import("@features/ventas/pages/VentasPendientesPagina"));
const VendedoresPendientesPagina = lazy(() => import("@features/auth/pages/VendedoresPendientesPagina"));
const GestionProductosPagina = lazy(() => import("@features/productos/pages/GestionProductosPagina"));
const GestionCategoriasPagina = lazy(() => import("@features/categorias/pages/GestionCategoriasPagina"));
const SobreMiPage = lazy(() => import("@features/dev/pages/SobreMiPage"));

function SuspenseWrapper({ children }: { children: React.ReactNode }) {
  return (
    <Suspense fallback={
      <div className="min-h-screen flex items-center justify-center bg-zinc-900">
        <div className="animate-pulse text-zinc-500 text-sm">Cargando...</div>
      </div>
    }>
      {children}
    </Suspense>
  );
}

interface AppRoutesProps {
  setIsOpen: (v: boolean) => void;
}

export function AppRoutes({ setIsOpen }: AppRoutesProps) {
  return (
    <Routes>
      <Route path="/" element={<LoginPage setIsOpen={setIsOpen} />} />
      <Route path="/login" element={<LoginPage setIsOpen={setIsOpen} />} />
      <Route path="/aboutme" element={<SuspenseWrapper><SobreMiPage /></SuspenseWrapper>} />

      <Route
        path="/dashboard"
        element={
          <PrivateRoute>
            <SuspenseWrapper><Dashboard /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
      <Route
        path="/ventas"
        element={
          <PrivateRoute>
            <SuspenseWrapper><VentasPagina /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
      <Route
        path="/ventas/pendientes"
        element={
          <PrivateRoute>
            <SuspenseWrapper><VentasPendientesPagina /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
      <Route
        path="/vendedores/pendientes"
        element={
          <PrivateRoute>
            <SuspenseWrapper><VendedoresPendientesPagina /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
      <Route
        path="/productos/gestion"
        element={
          <PrivateRoute>
            <SuspenseWrapper><GestionProductosPagina /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
      <Route
        path="/categorias/gestion"
        element={
          <PrivateRoute>
            <SuspenseWrapper><GestionCategoriasPagina /></SuspenseWrapper>
          </PrivateRoute>
        }
      />
    </Routes>
  );
}

import { describe, it, expect, vi } from "vitest";
import { screen } from "@testing-library/react";
import { render } from "@/test/test-utils";
import LoginPage from "../LoginPage";

describe("LoginPage", () => {
  it("renderiza el formulario de login", () => {
    render(<LoginPage setIsOpen={vi.fn()} />);
    expect(screen.getByText("Correo electrónico")).toBeInTheDocument();
    expect(screen.getByText("Contraseña")).toBeInTheDocument();
  });

  it("muestra botón de iniciar sesión", () => {
    render(<LoginPage setIsOpen={vi.fn()} />);
    expect(screen.getByRole("button", { name: /iniciar sesión/i })).toBeInTheDocument();
  });

  it("muestra enlace de registro", () => {
    render(<LoginPage setIsOpen={vi.fn()} />);
    expect(screen.getByText("Regístrate")).toBeInTheDocument();
  });
});

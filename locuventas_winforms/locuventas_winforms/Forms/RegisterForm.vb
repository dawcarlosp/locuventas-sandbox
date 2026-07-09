Imports System.Text.Json

Public Class RegisterForm
    Private selectedFotoBytes As Byte()
    Private selectedFotoName As String

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleBtnPrimary(btnRegistrar)
        StyleBtnSecondary(btnCancelar)
        StyleBtnSecondary(btnSubirFoto)
        StyleInput(txtNombre)
        StyleInput(txtEmail)
        StyleInput(txtPassword)
        StyleInput(txtConfirmPassword)
    End Sub

    Private Async Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        lblError.Text = ""

        Dim nombre = txtNombre.Text.Trim()
        Dim email = txtEmail.Text.Trim()
        Dim password = txtPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            lblError.Text = "Todos los campos son obligatorios."
            Return
        End If

        If password <> confirmPassword Then
            lblError.Text = "Las contraseñas no coinciden."
            Return
        End If

        If selectedFotoBytes Is Nothing Then
            lblError.Text = "Debes seleccionar una foto de perfil."
            Return
        End If

        btnRegistrar.Enabled = False
        btnRegistrar.Text = "Registrando..."

        Try
            Cursor = Cursors.WaitCursor
            Await AuthService.Register(nombre, email, password, selectedFotoBytes, selectedFotoName)
            MessageBox.Show("Cuenta creada correctamente. Un administrador habilitará tu acceso.",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As ApiException
            Try
                Dim errorObj = JsonSerializer.Deserialize(Of ApiResponse(Of Object))(ex.ResponseContent)
                lblError.Text = If(errorObj?.Message, "Error al registrar.")
            Catch
                lblError.Text = "Error al registrar. Intenta de nuevo."
            End Try
        Catch ex As Exception
            lblError.Text = ex.Message
        Finally
            Cursor = Cursors.Default
            btnRegistrar.Enabled = True
            btnRegistrar.Text = "Registrarse"
        End Try
    End Sub

    Private Sub btnSubirFoto_Click(sender As Object, e As EventArgs) Handles btnSubirFoto.Click
        Using ofd = New OpenFileDialog()
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.webp|Todos|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                selectedFotoBytes = IO.File.ReadAllBytes(ofd.FileName)
                selectedFotoName = IO.Path.GetFileName(ofd.FileName)
                Using ms = New IO.MemoryStream(selectedFotoBytes)
                    picFoto.Image = Image.FromStream(ms)
                End Using
            End If
        End Using
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

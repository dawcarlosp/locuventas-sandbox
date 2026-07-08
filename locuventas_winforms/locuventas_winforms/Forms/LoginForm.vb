Imports System.Text.Json

Public Class LoginForm
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Text = ""
        btnLogin.Enabled = False
        btnLogin.Text = "Iniciando sesión..."

        Dim email = txtEmail.Text.Trim()
        Dim password = txtPassword.Text

        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            lblError.Text = "Por favor, completa todos los campos."
            btnLogin.Enabled = True
            btnLogin.Text = "Iniciar Sesión"
            Return
        End If

        Try
            Cursor = Cursors.WaitCursor
            Dim userData = Await AuthService.Login(email, password)

            Dim mainForm = New MainForm()
            mainForm.Show()
            Me.Hide()

        Catch ex As ApiException
            Try
                Dim errorObj = JsonSerializer.Deserialize(Of ApiResponse(Of Object))(ex.ResponseContent)
                lblError.Text = If(errorObj?.Message, "Error de conexión con el servidor.")
            Catch
                lblError.Text = "Error de conexión con el servidor."
            End Try
        Catch ex As Exception
            lblError.Text = ex.Message
        Finally
            Cursor = Cursors.Default
            btnLogin.Enabled = True
            btnLogin.Text = "Iniciar Sesión"
        End Try
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Using registerForm = New RegisterForm()
            registerForm.ShowDialog()
        End Using
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

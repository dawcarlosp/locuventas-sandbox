Imports System.Net.Http

Public Class MainForm
    Private currentUserControl As UserControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = TokenManager.Nombre
        lblUserRole.Text = String.Join(", ", TokenManager.Roles)

        If Not String.IsNullOrEmpty(TokenManager.Foto) Then
            Try
                Dim fotoUrl = $"http://localhost:8080/imagenes/{TokenManager.Foto}"
                picProfile.LoadAsync(fotoUrl)
            Catch
            End Try
        End If

        btnAdmin.Visible = TokenManager.IsAdmin
        LoadUserControl(New DashboardControl())
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        MessageBox.Show("Módulo de Productos disponible en próxima actualización.",
                        "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        MessageBox.Show("Módulo de Ventas disponible en próxima actualización.",
                        "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        MessageBox.Show("Módulo de Categorías disponible en próxima actualización.",
                        "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        MessageBox.Show("Módulo de Administración disponible en próxima actualización.",
                        "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        TokenManager.Clear()
        ApiClient.ClearToken()

        Dim loginForm = New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        If Not TokenManager.IsAuthenticated Then
            Application.Exit()
        End If
    End Sub

    Public Sub LoadUserControl(ctrl As UserControl)
        If currentUserControl IsNot Nothing Then
            pnlContent.Controls.Remove(currentUserControl)
            currentUserControl.Dispose()
        End If

        currentUserControl = ctrl
        ctrl.Dock = DockStyle.Fill
        pnlContent.Controls.Add(ctrl)
        pnlContent.Controls.SetChildIndex(ctrl, 0)
    End Sub
End Class

Imports System.Net.Http

Public Class MainForm
    Private currentUserControl As UserControl
    Private activeSidebarButton As Button

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
        StyleBtnDanger(btnLogout)

        LoadUserControl(New DashboardControl())
        SetActiveButton(Nothing)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        LoadUserControl(New ProductosControl())
        SetActiveButton(btnProductos)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        LoadUserControl(New VentasControl())
        SetActiveButton(btnVentas)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        LoadUserControl(New CategoriasControl())
        SetActiveButton(btnCategorias)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        LoadUserControl(New UsuariosControl())
        SetActiveButton(btnAdmin)
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

    Private Sub SetActiveButton(active As Button)
        ' Reset previous active button
        If activeSidebarButton IsNot Nothing Then
            activeSidebarButton.BackColor = Color.Transparent
            activeSidebarButton.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        End If

        ' Set new active button
        activeSidebarButton = active
        If active IsNot Nothing Then
            active.BackColor = DarkBorder
            active.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        End If
    End Sub
End Class

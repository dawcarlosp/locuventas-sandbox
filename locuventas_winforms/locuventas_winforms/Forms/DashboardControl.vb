Public Class DashboardControl
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombre = TokenManager.Nombre
        lblWelcome.Text = $"Bienvenido, {nombre}"

        If TokenManager.IsAdmin Then
            lblRoleInfo.Text = "Has iniciado sesión como Administrador — tienes acceso completo a todos los módulos."
        ElseIf TokenManager.IsVendedor Then
            lblRoleInfo.Text = "Has iniciado sesión como Vendedor — puedes gestionar ventas y ver productos/categorías."
        End If
    End Sub
End Class

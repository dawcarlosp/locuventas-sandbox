Public Class UsuariosControl
    Private currentPage As Integer = 0
    Private totalPages As Integer = 0
    Private totalElements As Long = 0
    Private currentSearch As String = ""

    Private Async Sub UsuariosControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUsuarios()
    End Sub

    Private Async Function LoadUsuarios() As Task
        Try
            Cursor = Cursors.WaitCursor
            Dim result = Await AuthService.GetPendingUsers(currentPage, 10, currentSearch)

            dgvUsuarios.Rows.Clear()

            If result IsNot Nothing AndAlso result.Content IsNot Nothing Then
                totalPages = result.TotalPages
                totalElements = result.TotalElements

                For Each u In result.Content
                    Dim rowIndex = dgvUsuarios.Rows.Add()
                    Dim row = dgvUsuarios.Rows(rowIndex)
                    row.Cells("colUserId").Value = u.Id
                    row.Cells("colUserEmail").Value = u.Email
                    row.Cells("colUserNombre").Value = u.Nombre
                    row.Cells("colUserFecha").Value = u.CreatedAt
                Next
            End If

            UpdatePaginationInfo()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub UpdatePaginationInfo()
        lblPagina.Text = $"Página {currentPage + 1} de {Math.Max(1, totalPages)} ({totalElements} usuarios)"
        btnAnterior.Enabled = currentPage > 0
        btnSiguiente.Enabled = currentPage < totalPages - 1
    End Sub

    Private Async Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            currentSearch = txtSearch.Text.Trim()
            currentPage = 0
            Await LoadUsuarios()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Async Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If currentPage > 0 Then
            currentPage -= 1
            Await LoadUsuarios()
        End If
    End Sub

    Private Async Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If currentPage < totalPages - 1 Then
            currentPage += 1
            Await LoadUsuarios()
        End If
    End Sub

    Private Async Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex < 0 Then Return

        Dim userId = Convert.ToInt64(dgvUsuarios.Rows(e.RowIndex).Cells("colUserId").Value)

        If e.ColumnIndex = dgvUsuarios.Columns("colAccion").Index Then
            Dim result = MessageBox.Show("¿Habilitar este usuario como vendedor?",
                                         "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Await AuthService.AssignVendorRole(userId)
                    MessageBox.Show("Rol VENDEDOR asignado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Await LoadUsuarios()
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cursor = Cursors.Default
                End Try
            End If

        ElseIf e.ColumnIndex = dgvUsuarios.Columns("colEliminar").Index Then
            Dim userName = dgvUsuarios.Rows(e.RowIndex).Cells("colUserNombre").Value.ToString()
            Dim result = MessageBox.Show($"¿Eliminar permanentemente al usuario '{userName}'?",
                                         "Confirmar eliminación",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Await AuthService.DeleteUser(userId)
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Await LoadUsuarios()
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cursor = Cursors.Default
                End Try
            End If
        End If
    End Sub
End Class

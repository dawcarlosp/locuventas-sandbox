Public Class CategoriasControl
    Private Async Sub CategoriasControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCatNueva.Visible = TokenManager.IsAdmin
        btnCatEditar.Visible = TokenManager.IsAdmin
        btnCatEliminar.Visible = TokenManager.IsAdmin
        StyleBtnPrimary(btnCatNueva)
        StyleBtnSecondary(btnCatEditar)
        StyleBtnDanger(btnCatEliminar)
        ApplyDarkTheme(dgvCategorias)
        ApplyDarkTheme(dgvPaises)
        Await LoadCategorias()
        Await LoadPaises()
    End Sub

    Private Async Function LoadCategorias() As Task
        Try
            Cursor = Cursors.WaitCursor
            Dim categorias = Await CategoriaService.GetAll()

            dgvCategorias.Rows.Clear()
            If categorias IsNot Nothing Then
                For Each c In categorias
                    Dim rowIndex = dgvCategorias.Rows.Add()
                    Dim row = dgvCategorias.Rows(rowIndex)
                    row.Cells("colCatId").Value = c.Id
                    row.Cells("colCatNombre").Value = c.Nombre
                Next
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Async Function LoadPaises() As Task
        Try
            Cursor = Cursors.WaitCursor
            Dim paises = Await CategoriaService.GetAllPaises()

            dgvPaises.Rows.Clear()
            If paises IsNot Nothing Then
                For Each p In paises
                    Dim rowIndex = dgvPaises.Rows.Add()
                    Dim row = dgvPaises.Rows(rowIndex)
                    row.Cells("colPaisId").Value = p.Id
                    row.Cells("colPaisCodigo").Value = p.Codigo
                    row.Cells("colPaisNombre").Value = p.Nombre
                Next
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar países: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Async Sub btnCatNueva_Click(sender As Object, e As EventArgs) Handles btnCatNueva.Click
        Dim nombre = InputBox("Nombre de la nueva categoría:", "Nueva Categoría", "")
        If Not String.IsNullOrWhiteSpace(nombre) Then
            Try
                Cursor = Cursors.WaitCursor
                Await CategoriaService.Create(nombre.Trim())
                Await LoadCategorias()
            Catch ex As ApiException
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Async Sub btnCatEditar_Click(sender As Object, e As EventArgs) Handles btnCatEditar.Click
        If dgvCategorias.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una categoría para editar.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim id = Convert.ToInt64(dgvCategorias.SelectedRows(0).Cells("colCatId").Value)
        Dim currentName = dgvCategorias.SelectedRows(0).Cells("colCatNombre").Value.ToString()

        Dim nombre = InputBox("Nuevo nombre de la categoría:", "Editar Categoría", currentName)
        If Not String.IsNullOrWhiteSpace(nombre) AndAlso nombre.Trim() <> currentName Then
            Try
                Cursor = Cursors.WaitCursor
                Await CategoriaService.Update(id, nombre.Trim())
                Await LoadCategorias()
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Async Sub btnCatEliminar_Click(sender As Object, e As EventArgs) Handles btnCatEliminar.Click
        If dgvCategorias.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una categoría para eliminar.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim id = Convert.ToInt64(dgvCategorias.SelectedRows(0).Cells("colCatId").Value)
        Dim name = dgvCategorias.SelectedRows(0).Cells("colCatNombre").Value.ToString()

        Try
            Cursor = Cursors.WaitCursor
            Dim productCount = Await CategoriaService.Delete(id)

            If productCount > 0 Then
                Dim result = MessageBox.Show(
                    $"La categoría '{name}' tiene {productCount} producto(s) asociado(s).{vbCrLf}" &
                    $"¿Deseas eliminar la categoría y TODOS sus productos?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Await CategoriaService.DeleteForce(id)
                    MessageBox.Show("Categoría y productos eliminados correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Await LoadCategorias()
                End If
            Else
                MessageBox.Show("Categoría eliminada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Await LoadCategorias()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class

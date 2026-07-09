Imports System.Net.Http
Imports System.Text.Json

Public Class ProductosControl
    Private currentPage As Integer = 0
    Private totalPages As Integer = 0
    Private totalElements As Long = 0
    Private currentSearch As String = ""
    Private currentPaisId As Long?
    Private currentCategoriaId As Long?
    Private categoriasList As List(Of CategoriaResponse)
    Private paisesList As List(Of PaisResponse)

    Private Async Sub ProductosControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevo.Visible = TokenManager.IsAdmin
        StyleBtnPrimary(btnNuevo)
        StyleBtnOrange(btnSiguiente)
        StyleBtnOrange(btnAnterior)
        StyleInput(txtSearch)
        StyleCombo(cmbPais)
        StyleCombo(cmbCategoria)
        ApplyDarkTheme(dgvProductos)
        Await LoadPaises()
        Await LoadCategorias()
        Await LoadProductos()
    End Sub

    Private Async Function LoadPaises() As Task
        Try
            Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of PaisResponse)))("/paises")
            paisesList = response.Data

            cmbPais.Items.Clear()
            cmbPais.Items.Add("Todos los países")
            For Each p In paisesList
                cmbPais.Items.Add(p.Nombre)
            Next
            cmbPais.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Function

    Private Async Function LoadCategorias() As Task
        Try
            Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of CategoriaResponse)))("/categorias")
            categoriasList = response.Data

            cmbCategoria.Items.Clear()
            cmbCategoria.Items.Add("Todas las categorías")
            For Each c In categoriasList
                cmbCategoria.Items.Add(c.Nombre)
            Next
            cmbCategoria.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Function

    Private Async Function LoadProductos() As Task
        Try
            Cursor = Cursors.WaitCursor

            Dim result = Await ProductoService.GetAll(
                currentPage, 10, currentSearch, currentPaisId, currentCategoriaId)

            dgvProductos.Rows.Clear()

            If result IsNot Nothing AndAlso result.Content IsNot Nothing Then
                totalPages = result.TotalPages
                totalElements = result.TotalElements

                For Each p In result.Content
                    Dim rowIndex = dgvProductos.Rows.Add()
                    Dim row = dgvProductos.Rows(rowIndex)

                    row.Cells("colId").Value = p.Id
                    row.Cells("colNombre").Value = p.Nombre
                    row.Cells("colPrecio").Value = p.Precio
                    row.Cells("colIva").Value = p.Iva
                    row.Cells("colPais").Value = p.PaisNombre
                    row.Cells("colCategorias").Value = String.Join(", ", If(p.Categorias, New List(Of String)()))

                    If Not String.IsNullOrEmpty(p.Foto) Then
                        Try
                            Dim fotoUrl = $"http://localhost:8080/imagenes/{p.Foto}"
                            Dim httpClient = New HttpClient()
                            Dim imageBytes = Await httpClient.GetByteArrayAsync(fotoUrl)
                            Dim ms = New IO.MemoryStream(imageBytes)
                            row.Cells("colFoto").Value = Image.FromStream(ms)
                        Catch
                        End Try
                    End If
                Next
            End If

            UpdatePaginationInfo()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub UpdatePaginationInfo()
        lblPagina.Text = $"Página {currentPage + 1} de {Math.Max(1, totalPages)} ({totalElements} productos)"
        btnAnterior.Enabled = currentPage > 0
        btnSiguiente.Enabled = currentPage < totalPages - 1
    End Sub

    Private Async Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            currentSearch = txtSearch.Text.Trim()
            currentPage = 0
            Await LoadProductos()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Async Sub cmbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPais.SelectedIndexChanged
        If cmbPais.SelectedIndex <= 0 Then
            currentPaisId = Nothing
        Else
            currentPaisId = paisesList(cmbPais.SelectedIndex - 1).Id
        End If
        currentPage = 0
        Await LoadProductos()
    End Sub

    Private Async Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        If cmbCategoria.SelectedIndex <= 0 Then
            currentCategoriaId = Nothing
        Else
            currentCategoriaId = categoriasList(cmbCategoria.SelectedIndex - 1).Id
        End If
        currentPage = 0
        Await LoadProductos()
    End Sub

    Private Async Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If currentPage > 0 Then
            currentPage -= 1
            Await LoadProductos()
        End If
    End Sub

    Private Async Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If currentPage < totalPages - 1 Then
            currentPage += 1
            Await LoadProductos()
        End If
    End Sub

    Private Async Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Using editForm = New ProductoEditForm()
            If editForm.ShowDialog() = DialogResult.OK Then
                currentPage = 0
                Await LoadProductos()
            End If
        End Using
    End Sub

    Private Async Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim productoId = Convert.ToInt64(dgvProductos.Rows(e.RowIndex).Cells("colId").Value)

        Using editForm = New ProductoEditForm(productoId)
            If editForm.ShowDialog() = DialogResult.OK Then
                Await LoadProductos()
            End If
        End Using
    End Sub

    Private Async Sub dgvProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProductos.KeyDown
        If e.KeyCode = Keys.Delete AndAlso TokenManager.IsAdmin Then
            If dgvProductos.SelectedRows.Count = 0 Then Return

            Dim productoId = Convert.ToInt64(dgvProductos.SelectedRows(0).Cells("colId").Value)
            Dim productoName = dgvProductos.SelectedRows(0).Cells("colNombre").Value

            Dim result = MessageBox.Show($"¿Eliminar el producto '{productoName}'?",
                                         "Confirmar eliminación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Await ProductoService.Delete(productoId)
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Await LoadProductos()
                Catch ex As ApiException
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cursor = Cursors.Default
                End Try
            End If
        End If
    End Sub
End Class

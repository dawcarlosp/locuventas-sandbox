Imports System.Text.Json

Public Class VentaCreateForm
    Private productosDisponibles As List(Of ProductoResponse)
    Private lineas As New List(Of LineaVentaData)()

    Private Async Sub VentaCreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadProductos()
    End Sub

    Private Async Function LoadProductos() As Task
        Try
            Cursor = Cursors.WaitCursor

            Dim result = Await ProductoService.GetAll(0, 100, "", Nothing, Nothing)
            productosDisponibles = result.Content

            cmbProducto.Items.Clear()
            If productosDisponibles IsNot Nothing Then
                For Each p In productosDisponibles
                    cmbProducto.Items.Add($"{p.Nombre} ({p.Precio:N2} €)")
                Next
                If cmbProducto.Items.Count > 0 Then
                    cmbProducto.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbProducto.SelectedIndex < 0 Then
            MessageBox.Show("Selecciona un producto.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim producto = productosDisponibles(cmbProducto.SelectedIndex)
        Dim cantidad = CInt(nudCantidad.Value)
        Dim subtotal = producto.Precio * cantidad

        lineas.Add(New LineaVentaData With {
            .ProductoId = producto.Id,
            .Nombre = producto.Nombre,
            .Cantidad = cantidad,
            .Precio = producto.Precio
        })

        RefreshGrid()
        nudCantidad.Value = 1
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvLineas.SelectedRows.Count > 0 Then
            Dim index = dgvLineas.SelectedRows(0).Index
            If index >= 0 AndAlso index < lineas.Count Then
                lineas.RemoveAt(index)
                RefreshGrid()
            End If
        End If
    End Sub

    Private Sub RefreshGrid()
        dgvLineas.Rows.Clear()
        Dim total As Decimal = 0

        For Each l In lineas
            Dim rowIndex = dgvLineas.Rows.Add()
            Dim row = dgvLineas.Rows(rowIndex)
            row.Cells("colProdId").Value = l.ProductoId
            row.Cells("colProdNombre").Value = l.Nombre
            row.Cells("colProdCant").Value = l.Cantidad
            row.Cells("colProdPrecio").Value = l.Precio.ToString("F2")
            Dim subtotal = l.Precio * l.Cantidad
            row.Cells("colProdSubtotal").Value = subtotal.ToString("F2")
            total += subtotal
        Next

        lblTitle.Text = $"Nueva Venta - Total: {total:N2} €"
    End Sub

    Private Async Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If lineas.Count = 0 Then
            MessageBox.Show("Agrega al menos un producto a la venta.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        btnCrear.Enabled = False
        btnCrear.Text = "Creando..."

        Try
            Cursor = Cursors.WaitCursor

            Dim request = New VentaCreateRequest()
            request.Lineas = New List(Of LineaVenta)()

            For Each l In lineas
                request.Lineas.Add(New LineaVenta With {
                    .ProductoId = l.ProductoId,
                    .Cantidad = l.Cantidad
                })
            Next

            Await VentaService.Create(request)
            MessageBox.Show("Venta creada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As ApiException
            Try
                Dim errorObj = JsonSerializer.Deserialize(Of ApiResponse(Of Object))(ex.ResponseContent)
                MessageBox.Show($"Error: {errorObj?.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch
                MessageBox.Show($"Error del servidor: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
            btnCrear.Enabled = True
            btnCrear.Text = "Crear Venta"
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Class LineaVentaData
        Public Property ProductoId As Long
        Public Property Nombre As String
        Public Property Cantidad As Integer
        Public Property Precio As Decimal
    End Class
End Class

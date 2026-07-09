Public Class VentasControl
    Private currentPage As Integer = 0
    Private totalPages As Integer = 0
    Private totalElements As Long = 0
    Private showingPendientes As Boolean = False

    Private Async Sub VentasControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleBtnOrange(btnNuevaVenta)
        StyleBtnSecondary(btnTodas)
        StyleBtnSecondary(btnPendientes)
        StyleBtnOrange(btnSiguiente)
        StyleBtnOrange(btnAnterior)
        ApplyDarkTheme(dgvVentas)
        Await LoadVentas()
    End Sub

    ' Color estado badges in the DataGridView
    Private Sub dgvVentas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvVentas.CellFormatting
        If e.ColumnIndex = dgvVentas.Columns("colEstado").Index AndAlso e.Value IsNot Nothing Then
            Dim estado = e.Value.ToString()
            Select Case estado
                Case "PAGADO"
                    e.CellStyle.ForeColor = Emerald
                Case "PARCIAL"
                    e.CellStyle.ForeColor = Amber
                Case "PENDIENTE"
                    e.CellStyle.ForeColor = Rose
            End Select
            e.CellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        End If
        ' Color saldo column orange
        If e.ColumnIndex = dgvVentas.Columns("colSaldo").Index AndAlso e.Value IsNot Nothing Then
            Dim saldoVal = Convert.ToDecimal(e.Value)
            If saldoVal > 0 Then
                e.CellStyle.ForeColor = Orange
                e.CellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            End If
        End If
        ' Color total column purple
        If e.ColumnIndex = dgvVentas.Columns("colTotal").Index AndAlso e.Value IsNot Nothing Then
            e.CellStyle.ForeColor = OrangeLight
            e.CellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        End If
    End Sub

    Private Async Function LoadVentas() As Task
        Try
            Cursor = Cursors.WaitCursor

            Dim result As PageDTO(Of VentaResponse)

            If showingPendientes Then
                result = Await VentaService.GetPendientes(currentPage, 10)
            Else
                result = Await VentaService.GetAll(currentPage, 10)
            End If

            dgvVentas.Rows.Clear()

            If result IsNot Nothing AndAlso result.Content IsNot Nothing Then
                totalPages = result.TotalPages
                totalElements = result.TotalElements

                For Each v In result.Content
                    Dim rowIndex = dgvVentas.Rows.Add()
                    Dim row = dgvVentas.Rows(rowIndex)

                    row.Cells("colVentaId").Value = v.Id
                    row.Cells("colFecha").Value = v.Fecha
                    row.Cells("colVendedor").Value = v.Vendedor
                    row.Cells("colTotal").Value = v.Total.ToString("F2")
                    row.Cells("colPagado").Value = v.MontoPagado.ToString("F2")
                    row.Cells("colSaldo").Value = v.Saldo.ToString("F2")
                    row.Cells("colEstado").Value = v.EstadoPago
                    row.Cells("colCancelada").Value = v.Cancelada
                Next
            End If

            UpdatePaginationInfo()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar ventas: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub UpdatePaginationInfo()
        lblPagina.Text = $"Página {currentPage + 1} de {Math.Max(1, totalPages)} ({totalElements} ventas)"
        btnAnterior.Enabled = currentPage > 0
        btnSiguiente.Enabled = currentPage < totalPages - 1
    End Sub

    Private Async Sub btnTodas_Click(sender As Object, e As EventArgs) Handles btnTodas.Click
        showingPendientes = False
        currentPage = 0
        Await LoadVentas()
    End Sub

    Private Async Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        showingPendientes = True
        currentPage = 0
        Await LoadVentas()
    End Sub

    Private Async Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If currentPage > 0 Then
            currentPage -= 1
            Await LoadVentas()
        End If
    End Sub

    Private Async Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If currentPage < totalPages - 1 Then
            currentPage += 1
            Await LoadVentas()
        End If
    End Sub

    Private Async Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        Using createForm = New VentaCreateForm()
            If createForm.ShowDialog() = DialogResult.OK Then
                currentPage = 0
                Await LoadVentas()
            End If
        End Using
    End Sub

    Private Async Sub dgvVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim ventaId = Convert.ToInt64(dgvVentas.Rows(e.RowIndex).Cells("colVentaId").Value)

        ' Fetch full detail
        Try
            Cursor = Cursors.WaitCursor
            Dim venta = Await VentaService.GetById(ventaId)

            Using detailForm = New VentaDetailForm(venta)
                detailForm.ShowDialog()
            End Using

            Await LoadVentas()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar detalle de venta: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class

Public Class VentaDetailForm
    Private ventaData As VentaResponse

    Public Sub New(venta As VentaResponse)
        InitializeComponent()
        Me.ventaData = venta
    End Sub

    Private Sub VentaDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleBtnSuccess(btnPago)
        StyleBtnDanger(btnCancelarVenta)
        StyleBtnSecondary(btnCerrar)
        StyleBtnSecondary(btnDescargarPdf)
        ApplyDarkTheme(dgvLineas)

        lblTitle.Text = $"Venta #{ventaData.Id}"
        lblVendedorVal.Text = ventaData.Vendedor
        lblFechaVal.Text = ventaData.Fecha
        lblEstadoVal.Text = If(ventaData.Cancelada, "CANCELADA", ventaData.EstadoPago)

        ' Color estado
        If ventaData.Cancelada Then
            lblEstadoVal.ForeColor = Rose
        Else
            Select Case ventaData.EstadoPago
                Case "PAGADO"
                    lblEstadoVal.ForeColor = Emerald
                Case "PARCIAL"
                    lblEstadoVal.ForeColor = Amber
                Case "PENDIENTE"
                    lblEstadoVal.ForeColor = Rose
                Case Else
                    lblEstadoVal.ForeColor = TextSecondary
            End Select
        End If

        lblTotalVal.Text = $"{ventaData.Total:N2} €"
        lblPagadoVal.Text = $"{ventaData.MontoPagado:N2} €"
        lblSaldoVal.Text = $"{ventaData.Saldo:N2} €"

        btnCancelarVenta.Visible = TokenManager.IsAdmin AndAlso Not ventaData.Cancelada
        btnPago.Enabled = Not ventaData.Cancelada

        For Each linea In ventaData.Lineas
            Dim rowIndex = dgvLineas.Rows.Add()
            Dim row = dgvLineas.Rows(rowIndex)
            row.Cells("colProducto").Value = linea.ProductoNombre
            row.Cells("colCantidad").Value = linea.Cantidad
            row.Cells("colSubtotal").Value = linea.Subtotal.ToString("F2")
            row.Cells("colIva").Value = $"{linea.Iva}%"
            row.Cells("colTotalLinea").Value = linea.SubtotalConIva.ToString("F2")
        Next
    End Sub

    Private Async Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Using pagoForm = New PagoForm(ventaData.Id, ventaData.Saldo)
            If pagoForm.ShowDialog() = DialogResult.OK Then
                Try
                    Cursor = Cursors.WaitCursor
                    ventaData = Await VentaService.GetById(ventaData.Id)
                    lblPagadoVal.Text = $"{ventaData.MontoPagado:N2} €"
                    lblSaldoVal.Text = $"{ventaData.Saldo:N2} €"
                    lblEstadoVal.Text = ventaData.EstadoPago
                    btnPago.Enabled = Not ventaData.Cancelada AndAlso ventaData.Saldo > 0
                Catch ex As Exception
                    MessageBox.Show($"Error al actualizar: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cursor = Cursors.Default
                End Try
            End If
        End Using
    End Sub

    Private Async Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        Dim result = MessageBox.Show($"¿Cancelar la venta #{ventaData.Id}? Esta acción no se puede deshacer.",
                                     "Confirmar cancelación",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Cursor = Cursors.WaitCursor
                Await VentaService.Cancel(ventaData.Id)
                MessageBox.Show("Venta cancelada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                ventaData = Await VentaService.GetById(ventaData.Id)
                lblEstadoVal.Text = "CANCELADA"
                lblEstadoVal.ForeColor = Color.Red
                btnCancelarVenta.Visible = False
                btnPago.Enabled = False
            Catch ex As Exception
                MessageBox.Show($"Error al cancelar: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Async Sub btnDescargarPdf_Click(sender As Object, e As EventArgs) Handles btnDescargarPdf.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim pdfBytes = Await VentaService.DownloadPdf(ventaData.Id)

            Using sfd = New SaveFileDialog()
                sfd.FileName = $"ticket-venta-{ventaData.Id}.pdf"
                sfd.Filter = "PDF Files|*.pdf"
                If sfd.ShowDialog() = DialogResult.OK Then
                    IO.File.WriteAllBytes(sfd.FileName, pdfBytes)
                    MessageBox.Show("Ticket PDF descargado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al descargar PDF: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

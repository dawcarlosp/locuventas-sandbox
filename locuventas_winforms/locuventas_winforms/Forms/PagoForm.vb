Public Class PagoForm
    Private ventaId As Long
    Private saldoPendiente As Decimal

    Public Sub New(ventaId As Long, saldo As Decimal)
        InitializeComponent()
        Me.ventaId = ventaId
        Me.saldoPendiente = saldo
        Me.lblSaldoVal.Text = $"{saldo:N2} €"
        Me.txtMonto.Text = saldo.ToString("F2")
    End Sub

    Private Async Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim monto As Decimal
        If Not Decimal.TryParse(txtMonto.Text.Trim(), monto) OrElse monto <= 0 Then
            MessageBox.Show("Introduce un monto válido mayor que 0.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If monto > saldoPendiente Then
            Dim result = MessageBox.Show($"El monto ({monto:N2} €) supera el saldo pendiente ({saldoPendiente:N2} €). " &
                                         "¿Deseas registrar el pago de todas formas?",
                                         "Monto superior al saldo",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result <> DialogResult.Yes Then Return
        End If

        btnRegistrar.Enabled = False
        btnRegistrar.Text = "Registrando..."

        Try
            Cursor = Cursors.WaitCursor
            Await VentaService.AddPayment(ventaId, monto)
            MessageBox.Show("Pago registrado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error al registrar pago: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
            btnRegistrar.Enabled = True
            btnRegistrar.Text = "Registrar"
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

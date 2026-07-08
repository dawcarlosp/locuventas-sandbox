<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagoForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblSaldoPendiente = New System.Windows.Forms.Label()
        Me.lblSaldoVal = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(161, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Registrar Pago"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(25, 80)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(73, 13)
        Me.lblMonto.TabIndex = 1
        Me.lblMonto.Text = "Monto a pagar"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(25, 100)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(150, 22)
        Me.txtMonto.TabIndex = 2
        '
        'lblSaldoPendiente
        '
        Me.lblSaldoPendiente.AutoSize = True
        Me.lblSaldoPendiente.Location = New System.Drawing.Point(25, 140)
        Me.lblSaldoPendiente.Name = "lblSaldoPendiente"
        Me.lblSaldoPendiente.Size = New System.Drawing.Size(85, 13)
        Me.lblSaldoPendiente.TabIndex = 3
        Me.lblSaldoPendiente.Text = "Saldo pendiente:"
        '
        'lblSaldoVal
        '
        Me.lblSaldoVal.AutoSize = True
        Me.lblSaldoVal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldoVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblSaldoVal.Location = New System.Drawing.Point(120, 138)
        Me.lblSaldoVal.Name = "lblSaldoVal"
        Me.lblSaldoVal.Size = New System.Drawing.Size(45, 19)
        Me.lblSaldoVal.TabIndex = 4
        Me.lblSaldoVal.Text = "0,00 €"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(25, 180)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 35)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(145, 180)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PagoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 241)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblSaldoVal)
        Me.Controls.Add(Me.lblSaldoPendiente)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PagoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrar Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblMonto As Label
    Private WithEvents txtMonto As TextBox
    Private WithEvents lblSaldoPendiente As Label
    Private WithEvents lblSaldoVal As Label
    Private WithEvents btnRegistrar As Button
    Private WithEvents btnCancelar As Button
End Class

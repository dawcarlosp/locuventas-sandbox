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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = TextWhite
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(172, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Registrar Pago"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonto.ForeColor = TextSecondary
        Me.lblMonto.Location = New System.Drawing.Point(25, 75)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(89, 15)
        Me.lblMonto.TabIndex = 1
        Me.lblMonto.Text = "Monto a pagar"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtMonto.Location = New System.Drawing.Point(25, 95)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(220, 32)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSaldoPendiente
        '
        Me.lblSaldoPendiente.AutoSize = True
        Me.lblSaldoPendiente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSaldoPendiente.ForeColor = TextMuted
        Me.lblSaldoPendiente.Location = New System.Drawing.Point(25, 145)
        Me.lblSaldoPendiente.Name = "lblSaldoPendiente"
        Me.lblSaldoPendiente.Size = New System.Drawing.Size(93, 15)
        Me.lblSaldoPendiente.TabIndex = 3
        Me.lblSaldoPendiente.Text = "Saldo pendiente:"
        '
        'lblSaldoVal
        '
        Me.lblSaldoVal.AutoSize = True
        Me.lblSaldoVal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldoVal.ForeColor = Orange
        Me.lblSaldoVal.Location = New System.Drawing.Point(120, 142)
        Me.lblSaldoVal.Name = "lblSaldoVal"
        Me.lblSaldoVal.Size = New System.Drawing.Size(64, 21)
        Me.lblSaldoVal.TabIndex = 4
        Me.lblSaldoVal.Text = "0,00 €"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87)
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105)
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(25, 185)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 38)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 1
        Me.btnCancelar.FlatAppearance.BorderColor = DarkBorder
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 91)
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = DarkBorder
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelar.ForeColor = TextWhite
        Me.btnCancelar.Location = New System.Drawing.Point(145, 185)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 38)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'PagoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
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

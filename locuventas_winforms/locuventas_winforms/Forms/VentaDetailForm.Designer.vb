<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaDetailForm
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
        Me.lblVendedorVal = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblFechaVal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblEstadoVal = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPagadoVal = New System.Windows.Forms.Label()
        Me.lblPagado = New System.Windows.Forms.Label()
        Me.lblSaldoVal = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.colProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnDescargarPdf = New System.Windows.Forms.Button()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Detalle Venta"
        '
        'lblVendedorVal
        '
        Me.lblVendedorVal.AutoSize = True
        Me.lblVendedorVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblVendedorVal.Location = New System.Drawing.Point(120, 60)
        Me.lblVendedorVal.Name = "lblVendedorVal"
        Me.lblVendedorVal.Size = New System.Drawing.Size(63, 19)
        Me.lblVendedorVal.TabIndex = 3
        Me.lblVendedorVal.Text = "Vendedor"
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblVendedor.Location = New System.Drawing.Point(20, 60)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(74, 19)
        Me.lblVendedor.TabIndex = 2
        Me.lblVendedor.Text = "Vendedor:"
        '
        'lblFechaVal
        '
        Me.lblFechaVal.AutoSize = True
        Me.lblFechaVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFechaVal.Location = New System.Drawing.Point(120, 90)
        Me.lblFechaVal.Name = "lblFechaVal"
        Me.lblFechaVal.Size = New System.Drawing.Size(42, 19)
        Me.lblFechaVal.TabIndex = 5
        Me.lblFechaVal.Text = "Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.Location = New System.Drawing.Point(20, 90)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 19)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha:"
        '
        'lblEstadoVal
        '
        Me.lblEstadoVal.AutoSize = True
        Me.lblEstadoVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEstadoVal.Location = New System.Drawing.Point(120, 120)
        Me.lblEstadoVal.Name = "lblEstadoVal"
        Me.lblEstadoVal.Size = New System.Drawing.Size(48, 19)
        Me.lblEstadoVal.TabIndex = 7
        Me.lblEstadoVal.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Location = New System.Drawing.Point(20, 120)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(54, 19)
        Me.lblEstado.TabIndex = 6
        Me.lblEstado.Text = "Estado:"
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTotalVal.Location = New System.Drawing.Point(400, 60)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(36, 19)
        Me.lblTotalVal.TabIndex = 9
        Me.lblTotalVal.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(340, 60)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 19)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total:"
        '
        'lblPagadoVal
        '
        Me.lblPagadoVal.AutoSize = True
        Me.lblPagadoVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPagadoVal.Location = New System.Drawing.Point(400, 90)
        Me.lblPagadoVal.Name = "lblPagadoVal"
        Me.lblPagadoVal.Size = New System.Drawing.Size(53, 19)
        Me.lblPagadoVal.TabIndex = 11
        Me.lblPagadoVal.Text = "Pagado"
        '
        'lblPagado
        '
        Me.lblPagado.AutoSize = True
        Me.lblPagado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPagado.Location = New System.Drawing.Point(340, 90)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(60, 19)
        Me.lblPagado.TabIndex = 10
        Me.lblPagado.Text = "Pagado:"
        '
        'lblSaldoVal
        '
        Me.lblSaldoVal.AutoSize = True
        Me.lblSaldoVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSaldoVal.Location = New System.Drawing.Point(400, 120)
        Me.lblSaldoVal.Name = "lblSaldoVal"
        Me.lblSaldoVal.Size = New System.Drawing.Size(41, 19)
        Me.lblSaldoVal.TabIndex = 13
        Me.lblSaldoVal.Text = "Saldo"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo.Location = New System.Drawing.Point(340, 120)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(47, 19)
        Me.lblSaldo.TabIndex = 12
        Me.lblSaldo.Text = "Saldo:"
        '
        'dgvLineas
        '
        Me.dgvLineas.AllowUserToAddRows = False
        Me.dgvLineas.AllowUserToDeleteRows = False
        Me.dgvLineas.BackgroundColor = System.Drawing.Color.White
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProducto, Me.colCantidad, Me.colSubtotal, Me.colIva, Me.colTotalLinea})
        Me.dgvLineas.Location = New System.Drawing.Point(20, 160)
        Me.dgvLineas.MultiSelect = False
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.ReadOnly = True
        Me.dgvLineas.RowHeadersVisible = False
        Me.dgvLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineas.Size = New System.Drawing.Size(560, 200)
        Me.dgvLineas.TabIndex = 14
        '
        'colProducto
        '
        Me.colProducto.HeaderText = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Width = 200
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cant."
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Width = 50
        '
        'colSubtotal
        '
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        '
        'colIva
        '
        Me.colIva.HeaderText = "IVA %"
        Me.colIva.Name = "colIva"
        Me.colIva.Width = 60
        '
        'colTotalLinea
        '
        Me.colTotalLinea.HeaderText = "Total"
        Me.colTotalLinea.Name = "colTotalLinea"
        '
        'btnPago
        '
        Me.btnPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPago.ForeColor = System.Drawing.Color.White
        Me.btnPago.Location = New System.Drawing.Point(20, 380)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(120, 35)
        Me.btnPago.TabIndex = 15
        Me.btnPago.Text = "Registrar Pago"
        Me.btnPago.UseVisualStyleBackColor = False
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenta.ForeColor = System.Drawing.Color.White
        Me.btnCancelarVenta.Location = New System.Drawing.Point(160, 380)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(120, 35)
        Me.btnCancelarVenta.TabIndex = 16
        Me.btnCancelarVenta.Text = "Cancelar Venta"
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(500, 380)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 35)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnDescargarPdf
        '
        Me.btnDescargarPdf.Location = New System.Drawing.Point(300, 380)
        Me.btnDescargarPdf.Name = "btnDescargarPdf"
        Me.btnDescargarPdf.Size = New System.Drawing.Size(180, 35)
        Me.btnDescargarPdf.TabIndex = 18
        Me.btnDescargarPdf.Text = "Descargar Ticket PDF"
        Me.btnDescargarPdf.UseVisualStyleBackColor = True
        '
        'VentaDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 441)
        Me.Controls.Add(Me.btnDescargarPdf)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCancelarVenta)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.dgvLineas)
        Me.Controls.Add(Me.lblSaldoVal)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblPagadoVal)
        Me.Controls.Add(Me.lblPagado)
        Me.Controls.Add(Me.lblTotalVal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblEstadoVal)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblFechaVal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblVendedorVal)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de Venta"
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblVendedorVal As Label
    Private WithEvents lblVendedor As Label
    Private WithEvents lblFechaVal As Label
    Private WithEvents lblFecha As Label
    Private WithEvents lblEstadoVal As Label
    Private WithEvents lblEstado As Label
    Private WithEvents lblTotalVal As Label
    Private WithEvents lblTotal As Label
    Private WithEvents lblPagadoVal As Label
    Private WithEvents lblPagado As Label
    Private WithEvents lblSaldoVal As Label
    Private WithEvents lblSaldo As Label
    Private WithEvents dgvLineas As DataGridView
    Private WithEvents colProducto As DataGridViewTextBoxColumn
    Private WithEvents colCantidad As DataGridViewTextBoxColumn
    Private WithEvents colSubtotal As DataGridViewTextBoxColumn
    Private WithEvents colIva As DataGridViewTextBoxColumn
    Private WithEvents colTotalLinea As DataGridViewTextBoxColumn
    Private WithEvents btnPago As Button
    Private WithEvents btnCancelarVenta As Button
    Private WithEvents btnCerrar As Button
    Private WithEvents btnDescargarPdf As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentasControl
    Inherits System.Windows.Forms.UserControl

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
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.btnTodas = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.colVentaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCancelada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pnlPaginacion = New System.Windows.Forms.Panel()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlToolbar.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPaginacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnNuevaVenta)
        Me.pnlToolbar.Controls.Add(Me.btnPendientes)
        Me.pnlToolbar.Controls.Add(Me.btnTodas)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(900, 50)
        Me.pnlToolbar.TabIndex = 0
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaVenta.Location = New System.Drawing.Point(780, 10)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(110, 30)
        Me.btnNuevaVenta.TabIndex = 2
        Me.btnNuevaVenta.Text = "Nueva Venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'btnPendientes
        '
        Me.btnPendientes.Location = New System.Drawing.Point(100, 10)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(80, 30)
        Me.btnPendientes.TabIndex = 1
        Me.btnPendientes.Text = "Pendientes"
        Me.btnPendientes.UseVisualStyleBackColor = True
        '
        'btnTodas
        '
        Me.btnTodas.Location = New System.Drawing.Point(10, 10)
        Me.btnTodas.Name = "btnTodas"
        Me.btnTodas.Size = New System.Drawing.Size(80, 30)
        Me.btnTodas.TabIndex = 0
        Me.btnTodas.Text = "Todas"
        Me.btnTodas.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colVentaId, Me.colFecha, Me.colVendedor, Me.colTotal, Me.colPagado, Me.colSaldo, Me.colEstado, Me.colCancelada})
        Me.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.Location = New System.Drawing.Point(0, 50)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(900, 350)
        Me.dgvVentas.TabIndex = 1
        '
        'colVentaId
        '
        Me.colVentaId.HeaderText = "ID"
        Me.colVentaId.Name = "colVentaId"
        Me.colVentaId.Width = 40
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Width = 150
        '
        'colVendedor
        '
        Me.colVendedor.HeaderText = "Vendedor"
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.Width = 150
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        '
        'colPagado
        '
        Me.colPagado.HeaderText = "Pagado"
        Me.colPagado.Name = "colPagado"
        '
        'colSaldo
        '
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Width = 100
        '
        'colCancelada
        '
        Me.colCancelada.HeaderText = "Cancelada"
        Me.colCancelada.Name = "colCancelada"
        Me.colCancelada.Width = 60
        '
        'pnlPaginacion
        '
        Me.pnlPaginacion.BackColor = System.Drawing.Color.White
        Me.pnlPaginacion.Controls.Add(Me.lblPagina)
        Me.pnlPaginacion.Controls.Add(Me.btnSiguiente)
        Me.pnlPaginacion.Controls.Add(Me.btnAnterior)
        Me.pnlPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPaginacion.Location = New System.Drawing.Point(0, 400)
        Me.pnlPaginacion.Name = "pnlPaginacion"
        Me.pnlPaginacion.Size = New System.Drawing.Size(900, 40)
        Me.pnlPaginacion.TabIndex = 2
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Location = New System.Drawing.Point(420, 12)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(60, 13)
        Me.lblPagina.TabIndex = 2
        Me.lblPagina.Text = "Página 0 de 0"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(520, 7)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(80, 25)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente >"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(300, 7)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(80, 25)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.Text = "< Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'VentasControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.pnlPaginacion)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Name = "VentasControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.pnlToolbar.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPaginacion.ResumeLayout(False)
        Me.pnlPaginacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlToolbar As Panel
    Private WithEvents btnNuevaVenta As Button
    Private WithEvents btnPendientes As Button
    Private WithEvents btnTodas As Button
    Private WithEvents dgvVentas As DataGridView
    Private WithEvents colVentaId As DataGridViewTextBoxColumn
    Private WithEvents colFecha As DataGridViewTextBoxColumn
    Private WithEvents colVendedor As DataGridViewTextBoxColumn
    Private WithEvents colTotal As DataGridViewTextBoxColumn
    Private WithEvents colPagado As DataGridViewTextBoxColumn
    Private WithEvents colSaldo As DataGridViewTextBoxColumn
    Private WithEvents colEstado As DataGridViewTextBoxColumn
    Private WithEvents colCancelada As DataGridViewCheckBoxColumn
    Private WithEvents pnlPaginacion As Panel
    Private WithEvents lblPagina As Label
    Private WithEvents btnSiguiente As Button
    Private WithEvents btnAnterior As Button
End Class

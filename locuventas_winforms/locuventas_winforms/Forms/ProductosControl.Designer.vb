<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductosControl
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
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategorias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlPaginacion = New System.Windows.Forms.Panel()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlToolbar.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPaginacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnNuevo)
        Me.pnlToolbar.Controls.Add(Me.cmbCategoria)
        Me.pnlToolbar.Controls.Add(Me.cmbPais)
        Me.pnlToolbar.Controls.Add(Me.txtSearch)
        Me.pnlToolbar.Controls.Add(Me.lblSearch)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(900, 50)
        Me.pnlToolbar.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(790, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(470, 14)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(140, 21)
        Me.cmbCategoria.TabIndex = 3
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(320, 14)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(140, 21)
        Me.cmbPais.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(55, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(10, 17)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(40, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Buscar"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colFoto, Me.colNombre, Me.colPrecio, Me.colIva, Me.colPais, Me.colCategorias})
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Location = New System.Drawing.Point(0, 50)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(900, 350)
        Me.dgvProductos.TabIndex = 1
        '
        'colId
        '
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.Width = 40
        '
        'colFoto
        '
        Me.colFoto.HeaderText = "Foto"
        Me.colFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colFoto.Name = "colFoto"
        Me.colFoto.Width = 80
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 200
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        '
        'colIva
        '
        Me.colIva.HeaderText = "IVA %"
        Me.colIva.Name = "colIva"
        Me.colIva.Width = 60
        '
        'colPais
        '
        Me.colPais.HeaderText = "País"
        Me.colPais.Name = "colPais"
        Me.colPais.Width = 120
        '
        'colCategorias
        '
        Me.colCategorias.HeaderText = "Categorías"
        Me.colCategorias.Name = "colCategorias"
        Me.colCategorias.Width = 200
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
        'ProductosControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.pnlPaginacion)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Name = "ProductosControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPaginacion.ResumeLayout(False)
        Me.pnlPaginacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlToolbar As Panel
    Private WithEvents btnNuevo As Button
    Private WithEvents cmbCategoria As ComboBox
    Private WithEvents cmbPais As ComboBox
    Private WithEvents txtSearch As TextBox
    Private WithEvents lblSearch As Label
    Private WithEvents dgvProductos As DataGridView
    Private WithEvents colId As DataGridViewTextBoxColumn
    Private WithEvents colFoto As DataGridViewImageColumn
    Private WithEvents colNombre As DataGridViewTextBoxColumn
    Private WithEvents colPrecio As DataGridViewTextBoxColumn
    Private WithEvents colIva As DataGridViewTextBoxColumn
    Private WithEvents colPais As DataGridViewTextBoxColumn
    Private WithEvents colCategorias As DataGridViewTextBoxColumn
    Private WithEvents pnlPaginacion As Panel
    Private WithEvents lblPagina As Label
    Private WithEvents btnSiguiente As Button
    Private WithEvents btnAnterior As Button
End Class

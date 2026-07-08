<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaCreateForm
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
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.colProdId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdCant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(128, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Nueva Venta"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(25, 80)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(300, 21)
        Me.cmbProducto.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(25, 60)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 2
        Me.lblProducto.Text = "Producto"
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(340, 80)
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(60, 22)
        Me.nudCantidad.TabIndex = 3
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(340, 60)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(420, 78)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvLineas
        '
        Me.dgvLineas.AllowUserToAddRows = False
        Me.dgvLineas.AllowUserToDeleteRows = False
        Me.dgvLineas.BackgroundColor = System.Drawing.Color.White
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProdId, Me.colProdNombre, Me.colProdCant, Me.colProdPrecio, Me.colProdSubtotal})
        Me.dgvLineas.Location = New System.Drawing.Point(25, 120)
        Me.dgvLineas.MultiSelect = False
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.ReadOnly = True
        Me.dgvLineas.RowHeadersVisible = False
        Me.dgvLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineas.Size = New System.Drawing.Size(475, 200)
        Me.dgvLineas.TabIndex = 6
        '
        'colProdId
        '
        Me.colProdId.HeaderText = "ID"
        Me.colProdId.Name = "colProdId"
        Me.colProdId.Width = 40
        '
        'colProdNombre
        '
        Me.colProdNombre.HeaderText = "Producto"
        Me.colProdNombre.Name = "colProdNombre"
        Me.colProdNombre.Width = 200
        '
        'colProdCant
        '
        Me.colProdCant.HeaderText = "Cant."
        Me.colProdCant.Name = "colProdCant"
        Me.colProdCant.Width = 50
        '
        'colProdPrecio
        '
        Me.colProdPrecio.HeaderText = "Precio"
        Me.colProdPrecio.Name = "colProdPrecio"
        '
        'colProdSubtotal
        '
        Me.colProdSubtotal.HeaderText = "Subtotal"
        Me.colProdSubtotal.Name = "colProdSubtotal"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(25, 330)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 30)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(280, 330)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(100, 30)
        Me.btnCrear.TabIndex = 8
        Me.btnCrear.Text = "Crear Venta"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(400, 330)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'VentaCreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 381)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.dgvLineas)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaCreateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva Venta"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents cmbProducto As ComboBox
    Private WithEvents lblProducto As Label
    Private WithEvents nudCantidad As NumericUpDown
    Private WithEvents lblCantidad As Label
    Private WithEvents btnAgregar As Button
    Private WithEvents dgvLineas As DataGridView
    Private WithEvents btnQuitar As Button
    Private WithEvents btnCrear As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents colProdId As DataGridViewTextBoxColumn
    Private WithEvents colProdNombre As DataGridViewTextBoxColumn
    Private WithEvents colProdCant As DataGridViewTextBoxColumn
    Private WithEvents colProdPrecio As DataGridViewTextBoxColumn
    Private WithEvents colProdSubtotal As DataGridViewTextBoxColumn
End Class

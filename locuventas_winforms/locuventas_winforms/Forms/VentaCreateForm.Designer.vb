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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = TextWhite
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(147, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Nueva Venta"
        '
        'cmbProducto
        '
        Me.cmbProducto.BackColor = DarkBg2
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbProducto.ForeColor = TextWhite
        Me.cmbProducto.Location = New System.Drawing.Point(25, 80)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(300, 23)
        Me.cmbProducto.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.ForeColor = TextSecondary
        Me.lblProducto.Location = New System.Drawing.Point(25, 60)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(56, 13)
        Me.lblProducto.TabIndex = 2
        Me.lblProducto.Text = "Producto"
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = DarkBg2
        Me.nudCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudCantidad.ForeColor = TextWhite
        Me.nudCantidad.Location = New System.Drawing.Point(340, 80)
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(60, 23)
        Me.nudCantidad.TabIndex = 3
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = TextSecondary
        Me.lblCantidad.Location = New System.Drawing.Point(340, 60)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(53, 13)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 91)
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = DarkBorder
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = Purple
        Me.btnAgregar.Location = New System.Drawing.Point(420, 78)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "+ Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvLineas
        '
        Me.dgvLineas.AllowUserToAddRows = False
        Me.dgvLineas.AllowUserToDeleteRows = False
        Me.dgvLineas.BackgroundColor = DarkBg2
        Me.dgvLineas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProdId, Me.colProdNombre, Me.colProdCant, Me.colProdPrecio, Me.colProdSubtotal})
        Me.dgvLineas.GridColor = DarkBorder
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
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 91)
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = DarkBorder
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnQuitar.ForeColor = Rose
        Me.btnQuitar.Location = New System.Drawing.Point(25, 330)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 30)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 65, 12)
        Me.btnCrear.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 88, 12)
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(270, 330)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(120, 30)
        Me.btnCrear.TabIndex = 8
        Me.btnCrear.Text = "Crear Venta"
        Me.btnCrear.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(400, 330)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'VentaCreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
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

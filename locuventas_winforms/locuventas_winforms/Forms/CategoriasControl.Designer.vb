<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoriasControl
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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabCategorias = New System.Windows.Forms.TabPage()
        Me.pnlCatToolbar = New System.Windows.Forms.Panel()
        Me.btnCatNueva = New System.Windows.Forms.Button()
        Me.btnCatEditar = New System.Windows.Forms.Button()
        Me.btnCatEliminar = New System.Windows.Forms.Button()
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        Me.colCatId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPaises = New System.Windows.Forms.TabPage()
        Me.dgvPaises = New System.Windows.Forms.DataGridView()
        Me.colPaisId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaisCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaisNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabMain.SuspendLayout()
        Me.tabCategorias.SuspendLayout()
        Me.pnlCatToolbar.SuspendLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaises.SuspendLayout()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMain.Controls.Add(Me.tabCategorias)
        Me.tabMain.Controls.Add(Me.tabPaises)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(900, 440)
        Me.tabMain.TabIndex = 0
        '
        'tabCategorias
        '
        Me.tabCategorias.Controls.Add(Me.dgvCategorias)
        Me.tabCategorias.Controls.Add(Me.pnlCatToolbar)
        Me.tabCategorias.Location = New System.Drawing.Point(4, 22)
        Me.tabCategorias.Name = "tabCategorias"
        Me.tabCategorias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCategorias.Size = New System.Drawing.Size(892, 414)
        Me.tabCategorias.TabIndex = 0
        Me.tabCategorias.Text = "Categorías"
        '
        'pnlCatToolbar
        '
        Me.pnlCatToolbar.BackColor = DarkBg2
        Me.pnlCatToolbar.Controls.Add(Me.btnCatNueva)
        Me.pnlCatToolbar.Controls.Add(Me.btnCatEditar)
        Me.pnlCatToolbar.Controls.Add(Me.btnCatEliminar)
        Me.pnlCatToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCatToolbar.Location = New System.Drawing.Point(3, 3)
        Me.pnlCatToolbar.Name = "pnlCatToolbar"
        Me.pnlCatToolbar.Size = New System.Drawing.Size(886, 45)
        Me.pnlCatToolbar.TabIndex = 0
        '
        'btnCatNueva
        '
        Me.btnCatNueva.FlatAppearance.BorderSize = 0
        Me.btnCatNueva.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 34, 206)
        Me.btnCatNueva.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 51, 234)
        Me.btnCatNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatNueva.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatNueva.ForeColor = System.Drawing.Color.White
        Me.btnCatNueva.Location = New System.Drawing.Point(10, 8)
        Me.btnCatNueva.Name = "btnCatNueva"
        Me.btnCatNueva.Size = New System.Drawing.Size(90, 30)
        Me.btnCatNueva.TabIndex = 0
        Me.btnCatNueva.Text = "Nueva"
        Me.btnCatNueva.UseVisualStyleBackColor = False
        '
        'btnCatEditar
        '
        Me.btnCatEditar.FlatAppearance.BorderSize = 1
        Me.btnCatEditar.FlatAppearance.BorderColor = DarkBorder
        Me.btnCatEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 91)
        Me.btnCatEditar.FlatAppearance.MouseOverBackColor = DarkBorder
        Me.btnCatEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCatEditar.ForeColor = TextWhite
        Me.btnCatEditar.Location = New System.Drawing.Point(110, 8)
        Me.btnCatEditar.Name = "btnCatEditar"
        Me.btnCatEditar.Size = New System.Drawing.Size(90, 30)
        Me.btnCatEditar.TabIndex = 1
        Me.btnCatEditar.Text = "Editar"
        Me.btnCatEditar.UseVisualStyleBackColor = False
        '
        'btnCatEliminar
        '
        Me.btnCatEliminar.BackColor = Rose
        Me.btnCatEliminar.FlatAppearance.BorderSize = 0
        Me.btnCatEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 18, 60)
        Me.btnCatEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 29, 72)
        Me.btnCatEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatEliminar.ForeColor = System.Drawing.Color.White
        Me.btnCatEliminar.Location = New System.Drawing.Point(210, 8)
        Me.btnCatEliminar.Name = "btnCatEliminar"
        Me.btnCatEliminar.Size = New System.Drawing.Size(90, 30)
        Me.btnCatEliminar.TabIndex = 2
        Me.btnCatEliminar.Text = "Eliminar"
        Me.btnCatEliminar.UseVisualStyleBackColor = False
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.BackgroundColor = DarkBg2
        Me.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCatId, Me.colCatNombre})
        Me.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCategorias.GridColor = DarkBorder
        Me.dgvCategorias.Location = New System.Drawing.Point(3, 48)
        Me.dgvCategorias.MultiSelect = False
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.RowHeadersVisible = False
        Me.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategorias.Size = New System.Drawing.Size(886, 363)
        Me.dgvCategorias.TabIndex = 1
        '
        'colCatId
        '
        Me.colCatId.HeaderText = "ID"
        Me.colCatId.Name = "colCatId"
        Me.colCatId.Width = 50
        '
        'colCatNombre
        '
        Me.colCatNombre.HeaderText = "Nombre"
        Me.colCatNombre.Name = "colCatNombre"
        Me.colCatNombre.Width = 500
        '
        'tabPaises
        '
        Me.tabPaises.Controls.Add(Me.dgvPaises)
        Me.tabPaises.Location = New System.Drawing.Point(4, 22)
        Me.tabPaises.Name = "tabPaises"
        Me.tabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPaises.Size = New System.Drawing.Size(892, 414)
        Me.tabPaises.TabIndex = 1
        Me.tabPaises.Text = "Países"
        '
        'dgvPaises
        '
        Me.dgvPaises.AllowUserToAddRows = False
        Me.dgvPaises.AllowUserToDeleteRows = False
        Me.dgvPaises.BackgroundColor = DarkBg2
        Me.dgvPaises.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaises.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPaisId, Me.colPaisCodigo, Me.colPaisNombre})
        Me.dgvPaises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaises.GridColor = DarkBorder
        Me.dgvPaises.Location = New System.Drawing.Point(3, 3)
        Me.dgvPaises.MultiSelect = False
        Me.dgvPaises.Name = "dgvPaises"
        Me.dgvPaises.ReadOnly = True
        Me.dgvPaises.RowHeadersVisible = False
        Me.dgvPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaises.Size = New System.Drawing.Size(886, 408)
        Me.dgvPaises.TabIndex = 0
        '
        'colPaisId
        '
        Me.colPaisId.HeaderText = "ID"
        Me.colPaisId.Name = "colPaisId"
        Me.colPaisId.Width = 50
        '
        'colPaisCodigo
        '
        Me.colPaisCodigo.HeaderText = "Código"
        Me.colPaisCodigo.Name = "colPaisCodigo"
        Me.colPaisCodigo.Width = 80
        '
        'colPaisNombre
        '
        Me.colPaisNombre.HeaderText = "Nombre"
        Me.colPaisNombre.Name = "colPaisNombre"
        Me.colPaisNombre.Width = 500
        '
        'CategoriasControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabMain)
        Me.Name = "CategoriasControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.tabMain.ResumeLayout(False)
        Me.tabCategorias.ResumeLayout(False)
        Me.pnlCatToolbar.ResumeLayout(False)
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaises.ResumeLayout(False)
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabMain As TabControl
    Private WithEvents tabCategorias As TabPage
    Private WithEvents pnlCatToolbar As Panel
    Private WithEvents btnCatNueva As Button
    Private WithEvents btnCatEditar As Button
    Private WithEvents btnCatEliminar As Button
    Private WithEvents dgvCategorias As DataGridView
    Private WithEvents colCatId As DataGridViewTextBoxColumn
    Private WithEvents colCatNombre As DataGridViewTextBoxColumn
    Private WithEvents tabPaises As TabPage
    Private WithEvents dgvPaises As DataGridView
    Private WithEvents colPaisId As DataGridViewTextBoxColumn
    Private WithEvents colPaisCodigo As DataGridViewTextBoxColumn
    Private WithEvents colPaisNombre As DataGridViewTextBoxColumn
End Class

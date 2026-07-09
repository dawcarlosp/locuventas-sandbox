<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosControl
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.colUserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPaginacion = New System.Windows.Forms.Panel()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlToolbar.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPaginacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = DarkBg2
        Me.pnlToolbar.Controls.Add(Me.txtSearch)
        Me.pnlToolbar.Controls.Add(Me.lblSearch)
        Me.pnlToolbar.Controls.Add(Me.lblDescripcion)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(900, 60)
        Me.pnlToolbar.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(60, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 23)
        Me.txtSearch.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.ForeColor = TextSecondary
        Me.lblSearch.Location = New System.Drawing.Point(10, 33)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(42, 13)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Buscar"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.ForeColor = PurpleLight
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 10)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(353, 15)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Usuarios pendientes de habilitar como vendedores"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.BackgroundColor = DarkBg2
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUserId, Me.colUserEmail, Me.colUserNombre, Me.colUserFecha, Me.colAccion, Me.colEliminar})
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.GridColor = DarkBorder
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 60)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(900, 340)
        Me.dgvUsuarios.TabIndex = 1
        '
        'colUserId
        '
        Me.colUserId.HeaderText = "ID"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Width = 40
        '
        'colUserEmail
        '
        Me.colUserEmail.HeaderText = "Email"
        Me.colUserEmail.Name = "colUserEmail"
        Me.colUserEmail.Width = 200
        '
        'colUserNombre
        '
        Me.colUserNombre.HeaderText = "Nombre"
        Me.colUserNombre.Name = "colUserNombre"
        Me.colUserNombre.Width = 200
        '
        'colUserFecha
        '
        Me.colUserFecha.HeaderText = "Registrado"
        Me.colUserFecha.Name = "colUserFecha"
        Me.colUserFecha.Width = 150
        '
        'colAccion
        '
        Me.colAccion.HeaderText = "Acción"
        Me.colAccion.Name = "colAccion"
        Me.colAccion.Text = "Habilitar"
        Me.colAccion.UseColumnTextForButtonValue = True
        Me.colAccion.Width = 100
        '
        'colEliminar
        '
        Me.colEliminar.HeaderText = "Eliminar"
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.Text = "Eliminar"
        Me.colEliminar.UseColumnTextForButtonValue = True
        Me.colEliminar.Width = 80
        '
        'pnlPaginacion
        '
        Me.pnlPaginacion.BackColor = DarkBg2
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
        Me.lblPagina.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPagina.ForeColor = TextSecondary
        Me.lblPagina.Location = New System.Drawing.Point(400, 12)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(74, 15)
        Me.lblPagina.TabIndex = 2
        Me.lblPagina.Text = "Página 0 de 0"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 65, 12)
        Me.btnSiguiente.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 88, 12)
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(500, 7)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(85, 25)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente >"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 65, 12)
        Me.btnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 88, 12)
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.ForeColor = System.Drawing.Color.White
        Me.btnAnterior.Location = New System.Drawing.Point(300, 7)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(85, 25)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.Text = "< Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'UsuariosControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.pnlPaginacion)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Name = "UsuariosControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPaginacion.ResumeLayout(False)
        Me.pnlPaginacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlToolbar As Panel
    Private WithEvents txtSearch As TextBox
    Private WithEvents lblSearch As Label
    Private WithEvents lblDescripcion As Label
    Private WithEvents dgvUsuarios As DataGridView
    Private WithEvents colUserId As DataGridViewTextBoxColumn
    Private WithEvents colUserEmail As DataGridViewTextBoxColumn
    Private WithEvents colUserNombre As DataGridViewTextBoxColumn
    Private WithEvents colUserFecha As DataGridViewTextBoxColumn
    Private WithEvents colAccion As DataGridViewButtonColumn
    Private WithEvents colEliminar As DataGridViewButtonColumn
    Private WithEvents pnlPaginacion As Panel
    Private WithEvents lblPagina As Label
    Private WithEvents btnSiguiente As Button
    Private WithEvents btnAnterior As Button
End Class

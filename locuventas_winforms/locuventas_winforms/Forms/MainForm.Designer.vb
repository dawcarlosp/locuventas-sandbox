<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblLogoVentas = New System.Windows.Forms.Label()
        Me.lblLogoLocu = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = DarkBg2
        Me.pnlHeader.Controls.Add(Me.lblLogoVentas)
        Me.pnlHeader.Controls.Add(Me.lblLogoLocu)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.picProfile)
        Me.pnlHeader.Controls.Add(Me.lblUserRole)
        Me.pnlHeader.Controls.Add(Me.lblUserName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblLogoVentas
        '
        Me.lblLogoVentas.AutoSize = True
        Me.lblLogoVentas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoVentas.ForeColor = PurpleLight
        Me.lblLogoVentas.Location = New System.Drawing.Point(101, 14)
        Me.lblLogoVentas.Name = "lblLogoVentas"
        Me.lblLogoVentas.Size = New System.Drawing.Size(166, 32)
        Me.lblLogoVentas.TabIndex = 5
        Me.lblLogoVentas.Text = "Ventas"
        '
        'lblLogoLocu
        '
        Me.lblLogoLocu.AutoSize = True
        Me.lblLogoLocu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoLocu.ForeColor = TextWhite
        Me.lblLogoLocu.Location = New System.Drawing.Point(12, 14)
        Me.lblLogoLocu.Name = "lblLogoLocu"
        Me.lblLogoLocu.Size = New System.Drawing.Size(93, 32)
        Me.lblLogoLocu.TabIndex = 4
        Me.lblLogoLocu.Text = "Locu"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 18, 60)
        Me.btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 29, 72)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(993, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(95, 30)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Cerrar Sesión"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picProfile.BackColor = DarkBg
        Me.picProfile.Location = New System.Drawing.Point(893, 10)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(40, 40)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'lblUserRole
        '
        Me.lblUserRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUserRole.ForeColor = TextSecondary
        Me.lblUserRole.Location = New System.Drawing.Point(839, 33)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(30, 13)
        Me.lblUserRole.TabIndex = 2
        Me.lblUserRole.Text = "Rol"
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserName.ForeColor = TextWhite
        Me.lblUserName.Location = New System.Drawing.Point(837, 12)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(49, 19)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Nombre"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = DarkBg
        Me.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlSidebar.Controls.Add(Me.lblMenuTitle)
        Me.pnlSidebar.Controls.Add(Me.btnAdmin)
        Me.pnlSidebar.Controls.Add(Me.btnCategorias)
        Me.pnlSidebar.Controls.Add(Me.btnVentas)
        Me.pnlSidebar.Controls.Add(Me.btnProductos)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 60)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 440)
        Me.pnlSidebar.TabIndex = 1
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.AutoSize = True
        Me.lblMenuTitle.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenuTitle.ForeColor = TextMuted
        Me.lblMenuTitle.Location = New System.Drawing.Point(15, 18)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(50, 12)
        Me.lblMenuTitle.TabIndex = 4
        Me.lblMenuTitle.Text = "MÓDULOS"
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 63, 70)
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42)
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdmin.ForeColor = TextWhite
        Me.btnAdmin.Location = New System.Drawing.Point(0, 220)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(200, 45)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Administración"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnCategorias
        '
        Me.btnCategorias.FlatAppearance.BorderSize = 0
        Me.btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 63, 70)
        Me.btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42)
        Me.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategorias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCategorias.ForeColor = TextWhite
        Me.btnCategorias.Location = New System.Drawing.Point(0, 170)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(200, 45)
        Me.btnCategorias.TabIndex = 2
        Me.btnCategorias.Text = "Categorías"
        Me.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategorias.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 63, 70)
        Me.btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42)
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVentas.ForeColor = TextWhite
        Me.btnVentas.Location = New System.Drawing.Point(0, 120)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(200, 45)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 63, 70)
        Me.btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42)
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnProductos.ForeColor = TextWhite
        Me.btnProductos.Location = New System.Drawing.Point(0, 70)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(200, 45)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = DarkBg
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(200, 60)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(900, 440)
        Me.pnlContent.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
        Me.ClientSize = New System.Drawing.Size(1100, 500)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LocuVentas - Panel Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents picProfile As PictureBox
    Private WithEvents lblUserName As Label
    Private WithEvents lblUserRole As Label
    Private WithEvents btnLogout As Button
    Private WithEvents pnlSidebar As Panel
    Private WithEvents btnProductos As Button
    Private WithEvents btnVentas As Button
    Private WithEvents btnCategorias As Button
    Private WithEvents btnAdmin As Button
    Private WithEvents pnlContent As Panel
    Private WithEvents lblMenuTitle As Label
    Private WithEvents lblLogoLocu As Label
    Private WithEvents lblLogoVentas As Label
End Class

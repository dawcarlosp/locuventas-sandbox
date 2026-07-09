<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLogoVentas = New System.Windows.Forms.Label()
        Me.lblLogoLocu = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = DarkBg
        Me.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlCard.Controls.Add(Me.lblError)
        Me.pnlCard.Controls.Add(Me.lnkRegister)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.lblPassword)
        Me.pnlCard.Controls.Add(Me.txtEmail)
        Me.pnlCard.Controls.Add(Me.lblEmail)
        Me.pnlCard.Controls.Add(Me.lblLogoVentas)
        Me.pnlCard.Controls.Add(Me.lblLogoLocu)
        Me.pnlCard.Location = New System.Drawing.Point(62, 40)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlCard.Size = New System.Drawing.Size(340, 420)
        Me.pnlCard.TabIndex = 0
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblError.ForeColor = Rose
        Me.lblError.Location = New System.Drawing.Point(30, 220)
        Me.lblError.MaximumSize = New System.Drawing.Size(280, 40)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 9
        '
        'lnkRegister
        '
        Me.lnkRegister.ActiveLinkColor = PurpleLight
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lnkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkRegister.LinkColor = Purple
        Me.lnkRegister.Location = New System.Drawing.Point(105, 320)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(130, 15)
        Me.lnkRegister.TabIndex = 8
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Crear una cuenta"
        Me.lnkRegister.VisitedLinkColor = Purple
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 34, 206)
        Me.btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 51, 234)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(70, 270)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(200, 40)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(30, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(280, 25)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = TextSecondary
        Me.lblPassword.Location = New System.Drawing.Point(30, 170)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Contraseña"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(30, 130)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 25)
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = TextSecondary
        Me.lblEmail.Location = New System.Drawing.Point(30, 112)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'lblLogoVentas
        '
        Me.lblLogoVentas.AutoSize = True
        Me.lblLogoVentas.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoVentas.ForeColor = PurpleLight
        Me.lblLogoVentas.Location = New System.Drawing.Point(142, 57)
        Me.lblLogoVentas.Name = "lblLogoVentas"
        Me.lblLogoVentas.Size = New System.Drawing.Size(167, 47)
        Me.lblLogoVentas.TabIndex = 1
        Me.lblLogoVentas.Text = "Ventas"
        '
        'lblLogoLocu
        '
        Me.lblLogoLocu.AutoSize = True
        Me.lblLogoLocu.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoLocu.ForeColor = TextWhite
        Me.lblLogoLocu.Location = New System.Drawing.Point(30, 57)
        Me.lblLogoLocu.Name = "lblLogoLocu"
        Me.lblLogoLocu.Size = New System.Drawing.Size(108, 47)
        Me.lblLogoLocu.TabIndex = 0
        Me.lblLogoLocu.Text = "Locu"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg2
        Me.ClientSize = New System.Drawing.Size(464, 501)
        Me.Controls.Add(Me.pnlCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LocuVentas - Inicio de Sesión"
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlCard As Panel
    Private WithEvents lblLogoLocu As Label
    Private WithEvents lblLogoVentas As Label
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents lnkRegister As LinkLabel
    Private WithEvents lblError As Label
End Class

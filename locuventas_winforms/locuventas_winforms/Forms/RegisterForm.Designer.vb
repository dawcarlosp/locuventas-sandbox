<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnSubirFoto = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = TextWhite
        Me.lblTitle.Location = New System.Drawing.Point(25, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(191, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Crear una cuenta"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = TextSecondary
        Me.lblNombre.Location = New System.Drawing.Point(25, 65)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombre.Location = New System.Drawing.Point(25, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 25)
        Me.txtNombre.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = TextSecondary
        Me.lblEmail.Location = New System.Drawing.Point(25, 115)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(25, 132)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(240, 25)
        Me.txtEmail.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = TextSecondary
        Me.lblPassword.Location = New System.Drawing.Point(25, 165)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(25, 182)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(240, 25)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPassword.ForeColor = TextSecondary
        Me.lblConfirmPassword.Location = New System.Drawing.Point(25, 215)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(118, 13)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirmar contraseña"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(25, 232)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(240, 25)
        Me.txtConfirmPassword.TabIndex = 8
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'picFoto
        '
        Me.picFoto.BackColor = DarkBg2
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFoto.Location = New System.Drawing.Point(295, 82)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(150, 150)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 9
        Me.picFoto.TabStop = False
        '
        'btnSubirFoto
        '
        Me.btnSubirFoto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubirFoto.Location = New System.Drawing.Point(295, 240)
        Me.btnSubirFoto.Name = "btnSubirFoto"
        Me.btnSubirFoto.Size = New System.Drawing.Size(150, 28)
        Me.btnSubirFoto.TabIndex = 10
        Me.btnSubirFoto.Text = "Seleccionar foto..."
        Me.btnSubirFoto.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.Location = New System.Drawing.Point(25, 290)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(150, 38)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Registrarse"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(185, 290)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 38)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblError.ForeColor = Rose
        Me.lblError.Location = New System.Drawing.Point(25, 270)
        Me.lblError.MaximumSize = New System.Drawing.Size(420, 20)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 13
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
        Me.ClientSize = New System.Drawing.Size(474, 351)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnSubirFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crear una cuenta"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblNombre As Label
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents lblConfirmPassword As Label
    Private WithEvents txtConfirmPassword As TextBox
    Private WithEvents picFoto As PictureBox
    Private WithEvents btnSubirFoto As Button
    Private WithEvents btnRegistrar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents lblError As Label
End Class

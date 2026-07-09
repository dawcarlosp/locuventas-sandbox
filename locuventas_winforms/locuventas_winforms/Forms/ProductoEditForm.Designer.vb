<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductoEditForm
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.clbCategorias = New System.Windows.Forms.CheckedListBox()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnSubirFoto = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = TextSecondary
        Me.lblNombre.Location = New System.Drawing.Point(30, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombre.Location = New System.Drawing.Point(30, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 25)
        Me.txtNombre.TabIndex = 1
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.ForeColor = TextSecondary
        Me.lblPrecio.Location = New System.Drawing.Point(30, 115)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(41, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPrecio.Location = New System.Drawing.Point(30, 133)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(120, 25)
        Me.txtPrecio.TabIndex = 3
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblIva.ForeColor = TextSecondary
        Me.lblIva.Location = New System.Drawing.Point(160, 115)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(24, 13)
        Me.lblIva.TabIndex = 4
        Me.lblIva.Text = "IVA"
        '
        'txtIva
        '
        Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIva.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIva.Location = New System.Drawing.Point(160, 133)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(120, 25)
        Me.txtIva.TabIndex = 5
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPais.ForeColor = TextSecondary
        Me.lblPais.Location = New System.Drawing.Point(30, 170)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(28, 13)
        Me.lblPais.TabIndex = 6
        Me.lblPais.Text = "País"
        '
        'cmbPais
        '
        Me.cmbPais.BackColor = DarkBg2
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPais.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbPais.ForeColor = TextWhite
        Me.cmbPais.Location = New System.Drawing.Point(30, 188)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(250, 23)
        Me.cmbPais.TabIndex = 7
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCategorias.ForeColor = TextSecondary
        Me.lblCategorias.Location = New System.Drawing.Point(30, 225)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(64, 13)
        Me.lblCategorias.TabIndex = 8
        Me.lblCategorias.Text = "Categorías"
        '
        'clbCategorias
        '
        Me.clbCategorias.BackColor = DarkBg2
        Me.clbCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbCategorias.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.clbCategorias.ForeColor = TextWhite
        Me.clbCategorias.FormattingEnabled = True
        Me.clbCategorias.Location = New System.Drawing.Point(30, 243)
        Me.clbCategorias.Name = "clbCategorias"
        Me.clbCategorias.Size = New System.Drawing.Size(250, 140)
        Me.clbCategorias.TabIndex = 9
        '
        'picFoto
        '
        Me.picFoto.BackColor = DarkBg2
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFoto.Location = New System.Drawing.Point(310, 78)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(180, 180)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 10
        Me.picFoto.TabStop = False
        '
        'btnSubirFoto
        '
        Me.btnSubirFoto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubirFoto.Location = New System.Drawing.Point(310, 265)
        Me.btnSubirFoto.Name = "btnSubirFoto"
        Me.btnSubirFoto.Size = New System.Drawing.Size(180, 28)
        Me.btnSubirFoto.TabIndex = 11
        Me.btnSubirFoto.Text = "Seleccionar imagen..."
        Me.btnSubirFoto.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(310, 355)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 38)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(405, 355)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 38)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = TextWhite
        Me.lblTitle.Location = New System.Drawing.Point(28, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(169, 28)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Nuevo Producto"
        '
        'ProductoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
        Me.ClientSize = New System.Drawing.Size(524, 421)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSubirFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.clbCategorias)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductoEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producto"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblNombre As Label
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblPrecio As Label
    Private WithEvents txtPrecio As TextBox
    Private WithEvents lblIva As Label
    Private WithEvents txtIva As TextBox
    Private WithEvents lblPais As Label
    Private WithEvents cmbPais As ComboBox
    Private WithEvents lblCategorias As Label
    Private WithEvents clbCategorias As CheckedListBox
    Private WithEvents picFoto As PictureBox
    Private WithEvents btnSubirFoto As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents lblTitle As Label
End Class

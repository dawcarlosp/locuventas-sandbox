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
        Me.lblNombre.Location = New System.Drawing.Point(30, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(30, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 22)
        Me.txtNombre.TabIndex = 1
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(30, 120)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(30, 140)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(120, 22)
        Me.txtPrecio.TabIndex = 3
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(160, 120)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(22, 13)
        Me.lblIva.TabIndex = 4
        Me.lblIva.Text = "IVA"
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(160, 140)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(120, 22)
        Me.txtIva.TabIndex = 5
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(30, 180)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(27, 13)
        Me.lblPais.TabIndex = 6
        Me.lblPais.Text = "País"
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(30, 200)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(250, 21)
        Me.cmbPais.TabIndex = 7
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Location = New System.Drawing.Point(30, 240)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(60, 13)
        Me.lblCategorias.TabIndex = 8
        Me.lblCategorias.Text = "Categorías"
        '
        'clbCategorias
        '
        Me.clbCategorias.FormattingEnabled = True
        Me.clbCategorias.Location = New System.Drawing.Point(30, 260)
        Me.clbCategorias.Name = "clbCategorias"
        Me.clbCategorias.Size = New System.Drawing.Size(250, 140)
        Me.clbCategorias.TabIndex = 9
        '
        'picFoto
        '
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFoto.Location = New System.Drawing.Point(310, 80)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(180, 180)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 10
        Me.picFoto.TabStop = False
        '
        'btnSubirFoto
        '
        Me.btnSubirFoto.Location = New System.Drawing.Point(310, 270)
        Me.btnSubirFoto.Name = "btnSubirFoto"
        Me.btnSubirFoto.Size = New System.Drawing.Size(180, 30)
        Me.btnSubirFoto.TabIndex = 11
        Me.btnSubirFoto.Text = "Seleccionar imagen..."
        Me.btnSubirFoto.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(310, 360)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 40)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(410, 360)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 40)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(163, 25)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Nuevo Producto"
        '
        'ProductoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomeSub = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblRoleInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(280, 120)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(360, 41)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Bienvenido a LocuVentas"
        '
        'lblWelcomeSub
        '
        Me.lblWelcomeSub.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeSub.AutoSize = True
        Me.lblWelcomeSub.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblWelcomeSub.Location = New System.Drawing.Point(350, 175)
        Me.lblWelcomeSub.Name = "lblWelcomeSub"
        Me.lblWelcomeSub.Size = New System.Drawing.Size(220, 25)
        Me.lblWelcomeSub.TabIndex = 1
        Me.lblWelcomeSub.Text = "Selecciona un módulo lateral"
        '
        'pnlStats
        '
        Me.pnlStats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStats.BackColor = System.Drawing.Color.White
        Me.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStats.Location = New System.Drawing.Point(260, 230)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(400, 120)
        Me.pnlStats.TabIndex = 2
        '
        'lblRoleInfo
        '
        Me.lblRoleInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRoleInfo.AutoSize = True
        Me.lblRoleInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRoleInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblRoleInfo.Location = New System.Drawing.Point(310, 260)
        Me.lblRoleInfo.Name = "lblRoleInfo"
        Me.lblRoleInfo.Size = New System.Drawing.Size(300, 19)
        Me.lblRoleInfo.TabIndex = 3
        Me.lblRoleInfo.Text = "Has iniciado sesión como Administrador"
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.lblRoleInfo)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.lblWelcomeSub)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblWelcome As Label
    Private WithEvents lblWelcomeSub As Label
    Private WithEvents pnlStats As Panel
    Private WithEvents lblRoleInfo As Label
End Class

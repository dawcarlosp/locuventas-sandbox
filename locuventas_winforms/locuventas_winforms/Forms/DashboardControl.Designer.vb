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
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblRoleInfo = New System.Windows.Forms.Label()
        Me.lblWelcomeSub = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = TextWhite
        Me.lblWelcome.Location = New System.Drawing.Point(30, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(370, 41)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Bienvenido a LocuVentas"
        '
        'pnlCard
        '
        Me.pnlCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCard.BackColor = DarkBg2
        Me.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlCard.Controls.Add(Me.lblRoleInfo)
        Me.pnlCard.Controls.Add(Me.lblWelcomeSub)
        Me.pnlCard.Controls.Add(Me.lblWelcome)
        Me.pnlCard.Location = New System.Drawing.Point(30, 30)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(840, 180)
        Me.pnlCard.TabIndex = 4
        '
        'lblRoleInfo
        '
        Me.lblRoleInfo.AutoSize = True
        Me.lblRoleInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRoleInfo.ForeColor = TextSecondary
        Me.lblRoleInfo.Location = New System.Drawing.Point(35, 120)
        Me.lblRoleInfo.Name = "lblRoleInfo"
        Me.lblRoleInfo.Size = New System.Drawing.Size(300, 19)
        Me.lblRoleInfo.TabIndex = 3
        Me.lblRoleInfo.Text = "Has iniciado sesión como Administrador"
        '
        'lblWelcomeSub
        '
        Me.lblWelcomeSub.AutoSize = True
        Me.lblWelcomeSub.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblWelcomeSub.ForeColor = TextMuted
        Me.lblWelcomeSub.Location = New System.Drawing.Point(34, 80)
        Me.lblWelcomeSub.Name = "lblWelcomeSub"
        Me.lblWelcomeSub.Size = New System.Drawing.Size(220, 21)
        Me.lblWelcomeSub.TabIndex = 1
        Me.lblWelcomeSub.Text = "Selecciona un módulo lateral"
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = DarkBg
        Me.Controls.Add(Me.pnlCard)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(900, 440)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblWelcome As Label
    Private WithEvents lblWelcomeSub As Label
    Private WithEvents lblRoleInfo As Label
    Private WithEvents pnlCard As Panel
End Class

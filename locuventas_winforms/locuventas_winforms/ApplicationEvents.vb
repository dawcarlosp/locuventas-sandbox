Imports Microsoft.VisualBasic.ApplicationServices

Public Module AppColors
    ' Tema oscuro zinc (equivalente a Tailwind zinc-900/800/700)
    Public ReadOnly DarkBg As Color = Color.FromArgb(24, 24, 27)        ' #18181b zinc-900
    Public ReadOnly DarkBg2 As Color = Color.FromArgb(39, 39, 42)       ' #27272a zinc-800
    Public ReadOnly DarkBorder As Color = Color.FromArgb(63, 63, 70)    ' #3f3f46 zinc-700
    Public ReadOnly TextMuted As Color = Color.FromArgb(113, 113, 122)  ' #71717a zinc-500
    Public ReadOnly TextSecondary As Color = Color.FromArgb(161, 161, 170) ' #a1a1aa zinc-400
    Public ReadOnly TextWhite As Color = Color.FromArgb(244, 244, 245)  ' #f4f4f5 zinc-100
    Public ReadOnly Purple As Color = Color.FromArgb(168, 85, 247)      ' #a855f7 purple-500
    Public ReadOnly PurpleLight As Color = Color.FromArgb(192, 132, 252) ' #c084fc purple-400
    Public ReadOnly Orange As Color = Color.FromArgb(249, 115, 22)      ' #f97316 orange-500
    Public ReadOnly OrangeLight As Color = Color.FromArgb(251, 146, 60) ' #fb923c orange-400
    Public ReadOnly Rose As Color = Color.FromArgb(244, 63, 94)         ' #f43f5e rose-500
    Public ReadOnly Emerald As Color = Color.FromArgb(16, 185, 129)     ' #10b981 emerald-500
    Public ReadOnly Amber As Color = Color.FromArgb(245, 158, 11)       ' #f59e0b amber-500

    ' Helper para DataGridView dark theme
    Public Sub ApplyDarkTheme(dgv As DataGridView)
        dgv.BackgroundColor = DarkBg2
        dgv.BorderStyle = BorderStyle.None
        dgv.GridColor = DarkBorder
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        ' Header style
        dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkBg
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextSecondary
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.25!, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = DarkBg
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextSecondary
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = 36

        ' Cell style
        dgv.DefaultCellStyle.BackColor = DarkBg2
        dgv.DefaultCellStyle.ForeColor = TextWhite
        dgv.DefaultCellStyle.SelectionBackColor = DarkBorder
        dgv.DefaultCellStyle.SelectionForeColor = TextWhite
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 9.0!)
        dgv.RowTemplate.Height = 32

        ' Row hover not natively supported in WinForms DataGridView,
        ' but SelectionMode FullRowSelect + dark selection color approximates it
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
    End Sub

    ' Helper for dark-styled input TextBox
    Public Sub StyleInput(tb As TextBox)
        tb.BackColor = DarkBg2
        tb.ForeColor = TextWhite
        tb.BorderStyle = BorderStyle.FixedSingle
    End Sub

    ' Helper for dark-styled ComboBox
    Public Sub StyleCombo(cb As ComboBox)
        cb.BackColor = DarkBg2
        cb.ForeColor = TextWhite
        cb.FlatStyle = FlatStyle.Flat
    End Sub

    ' Helper for primary (purple) button
    Public Sub StyleBtnPrimary(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Purple
        btn.ForeColor = Color.White
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 51, 234)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 34, 206)
        btn.UseVisualStyleBackColor = False
        btn.Cursor = Cursors.Hand
    End Sub

    ' Helper for danger (rose) button
    Public Sub StyleBtnDanger(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Rose
        btn.ForeColor = Color.White
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 29, 72)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 18, 60)
        btn.UseVisualStyleBackColor = False
        btn.Cursor = Cursors.Hand
    End Sub

    ' Helper for secondary (dark) button
    Public Sub StyleBtnSecondary(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.BorderColor = DarkBorder
        btn.BackColor = DarkBg2
        btn.ForeColor = TextWhite
        btn.FlatAppearance.MouseOverBackColor = DarkBorder
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 91)
        btn.UseVisualStyleBackColor = False
        btn.Cursor = Cursors.Hand
    End Sub

    ' Helper for success (emerald) button
    Public Sub StyleBtnSuccess(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Emerald
        btn.ForeColor = Color.White
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 120, 87)
        btn.UseVisualStyleBackColor = False
        btn.Cursor = Cursors.Hand
    End Sub

    ' Helper for orange/accent button
    Public Sub StyleBtnOrange(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Orange
        btn.ForeColor = Color.White
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 88, 12)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 65, 12)
        btn.UseVisualStyleBackColor = False
        btn.Cursor = Cursors.Hand
    End Sub
End Module

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show(
                $"Error inesperado: {e.Exception.Message}{vbCrLf}{vbCrLf}La aplicación se cerrará.",
                "Error crítico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Sub

        Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
            e.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
            e.HighDpiMode = HighDpiMode.PerMonitorV2
        End Sub
    End Class
End Namespace

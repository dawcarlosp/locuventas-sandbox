Imports Microsoft.VisualBasic.ApplicationServices

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
            e.Font = New Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular)
            e.HighDpiMode = HighDpiMode.PerMonitorV2
        End Sub
    End Class
End Namespace

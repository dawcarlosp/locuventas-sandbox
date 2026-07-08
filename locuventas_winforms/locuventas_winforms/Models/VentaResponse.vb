Public Class VentaResponse
    Public Property Id As Long
    Public Property Total As Decimal
    Public Property MontoPagado As Decimal
    Public Property Saldo As Decimal
    Public Property EstadoPago As String
    Public Property Vendedor As String
    Public Property Fecha As String
    Public Property Cancelada As Boolean
    Public Property Lineas As List(Of LineaVentaResponse)
End Class

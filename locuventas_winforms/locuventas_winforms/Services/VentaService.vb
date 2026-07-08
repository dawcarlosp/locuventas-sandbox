Imports System.Text.Json

Public Class VentaService
    Public Shared Async Function GetAll(page As Integer, size As Integer) As Task(Of PageDTO(Of VentaResponse))
        Dim result = Await ApiClient.GetAsync(Of PageDTO(Of VentaResponse))($"/ventas?page={page}&size={size}")
        Return result
    End Function

    Public Shared Async Function GetPendientes(page As Integer, size As Integer) As Task(Of PageDTO(Of VentaResponse))
        Dim result = Await ApiClient.GetAsync(Of PageDTO(Of VentaResponse))($"/ventas/pendientes?page={page}&size={size}")
        Return result
    End Function

    Public Shared Async Function GetById(id As Long) As Task(Of VentaResponse)
        Dim result = Await ApiClient.GetAsync(Of VentaResponse)($"/ventas/{id}")
        Return result
    End Function

    Public Shared Async Function Create(request As VentaCreateRequest) As Task(Of VentaResponse)
        Dim result = Await ApiClient.PostAsync(Of VentaCreateRequest, VentaResponse)("/ventas", request)
        Return result
    End Function

    Public Shared Async Function AddPayment(ventaId As Long, monto As Decimal) As Task(Of VentaResponse)
        Dim request = New PagoRequest With { .Monto = monto }
        Dim result = Await ApiClient.PostAsync(Of PagoRequest, VentaResponse)($"/ventas/{ventaId}/pago", request)
        Return result
    End Function

    Public Shared Async Function Cancel(ventaId As Long) As Task
        Await ApiClient.PatchAsync(Of Dictionary(Of String, String))($"/ventas/{ventaId}/cancelar")
    End Function

    Public Shared Async Function DownloadPdf(ventaId As Long) As Task(Of Byte())
        Dim bytes = Await ApiClient.GetByteArrayAsync($"/ventas/{ventaId}/ticket-pdf")
        Return bytes
    End Function
End Class

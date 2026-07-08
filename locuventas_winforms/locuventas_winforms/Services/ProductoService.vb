Imports System.Text.Json

Public Class ProductoService
    Public Shared Async Function GetAll(
        page As Integer,
        size As Integer,
        search As String,
        paisId As Long?,
        categoriaId As Long?) As Task(Of PageDTO(Of ProductoResponse))

        Dim endpoint = $"/productos?page={page}&size={size}&search={Uri.EscapeDataString(If(search, ""))}"
        If paisId.HasValue Then endpoint &= $"&paisId={paisId.Value}"
        If categoriaId.HasValue Then endpoint &= $"&categoriaId={categoriaId.Value}"

        Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of PageDTO(Of ProductoResponse)))(endpoint)
        Return response.Data
    End Function

    Public Shared Async Function Create(
        request As ProductoCreateRequest,
        fotoBytes As Byte(),
        fotoFileName As String) As Task(Of ProductoResponse)

        Dim json = JsonSerializer.Serialize(request, New JsonSerializerOptions With {
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        })

        Dim parts = New List(Of MultipartPart) From {
            MultipartPart.CreateText("producto", json),
            MultipartPart.CreateFile("foto", fotoBytes, fotoFileName)
        }

        Dim response = Await ApiClient.PostMultipartAsync(Of ApiResponse(Of ProductoResponse))(
            "/productos", parts)
        Return response.Data
    End Function

    Public Shared Async Function Update(
        id As Long,
        request As ProductoUpdateRequest,
        fotoBytes As Byte(),
        fotoFileName As String) As Task(Of ProductoResponse)

        Dim json = JsonSerializer.Serialize(request, New JsonSerializerOptions With {
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        })

        Dim parts = New List(Of MultipartPart) From {
            MultipartPart.CreateText("producto", json)
        }

        If fotoBytes IsNot Nothing Then
            parts.Add(MultipartPart.CreateFile("foto", fotoBytes, fotoFileName))
        End If

        Dim response = Await ApiClient.PutMultipartAsync(Of ApiResponse(Of ProductoResponse))(
            $"/productos/{id}", parts)
        Return response.Data
    End Function

    Public Shared Async Function Delete(id As Long) As Task
        Await ApiClient.DeleteAsync(Of ApiResponse(Of Object))($"/productos/{id}")
    End Function
End Class

Imports System.Text.Json

Public Class CategoriaService
    Public Shared Async Function GetAll() As Task(Of List(Of CategoriaResponse))
        Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of CategoriaResponse)))("/categorias")
        Return response.Data
    End Function

    Public Shared Async Function Create(nombre As String) As Task(Of CategoriaResponse)
        Dim request = New CategoriaCreateRequest With { .Nombre = nombre }
        Dim response = Await ApiClient.PostAsync(Of CategoriaCreateRequest, ApiResponse(Of CategoriaResponse))(
            "/categorias", request)
        Return response.Data
    End Function

    Public Shared Async Function Update(id As Long, nombre As String) As Task(Of CategoriaResponse)
        Dim request = New CategoriaCreateRequest With { .Nombre = nombre }
        Dim response = Await ApiClient.PutAsync(Of CategoriaCreateRequest, ApiResponse(Of CategoriaResponse))(
            $"/categorias/{id}", request)
        Return response.Data
    End Function

    Public Shared Async Function Delete(id As Long) As Task(Of Integer)
        Try
            Dim response = Await ApiClient.DeleteAsync(Of ApiResponse(Of Integer))($"/categorias/{id}")
            Return response.Data
        Catch ex As ApiException
            If CInt(ex.StatusCode) = 409 Then
                ' Parse the conflict response to get product count
                Try
                    Dim errorResponse = JsonSerializer.Deserialize(Of ApiResponse(Of Integer))(ex.ResponseContent)
                    Return If(errorResponse?.Data, -1)
                Catch
                    Return -1
                End Try
            End If
            Throw
        End Try
    End Function

    Public Shared Async Function DeleteForce(id As Long) As Task
        Await ApiClient.DeleteAsync(Of ApiResponse(Of Object))($"/categorias/{id}/force")
    End Function

    Public Shared Async Function GetAllPaises() As Task(Of List(Of PaisResponse))
        Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of List(Of PaisResponse)))("/paises")
        Return response.Data
    End Function
End Class

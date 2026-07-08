Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Text.Json

Public Class ApiClient
    Private Shared ReadOnly _httpClient As New HttpClient()
    Private Shared ReadOnly _baseUrl As String = "http://localhost:8080"

    Shared Sub New()
        _httpClient.BaseAddress = New Uri(_baseUrl)
        _httpClient.DefaultRequestHeaders.Accept.Add(
            New MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    Public Shared Sub SetToken(token As String)
        If Not String.IsNullOrEmpty(token) Then
            _httpClient.DefaultRequestHeaders.Authorization =
                New AuthenticationHeaderValue("Bearer", token)
        Else
            _httpClient.DefaultRequestHeaders.Authorization = Nothing
        End If
    End Sub

    Public Shared Sub ClearToken()
        _httpClient.DefaultRequestHeaders.Authorization = Nothing
    End Sub

    Public Shared Async Function GetAsync(Of T)(endpoint As String) As Task(Of T)
        Dim response = Await _httpClient.GetAsync(endpoint)
        Dim content = Await response.Content.ReadAsStringAsync()
        response.EnsureSuccessStatusCode()
        Return JsonSerializer.Deserialize(Of T)(content, GetJsonOptions())
    End Function

    Public Shared Async Function PostAsync(Of TRequest, TResponse)(endpoint As String, data As TRequest) As Task(Of TResponse)
        Dim json = JsonSerializer.Serialize(data, GetJsonOptions())
        Dim httpContent = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await _httpClient.PostAsync(endpoint, httpContent)
        Dim responseContent = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Throw New ApiException(responseContent, response.StatusCode)
        End If

        Return JsonSerializer.Deserialize(Of TResponse)(responseContent, GetJsonOptions())
    End Function

    Public Shared Async Function PutAsync(Of TRequest, TResponse)(endpoint As String, data As TRequest) As Task(Of TResponse)
        Dim json = JsonSerializer.Serialize(data, GetJsonOptions())
        Dim httpContent = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await _httpClient.PutAsync(endpoint, httpContent)
        Dim responseContent = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Throw New ApiException(responseContent, response.StatusCode)
        End If

        Return JsonSerializer.Deserialize(Of TResponse)(responseContent, GetJsonOptions())
    End Function

    Public Shared Async Function DeleteAsync(Of T)(endpoint As String) As Task(Of T)
        Dim response = Await _httpClient.DeleteAsync(endpoint)
        Dim content = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Throw New ApiException(content, response.StatusCode)
        End If

        Return JsonSerializer.Deserialize(Of T)(content, GetJsonOptions())
    End Function

    Public Shared Async Function PostMultipartAsync(Of TResponse)(
        endpoint As String,
        parts As List(Of MultipartPart)) As Task(Of TResponse)

        Using formData = New MultipartFormDataContent()
            For Each part In parts
                If part.IsFile Then
                    formData.Add(New ByteArrayContent(part.FileBytes), part.Name, part.FileName)
                Else
                    formData.Add(New StringContent(part.Value, Encoding.UTF8, "application/json"), part.Name)
                End If
            Next

            Dim response = Await _httpClient.PostAsync(endpoint, formData)
            Dim content = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Throw New ApiException(content, response.StatusCode)
            End If

            Return JsonSerializer.Deserialize(Of TResponse)(content, GetJsonOptions())
        End Using
    End Function

    Public Shared Async Function PutMultipartAsync(Of TResponse)(
        endpoint As String,
        parts As List(Of MultipartPart)) As Task(Of TResponse)

        Using formData = New MultipartFormDataContent()
            For Each part In parts
                If part.IsFile Then
                    formData.Add(New ByteArrayContent(part.FileBytes), part.Name, part.FileName)
                Else
                    formData.Add(New StringContent(part.Value, Encoding.UTF8, "application/json"), part.Name)
                End If
            Next

            Dim response = Await _httpClient.PutAsync(endpoint, formData)
            Dim content = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Throw New ApiException(content, response.StatusCode)
            End If

            Return JsonSerializer.Deserialize(Of TResponse)(content, GetJsonOptions())
        End Using
    End Function

    Public Shared Async Function GetByteArrayAsync(endpoint As String) As Task(Of Byte())
        Dim response = Await _httpClient.GetAsync(endpoint)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsByteArrayAsync()
    End Function

    Public Shared Async Function PostRawAsync(Of TResponse)(endpoint As String, data As Object) As Task(Of TResponse)
        Dim json = JsonSerializer.Serialize(data, GetJsonOptions())
        Dim httpContent = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await _httpClient.PostAsync(endpoint, httpContent)
        Dim content = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Throw New ApiException(content, response.StatusCode)
        End If

        Return JsonSerializer.Deserialize(Of TResponse)(content, GetJsonOptions())
    End Function

    Public Shared Async Function PatchAsync(Of TResponse)(endpoint As String) As Task(Of TResponse)
        Dim request = New HttpRequestMessage(New HttpMethod("PATCH"), endpoint)
        Dim response = Await _httpClient.SendAsync(request)
        Dim content = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Throw New ApiException(content, response.StatusCode)
        End If

        Return JsonSerializer.Deserialize(Of TResponse)(content, GetJsonOptions())
    End Function

    Private Shared Function GetJsonOptions() As JsonSerializerOptions
        Dim options = New JsonSerializerOptions()
        options.PropertyNameCaseInsensitive = True
        options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        Return options
    End Function
End Class

Public Class MultipartPart
    Public Property Name As String
    Public Property Value As String
    Public Property IsFile As Boolean
    Public Property FileBytes As Byte()
    Public Property FileName As String

    Public Shared Function CreateText(name As String, value As String) As MultipartPart
        Return New MultipartPart With {
            .Name = name,
            .Value = value,
            .IsFile = False
        }
    End Function

    Public Shared Function CreateFile(name As String, fileBytes As Byte(), fileName As String) As MultipartPart
        Return New MultipartPart With {
            .Name = name,
            .IsFile = True,
            .FileBytes = fileBytes,
            .FileName = fileName
        }
    End Function
End Class

Public Class ApiException
    Inherits Exception

    Public Property StatusCode As System.Net.HttpStatusCode
    Public Property ResponseContent As String

    Public Sub New(responseContent As String, statusCode As System.Net.HttpStatusCode)
        MyBase.New($"API Error ({statusCode}): {TruncateMessage(responseContent)}")
        Me.ResponseContent = responseContent
        Me.StatusCode = statusCode
    End Sub

    Private Shared Function TruncateMessage(msg As String) As String
        If msg.Length > 200 Then
            Return msg.Substring(0, 200) & "..."
        End If
        Return msg
    End Function
End Class

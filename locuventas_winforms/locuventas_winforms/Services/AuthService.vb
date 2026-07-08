Imports System.Text.Json

Public Class AuthService
    Public Shared Async Function Login(email As String, password As String) As Task(Of LoginResponse)
        Dim request = New LoginRequest With {
            .Email = email,
            .Password = password
        }

        Dim response = Await ApiClient.PostAsync(Of LoginRequest, ApiResponse(Of LoginResponse))(
            "/auth/login", request)

        If response.Data Is Nothing Then
            Throw New Exception(response.Message)
        End If

        TokenManager.SetSession(response.Data)
        ApiClient.SetToken(response.Data.Token)

        Return response.Data
    End Function

    Public Shared Async Function Register(
        nombre As String,
        email As String,
        password As String,
        fotoBytes As Byte(),
        fotoFileName As String) As Task

        Dim userJson = JsonSerializer.Serialize(New UserRegisterRequest With {
            .Nombre = nombre,
            .Email = email,
            .Password = password
        }, New JsonSerializerOptions With {
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        })

        Dim parts = New List(Of MultipartPart) From {
            MultipartPart.CreateText("user", userJson),
            MultipartPart.CreateFile("foto", fotoBytes, fotoFileName)
        }

        Await ApiClient.PostMultipartAsync(Of ApiResponse(Of Object))("/auth/register", parts)
    End Function

    Public Shared Async Function EditProfile(
        nombre As String,
        email As String,
        password As String,
        fotoBytes As Byte(),
        fotoFileName As String) As Task(Of UserResponse)

        Dim request = New UserEditRequest With {
            .Nombre = nombre,
            .Email = email,
            .Password = password
        }

        If fotoBytes IsNot Nothing Then
            Dim userJson = JsonSerializer.Serialize(request, New JsonSerializerOptions With {
                .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            })

            Dim parts = New List(Of MultipartPart) From {
                MultipartPart.CreateText("user", userJson),
                MultipartPart.CreateFile("foto", fotoBytes, fotoFileName)
            }

            Dim response = Await ApiClient.PutMultipartAsync(Of ApiResponse(Of UserResponse))(
                "/usuarios/editar-perfil", parts)
            Return response.Data
        Else
            Dim userJson = JsonSerializer.Serialize(request, New JsonSerializerOptions With {
                .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            })

            Dim parts = New List(Of MultipartPart) From {
                MultipartPart.CreateText("user", userJson)
            }

            Dim response = Await ApiClient.PutMultipartAsync(Of ApiResponse(Of UserResponse))(
                "/usuarios/editar-perfil", parts)
            Return response.Data
        End If
    End Function

    Public Shared Async Function GetPendingUsers(page As Integer, size As Integer, search As String) As Task(Of PageDTO(Of UserResponse))
        Dim endpoint = $"/usuarios/sin-rol?page={page}&size={size}&search={Uri.EscapeDataString(search)}"
        Dim response = Await ApiClient.GetAsync(Of ApiResponse(Of PageDTO(Of UserResponse)))(endpoint)
        Return response.Data
    End Function

    Public Shared Async Function AssignVendorRole(userId As Long) As Task
        Await ApiClient.PutAsync(Of Object, ApiResponse(Of Object))(
            $"/usuarios/{userId}/asignar-rol", Nothing)
    End Function

    Public Shared Async Function DeleteUser(userId As Long) As Task
        Await ApiClient.DeleteAsync(Of ApiResponse(Of Object))($"/usuarios/{userId}")
    End Function
End Class

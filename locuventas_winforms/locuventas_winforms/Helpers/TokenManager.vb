Public Class TokenManager
    Private Shared _token As String
    Private Shared _email As String
    Private Shared _nombre As String
    Private Shared _foto As String
    Private Shared _roles As List(Of String)

    Public Shared Property Token As String
        Get
            Return _token
        End Get
        Set(value As String)
            _token = value
        End Set
    End Property

    Public Shared Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Shared Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Shared Property Foto As String
        Get
            Return _foto
        End Get
        Set(value As String)
            _foto = value
        End Set
    End Property

    Public Shared Property Roles As List(Of String)
        Get
            Return _roles
        End Get
        Set(value As List(Of String))
            _roles = value
        End Set
    End Property

    Public Shared ReadOnly Property IsAdmin As Boolean
        Get
            Return _roles IsNot Nothing AndAlso _roles.Contains("ROLE_ADMIN")
        End Get
    End Property

    Public Shared ReadOnly Property IsVendedor As Boolean
        Get
            Return _roles IsNot Nothing AndAlso _roles.Contains("ROLE_VENDEDOR")
        End Get
    End Property

    Public Shared ReadOnly Property IsAuthenticated As Boolean
        Get
            Return Not String.IsNullOrEmpty(_token)
        End Get
    End Property

    Public Shared Sub SetSession(response As LoginResponse)
        _token = response.Token
        _email = response.Email
        _nombre = response.Nombre
        _foto = response.Foto
        _roles = response.Roles
    End Sub

    Public Shared Sub Clear()
        _token = Nothing
        _email = Nothing
        _nombre = Nothing
        _foto = Nothing
        _roles = Nothing
    End Sub
End Class

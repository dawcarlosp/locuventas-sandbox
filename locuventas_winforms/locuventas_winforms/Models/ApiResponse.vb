Public Class ApiResponse(Of T)
    Public Property Message As String
    Public Property Data As T
    Public Property Status As Integer
    Public Property Timestamp As String
End Class

Public Class PageDTO(Of T)
    Public Property Content As List(Of T)
    Public Property PageNumber As Integer
    Public Property TotalPages As Integer
    Public Property TotalElements As Long
End Class

#Disable Warning IDE1006
Public Class clsItem
    Public Code As String
    Public Name As String
    Public Note As String
    Public Value As Integer
End Class

Public Class clsItems
    Private oCol As Collection

    Public Sub New()
        oCol = New Collection
    End Sub

    Public Function Add(pCode As String, pName As String) As clsItem
        Dim lItem As clsItem
        If oCol.Contains(pCode) Then Return oCol(pCode)
        lItem = New clsItem With {
            .Code = pCode,
            .Name = pName
        }
        oCol.Add(lItem, pCode)
        Return lItem
    End Function

End Class

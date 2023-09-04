Public Class Class1
    Public Sub New()

    End Sub

    Protected Overloads Function Equals(other As Class1) As Boolean
        Throw New NotImplementedException
    End Function

    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        If ReferenceEquals(Nothing, obj) Then Return False
        If ReferenceEquals(Me, obj) Then Return True
        If obj.GetType IsNot Me.GetType Then Return False
        Return Equals(DirectCast(obj, Class1))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Throw New NotImplementedException
    End Function
End Class

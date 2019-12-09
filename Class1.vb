Public Class Voiture
    Protected _roues As String = "btrbtrb"
    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            _roues = value
        End Set
    End Property
End Class

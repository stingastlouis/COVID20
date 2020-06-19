Public Class Player
    Public name As String
    Public point As Integer

    Public Sub New()
        point = 0
    End Sub

    Public Property PlayerPoint() As Integer
        Get
            Return point
        End Get
        Set(value As Integer)
            point += value
        End Set

    End Property

End Class

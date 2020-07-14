Public Class ClassPlayer
    Public Shared score As Integer
    Public Shared life As Integer
    Public Shared item As Integer
    Public Shared name As String

    Sub New()
        Me.score = 0
        Me.life = 3
        Me.item = 0
        Me.name = "Johny"
    End Sub
    Public Property playerScore As Integer
        Set(value As Integer)
            Me.score = value
        End Set
        Get
            Return Me.score
        End Get
    End Property

    Public Property playerLife As Integer
        Set(value As Integer)
            Me.life = value
        End Set
        Get
            Return Me.life
        End Get
    End Property
    Public Property playerItem As Integer
        Set(value As Integer)
            Me.item = value
        End Set
        Get
            Return Me.item
        End Get
    End Property


End Class

Public Class mulPLayerClass
    Private multiplayername As String
    Private multiplayerScore As Integer = 0
    Private multiplayerLife As Integer = 3
    Private multiplayerItem As Integer
    Private multiplayerFalling As Boolean = True
    Private multiplayerShoot As Boolean = True
    Private multiplayerRight As Boolean
    Private multiplayerLeft As Boolean
    Private multiplayerUp As Boolean
    Private multiplayerjumpHeight As Integer = 100
    Private multiplayerSpeed As Integer = 5
    Private multiplayerGravitySpeed As Integer = 3
    Private multicanplay As Boolean
    Private multiPlayerimg As Image

    Sub New()

    End Sub
    Sub New(name As String)
        multiplayername = name
    End Sub
    Public Property playerFall As Boolean
        Set(value As Boolean)
            multiplayerFalling = value
        End Set
        Get
            Return multiplayerFalling
        End Get
    End Property
    Public Property playgame As Boolean
        Set(value As Boolean)
            multicanplay = value
        End Set
        Get
            Return multicanplay
        End Get
    End Property
    Public Property playerShoot As Boolean
        Set(value As Boolean)
            multiplayerShoot = value
        End Set
        Get
            Return multiplayerShoot
        End Get
    End Property
    Public Property playerMoveRight As Boolean
        Set(value As Boolean)
            multiplayerRight = value
        End Set
        Get
            Return multiplayerRight
        End Get
    End Property
    Public Property playerMoveLeft As Boolean
        Set(value As Boolean)
            multiplayerLeft = value
        End Set
        Get
            Return multiplayerLeft
        End Get
    End Property
    Public Property playerMoveUp As Boolean
        Set(value As Boolean)
            multiplayerUp = value
        End Set
        Get
            Return multiplayerUp
        End Get
    End Property
    Public Property playerName As String
        Set(value As String)
            multiplayername = value
        End Set
        Get
            Return multiplayername
        End Get
    End Property

    Public Property playerScore As Integer
        Set(value As Integer)
            multiplayerScore = value
        End Set
        Get
            Return multiplayerScore
        End Get
    End Property
    Public Property playerjump As Integer
        Set(value As Integer)
            multiplayerjumpHeight = value
        End Set
        Get
            Return multiplayerjumpHeight
        End Get
    End Property
    Public Property playerLife As Integer
        Set(value As Integer)
            multiplayerLife = value
        End Set
        Get
            Return multiplayerLife
        End Get
    End Property
    Public Property playerItem As Integer
        Set(value As Integer)
            multiplayerItem = value
        End Set
        Get
            Return multiplayerItem
        End Get
    End Property
    Public Property playerGravitySpeed As Integer
        Set(value As Integer)
            multiplayerGravitySpeed = value
        End Set
        Get
            Return multiplayerGravitySpeed
        End Get
    End Property

    Public Property playerSpeed As Integer
        Set(value As Integer)
            multiplayerSpeed = value
        End Set
        Get
            Return multiplayerSpeed
        End Get
    End Property

    Public Property playerImage As Image
        Set(value As Image)
            multiPlayerimg = value
        End Set
        Get
            Return multiPlayerimg
        End Get
    End Property

End Class

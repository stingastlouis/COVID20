Public Class MyGameManager

    '--------------------------------------------------------------------------------------------------------vars
    Public Shared universalScore As Integer
    Private name As String
    Private life, score, item As Integer



    '--------------------------------------------------------------------------------------------------------setters getters
    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Life1 As Integer
        Get
            Return life
        End Get
        Set(value As Integer)
            life = value
        End Set
    End Property

    Public Property Score1 As Integer
        Get
            Return score
        End Get
        Set(value As Integer)
            score = value
        End Set
    End Property

    Public Property Item1 As Integer
        Get
            Return item
        End Get
        Set(value As Integer)
            item = value
        End Set
    End Property




    '--------------------------------------------------------------------------------------------------------constructors 'or Shared Sub New()
    Public Sub New(name As String) 'all new users
        Me.name = name
        Me.life = 3
        Me.score = 0
        Me.item = 0
    End Sub

    Public Sub New(name As String, life As Integer, score As Integer, item As Integer) 'lvl2 & lvl3
        Me.name = name
        Me.life = life
        Me.score = score
        Me.item = item
    End Sub



    '--------------------------------------------------------------------------------------------------------fns for the game







End Class

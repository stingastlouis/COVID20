Public Class ClassBoss
    Private width As Integer
    Private height As Integer

    Private life As Integer
    Private pos_X As Integer
    Private pos_Y As Integer
    Private bossFace As Bitmap
    Private moveSpeed As Integer
    Sub New()

    End Sub
    Public Sub New(ByRef pic As PictureBox, width As Integer, height As Integer, speed As Integer, img As Bitmap, life As Integer)
        Me.width = width
        Me.height = height
        Me.bossFace = img
        Me.pos_X = pos_X
        Me.pos_Y = pos_Y
        Me.moveSpeed = moveSpeed

        pic.Image = Me.bossFace
        pic.Width = Me.width
        pic.Height = Me.height
        pic.Location = New Point(pos_X, pos_Y)

    End Sub
    Public Sub New(xPosition As Integer, yPosition As Integer, moveSpeed As Integer, image As Bitmap) 'for new enemies image use this constructor
        Me.width = 87
        Me.height = 62
        Me.bossFace = image

        Me.pos_X = xPosition
        Me.pos_Y = yPosition

        Me.moveSpeed = moveSpeed
    End Sub



    Public Property bossWidth As Integer
        Set(value As Integer)
            Me.width = value
        End Set
        Get
            Return width
        End Get
    End Property
    Public Property bossHeight As Integer
        Set(value As Integer)
            Me.height = value
        End Set
        Get
            Return height
        End Get
    End Property





    Public Property bossLife As Integer
        Set(value As Integer)
            Me.life = value
        End Set
        Get
            Return life
        End Get
    End Property


    Public Property bossPosX As Integer
        Set(value As Integer)
            Me.pos_X = value
        End Set
        Get
            Return pos_X
        End Get
    End Property
    Public Property bossPosY As Integer
        Set(value As Integer)
            Me.pos_Y = value
        End Set
        Get
            Return pos_Y
        End Get
    End Property
    Public Property bossImage As Image
        Set(value As Image)
            Me.bossFace = value
        End Set
        Get
            Return bossFace
        End Get
    End Property

    Public Property bossSpeed As Integer
        Set(value As Integer)
            Me.moveSpeed = value
        End Set
        Get
            Return moveSpeed
        End Get
    End Property

    Public Function generateBoss()
        Dim bossPb As New ClassPictureBox(Me.width, Me.height, "boss", Me.pos_X, Me.pos_Y, Me.bossFace)
        Return bossPb.showPictureBox()
    End Function


    Public Sub bossAndEnemiesMoveTowardPlayer(ByRef contaminer As PictureBox, ByRef player As Object)
        If contaminer.Left + contaminer.Width > player.Left Then
            contaminer.Left -= moveSpeed
        End If
        If contaminer.Left + contaminer.Width < player.Left Then
            contaminer.Left += moveSpeed
        End If

    End Sub














    'Public Sub bossCollision(ByRef boss As PictureBox, ByRef player As PictureBox)
    '    bossAndEnemiesMoveTowardPlayer(boss, player)
    '    For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
    '        If activePictureBox IsNot boss AndAlso boss.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
    '            If activePictureBox.Name.Contains("wall") Then
    '                If boss.Left + boss.Width > player.Left Then
    '                    boss.Left += 1
    '                End If
    '                If boss.Left + boss.Width < player.Left Then
    '                    boss.Left -= 1
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub



End Class

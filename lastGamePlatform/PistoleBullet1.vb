Public Class PistoleBullet1

    Inherits PictureBox
    Dim bmp As Bitmap = My.Resources._5a3719ae33d594_4783473215135604942123
    Dim shootSpeed As Integer = 20
    Public Sub New(ByVal ob As Object)
        With Me
            .Size = New Size(10, 30)
            .Location = ob.Location
            .BackgroundImage = bmp
            .BackgroundImageLayout = ImageLayout.Stretch
            .BringToFront()
        End With


    End Sub
    Public Sub player1(ByVal ob1 As Object)
        With ob1
            .Size = New Size(10, 30)
            .Location = ob1.Location
            .BackgroundImage = bmp
            .BackgroundImageLayout = ImageLayout.Stretch

        End With
    End Sub
    Public Sub Shoot(ByVal b As Object)

        Me.Left += shootSpeed

        'If Not b.left <= 500 Then
        '    Me.Left -= shootSpeed
        'End If
    End Sub
    Public Sub Shoot2(ByVal aa As Object)

        Me.Left -= shootSpeed
    End Sub
End Class

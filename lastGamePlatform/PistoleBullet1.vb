Public Class PistoleBullet1

    Inherits PictureBox
    Dim bmp As Bitmap = My.Resources._5a3719ae33d594_4783473215135604942123
	Dim shootSpeed As Integer = 20
	Dim shootEnemy As Integer = 5
	Dim shootBoss As Integer = 10
	Public Sub New(ByVal ob As Object)
        With Me
            .Size = New Size(10, 30)
            .Location = New Point(ob.Width + ob.Left, ob.Top + 12)
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


	End Sub
    Public Sub Shoot2(ByVal aa As Object)

        Me.Left -= shootSpeed
    End Sub

	Public Sub bulletManager(ByRef Score As Integer, ByRef ProgressBar1 As ProgressBar, ByVal bullet1 As Array, ByVal player1 As Object, ByVal boss As Object, ByVal enemies As List(Of PictureBox))



		For x As Integer = 0 To bullet1.Length - 1 '????????????????????????????????????????bizin recheck sa array la
			bullet1(x).Shoot(player1)
			If Module1.checkforCollision(bullet1(x), boss) And boss.Enabled = True And bullet1(x).Enabled = True Then
				ProgressBar1.Value -= 1 '???????????????????????????????????????????????????????????????????p ggn exception kan boss mor
				If ProgressBar1.Value <= 0 Then
					ProgressBar1.Value = 0
				End If
				Score += shootBoss

				bullet1(x).Enabled = False
				bullet1(x).Dispose()
				boss.Enabled = False
			End If

			'For Each coin As PictureBox In coins
			'	If Module1.checkforCollision(bullet1(x), coin) And bullet1(x).Enabled And coin.Enabled Then
			'		bullet1(x).Dispose()
			'		Me.Controls.Remove(bullet1(x))
			'		bullet1(x).Enabled = False
			'	End If
			'Next
			For Each enemy As PictureBox In enemies
				If checkforCollision(bullet1(x), enemy) And bullet1(x).Enabled And enemy.Enabled Then
					Score += shootEnemy
					bullet1(x).Dispose()
					bullet1(x).Enabled = False
					'enemy.Enabled = False
					Me.Controls.Remove(enemy)

					ClassMyPublicShared.allPictureBoxes.Remove(enemy)

					Exit For ''----------------------------------------------------------------------------kifer exit----?mem zafr r break sa
					'Me.Controls.Remove(enemy)
				End If
			Next


			'	For Each life As PictureBox In lifes
			'		If checkforCollision(bullet1(x), life) And bullet1(x).Enabled And life.Enabled Then
			'			bullet1(x).Dispose()
			'			Me.Controls.Remove(bullet1(x))
			'			bullet1(x).Enabled = False
			'		End If
			'	Next

			'	For Each adn As PictureBox In adns 'scan all controls present in form
			'		If checkforCollision(bullet1(x), adn) And bullet1(x).Enabled And adn.Enabled Then
			'			bullet1(x).Dispose()
			'			Me.Controls.Remove(bullet1(x))
			'			bullet1(x).Enabled = False
			'		End If
			'	Next
			'	'-------------------------------------------
		Next


	End Sub
End Class

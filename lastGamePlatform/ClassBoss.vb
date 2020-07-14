Public Class ClassBoss
	Inherits ClassEnemies
	Dim returnTOposition As Integer = 0
	Dim moveOp As Integer
	Dim randomSpeed As Integer
	Sub New()
		moveOp = 1
	End Sub
	Public Property startTime As Integer
		Set(value As Integer)
			returnTOposition = value
		End Set
		Get
			Return returnTOposition
		End Get
	End Property


	Public Property howtomoveBoss As Integer
		Set(value As Integer)
			moveOp = value
		End Set
		Get
			Return moveOp
		End Get
	End Property


	Public Sub makeBossMove(ByVal player As Object, ByRef boss As Object, ByVal ground As Object, ByVal door As Object)

		returnTOposition += 1
		'Step 1:at start make player go backward and forward. 
		'STep 2: after 2 second make it go weird . go in diagonal way to player
		'Step 3: if boss hit boss make it do step number 1 
		Dim BackwardSpeed As Integer = 5
		Dim gen As New Random

		Dim moveOp As Integer
		'moveOp = gen.Next(2)

		Select Case Me.moveOp
			Case 0
				'go forward and backward on ground. 

				If returnTOposition > 2 And returnTOposition < 100 And Not boss.Bounds.IntersectsWith(player.Bounds) Then
					boss.Location = New Point(boss.Location.X - randomSpeed, boss.Location.Y)
				ElseIf boss.Bounds.IntersectsWith(player.Bounds) Then
					boss.Location = New Point(boss.Location.X + BackwardSpeed, boss.Location.Y)
					returnTOposition = 101

				ElseIf returnTOposition > 100 And returnTOposition < 200 And Not boss.Left + boss.Width > door.Left Then
					boss.Location = New Point(boss.Location.X + BackwardSpeed, boss.Location.Y)
				ElseIf boss.Left + boss.Width >= door.Left Then
					boss.Location = New Point(boss.Location.X - randomSpeed, boss.Location.Y)
					returnTOposition = 199
				End If
				If returnTOposition = 199 Then
					returnTOposition = 0
					randomSpeed += gen.Next(1, 5)
				End If
			Case 1
				Dim bouncing_Speed As Integer
				bouncing_Speed = 2
				'bounce on the ground 


				If Not boss.Bounds.IntersectsWith(player.Bounds) And returnTOposition > 2 And returnTOposition < 50 Then
					boss.Location = New Point(boss.Location.X - bouncing_Speed, boss.Location.Y - bouncing_Speed)

				ElseIf Not boss.Bounds.IntersectsWith(player.Bounds) And returnTOposition > 50 And returnTOposition < 100 Then
					boss.Location = New Point(boss.Location.X - bouncing_Speed, boss.Location.Y + bouncing_Speed)

				ElseIf boss.Bounds.IntersectsWith(ground.Bounds) And returnTOposition < 200 Then
					boss.Location = New Point(boss.Location.X - bouncing_Speed, boss.Location.Y - bouncing_Speed)


				ElseIf boss.Bounds.IntersectsWith(player.Bounds) Then

					returnTOposition = 200





				End If
				If returnTOposition > 200 Then
					If Not boss.Bounds.IntersectsWith(ground.Bounds) Then
						boss.Location = New Point(boss.Location.X + 1, boss.Location.Y + 1)
					ElseIf boss.Bounds.IntersectsWith(ground.Bounds) And Not boss.Bounds.IntersectsWith(door.Bounds) Then
						boss.Location = New Point(boss.Location.X + 5, boss.Location.Y)
					End If





					If boss.Bounds.IntersectsWith(door.Bounds) Then
						returnTOposition = 99
					End If
				End If

				If returnTOposition = 99 Then
					returnTOposition = 0
					randomSpeed += gen.Next(1, 5)
				End If


			Case 2
				Dim deadlySpeed As Integer = 7
				'chase the player. 
				If player.left < boss.left Then
					boss.Location = New Point(boss.Location.X - deadlySpeed, boss.Location.Y)
				End If
		End Select


		'If returnTOposition = 199 Then
		'	returnTOposition = 0
		'	randomSpeed += gen.Next(1, 5)
		'End If



		'If returnTOposition > 2 And returnTOposition < 100 Then
		'	boss.Location = New Point(boss.Location.X - randomSpeed, boss.Location.Y)
		'ElseIf returnTOposition > 100 And returnTOposition < 200 And Not boss.Left + boss.Width > door2.Left Then
		'	boss.Location = New Point(boss.Location.X + BackwardSpeed, boss.Location.Y)
		'End If




		'If boss.Location.X + boss.Width >= door2.Location.X Then
		'	boss.Location = New Point(boss.Location.X - randomSpeed, boss.Location.Y)
		'End If


		'If boss.Bounds.IntersectsWith(player1.Bounds) Then
		'	startLife -= 1
		'End If


		'If ProgressBar1.Value < 10 Then
		'	tmWeird += 1
		'	If tmWeird > 2 And tmWeird < 50 Then
		'		boss.Location = New Point(boss.Location.X - 1, boss.Location.Y + 1)
		'	End If

		'	If tmWeird > 50 And tmWeird < 100 Then
		'		boss.Location = New Point(boss.Location.X - 1, boss.Location.Y - 1)
		'	End If

		'	If tmWeird = 99 Then
		'		tmWeird = 0
		'	End If
		'End If



	End Sub

	Public Sub bulletIntersectsWithBoss(ByRef pro As ProgressBar, ByRef bullets As List(Of PictureBox), ByVal boss As Object)



		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(boss.Bounds) AndAlso boss.Visible Then
				ClassPlayer.score += ClassItems.scoreBoss
				If pro.Value > 0 Then
					pro.Value -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
				End If
				If pro.Value <= 0 Then
					pro.Value = 0
					Console.WriteLine("oo boss dead")
					ClassPlayer.score += ClassItems.scoreBoss
					ClassMyPublicShared.allPictureBoxes.Remove(boss)

				End If
				bullets.Remove(bullet)
				ClassMyPublicShared.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub





End Class

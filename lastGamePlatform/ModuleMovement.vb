Module ModuleMovement
	Private bulletMoveSpeed As Integer = 10
	Private moveOp As Integer = 0
	Dim returnTOposition As Integer = 0
	Dim randomSpeed As Integer = 1



	''' <summary>
	''' check player collision with...each time player change the position
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Public Sub player1_LocationChanged(sender As Object, e As EventArgs) ' Handles player1.LocationChanged
		ModuleIntersection.playerIntersectWithStaticPictureBoxes()
		'If (player1.Left >= supergun0.Left) AndAlso (boss.Visible = False) Then
		'	LabelBossLife.Visible = True
		'	LabelBossLife.Enabled = True
		'	ProgressBar1.Enabled = True
		'	ProgressBar1.Visible = True

		'	ModuleGameManager.boss.BackColor = Color.Empty
		'	Select Case ClassMyPublicShared.level
		'		Case 1
		'			ModuleGameManager.boss.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bosses\boss1.png"))
		'			Exit Select
		'		Case 2
		'			ModuleGameManager.boss.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bosses\boss2.png"))
		'			Exit Select
		'		Case 3
		'			ModuleGameManager.boss.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bosses\boss3.png"))
		'			Exit Select
		'	End Select
		'	ModuleGameManager.boss.BringToFront()
		'	ModuleGameManager.boss.Visible = True
		'End If
	End Sub






	'-keyboard button press/release
	''' <summary>
	''' once key is release on keyboard
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Public Sub myForm_KeyUp(sender As Object, e As KeyEventArgs)
		Select Case e.KeyValue
			Case Keys.Right
				ClassPlayer.posRight = False
				Exit Select
			Case Keys.Left
				ClassPlayer.posLeft = False
				Exit Select 'same as break
		End Select
	End Sub
	''' <summary>
	''' execute once key is pressed on keyboard
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Public Sub myForm_KeyDown(sender As Object, e As KeyEventArgs)
		Select Case e.KeyValue
			Case Keys.Right
				ClassPlayer.posRight = True

			Case Keys.Left
				If player1.Left > 0 Then
					ClassPlayer.posLeft = True
				Else : ClassPlayer.posLeft = True
				End If

			Case Keys.Up
				If Not ClassPlayer.playerIsFalling Then
					player1.Top -= ClassPlayer.jumpHeight
					ClassPlayer.playerIsFalling = True
				End If

			Case Keys.Q
				If (bullets.Count <= 10) AndAlso ClassPlayer.canShoot Then 'allow to shot only 10 bullets - reduce cpu usage and lag
					GenerateNewBullet(player1)
				End If

			Case Keys.Escape
				myForm.Close()
				startHere.Show()
		End Select
	End Sub
	'-end keyboard button press/release



	Public Sub MakeBossMove(ByVal player As Object, ByRef boss As Object, ByVal ground As Object, ByVal door As Object, ByVal movementOperation As Integer)
		moveOp = 0
		returnTOposition += 1

		'Step 1:at start make player go backward and forward. 
		'STep 2: after 2 second make it go weird . go in diagonal way to player
		'Step 3: if boss hit boss make it do step number 1 
		Dim BackwardSpeed As Integer = 5
		Dim gen As New Random


		'moveOp = gen.Next(2)

		Select Case moveOp
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






	''' <summary>
	''' makes all enemies move with there respective speed
	''' </summary>
	Public Sub EnemyMovement()
		For en As Integer = 0 To ModuleGameManager.enemies.Count - 1
			ModuleGameManager.enemies(en).Location = New Point(ModuleGameManager.enemies(en).Location.X - ModuleGameManager.enemiesSpeed(en), ModuleGameManager.enemies(en).Location.Y)
			If ModuleGameManager.enemies(en).Location.Y < ModuleGameManager.player1.Location.Y Then
				ModuleGameManager.enemies(en).Location = New Point(ModuleGameManager.enemies(en).Location.X, ModuleGameManager.enemies(en).Location.Y + ModuleGameManager.enemiesSpeed(en))
			End If
		Next
	End Sub

	''' <summary>
	''' make all bullet present in bullets list
	''' </summary>
	Public Sub BulletMovement()
		For Each bullet In ModuleGameManager.bullets
			bullet.Location = New Point(bullet.Location.X + bulletMoveSpeed, bullet.Location.Y) 'move the bullets
			If bullet.Location.X > ModuleGameManager.myForm.Width Then 'delete the bullets that goes after the right door
				ModuleGameManager.bullets.Remove(bullet) 'remove fro bullets<>
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub
End Module

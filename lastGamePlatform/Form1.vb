

Public Class Form1
	'list
	Dim walls As New List(Of PictureBox)
	Dim grounds As New List(Of PictureBox)


	'enemies var
	Dim enemies As New List(Of PictureBox)
	Dim enemiesSpeed As New List(Of Integer)


	'bullet vars
	Dim bullets As New List(Of PictureBox)
	Dim bulletMoveSpeed As Integer


	'player vars
	Dim playerIsFalling As Boolean
	Dim playerSpeed As Integer
	Dim gravitySpeed As Integer
	Dim jumpHeight As Integer
	Dim posLeft As Boolean
	Dim posRight As Boolean


	'score vars
	Public Score As Integer
	Dim Item_Collected As Integer
	Dim scoreGun As Integer
	Dim scoreEnemy As Integer
	Dim startLife As Integer
	Dim enemyScore As Integer


	'no of sec to wait 
	Dim waitBeforeFight As Integer


	'boss vars
	Dim moveTheBoss As Boolean = False






	''' <summary>
	''' when the form is loading
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		'name taken from register form
		'Dim lvl1 = New MyGameManager("John") 'name or name,life,score,item

		Console.WriteLine("clear main list of objects")
		ClassMyPublicShared.allPictureBoxes.Clear()

		Console.WriteLine("setting all parameters for the game")
		setGame()

		Console.WriteLine("pushing pictureboxes to main list of objects")
		Dim itm As New ClassItems()
		itm.scanPredefineItem()




		Console.WriteLine("updating the lists")
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes
			'seperating randomPictureBoxes to specific ones
			If activePictureBox.Name.Contains("ground") Then
				grounds.Add(activePictureBox) 'push to list
			ElseIf activePictureBox.Name.Contains("wall") Then
				walls.Add(activePictureBox) 'push to list
			ElseIf activePictureBox.Name.Contains("enemy") Then
				enemies.Add(activePictureBox)
			ElseIf activePictureBox.Name.Contains("boss") OrElse activePictureBox.Name.Contains("player") OrElse activePictureBox.Name.Contains("instruction") Then 'all pictureboxes to exclude here
			End If
		Next






	End Sub


	''' <summary>
	''' continue or restart button
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
		If RestartBtn.Text = "Restart" Then
			Me.Hide()
			Dim f1 = New Form1()
			f1.Show()
		End If
		If RestartBtn.Text = "Continue" Then
			Me.Close()
			Form2.Show()
		End If
	End Sub


	''' <summary>
	''' exit button reopen startHere form
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub extbtn_Click(sender As Object, e As EventArgs) Handles extbtn.Click
		Me.Hide()
		startHere.ShowDialog()
	End Sub


	''' <summary>
	''' once key is release on keyboard
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub mainCamera_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		Select Case e.KeyValue
			Case Keys.Right
				posRight = False
				Exit Select
			Case Keys.Left
				posLeft = False
				Exit Select 'same as break
		End Select
	End Sub


	''' <summary>
	''' execute once key is pressed on keyboard
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub mainCamera_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown '
		Select Case e.KeyValue
			Case Keys.Right
				posRight = True

			Case Keys.Left
				posLeft = True

			Case Keys.Up
				If Not playerIsFalling Then
					player1.Top -= jumpHeight
					playerIsFalling = True
				End If

			Case Keys.Q
				If (bullets.Count <= 10) Then
					Dim bullet As New ClassBullets(player1)
					Dim bulletpb As PictureBox = bullet.generateBullet()
					Me.Controls.Add(bulletpb)
					bullets.Add(bulletpb)
					My.Computer.Audio.Play(My.Resources._1, AudioPlayMode.Background)
				End If


			Case Keys.Escape
				Me.Close()
				startHere.Show()
		End Select
	End Sub








	''' <summary>
	''' check player collision with...each time player change the position
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub player1_LocationChanged(sender As Object, e As EventArgs) Handles player1.LocationChanged
		collideWithStaticPictureBoxes()


		If (player1.Left >= supergun0.Left) AndAlso (boss.Visible = False) Then
			Label1.Visible = True
			Label1.Enabled = True
			ProgressBar1.Enabled = True
			ProgressBar1.Visible = True

			boss.BackColor = Color.Empty
			boss.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\download.jpg"))
			boss.BringToFront()
			enemies.Add(boss)
			Dim bossMoveSpeed As Int16 = 1
			enemiesSpeed.Add(bossMoveSpeed)
			boss.Visible = True
		End If
	End Sub














	Private Sub Timer1000ms_Tick(sender As Object, e As EventArgs) Handles Timer1000ms.Tick
		Dim myGraphics As Graphics = Me.CreateGraphics
		Dim myFont As Font
		Dim myBrush As Brush
		myBrush = New SolidBrush(Color.Red)
		myFont = New Font("Verdana", 25, FontStyle.Italic)
		If waitBeforeFight <= 0 Then
			Timer1000ms.Enabled = False
			myGraphics.DrawString("Go", myFont, myBrush, Me.Width / 2, Me.Height / 2) 'go
			waitBeforeFight = ClassMyPublicShared.waitBeforeFight
			FastestTimer.Enabled = True
		End If
		myGraphics.DrawString(waitBeforeFight.ToString(), myFont, myBrush, Me.Width / 2, Me.Height / 2)  '3,2,1
		waitBeforeFight -= 1
	End Sub


	Private Sub FastestTimer_Tick(sender As Object, e As EventArgs) Handles FastestTimer.Tick
		If posRight Then
			player1.Location = New Point(player1.Location.X + playerSpeed, player1.Location.Y)
		ElseIf posLeft Then
			player1.Location = New Point(player1.Location.X - playerSpeed, player1.Location.Y)
		End If

		If playerIsFalling Then
			player1.Location = New Point(player1.Location.X, player1.Location.Y + gravitySpeed)
		End If

		If (player1.Left + player1.Width > Me.Width) Then
			For Each enemy In enemies
				removeOtherPictureBoxAndUpdateScore(enemy)
			Next
			For Each bullet In bullets
				removeOtherPictureBoxAndUpdateScore(bullet)
			Next
			enemies.Clear()
			enemiesSpeed.Clear()
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y)
				door2.Location = New Point(Me.Width - (door2.Width), door2.Location.Y)
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - Me.Width, activePictureBox.Location.Y)
			Next
			door1.BringToFront()
			door2.BringToFront()
			Dim noOfEnemies As Integer = numberOfEnemies()
			While noOfEnemies > 0
				Dim enemy As New ClassEnemies(numberBetween(Me.Width / 5, Me.Width - (door2.Width) - 1), numberBetween(0, ground1.Top - 62 - 1), "enemy" & noOfEnemies, enemyMoveSpeed())
				Dim en As PictureBox = enemy.generateEnemy()
				Me.Controls.Add(en)
				enemiesSpeed.Add(enemy.MoveSpeed1)
				enemies.Add(en)
				noOfEnemies -= 1
			End While
			FastestTimer.Enabled = False
			Timer1000ms.Enabled = True
		End If






		If enemies.Count > 0 Then
			enemyMovement() 'bizin re check to code logic
		End If

		If bullets.Count > 0 Then
			bulletMovement()
			bulletIntersectWithEnemy()
		End If
	End Sub

	Public Sub bulletIntersectWithEnemy()
		For Each enemy In enemies
			For Each bullet In bullets
				If bullet IsNot enemy AndAlso enemy.Bounds.IntersectsWith(bullet.Bounds) Then 'if player picturebox 
					If enemy.Name.Contains("boss") Then
						Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
					End If
					Console.WriteLine("bullet intersect enemy")
					Score += enemyScore
					bullets.Remove(bullet)
					enemies.Remove(enemy)
					removeOtherPictureBoxAndUpdateScore(bullet)
					removeOtherPictureBoxAndUpdateScore(enemy)
					Exit For
				End If

			Next
			Exit For
		Next
	End Sub
	Public Sub bulletMovement()
		For Each bullet In bullets
			bullet.Location = New Point(bullet.Location.X + bulletMoveSpeed, bullet.Location.Y)
			If bullet.Location.X > Me.Width Then
				bullets.Remove(bullet)
				removeOtherPictureBoxAndUpdateScore(bullet)
				Exit For
			End If
		Next
	End Sub
	Public Sub enemyMovement()
		For en As Integer = 0 To enemies.Count - 1
			'If player1 IsNot enemies(en) AndAlso enemies(en).Bounds.IntersectsWith(player1.Bounds) Then
			'	Console.WriteLine("player intersect with enemy")
			'	Exit For
			'End If
			'For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes  'list all controls in the form
			'	If activePictureBox IsNot enemies(en) AndAlso enemies(en).Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
			'		If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
			'			If enemies(en).Top > activePictureBox.Top - enemies(en).Height Then 'to stay on top of ground and wall
			'				enemies(en).Location = New Point(enemies(en).Location.X, activePictureBox.Top - enemies(en).Height)
			'			End If
			'			Exit For
			'		End If
			'		'If otherPicBox.Name.Contains("enemy") Then
			'		'	startLife -= 1
			'		'	Console.WriteLine("new enemy")
			'		'	enemies.Remove(otherPicBox)
			'		'	removeOtherPictureBoxAndUpdateScore(otherPicBox)
			'		'	Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
			'		'End If

			'	End If
			'Next




			'If enemies(en).Left > player1.Left Then
			'	enemies(en).Left -= enemiesSpeed(en)
			'ElseIf enemies(en).Left < player1.Left Then
			'	enemies(en).Left += enemiesSpeed(en)
			'End If' 
			'If enemies(en).Top > player1.Top Then
			'	enemies(en).Top -= enemiesSpeed(en)
			'ElseIf enemies(en).Top < player1.Top Then
			'	enemies(en).Top += enemiesSpeed(en)
			'End If

			'--------------------------------------------------------------------------------------------enkor tremblee mm
			'If enemies(en).Left > player1.Left + player1.Width And enemies(en).Top < player1.Top Then
			'	enemies(en).Left -= enemiesSpeed(en)
			'	enemies(en).Top += enemiesSpeed(en)
			'ElseIf enemies(en).Left > player1.Left + player1.Width And enemies(en).Top > player1.Top Then
			'	enemies(en).Left -= enemiesSpeed(en)
			'	enemies(en).Top -= enemiesSpeed(en)
			'ElseIf enemies(en).Left < player1.Left And enemies(en).Top < player1.Top Then
			'	enemies(en).Left += enemiesSpeed(en)
			'	enemies(en).Top += enemiesSpeed(en)
			'ElseIf enemies(en).Left < player1.Left And enemies(en).Top > player1.Top Then
			'	enemies(en).Left += enemiesSpeed(en)
			'	enemies(en).Top -= enemiesSpeed(en)
			'ElseIf enemies(en).Left > player1.Left And enemies(en).Top = player1.Top Then
			'	enemies(en).Left -= enemiesSpeed(en)
			'ElseIf enemies(en).Left < player1.Left And enemies(en).Top = player1.Top Then
			'	enemies(en).Left += enemiesSpeed(en)
			'End If


			'dans right 
			If enemies(en).Left > player1.Left + player1.Width And enemies(en).Top + enemies(en).Height < player1.Top + player1.Height Then
				If Not enemies(en).Top + enemies(en).Height = player1.Top + player1.Height Then
					enemies(en).Top += enemiesSpeed(en)


				End If

			Else
				enemies(en).Left -= enemiesSpeed(en)
			End If



			'------

			'dans left 

			'------




		Next
	End Sub




	'----pa bon will be deleted when bon

	Private Sub Timer75ms_Tick(sender As Object, e As EventArgs) Handles Timer75ms.Tick '50 - 20fps
		'If moveTheBoss Then

		'	Console.WriteLine(boss.Location)
		'	enemiesSpeed.Add(boss1.MoveSpeed1)
		'	enemies.Add(boss)
		'End If




	End Sub







	''' <summary>
	''' used in timer
	''' gather all controls - select all pictureboxes give a score as per proper pictureboxes - delete collided pictureboxes and update the lables
	''' </summary>
	Public Sub collideWithStaticPictureBoxes()
		playerIsFalling = True
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
			If activePictureBox IsNot player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					'Console.WriteLine("wall/ground")
					'????????????????????????????bizin dreC???????this code allow to pass through wall???? 1 zafr width sa???
					If player1.Top > activePictureBox.Top - player1.Height Then 'to stay on top of ground and wall
						player1.Location = New Point(player1.Location.X, activePictureBox.Top - player1.Height)
						playerIsFalling = False
					End If
					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then
					Item_Collected += 1
					startLife += 1
					Score += 1
					Console.WriteLine("new life")
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("gun") Then
					If activePictureBox.Name.Contains("supergun") Then
						Item_Collected += 100
						Score += 500
					Else
						Item_Collected += 1
						Score += 5
					End If
					Console.WriteLine("new gun")
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					Item_Collected += 1
					Score += 5
					Console.WriteLine("new adn")
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then
					Item_Collected += 1
					Score += 3
					Console.WriteLine("new coin")
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
			End If
		Next
	End Sub



	''' <summary>
	''' set all picture box
	''' enemies
	''' boss
	''' randomise item to be collected
	''' </summary>
	Private Sub setGame()
		RestartBtn.Enabled = False
		pScore.Text = "Item :" + CStr(Score)
		RestartBtn.Visible = False
		winorloseTxt.Visible = False
		extbtn.Visible = False
		ProgressBar1.Enabled = False
		ProgressBar1.Visible = False
		Label1.Visible = False
		Label1.Enabled = False
		boss.Visible = False
		Me.HorizontalScroll.Enabled = False
		Me.HorizontalScroll.Visible = False

		ProgressBar1.Value = 18
		'AxWindowsMediaPlayer1.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Dosseh - Le bruit du silence (Clip Officiel).wav")
		'AxWindowsMediaPlayer1.settings.setMode("Loop", True)

		playerIsFalling = True
		playerSpeed = 5
		gravitySpeed = 3
		jumpHeight = 100
		waitBeforeFight = ClassMyPublicShared.waitBeforeFight

		Score = 0
		scoreGun = 5
		scoreEnemy = 10
		startLife = 3
		enemyScore = 5

		ClassMyPublicShared.level = 1
		door2.Location = New Point(Me.Width - door2.Width / 2, door2.Location.Y)
		door2.BringToFront()
		Dim bullet As New ClassBullets()
		bulletMoveSpeed = bullet.MoveSpeed1
	End Sub



	''' <summary>
	''' remove the pictureboxes that the player collided with and update the labels
	''' </summary>
	Private Sub removeOtherPictureBoxAndUpdateScore(picBox As PictureBox)
		'removing the control
		ClassMyPublicShared.allPictureBoxes.Remove(picBox)
		Me.Controls.Remove(picBox)
		picBox.Dispose()
		updateLabels()
	End Sub



	''' <summary>
	''' refresh all lables
	''' </summary>
	Private Sub updateLabels()
		pScore.Text = "Score :" + CStr(Score)
		pLife.Text = "X" + CStr(startLife)
		pItem.Text = "Item :" + CStr(Item_Collected)

		If ProgressBar1.Value <= 0 Then
			ProgressBar1.Value = 0
			Timer75ms.Enabled = False
			winorloseTxt.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
			winorloseTxt.Visible = True

			RestartBtn.Text = "Continue"
			RestartBtn.Visible = True
			RestartBtn.Enabled = True
			winorloseTxt.Top = Me.Height / 2 - 60
			winorloseTxt.Left = Me.Width / 2 - 15
			RestartBtn.BringToFront()
			RestartBtn.Top = Me.Height / 2
			RestartBtn.Left = Me.Width / 2

			extbtn.Visible = True
			extbtn.Enabled = True
			extbtn.Text = "Abandon Mission"
			extbtn.Top = Me.Height / 2 + 30
			extbtn.Left = Me.Width / 2
			extbtn.BringToFront()

		ElseIf startLife <= 0 Then
			winorloseTxt.Text = "You Lose!!" + vbNewLine + "Try better Next Time"
			winorloseTxt.Visible = True

			RestartBtn.Text = "Restart"
			RestartBtn.Visible = True
			RestartBtn.Enabled = True
			RestartBtn.BringToFront()
			winorloseTxt.Top = Me.Height / 2 - 60
			winorloseTxt.Left = Me.Width / 2 - 15
			RestartBtn.Top = Me.Height / 2
			RestartBtn.Left = Me.Width / 2
			extbtn.Visible = True
			extbtn.Enabled = True
			extbtn.Text = "Abandon Mission"
			extbtn.Top = Me.Height / 2 + 30
			extbtn.Left = Me.Width / 2
			extbtn.BringToFront()
		End If
	End Sub
End Class

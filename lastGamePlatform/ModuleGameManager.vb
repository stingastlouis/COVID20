Module ModuleGameManager
	Public myForm As Form
	Public player1 As PictureBox
	Public boss As PictureBox
	Public enemies As New List(Of PictureBox)
	Public enemiesSpeed As New List(Of Integer)
	Public bullets As New List(Of PictureBox)



	Private pScore As Label
	Private pLife As Label
	Private pItem As Label
	Private walls As New List(Of PictureBox)
	Private mediaPlayer
	Private waitBeforeFight As Integer
	Private LabelBossLife As Label
	Private door2 As PictureBox
	Private door1 As PictureBox
	Private ground1 As PictureBox
	Private progressBar As ProgressBar
	Private myTimer As Timer
	Private timer3sec As Timer



	Private restBtn As New Button
	Private winorlosetText As New Label
	Private exitBtn As New Button



	Private countdownLabel As New Label








	Public Sub formLoader(currentForm As Form, score As Label, item As Label, player As PictureBox, progBar As ProgressBar, fTimer As Timer, sTimer As Timer, blife As Label, doorOne As PictureBox, doorTwo As PictureBox, bossPb As PictureBox, ground As PictureBox)
		myForm = currentForm

		Dim mp As New AxWMPLib.AxWindowsMediaPlayer
		mp.CreateControl()
		mp.uiMode = "invisible"
		mediaPlayer = mp

		Dim life As New Label '????????????????????????????????????????????????????????????????????????????????????fer pareil pou les auter control
		life.Location = New Point(87, 10)
		life.BackColor = Color.Empty
		life.Name = "pLife"
		life.Font = New Font("Microsoft Sans Serif", 14.25)
		life.Text = "X 3"
		life.AutoSize = True
		life.CreateControl()
		myForm.Controls.Add(life)
		pLife = life



		pScore = score
		pItem = item
		player1 = player
		progressBar = progBar
		myTimer = fTimer
		timer3sec = sTimer

		LabelBossLife = blife
		door1 = doorOne
		door2 = doorTwo
		boss = bossPb
		ground1 = ground




		ClassPlayer.playerIsFalling = True
		gameLoader()
	End Sub


	Private Sub gameLoader()
		Console.WriteLine("clear main list of objects")
		ClassMyPublicShared.allPictureBoxes.Clear()

		Console.WriteLine("setting all parameters for the game")
		progressBar.Value = 18
		mediaPlayer.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bgSound.wav")
		mediaPlayer.settings.setMode("Loop", True)

		waitBeforeFight = ClassMyPublicShared.waitBeforeFight

		ClassMyPublicShared.level = 1
		door2.Location = New Point(myForm.Width - door2.Width / 2, door2.Location.Y)
		door2.BringToFront()
		door2.BackColor = Color.Empty
		pScore.Text = "Score :" + CStr(ClassPlayer.score)
		pItem.Text = "Item :" + CStr(ClassPlayer.item)
		progressBar.Enabled = False
		progressBar.Visible = False
		LabelBossLife.Visible = False
		LabelBossLife.Enabled = False
		boss.Visible = False
		myForm.HorizontalScroll.Enabled = False '#################################################pa p marC
		myForm.HorizontalScroll.Visible = False '#################################################pa p marC

		Console.WriteLine("pushing pictureboxes to main list of objects")
		Dim itm As New ClassItems()
		itm.scanPredefineItem()

		Console.WriteLine("updating the lists")
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes
			'seperating randomPictureBoxes to specific ones
			If activePictureBox.Name.Contains("wall") Then
				walls.Add(activePictureBox) 'push to list
			ElseIf activePictureBox.Name.Contains("enemy") Then
				enemies.Add(activePictureBox)
				enemiesSpeed.Add(1)
			ElseIf activePictureBox.Name.Contains("boss") OrElse activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("player") OrElse activePictureBox.Name.Contains("instruction") Then 'all pictureboxes to exclude here
			End If
		Next
		'adding handlers
		AddHandler timer3sec.Tick, AddressOf Timer1000ms_Tick
		AddHandler myTimer.Tick, AddressOf FastestTimer_Tick
		AddHandler myForm.KeyUp, AddressOf ModuleMovement.myForm_KeyUp
		AddHandler myForm.KeyDown, AddressOf ModuleMovement.myForm_KeyDown
		AddHandler player1.LocationChanged, AddressOf ModuleMovement.player1_LocationChanged
		'?????????????????????????????????????????????????????????????????????????????????????????????????????AddHandler myForm.MyBase.FormClosed, AddressOf myForm_FormClosed
	End Sub


	Public Sub generateNewBullet(player)
		Dim bullet As New ClassBullets(player)
		Dim bulletpb As PictureBox = bullet.generateBullet()
		myForm.Controls.Add(bulletpb)
		ModuleGameManager.bullets.Add(bulletpb)
		My.Computer.Audio.Play(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bulletSound.wav"), AudioPlayMode.Background)
	End Sub


	Public Sub removePictureBoxAndUpdateScore(picBox)
		'removing the control
		ClassMyPublicShared.allPictureBoxes.Remove(picBox)
		myForm.Controls.Remove(picBox)
		picBox.Dispose()

		pScore.Text = "Score :" + CStr(ClassPlayer.score)
		pLife.Text = "X" + CStr(ClassPlayer.life)
		pItem.Text = "Item :" + CStr(ClassPlayer.item)

		If progressBar.Value <= 0 Then
			progressBar.Value = 0
			myTimer.Enabled = False

			With winorlosetText
				.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
				.Visible = True
				.Top = myForm.Height / 2 - 60
				.Left = myForm.Width / 2 - 15
				.Enabled = True
				.BringToFront()

			End With
			With restBtn
				.Text = "Continue"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2
				.Left = myForm.Width / 2
				.BringToFront()

			End With
			With exitBtn
				.Text = "Abandon Mission"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2 + 30
				.Left = myForm.Width / 2
				.BringToFront()
			End With
			myForm.Controls.Add(winorlosetText)
			myForm.Controls.Add(restBtn)
			myForm.Controls.Add(exitBtn)
			AddHandler restBtn.Click, AddressOf RestartBtn_Click
			AddHandler exitBtn.Click, AddressOf extbtn_Click
		End If
	End Sub


	Private Sub RestartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim btn As Button = CType(sender, Button) 'convert obj to button
		Dim nextForm As Form = myForm
		Select Case ClassMyPublicShared.level
			Case 1
				nextForm = Form2
				Exit Select
			Case 2
				nextForm = Form3
				Exit Select
			Case 3
				nextForm = bonusForm
				Exit Select
		End Select
		If btn.Text = "Restart" Then
			Dim restartForm As Form
			restartForm = myForm
			restartForm.Show()
			myForm.Close()
		ElseIf btn.Text = "Continue" Then
			nextForm.Show()
		End If
	End Sub


	Private Sub extbtn_Click(sender As Object, e As EventArgs)
		startHere.ShowDialog()
	End Sub


	'Private Sub myForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
	'	myForm.Dispose()
	'	startHere.Show()
	'	Console.WriteLine("close the form")
	'End Sub



	Private Sub Timer1000ms_Tick(sender As Object, e As EventArgs)
		If waitBeforeFight <= 0 Then
			countdownLabel.Text = "Go" 'go
			If waitBeforeFight < 0 Then
				timer3sec.Enabled = False
				waitBeforeFight = ClassMyPublicShared.waitBeforeFight
				myForm.Controls.Remove(countdownLabel)
				ClassPlayer.canShoot = True
				myTimer.Enabled = True
			End If
		Else : countdownLabel.Text = waitBeforeFight.ToString()  '3,2,1
		End If
		waitBeforeFight -= 1
	End Sub


	Private Sub FastestTimer_Tick(sender As Object, e As EventArgs)
		'-player move
		If ClassPlayer.posRight Then
			player1.Location = New Point(player1.Location.X + ClassPlayer.playerSpeed, player1.Location.Y)
		ElseIf ClassPlayer.posLeft Then
			player1.Location = New Point(player1.Location.X - ClassPlayer.playerSpeed, player1.Location.Y)
		End If

		If ClassPlayer.playerIsFalling Then
			player1.Location = New Point(player1.Location.X, player1.Location.Y + ClassPlayer.gravitySpeed)
		End If
		'-

		'-player pass through right door
		If (player1.Left + player1.Width > myForm.Width) Then
			For Each enemy In enemies 'remove all enemies from form and allPictureBoxes<> before left door
				removePictureBoxAndUpdateScore(enemy)
			Next
			For Each bullet In bullets 'remove all bullets from form and allPictureBoxes<>  before left door
				removePictureBoxAndUpdateScore(bullet)
			Next
			ModuleGameManager.enemies.Clear() 'remove everything in enemies<>
			ModuleGameManager.enemiesSpeed.Clear() 'remove everything in enemiesSpeed<>
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y) 'door appear on left
				door2.Location = New Point(myForm.Width - (door2.Width), door2.Location.Y) 'door appear on right
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - myForm.Width, activePictureBox.Location.Y) 'keep same ypos and display everything before the left door
			Next
			door1.BackColor = Color.Empty
			door2.BackColor = Color.Empty

			'--generate random no of enemies at random position with random move speed
			Dim noOfEnemies As Integer = ModuleRandomiser.numberOfEnemies()
			While noOfEnemies > 0
				Dim xpos As Integer = ModuleRandomiser.numberBetween(myForm.Width / 5, myForm.Width - (door2.Width) - 1) 'from 20% of the form to the right door
				Dim ypos As Integer = ModuleRandomiser.numberBetween(0, ground1.Top - 62 - 1) 'from top of the form to the top of the ground

				Dim enemy As New ClassEnemies(xpos, ypos, "enemy" & noOfEnemies, ModuleRandomiser.enemyMoveSpeed()) 'constructor with parameter(xPosition, yPosition, name, moveSpeed)
				Dim en As PictureBox = enemy.generateEnemy() 'generate enemy picture box
				myForm.Controls.Add(en) 'add the enemy generated to form
				ModuleGameManager.enemiesSpeed.Add(enemy.MoveSpeed1) 'retrive the movespeed of the enemy from constructor and add it to enemiesSpeed<>
				ModuleGameManager.enemies.Add(en) 'add the picturebox to enemies<>
				noOfEnemies -= 1 'decrement the no of enemies
			End While
			'--

			'--stop the time for 3 seconds to let the player prepare for the coming enemies
			myTimer.Enabled = False
			ClassPlayer.canShoot = False
			myForm.Controls.Add(countdownLabel)
			countdownLabel.Font = New Font("Verdana", 25, FontStyle.Italic)
			countdownLabel.ForeColor = Color.Red
			countdownLabel.AutoSize = True
			countdownLabel.Location = New Point(myForm.Width / 2, myForm.Height / 2)
			timer3sec.Enabled = True
			'--
		End If
		'-

		'-move the enemies only when there is/are enemies in the list
		If ModuleGameManager.enemies.Count > 0 Then
			ModuleMovement.enemyMovement()
		End If
		'-

		'-move the bullets when bullet is shot and check if bullet intersect with enemy or boss
		If ModuleGameManager.bullets.Count > 0 Then
			ModuleMovement.bulletMovement()
			ModuleIntersection.bulletIntersectWithEnemy()
			If boss.Visible Then
				'Dim bulletBoss As New ClassBoss
				ModuleIntersection.bulletIntersectsWithBoss(progressBar, bullets, boss)

				If progressBar.Visible Then
					Dim cB As New ClassBoss
					cB.howtomoveBoss = 2
					ModuleMovement.makeBossMove(player1, boss, ground1, door2)
					pScore.Text = "Score :" + CStr(ClassPlayer.score)
				End If
			End If
		End If
		'-
	End Sub


End Module

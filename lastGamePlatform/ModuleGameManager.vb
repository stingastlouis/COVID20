﻿Module ModuleGameManager
	Public myForm As Form
	Public player1 As PictureBox
	Public boss As PictureBox
	Public enemies As New List(Of PictureBox)
	Public enemiesSpeed As New List(Of Integer)
	Public bullets As New List(Of PictureBox)

	Public level As Integer = 0
	Public universalScore As Integer
	Public allPictureBoxes As New List(Of PictureBox)
	Public waitBeforeFight As Integer = 3 'number of second to wait before fight





	Private pScore As Label
	Private pLife As Label
	Private pItem As Label
	Private walls As New List(Of PictureBox)
	Private mediaPlayer As New AxWMPLib.AxWindowsMediaPlayer
	Private waitTime As Integer
	Private LabelBossLife As Label
	Private door2 As PictureBox
	Private instruction As PictureBox
	Private door1 As PictureBox
	Private supergun0 As PictureBox
	Private ground1 As PictureBox
	Private progressBar As ProgressBar
	Private myTimer As Timer
	Private timer3sec As Timer






	'------------delete unnessesary
	Private restBtn As New Button
	Private winorlosetText As New Label
	Private exitBtn As New Button
	Private countdownLabel As New Label
	Private ready_boss As Boolean = False
	'------------





	'-call this method on any form to play
	Public Sub FormLoader(currentForm As Form, myLevel As Int16)
		Console.WriteLine("clear main list of objects")
		ModuleGameManager.allPictureBoxes.Clear()


		Console.WriteLine("creating form")
		myForm = currentForm
		myForm.Width = 790
		myForm.Height = 520
		myForm.HorizontalScroll.Enabled = False '#################################################pa p marC
		myForm.HorizontalScroll.Visible = False '#################################################pa p marC


		level = myLevel

		Console.WriteLine("creating media player")
		mediaPlayer.CreateControl()
		mediaPlayer.uiMode = "invisible"
		'mediaPlayer.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bgSound.wav")
		'mediaPlayer.settings.setMode("Loop", True)


		'progress bar
		progressBar = CreateBossProgressBar(False, False, 18)

		'doors
		door1 = CreateDoor("door1")
		door2 = CreateDoor("door2")
		door2.Location = New Point(myForm.Width - door2.Width / 2, door2.Location.Y)
		door2.BackColor = Color.Empty

		'labels
		pLife = CreateLabel(30, 12, "pLife", "Johny X3")
		pScore = CreateLabel(140, 12, "pScore", "Score : ")
		pScore.Text = "Score :" + CStr(ClassPlayer.score)
		pItem = CreateLabel(250, 12, "pItem", "Item(s) : ")
		pItem.Text = "Item :" + CStr(ClassPlayer.item)
		LabelBossLife = CreateLabel(350, 13, "lblBoss", "Boss Life : ")
		LabelBossLife.Visible = False
		LabelBossLife.Enabled = False

		'pictureboxes
		instruction = CreatePicBoxes(420, 172, "instruction1", 215, 80, "instruction1")
		player1 = CreatePicBoxes(87, 62, "player1", 40, 235, "Players\player1Mov")
		ground1 = CreatePicBoxes(3950, 62, "ground1", 0, 400, "Grounds\ground" & level)
		supergun0 = CreatePicBoxes(101, 81, "supergun0", 3099, 243, "superGun")
		boss = CreatePicBoxes(173, 117, "boss", 3700, 200, "Bosses\boss" & level)
		boss.Visible = False
		boss.Location = New Point(4000, 300)

		'timers
		Console.WriteLine("creating timers")
		myTimer = CreateTimer(True, 10)
		timer3sec = CreateTimer(False, 1000)

		Console.WriteLine("other setting")
		waitTime = ModuleGameManager.waitBeforeFight
		ClassPlayer.playerIsFalling = True

		Console.WriteLine("pushing pictureboxes to main list of objects")
		Dim itm As New ClassItems()
		itm.itemsInForm(myForm)

		Console.WriteLine("updating the lists")
		itm.updateLists(walls, enemies, enemiesSpeed)

		Console.WriteLine("adding handlers to present gameobjects")
		AddHandlers()

		Console.WriteLine("form fully set!!!")
	End Sub





	'-functions
	Public Sub GenerateNewBullet(player)
		Dim bullet As New ClassBullets(player)
		Dim bulletpb As PictureBox = bullet.generateBullet()
		myForm.Controls.Add(bulletpb)
		ModuleGameManager.bullets.Add(bulletpb)
		My.Computer.Audio.Play(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bullets\bulletSound.wav"), AudioPlayMode.Background)
	End Sub

	Public Sub RemovePictureBoxAndUpdateScore(picBox As PictureBox)
		Console.WriteLine("removing the control " & picBox.Name.ToString)
		ModuleGameManager.allPictureBoxes.Remove(picBox)
		myForm.Controls.Remove(picBox)
		picBox.Dispose()

		Console.WriteLine("update lables")
		pScore.Text = "Score : " + CStr(ClassPlayer.score)
		pLife.Text = "Johny X" + CStr(ClassPlayer.life)
		pItem.Text = "Item : " + CStr(ClassPlayer.item)

		Console.WriteLine("Check If Win Or Lose")
		CheckIfWinOrLose()
	End Sub

	Private Sub StartCountdown()
		myTimer.Enabled = False
		ClassPlayer.canShoot = False
		myForm.Controls.Add(countdownLabel)
		countdownLabel.Font = New Font("Verdana", 25, FontStyle.Italic)
		countdownLabel.ForeColor = Color.Red
		waitTime = ModuleGameManager.waitBeforeFight
		countdownLabel.Text = waitTime.ToString
		countdownLabel.AutoSize = True
		countdownLabel.Location = New Point(myForm.Width / 2, myForm.Height / 2)
		timer3sec.Enabled = True
	End Sub

	Private Sub GenerateNewEnemies()
		Dim noOfEnemies As Integer = ModuleRandomiser.NumberOfEnemies()
		While noOfEnemies > 0
			Dim xpos As Integer = ModuleRandomiser.NumberBetween(myForm.Width / 5, myForm.Width - (door2.Width) - 1) 'from 20% of the form to the right door
			Dim ypos As Integer = ModuleRandomiser.NumberBetween(0, ground1.Top - 62 - 1) 'from top of the form to the top of the ground
			Dim enemy As New ClassEnemies(xpos, ypos, "enemy" & noOfEnemies, ModuleRandomiser.EnemyMoveSpeed()) 'constructor with parameter(xPosition, yPosition, name, moveSpeed)
			Dim en As PictureBox = enemy.generateEnemy() 'generate enemy picture box
			myForm.Controls.Add(en) 'add the enemy generated to form
			ModuleGameManager.enemiesSpeed.Add(enemy.MoveSpeed1) 'retrive the movespeed of the enemy from constructor and add it to enemiesSpeed<>
			ModuleGameManager.enemies.Add(en) 'add the picturebox to enemies<>
			noOfEnemies -= 1 'decrement the no of enemies
		End While
	End Sub

	Private Sub MoveTheDoors()
		For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes 'list all controls in the form
			door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y) 'door appear on left
			door2.Location = New Point(myForm.Width - (door2.Width), door2.Location.Y) 'door appear on right
			activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - myForm.Width, activePictureBox.Location.Y) 'keep same ypos and display everything before the left door
		Next
		door1.BackColor = Color.Empty
		door2.BackColor = Color.Empty
	End Sub

	Private Sub EmptyEnemyLists()
		For Each enemy In enemies 'remove all enemies from form and allPictureBoxes<> before left door
			RemovePictureBoxAndUpdateScore(enemy)
		Next
		ModuleGameManager.enemies.Clear() 'remove everything in enemies<>
		ModuleGameManager.enemiesSpeed.Clear()
	End Sub

	Private Sub MakeBossAppear()
		LabelBossLife.Visible = True
		LabelBossLife.Enabled = True
		progressBar.Enabled = True
		progressBar.Visible = True
		boss.Visible = True
		boss.Enabled = True

		'Dim bulletBoss As New ClassBoss
		ModuleMovement.MakeBossMove(player1, boss, ground1, door2, 2)
		ModuleIntersection.bulletIntersectsWithBoss(progressBar, bullets, boss)

		pScore.Text = "Score :" + CStr(ClassPlayer.score)
	End Sub

	Private Sub CheckIfWinOrLose()
		If progressBar.Value <= 0 Then
			myTimer.Enabled = False
			With winorlosetText
				.Text = Space(10) + "You win!!" + vbNewLine + "Ready For Next Level?"
				.Visible = True
				.Top = myForm.Height / 2 - 180
				.Left = myForm.Width / 2 - 230
				.Enabled = True
				.BringToFront()
				.AutoSize = True
				.BackColor = Color.Empty
				.Name = "winorlosetText"
				.Font = New Font("Agency FB", 50)
				.CreateControl()
			End With
			With restBtn
				.Text = "Continue"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2
				.Left = myForm.Width / 2 - 150
				.BringToFront()
				.Font = New Font("Agency FB", 16)
				.BackColor = Color.Empty
				.AutoSize = True
				.CreateControl()
			End With
			With exitBtn
				.Text = "Abandon Mission"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2 + 40
				.Left = myForm.Width / 2 - 170
				.Font = New Font("Agency FB", 16)
				.BackColor = Color.Empty
				.BringToFront()
				.AutoSize = True
				.CreateControl()
			End With

			myForm.Controls.Add(winorlosetText)
			myForm.Controls.Add(restBtn)
			myForm.Controls.Add(exitBtn)
			AddHandler restBtn.Click, AddressOf RestartBtn_Click
			AddHandler exitBtn.Click, AddressOf Extbtn_Click
		End If

		If ClassPlayer.life <= 0 Then
			ClassPlayer.life = 0
			myTimer.Enabled = False

			With winorlosetText
				.Text = "You lose!!" + vbNewLine + "Try better next Time"
				.Visible = True
				.Top = myForm.Height / 2 - 50
				.Left = myForm.Width / 2 - 15
				.Enabled = True
				.BringToFront()
				.AutoSize = True
				.BackColor = Color.Empty
				.Name = "winorlosetText"
				.Font = New Font("Agency FB", 16)
				.CreateControl()
			End With
			With restBtn
				.Text = "Restart"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2
				.Left = myForm.Width / 2
				.BringToFront()
				.Font = New Font("Agency FB", 16)
				.BackColor = Color.Empty
				.AutoSize = True
				.CreateControl()
			End With
			With exitBtn
				.Text = "Abandon Mission"
				.Visible = True
				.Enabled = True
				.Top = myForm.Height / 2 + 40
				.Left = myForm.Width / 2
				.Font = New Font("Agency FB", 16)
				.BackColor = Color.Empty
				.BringToFront()
				.AutoSize = True
				.CreateControl()
			End With

			myForm.Controls.Add(winorlosetText)
			myForm.Controls.Add(restBtn)
			myForm.Controls.Add(exitBtn)
			AddHandler restBtn.Click, AddressOf RestartBtn_Click
			AddHandler exitBtn.Click, AddressOf Extbtn_Click
		End If
	End Sub

	Private Function CreateLabel(x, y, Name, Text)
		Dim lbl As New Label
		With lbl
			.Location = New Point(x, y)
			.BackColor = Color.Empty
			.Name = Name
			.Font = New Font("Agency FB", 16)
			.Visible = True
			.Enabled = True
			.Text = Text
			.AutoSize = True
			.CreateControl()
		End With
		myForm.Controls.Add(lbl)
		Console.WriteLine("label " & Name & " created with text " & Text)
		Return lbl
	End Function

	Private Sub AddHandlers()
		AddHandler timer3sec.Tick, AddressOf Timer1000ms_Tick
		AddHandler myTimer.Tick, AddressOf FastestTimer_Tick
		AddHandler myForm.KeyUp, AddressOf ModuleMovement.myForm_KeyUp
		AddHandler myForm.KeyDown, AddressOf ModuleMovement.myForm_KeyDown
		AddHandler player1.LocationChanged, AddressOf ModuleMovement.player1_LocationChanged
		AddHandler myForm.FormClosed, AddressOf MyForm_FormClosed
	End Sub

	Private Function CreateBossProgressBar(Enabled, Visible, Value)
		Dim progBar As New ProgressBar
		With progBar
			.Location = New Point(450, 13)
			.BringToFront()
			.Name = "ProgressBar1"
			.Maximum = 18
			.Minimum = 0
			.Value = Value
			.Size = New Size(133, 28)
			.Visible = Visible
			.Enabled = Enabled
			.CreateControl()
		End With
		myForm.Controls.Add(progBar)
		Console.WriteLine("progress bar added to from")
		Return progBar
	End Function

	Private Function CreateDoor(Name)
		Dim door As New PictureBox With {
			.Location = New Point(2933, 49),
			.BackColor = Color.Empty,
			.Name = Name,
			.Size = New Size(2, 443),
			.Visible = False,
			.Enabled = True
		}
		door.SendToBack()
		myForm.Controls.Add(door)
		Console.WriteLine("door added to form")
		Return door
	End Function

	Private Function CreatePicBoxes(width, height, name, x, y, path)
		Dim pb As New ClassPictureBox(width, height, name, x, y, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\" & path & ".png")))
		Dim picbox As PictureBox = pb.showPictureBoxNoAdd()
		myForm.Controls.Add(picbox)
		Return picbox
	End Function

	Private Function CreateTimer(enable, interval)
		Dim timer As New Timer With {
		.Enabled = enable,
		.Interval = interval
	}
		Return timer
	End Function
	'-





	'-handlers function/sub
	Private Sub RestartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim btn As Button = CType(sender, Button) 'convert obj to button
		Dim nextForm As Form = myForm
		Select Case level
			Case 1
				'nextForm = Form2
				Exit Select
			Case 2
				'nextForm = Form3
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

	Private Sub Extbtn_Click(sender As Object, e As EventArgs)
		startHere.ShowDialog()
	End Sub

	Private Sub MyForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		myForm.Dispose()
		startHere.Show()
		Console.WriteLine("close the form")
	End Sub

	Private Sub Timer1000ms_Tick(sender As Object, e As EventArgs)
		If waitTime <= 0 Then
			countdownLabel.Text = "Go" 'go
			If waitTime < 0 Then
				myForm.Controls.Remove(countdownLabel)
				ClassPlayer.canShoot = True
				timer3sec.Enabled = False
				myTimer.Enabled = True
			End If
		Else : countdownLabel.Text = waitTime.ToString()  '3,2,1
		End If
		waitTime -= 1
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
			Console.WriteLine("clearing enemies lists")
			EmptyEnemyLists()

			Console.WriteLine("moving the doors")
			MoveTheDoors()

			Console.WriteLine("generate random no of enemies at random position with random move speed")
			GenerateNewEnemies()

			Console.WriteLine("stop the time for 3 seconds to let the player prepare for the coming enemies")
			StartCountdown()
		End If
		'-

		'-if  supergun is present boss appear
		If supergun0.Left < myForm.Width Then
			'Console.WriteLine("make the boss appear")
			MakeBossAppear()
			If player1.Left > myForm.Width Then
				ClassPlayer.posRight = False
			End If
		End If



		If ModuleGameManager.enemies.Count > 0 Then
			'Console.WriteLine("move the enemies only when there is/are enemies in the list")
			'Console.WriteLine("activate EnemyMovement() and EnemyIntersectWithPlayer()")
			ModuleMovement.EnemyMovement()
			'ModuleIntersection.EnemyIntersectWithPlayer()
		End If
		If ModuleGameManager.bullets.Count > 0 Then
			'Console.WriteLine("move the bullets when bullet is shot and check if bullet intersect with enemy or boss")
			'Console.WriteLine("activate BulletMovement() and BulletIntersectWithEnemy()")
			ModuleMovement.BulletMovement()
			ModuleIntersection.BulletIntersectWithEnemy()
		End If
		'-
	End Sub
	' end handlers function/sub


End Module

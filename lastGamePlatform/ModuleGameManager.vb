Module ModuleGameManager
	Public myForm As Form
	Public player1 As PictureBox
	Public boss As PictureBox
	Public enemies As New List(Of PictureBox)
	Public enemiesSpeed As New List(Of Integer)
	Public bullets As New List(Of PictureBox)

	Public level As Integer = 0


	Private pScore As Label
	Private pLife As Label
	Private pItem As Label
	Private walls As New List(Of PictureBox)
	Private mediaPlayer
	Private waitBeforeFight As Integer
	Private LabelBossLife As Label
	Private door2 As PictureBox
	Private instruction As PictureBox
	Private door1 As PictureBox
	Private supergun0 As PictureBox
	Private ground1 As PictureBox
	Private progressBar As ProgressBar

	Private myTimer As Timer
	Private timer3sec As Timer



	Private restBtn As New Button
	Private winorlosetText As New Label
	Private exitBtn As New Button



	Private countdownLabel As New Label


	Private ready_boss As Boolean = False





	Public Sub formLoader(currentForm As Form, myLevel As Int16)
		myForm = currentForm
		myForm.Width = 871
		myForm.Height = 520

		level = myLevel

		Dim mp As New AxWMPLib.AxWindowsMediaPlayer
		mp.CreateControl()
		mp.uiMode = "invisible"
		mediaPlayer = mp


		'=========Progress=Bar=Boss===================
		Dim prog As New ProgressBar
		With prog
			.Location = New Point(450, 13)
			.BringToFront()
			.Name = "ProgressBar1"
			.Maximum = 18
			.Minimum = 0
			.Value = 1
			.Size = New Size(133, 28)
			.Visible = True
			.Enabled = True
			.CreateControl()
		End With
		progressBar = prog
		myForm.Controls.Add(progressBar)
		'=================================


		'=========Door1==================
		Dim d1 As New PictureBox With {
			.Location = New Point(2933, 49),
			.BackColor = Color.Empty,
			.Name = "door2",
			.Size = New Size(2, 443),
			.Visible = False,
			.Enabled = True
		}
		d1.SendToBack()
		door1 = d1
		myForm.Controls.Add(door2)
		'=================================

		'=========Door2==================
		Dim d2 As New PictureBox With {
			.Location = New Point(2933, 49),
			.BackColor = Color.Empty,
			.Name = "door2",
			.Size = New Size(2, 443),
			.Visible = False,
			.Enabled = True
		}
		d2.SendToBack()
		door2 = d2
		myForm.Controls.Add(door2)
		'=================================


		'=========Life====================
		pLife = CreateLabel(30, 12, "pLife", "Johny X3")
		myForm.Controls.Add(pLife)
		'=================================

		'=========Score===================
		pScore = CreateLabel(140, 12, "pScore", "Score : ")
		myForm.Controls.Add(pScore)
		'=================================

		'=========Item===================
		pItem = CreateLabel(250, 12, "pItem", "Item(s) : ")
		myForm.Controls.Add(pItem)
		'================================

		'=========boss=label===================
		LabelBossLife = CreateLabel(350, 13, "lblBoss", "Boss Life : ")
		myForm.Controls.Add(LabelBossLife)
		'=================================



		'=========instruction=to=user===================
		Dim instruct As New ClassPictureBox(420, 172, "instruction1", 215, 80, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\instruction1.png")))
		instruction = instruct.showPictureBoxNoAdd()
		myForm.Controls.Add(instruction)
		'=================================



		'=========Player==================
		Dim ppl As New ClassPictureBox(87, 62, "player1", 40, 235, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Players\player1Mov.png")))
		player1 = ppl.showPictureBoxNoAdd()
		myForm.Controls.Add(player1)
		'=================================



		'=========Ground==================
		Dim gg As New ClassPictureBox(3950, 62, "ground1", 0, 400, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Grounds\ground" & level & ".png")))
		ground1 = gg.showPictureBoxNoAdd()
		myForm.Controls.Add(ground1)
		'=================================

		'=========SuperGun==================
		Dim sg As New ClassPictureBox(101, 81, "supergun0", 3099, 243, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\superGun.png")))
		supergun0 = sg.showPictureBoxNoAdd()
		myForm.Controls.Add(supergun0)
		'=================================

		'=========boss==================s
		Dim bs As New ClassPictureBox(173, 117, "boss", 3700, 200, Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bosses\boss" & level & ".png")))
		boss = bs.showPictureBoxNoAdd()
		myForm.Controls.Add(boss)
		'=================================




		''============Timer 1 ===============

		Dim tm1 As New Timer With {
			.Enabled = False,
			.Interval = 1000
		}
		timer3sec = tm1
		''=================================

		''============Timer 2 ===============

		Dim tm2 As New Timer With {
			.Enabled = True,
			.Interval = 10
		}
		myTimer = tm2
		''=================================



		'myTimer = fTimer
		'timer3sec = sTimer

		ClassPlayer.playerIsFalling = True
		gameLoader()
	End Sub


	Private Sub gameLoader()
		Console.WriteLine("clear main list of objects")
		ClassMyPublicShared.allPictureBoxes.Clear()

		Console.WriteLine("setting all parameters for the game")

		mediaPlayer.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bgSound.wav")
		mediaPlayer.settings.setMode("Loop", True)

		waitBeforeFight = ClassMyPublicShared.waitBeforeFight

		door2.Location = New Point(myForm.Width - door2.Width / 2, door2.Location.Y)
		door2.BackColor = Color.Empty
		pScore.Text = "Score :" + CStr(ClassPlayer.score)
		pItem.Text = "Item :" + CStr(ClassPlayer.item)
		progressBar.Enabled = False
		progressBar.Visible = False
		progressBar.Value = 18
		LabelBossLife.Visible = False
		LabelBossLife.Enabled = False
		boss.Visible = False

		myForm.HorizontalScroll.Enabled = False '#################################################pa p marC
		myForm.HorizontalScroll.Visible = False '#################################################pa p marC
		boss.Location = New Point(4000, 300)

		Console.WriteLine("pushing pictureboxes to main list of objects")
		Dim itm As New ClassItems()
		itm.itemsInForm(myForm)

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


	Public Sub GenerateNewBullet(player)
		Dim bullet As New ClassBullets(player)
		Dim bulletpb As PictureBox = bullet.generateBullet()
		myForm.Controls.Add(bulletpb)
		ModuleGameManager.bullets.Add(bulletpb)
		My.Computer.Audio.Play(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bullets\bulletSound.wav"), AudioPlayMode.Background)
	End Sub


	Public Sub RemovePictureBoxAndUpdateScore(picBox)
		'removing the control
		ClassMyPublicShared.allPictureBoxes.Remove(picBox)
		myForm.Controls.Remove(picBox)
		picBox.Dispose()

		pScore.Text = "Score : " + CStr(ClassPlayer.score)
		pLife.Text = "Johny X" + CStr(ClassPlayer.life)
		pItem.Text = "Item : " + CStr(ClassPlayer.item)

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


	'Private Sub myForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
	'	myForm.Dispose()
	'	startHere.Show()
	'	Console.WriteLine("close the form")
	'End Sub
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
		Return lbl
	End Function


	Private Sub Timer1000ms_Tick(sender As Object, e As EventArgs)
		If waitBeforeFight <= 0 Then
			countdownLabel.Text = "Go" 'go
			If waitBeforeFight < 0 Then
				waitBeforeFight = ClassMyPublicShared.waitBeforeFight
				myForm.Controls.Remove(countdownLabel)
				ClassPlayer.canShoot = True
				timer3sec.Enabled = False
				myTimer.Enabled = True
			End If
		Else : countdownLabel.Text = waitBeforeFight.ToString()  '3,2,1
		End If
		waitBeforeFight -= 1
		ModuleIntersection.bulletIntersectWithEnemy()
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
				RemovePictureBoxAndUpdateScore(enemy)
			Next
			For Each bullet In bullets 'remove all bullets from form and allPictureBoxes<>  before left door
				RemovePictureBoxAndUpdateScore(bullet)
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
		'-if boss collects supergun. 
		If player1.Left > supergun0.Left Then
			LabelBossLife.Visible = True
			LabelBossLife.Enabled = True
			progressBar.Enabled = True
			progressBar.Visible = True
			boss.Visible = True
			boss.Enabled = True

			'Dim bulletBoss As New ClassBoss
			ModuleMovement.makeBossMove(player1, boss, ground1, door2, 2)
			ModuleIntersection.bulletIntersectsWithBoss(progressBar, bullets, boss)

			pScore.Text = "Score :" + CStr(ClassPlayer.score)
		End If











		'-move the bullets when bullet is shot and check if bullet intersect with enemy or boss
		If ModuleGameManager.bullets.Count > 0 Then
			ModuleMovement.bulletMovement()
			ModuleIntersection.bulletIntersectWithEnemy()

		End If
		'-
	End Sub


End Module

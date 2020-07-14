

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


	'label vars
	Public Score As Integer
	'Dim itemCollected As Integer
	'Dim startLife As Integer


	'score vars
	Dim scoreEnemy As Integer
	Dim scoreGun As Integer
	Dim scoreSuperGun As Integer
	Dim scoreLife As Integer
	Dim scoreCoin As Integer
	Dim scoreAdn As Integer


	'no of sec to wait normally 3
	Dim waitBeforeFight As Integer


	'boss vars
	Dim moveTheBoss As Boolean = False
	Dim scoreBoss As Integer
	Dim tmWeird As Integer = 0 'number of sec for boss movement 

	Dim randomSpeed As Integer = 1

	'------------------------------------------------------------------------------

	'-buttons exit and restart
	''' <summary>
	''' continue or restart button
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	'Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
	'	If RestartBtn.Text = "Restart" Then
	'		Me.Close()
	'		Dim f1 = New Form1()
	'		f1.Show()
	'	End If
	'	If RestartBtn.Text = "Continue" Then
	'		Me.Close()
	'		Form2.Show()
	'	End If
	'End Sub


	''' <summary>
	''' exit button reopen startHere form
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub extbtn_Click(sender As Object, e As EventArgs) Handles extbtn.Click

		startHere.ShowDialog()
	End Sub
	'-end buttons exit and restart













	'-keyboard button press/release
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
				If (bullets.Count <= 10) Then 'allow to shot only 10 bullets - reduce cpu usage and lag
					Dim bullet As New ClassBullets(player1)
					Dim bulletpb As PictureBox = bullet.generateBullet()
					Me.Controls.Add(bulletpb)
					bullets.Add(bulletpb)
					My.Computer.Audio.Play(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bulletSound.wav"), AudioPlayMode.Background)
				End If

			Case Keys.Escape
				Me.Close()
				startHere.Show()
		End Select
	End Sub
	'-end keyboard button press/release










	''' <summary>
	''' when the form is loading
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' 
	Public Shared clPlayer As New ClassPlayer()
	Private Sub setPlayer()
		clPlayer.playerItem = 0

		clPlayer.playerScore = 0

		clPlayer.playerLife = 3
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Console.WriteLine("clear main list of objects")
		ClassMyPublicShared.allPictureBoxes.Clear()






		Console.WriteLine("setting all parameters for the game")
		ProgressBar1.Value = 18
		AxWindowsMediaPlayer1.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\bgSound.wav")
		AxWindowsMediaPlayer1.settings.setMode("Loop", True)

		playerIsFalling = True
		playerSpeed = 5
		gravitySpeed = 3
		jumpHeight = 100
		waitBeforeFight = ClassMyPublicShared.waitBeforeFight

		'-labels 


		''-score for items
		'scoreGun = 5
		'scoreSuperGun = 10
		'scoreEnemy = 10
		'scoreLife = 3
		'scoreCoin = 5
		'scoreAdn = 5
		'scoreBoss = 50

		ClassMyPublicShared.level = 1
		door2.Location = New Point(Me.Width - door2.Width / 2, door2.Location.Y)
		door2.BringToFront()
		door2.BackColor = Color.Empty
		'Dim bullet As New ClassBullets()
		'bulletMoveSpeed = bullet.MoveSpeed1 'get the move speed of bullets
		RestartBtn.Enabled = False
		pScore.Text = "Score :" + CStr(clPlayer.playerScore)
		pItem.Text = "Item :" + CStr(clPlayer.playerItem)
		RestartBtn.Visible = False
		winorloseTxt.Visible = False
		extbtn.Visible = False
		ProgressBar1.Enabled = False
		ProgressBar1.Visible = False
		Label1.Visible = False
		Label1.Enabled = False
		boss.Visible = False
		Me.HorizontalScroll.Enabled = False '#################################################pa p marC
		Me.HorizontalScroll.Visible = False '#################################################pa p marC

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
				enemiesSpeed.Add(1)
			ElseIf activePictureBox.Name.Contains("boss") OrElse activePictureBox.Name.Contains("player") OrElse activePictureBox.Name.Contains("instruction") Then 'all pictureboxes to exclude here
			End If
		Next
	End Sub



	''' <summary>
	''' check player collision with...each time player change the position
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub player1_LocationChanged(sender As Object, e As EventArgs) Handles player1.LocationChanged
		'collideWithStaticPictureBoxes()
		playerIsFalling = True
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
			If activePictureBox IsNot player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					If player1.Top > activePictureBox.Top - player1.Height Then 'to stay on top of ground and wall
						player1.Location = New Point(player1.Location.X, activePictureBox.Top - player1.Height)
						playerIsFalling = False
					End If
					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then
					clPlayer.playerItem += 1
					'startLife += 1
					clPlayer.playerLife += 1 'updated
					clPlayer.playerScore += ClassItems.scoreLife
					Console.WriteLine("new life")
					'removePictureBoxAndUpdateScore(activePictureBox)
					Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("gun") Then
					If activePictureBox.Name.Contains("supergun") Then
						clPlayer.playerScore += ClassItems.scoreSuperGun
					Else
						clPlayer.playerScore += ClassItems.scoreGun
					End If
					clPlayer.playerItem += 1
					Console.WriteLine("new gun")
					'removePictureBoxAndUpdateScore(activePictureBox)
					Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					clPlayer.playerItem += 1
					clPlayer.playerScore += ClassItems.scoreAdn
					Console.WriteLine("new adn")
					'removePictureBoxAndUpdateScore(activePictureBox)
					Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then
					clPlayer.playerItem += 1
					clPlayer.playerScore += ClassItems.scoreCoin
					Console.WriteLine("new coin")
					'removePictureBoxAndUpdateScore(activePictureBox)
					Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
			End If
		Next

		If (player1.Left >= supergun0.Left) AndAlso (boss.Visible = False) Then
			Label1.Visible = True
			Label1.Enabled = True
			ProgressBar1.Enabled = True
			ProgressBar1.Visible = True

			boss.BackColor = Color.Empty
			boss.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Bosses\boss1.png"))
			boss.BringToFront()
			boss.Visible = True
		End If
	End Sub

	'-my timers
	''' <summary>
	''' display 3,2,1,go
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
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
		'-player move
		If posRight Then
			player1.Location = New Point(player1.Location.X + playerSpeed, player1.Location.Y)
		ElseIf posLeft Then
			player1.Location = New Point(player1.Location.X - playerSpeed, player1.Location.Y)
		End If

		If playerIsFalling Then
			player1.Location = New Point(player1.Location.X, player1.Location.Y + gravitySpeed)
		End If
		'-

		'-player pass through right door
		If (player1.Left + player1.Width > Me.Width) Then
			For Each enemy In enemies 'remove all enemies from form and allPictureBoxes<> before left door
				'removePictureBoxAndUpdateScore(enemy)
				Module1.removePictureBoxandUpdateScore(enemy, Me, pScore, pLife, pItem)
			Next
			For Each bullet In bullets 'remove all bullets from form and allPictureBoxes<>  before left door
				'removePictureBoxAndUpdateScore(bullet)
				Module1.removePictureBoxandUpdateScore(bullet, Me, pScore, pLife, pItem)
			Next
			enemies.Clear() 'remove everything in enemies<>
			enemiesSpeed.Clear() 'remove everything in enemiesSpeed<>
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y) 'door appear on left
				door2.Location = New Point(Me.Width - (door2.Width), door2.Location.Y) 'door appear on right
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - Me.Width, activePictureBox.Location.Y) 'keep same ypos and display everything before the left door
			Next
			door1.BackColor = Color.Empty
			door2.BackColor = Color.Empty

			'--generate random no of enemies at random position with random move speed
			Dim noOfEnemies As Integer = ModuleRandomiser.numberOfEnemies()
			While noOfEnemies > 0
				Dim xpos As Integer = ModuleRandomiser.numberBetween(Me.Width / 5, Me.Width - (door2.Width) - 1) 'from 20% of the form to the right door
				Dim ypos As Integer = ModuleRandomiser.numberBetween(0, ground1.Top - 62 - 1) 'from top of the form to the top of the ground

				Dim enemy As New ClassEnemies(xpos, ypos, "enemy" & noOfEnemies, ModuleRandomiser.enemyMoveSpeed()) 'constructor with parameter(xPosition, yPosition, name, moveSpeed)
				Dim en As PictureBox = enemy.generateEnemy() 'generate enemy picture box
				Me.Controls.Add(en) 'add the enemy generated to form
				enemiesSpeed.Add(enemy.MoveSpeed1) 'retrive the movespeed of the enemy from constructor and add it to enemiesSpeed<>
				enemies.Add(en) 'add the picturebox to enemies<>
				noOfEnemies -= 1 'decrement the no of enemies
			End While
			'--

			'--stop the time for 3 seconds to let the player prepare for the coming enemies
			FastestTimer.Enabled = False
			Timer1000ms.Enabled = True
			'--
		End If
		'-

		'-move the enemies only when there is/are enemies in the list
		If enemies.Count > 0 Then
			enemyMovement()
		End If
		'-

		'-move the bullets when bullet is shot and check if bullet intersect with enemy or boss
		If bullets.Count > 0 Then

			Dim enemybullet As New ClassBullets
			enemybullet.bulletMovement(bullets, Me)

			enemybullet.bulletIntersectWithEnemy(enemies, bullets)
			If boss.Visible Then
				Dim bulletBoss As New ClassBoss
				bulletBoss.bulletIntersectsWithBoss(ProgressBar1, bullets, boss)
			End If
		End If
		'-
	End Sub


	Private Sub Timer75ms_Tick(sender As Object, e As EventArgs) Handles Timer75ms.Tick '----pa bon will be deleted when bon
		Module1.checkGameStatus(ProgressBar1, clPlayer.playerLife, Timer75ms)
		If ProgressBar1.Visible Then
			Dim cB As New ClassBoss
			cB.howtomoveBoss = 2
			cB.makeBossMove(player1, boss, ground1, door2)
			pScore.Text = "Score :" + CStr(ClassPlayer.score)
		End If
	End Sub
	'-end my timers

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
			'		If activePictureBox.Name.Contains("enemy") Then
			'			'startLife -= 1
			'			clPlayer.playerLife -= 1
			'			Console.WriteLine("new enemy")
			'			enemies.Remove(activePictureBox)
			'			removePictureBoxAndUpdateScore(activePictureBox)
			'			Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
			'		End If

			'	End If
			'Next


			If enemies(en).Location.Y < player1.Location.Y Then
				enemies(en).Location = New Point(enemies(en).Location.X, enemies(en).Location.Y + enemiesSpeed(en))
			End If
			enemies(en).Location = New Point(enemies(en).Location.X - enemiesSpeed(en), enemies(en).Location.Y)
		Next
	End Sub



	''' <summary>
	''' remove the pictureboxes that the player collided with and update the labels
	''' </summary>
	'Private Sub removePictureBoxAndUpdateScore(picBox As PictureBox)
	'	'removing the control
	'	ClassMyPublicShared.allPictureBoxes.Remove(picBox)
	'	Me.Controls.Remove(picBox)
	'	picBox.Dispose()


	'	pScore.Text = "Score :" + CStr(clPlayer.playerScore)
	'	'pLife.Text = "X" + CStr(startLife)
	'	pLife.Text = "X" + CStr(clPlayer.playerLife)
	'	pItem.Text = "Item :" + CStr(clPlayer.playerItem)

	'	If ProgressBar1.Value <= 0 Then
	'		ProgressBar1.Value = 0
	'		Timer75ms.Enabled = False
	'		winorloseTxt.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
	'		winorloseTxt.Visible = True

	'		RestartBtn.Text = "Continue"
	'		RestartBtn.Visible = True
	'		RestartBtn.Enabled = True
	'		winorloseTxt.Top = Me.Height / 2 - 60
	'		winorloseTxt.Left = Me.Width / 2 - 15
	'		RestartBtn.BringToFront()
	'		RestartBtn.Top = Me.Height / 2
	'		RestartBtn.Left = Me.Width / 2

	'		extbtn.Visible = True
	'		extbtn.Enabled = True
	'		extbtn.Text = "Abandon Mission"
	'		extbtn.Top = Me.Height / 2 + 30
	'		extbtn.Left = Me.Width / 2
	'		extbtn.BringToFront()

	'	ElseIf clPlayer.playerLife <= 0 Then
	'		winorloseTxt.Text = "You Lose!!" + vbNewLine + "Try better Next Time"
	'		winorloseTxt.Visible = True

	'		RestartBtn.Text = "Restart"
	'		RestartBtn.Visible = True
	'		RestartBtn.Enabled = True
	'		RestartBtn.BringToFront()
	'		winorloseTxt.Top = Me.Height / 2 - 60
	'		winorloseTxt.Left = Me.Width / 2 - 15
	'		RestartBtn.Top = Me.Height / 2
	'		RestartBtn.Left = Me.Width / 2
	'		extbtn.Visible = True
	'		extbtn.Enabled = True
	'		extbtn.Text = "Abandon Mission"
	'		extbtn.Top = Me.Height / 2 + 30
	'		extbtn.Left = Me.Width / 2
	'		extbtn.BringToFront()
	'	End If
	'End Sub

	Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Me.Dispose()
		startHere.Show()
	End Sub
End Class

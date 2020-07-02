﻿

Public Class Form1
	'list
	Dim walls As New List(Of PictureBox)
	Dim grounds As New List(Of PictureBox)


	Dim enemies As New List(Of PictureBox)
	Dim enemiesSpeed As New List(Of Integer)


	'player vars
	Dim playerIsFalling As Boolean = True
	Dim playerSpeed As Integer = 5
	Dim cameraSpeed As Integer = 3 + playerSpeed
	Dim gravitySpeed As Integer = 3
	Dim jumpHeight As Integer = 100
	Dim IsJumping As Boolean = False


	'score vars
	Dim scoreGun As Integer = 5
	Dim scoreEnemy As Integer = 10
	Dim startLife As Integer = 3
	Dim enemyScore As Integer = 5


	'boss vars
	Dim moveTheBoss As Boolean = False





	'bullet vars
	Dim bullets As New List(Of PictureBox)
	Dim bulletMoveSpeed As Integer




	'no of sec to wait 
	Dim waitBeforeFight As Integer = ClassMyPublicShared.waitBeforeFight




	Dim allowToshotShotGUNl As Boolean = False

	Public Score As Integer = 0



	'Dim shotGun() As PictureBox
	'Dim bulletNumber As Integer = -1
	'Dim bullet1(-1) As PistoleBullet1


	'--------------------------

	'---------VARIABLE-----------
	Dim posLeft, posRight As Boolean
	Dim Item_Collected As Integer
	Dim pointRegenerator As Point
	'Dim pp As Player
	Dim count1 As Integer


	'Private getEnemyScore As Integer
	'Dim generator As Integer
	'Dim count As Integer
	'Dim Player_Name As String
	'Dim bulletArray1ForShotGun(5) As PictureBox
	'Dim timerCount As Integer
	'Dim timer1, timer2, timer3 As Integer
	'Dim ran1 As New Random
	'Dim loc As New Integer
	'Private timeLimit As Integer
	'Private timeLimit2 As Integer
	'Private timeLimit3 As Integer


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
		updateAllLists()

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
				Console.WriteLine("try with classbullet()")
				Dim bullet As New ClassBullets(player1)
				Dim bulletpb As PictureBox = bullet.generateBullet()
				Me.Controls.Add(bulletpb)
				bullets.Add(bulletpb)
				Console.WriteLine(player1.Location)


				'If allowToshotShotGUNl = True And Item_Collected >= 2 Then
				'	ReDim Preserve bullet1(count1)
				'	Dim boulette As New PistoleBullet1(player1)
				'	Controls.Add(boulette)
				'	bullet1(count1) = boulette
				'	count1 += 1
				'	If count1 = 10 Then
				'		allowToshotShotGUNl = False
				'		count1 = 0
				'		Item_Collected = 0
				'		updateLabels()
				'	End If
				'End If

			Case Keys.Escape
				Me.Close()
				startHere.Show()
		End Select
		'redim = li p redeclare aray la . to rappele la haut ti 0 ?
		'???????????????????????????????????????????servi list<> pou boucoup pli facil pa bizin redeclar li chack foi li fr moins travail???????????????????????????????????????????????????

	End Sub







	''' <summary>
	''' check player collision with...each time player change the position
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub player1_LocationChanged(sender As Object, e As EventArgs) Handles player1.LocationChanged
		collideWithStaticPictureBoxes()
		'@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@pou re me t sa
		'If otherPicBox.Name.Contains("enemy") Then
		'	startLife -= 1
		'	Console.WriteLine("new enemy")
		'	enemies.Remove(otherPicBox)
		'	removeOtherPictureBoxAndUpdateScore(otherPicBox)
		'	Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
		'End If

		'If activePictureBox.Name.Contains("boss") Then
		'	startLife = 0
		'	Console.WriteLine("collide with boss and die")
		'	updateLabels()
		'	Exit For 'exit the for loop as picturebox name contains "boss" help in using less cpu power
		'End If
		'@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
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
				ClassMyPublicShared.allPictureBoxes.Remove(enemy)
			Next
			For Each bullet In bullets
				ClassMyPublicShared.allPictureBoxes.Remove(bullet)
			Next
			enemies.Clear()
			enemiesSpeed.Clear()
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y)
				door2.Location = New Point(Me.Width - (door2.Width), door2.Location.Y)
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - Me.Width, activePictureBox.Location.Y)
			Next
			Dim noOfEnemies As Integer = numberOfEnemies()
			While noOfEnemies > 0
				Dim enemy As New ClassEnemies(numberBetween(Me.Width / 5, Me.Width - (door2.Width / 2) - 1), numberBetween(0, ground1.Top - 1), "enemy" & noOfEnemies, enemyMoveSpeed())
				Dim en As PictureBox = enemy.generateEnemy()
				Me.Controls.Add(en)
				enemiesSpeed.Add(enemy.MoveSpeed1)
				enemies.Add(en)
				noOfEnemies -= 1
			End While
			FastestTimer.Enabled = False
			Timer1000ms.Enabled = True
		End If

		enemyMovement()


	End Sub




	'------------------------------------------------------------------------------------pa bon
	Private Sub Timer75ms_Tick(sender As Object, e As EventArgs) Handles Timer75ms.Tick '50 - 20fps
		If moveTheBoss Then
			bossAndEnemiesMoveTowardPlayer(boss)
		End If

		If (player1.Left >= beforeBoss.Left + beforeBoss.Width) Then '?????????????????????????????????????bizin recheck sa la
			Label1.Visible = True
			Label1.Enabled = True
			ProgressBar1.Enabled = True
			ProgressBar1.Visible = True
			boss.Enabled = True
			supergun0.Enabled = True
			supergun0.Visible = True
			moveTheBoss = True
		End If





		Dim eneC As New ClassEnemies
		eneC.getLives(startLife)
		eneC.collisionPlayer(player1, enemies)


		startLife = eneC.submitLives()



		'Dim mono As New PistoleBullet1(player1)
		'mono.bulletManager(bullet1, player1, boss, enemies, coins, lifes, adns)

		'Score = mono.setScore(Score)



		'mono.bosslifeRequire(ProgressBar1)
		'ProgressBar1.Value = mono.setBossLife(ProgressBar1)
		'updateLabels()

		bulletMovement()
	End Sub



	Public Sub bulletMovement()
		For Each bullet In bullets
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				If activePictureBox IsNot bullet AndAlso bullet.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
					If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
						bullets.Remove(bullet)
						removeOtherPictureBoxAndUpdateScore(bullet)
						Exit For
					End If

				End If
			Next

			For Each enemy In enemies 'list all controls in the form
				If enemy IsNot bullet AndAlso bullet.Bounds.IntersectsWith(enemy.Bounds) Then 'if player picturebox intersects with other pictureboxes
					Console.WriteLine("bullet intersect enemy")
					Score += enemyScore
					enemies.Remove(enemy)
					removeOtherPictureBoxAndUpdateScore(bullet)
					removeOtherPictureBoxAndUpdateScore(enemy)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power

				End If
			Next



			If bullet.Location.X > Me.Width Then
				bullets.Remove(bullet)
				Exit For
			Else
				bullet.Location = New Point(bullet.Location.X + bulletMoveSpeed, bullet.Location.Y)
				Exit For
			End If
		Next
	End Sub





	Public Sub enemyMovement()
		For en As Integer = 0 To enemies.Count - 1
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes  'list all controls in the form
				If activePictureBox IsNot enemies(en) AndAlso enemies(en).Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
					If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
						Console.WriteLine("wall/ground")

						If enemies(en).Top > activePictureBox.Top - enemies(en).Height Then 'to stay on top of ground and wall
							enemies(en).Location = New Point(enemies(en).Location.X, activePictureBox.Top - enemies(en).Height)
						End If
						Exit For
					End If
				End If
			Next
			If enemies(en).Left > player1.Left Then
				enemies(en).Left -= enemiesSpeed(en)
			ElseIf enemies(en).Left < player1.Left Then
				enemies(en).Left += enemiesSpeed(en)
			End If
			If enemies(en).Top > player1.Top Then
				enemies(en).Top -= enemiesSpeed(en)
			ElseIf enemies(en).Top < player1.Top Then
				enemies(en).Top += enemiesSpeed(en)
			End If
		Next
	End Sub



	'for enemy and boss
	Public Sub bossAndEnemiesMoveTowardPlayer(ByRef contaminer As Object)
		If contaminer.left + contaminer.Width > player1.Left Then
			contaminer.left -= 1
		End If
		If contaminer.left + contaminer.Width < player1.Left Then
			contaminer.left += 1
		End If


		'li p checker cote player la eT par rapport a enemy . si player dans droite li pou vers li . si li dans gauche li pou al vers li 
		'aster le temps li p bouger si li ggn un wall devant li, li pas pou kav passer . 
		'?????????????????????????????????????????????????????'makeEnemyMove() pa rent ladan????????????????
		'b sem la bas em mo p servi la . li p suivre player mais en meme temps dans makemyenemymove li p donne li gravity et cheK si pendant gravity 
		'li p collide ek un wall lerla. li faire li reste lor wall la

	End Sub








	'''''######################################################################################will be deleted
	Public Sub updateAllLists()
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

	'''''######################################################################################will be in classboss
	Public Sub bossCollision()
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
			If activePictureBox IsNot boss AndAlso boss.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("wall") Then
					If boss.Left + boss.Width > player1.Left Then
						boss.Left += 1
					End If
					If boss.Left + boss.Width < player1.Left Then
						boss.Left -= 1
					End If
				End If
			End If
		Next
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
					Item_Collected += 1
					Console.WriteLine("new gun")
					If activePictureBox.Enabled Then
						Score += scoreGun
						allowToshotShotGUNl = True
					End If
					If supergun0.Enabled = True Then
						allowToshotShotGUNl = True
						Item_Collected = 2 '?????????????????????????????????????????????????????????????????????????????????????????? score + 100 ??????????? pa pli bon ????????
					End If
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
		supergun0.Visible = False
		lastItem1.Visible = False
		supergun0.Enabled = False
		lastItem1.Enabled = False
		pScore.Text = "Item :" + CStr(Score)
		RestartBtn.Visible = False
		winorloseTxt.Visible = False
		extbtn.Visible = False
		ProgressBar1.Enabled = False
		ProgressBar1.Visible = False
		Label1.Visible = False
		Label1.Enabled = False
		boss.Enabled = False

		ProgressBar1.Value = 18 '??????????????????????????????????????????????????????????????????????????????????????????????ki li fr sa
		'My.Computer.Audio.Play(My.Resources.Dosseh___Le_bruit_du_silence__Clip_Officiel_, AudioPlayMode.BackgroundLoop) 

		ClassMyPublicShared.level = 1
		door2.Location = New Point(Me.Width - door2.Width / 2, door2.Location.Y)
		Dim bullet As New ClassBullets()
		bulletMoveSpeed = bullet.MoveSpeed1
	End Sub



	''' <summary>
	''' remove the pictureboxes that the player collided with and update the labels
	''' </summary>
	''' <param name="otherPicBox">picturebox to remove</param>
	Private Sub removeOtherPictureBoxAndUpdateScore(otherPicBox As PictureBox)
		'removing the control
		ClassMyPublicShared.allPictureBoxes.Remove(otherPicBox)
		Me.Controls.Remove(otherPicBox)
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

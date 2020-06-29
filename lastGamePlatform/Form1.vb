

Public Class Form1
	'list
	Dim walls As New List(Of PictureBox)
	Dim grounds As New List(Of PictureBox)
	Dim enemies As New List(Of PictureBox)
	Dim coins As New List(Of PictureBox)
	Dim lifes As New List(Of PictureBox)
	Dim guns As New List(Of PictureBox)
	Dim adns As New List(Of PictureBox)


	'Dim allMyControls As New List(Of Control)
	'Dim allPictureBoxes As New List(Of PictureBox)


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


	'boss vars
	Dim moveTheBoss As Boolean = False





	'bullet vars
	Dim bulletNumber As Integer = -1


	'
	Dim waitBeforeFight As Integer = ClassMyPublicShared.waitBeforeFight




	Dim allowToshotShotGUNl As Boolean = False

	Public Score As Integer = 0

	Dim bullet1(-1) As PistoleBullet1

	'Dim shotGun() As PictureBox
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
		Dim gatheringItems As New ClassItems()
		gatheringItems.populatingAllPictureBoxes()



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
				If allowToshotShotGUNl = True And Item_Collected >= 2 Then
					ReDim Preserve bullet1(count1)
					Dim boulette As New PistoleBullet1(player1)
					Controls.Add(boulette)
					bullet1(count1) = boulette
					count1 += 1
					If count1 = 10 Then
						allowToshotShotGUNl = False
						count1 = 0
						Item_Collected = 0
						updateLabels()
					End If
				End If

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
		collisionChecker()
	End Sub














	Private Sub Timer1000ms_Tick(sender As Object, e As EventArgs) Handles Timer1000ms.Tick
		If waitBeforeFight <= 0 Then
			Timer1000ms.Enabled = False
			Console.WriteLine("go")
			waitBeforeFight = ClassMyPublicShared.waitBeforeFight
			FastestTimer.Enabled = True
		End If
		Console.WriteLine(waitBeforeFight)
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
			enemies.Clear()
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form

				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y)
				door2.Location = New Point(Me.Width - (door2.Width), door2.Location.Y)
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - Me.Width, activePictureBox.Location.Y)
			Next

			Dim noOfEnemies As Integer = numberOfEnemies()
			Console.WriteLine(noOfEnemies & " enemies")
			While noOfEnemies > 0
				Dim xPos As Integer = numberBetween(Me.Width / 5, Me.Width - (door2.Width / 2) - 1) 'start 20% to (door2 -1)
				Dim yPos As Integer = ground1.Top - 60

				Dim enemyGenerated As New ClassEnemy(xPos, yPos, "enemy" & noOfEnemies, 3)
				Dim enemyPictureBox As PictureBox = enemyGenerated.generatePictureBox()
				Me.Controls.Add(enemyPictureBox)
				ClassMyPublicShared.allPictureBoxes.Add(enemyPictureBox)
				enemies.Add(enemyPictureBox)

				noOfEnemies -= 1
			End While
			FastestTimer.Enabled = False
			Timer1000ms.Enabled = True
		End If


		If (player1.Left >= beforeBoss.Left + beforeBoss.Width) Then '?????????????????????????????????????bizin recheck sa la
			Label1.Visible = True
			Label1.Enabled = True
			ProgressBar1.Enabled = True
			ProgressBar1.Visible = True
			boss.Enabled = True
			supergun.Enabled = True
			supergun.Visible = True
			moveTheBoss = True
		End If
	End Sub




	'------------------------------------------------------------------------------------pa bon
	Private Sub Timer75ms_Tick(sender As Object, e As EventArgs) Handles Timer75ms.Tick '50 - 20fps
		If moveTheBoss Then
			bossAndEnemiesMoveTowardPlayer(boss)
		End If





		Dim enemy As New ClassEnemy()
		enemy.makeEnemyMoves()

		'bulletManager() 'too much loop
	End Sub





	'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++pren la jus k lot++++++sa banlamm ki p fr zoue la lourd la====248-370



	Private Sub bulletManager()
		For x As Integer = 0 To bullet1.Length - 1 '????????????????????????????????????????bizin recheck sa array la
			bullet1(x).Shoot(player1)
			If checkforCollision(bullet1(x), boss) And boss.Enabled = True And bullet1(x).Enabled = True Then
				ProgressBar1.Value -= 1 '???????????????????????????????????????????????????????????????????p ggn exception kan boss mor
				If ProgressBar1.Value <= 0 Then
					ProgressBar1.Value = 0
				End If
				Score += 30 * 0.5
				updateLabels()
				bullet1(x).Enabled = False
				bullet1(x).Dispose()
				boss.Enabled = False
			End If

			For Each coin As PictureBox In coins
				If checkforCollision(bullet1(x), coin) And bullet1(x).Enabled And coin.Enabled Then
					bullet1(x).Dispose()
					Me.Controls.Remove(bullet1(x))
					bullet1(x).Enabled = False
				End If
			Next
			For Each enemy As PictureBox In enemies
				If checkforCollision(bullet1(x), enemy) And bullet1(x).Enabled And enemy.Enabled Then
					Score += scoreEnemy
					bullet1(x).Dispose()
					bullet1(x).Enabled = False
					'enemy.Enabled = False
					Me.Controls.Remove(enemy)
					enemies.Remove(enemy)
					ClassMyPublicShared.allPictureBoxes.Remove(enemy)
					updateLabels()
					Exit For ''----------------------------------------------------------------------------kifer exit----?mem zafr r break sa
					'Me.Controls.Remove(enemy)
				End If
			Next


			For Each life As PictureBox In lifes
				If checkforCollision(bullet1(x), life) And bullet1(x).Enabled And life.Enabled Then
					bullet1(x).Dispose()
					Me.Controls.Remove(bullet1(x))
					bullet1(x).Enabled = False
				End If
			Next

			For Each adn As PictureBox In adns 'scan all controls present in form
				If checkforCollision(bullet1(x), adn) And bullet1(x).Enabled And adn.Enabled Then
					bullet1(x).Dispose()
					Me.Controls.Remove(bullet1(x))
					bullet1(x).Enabled = False
				End If
			Next
			'-------------------------------------------
		Next
	End Sub

	'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++jus k la++++++



	'for enemy and boss
	Private Sub bossAndEnemiesMoveTowardPlayer(ByRef contaminer As Object)
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



	''' <summary>
	''' return true if the 2 obj collide else return false
	''' </summary>
	''' <param name="ob1"></param>
	''' <param name="ob2"></param>
	''' <returns></returns>
	Function checkforCollision(ByVal ob1 As Object, ByVal ob2 As Object) As Boolean
		If ob1.Top + ob1.Height >= ob2.Top - 5 And ob2.Top + ob2.Height >= ob1.Top And ob1.Left + ob1.Width >= ob2.Left And ob2.Left + ob2.Width >= ob1.Left Then
			Return True
		End If
		Return False
	End Function





	'''''######################################################################################will be deleted
	Private Sub updateAllLists()
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes
			'seperating randomPictureBoxes to specific ones
			If activePictureBox.Name.Contains("adn") Then
				adns.Add(activePictureBox)
			ElseIf activePictureBox.Name.Contains("coin") Then
				coins.Add(activePictureBox)
			ElseIf activePictureBox.Name.Contains("life") Then
				lifes.Add(activePictureBox)
			ElseIf activePictureBox.Name.Contains("gun") Then
				guns.Add(activePictureBox)
			ElseIf activePictureBox.Name.Contains("ground") Then
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
	Private Sub bossCollision()
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
	Private Sub collisionChecker()
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

				If activePictureBox.Name.Contains("life") Then
					Item_Collected += 1
					startLife += 1
					Score += 1
					Console.WriteLine("new life")
					lifes.Remove(activePictureBox)
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
					If supergun.Enabled = True Then
						allowToshotShotGUNl = True
						Item_Collected = 2 '?????????????????????????????????????????????????????????????????????????????????????????? score + 100 ??????????? pa pli bon ????????
					End If
					guns.Remove(activePictureBox)
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					Item_Collected += 1
					Score += 5
					Console.WriteLine("new adn")
					adns.Remove(activePictureBox)
					removeOtherPictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then
					Item_Collected += 1
					Score += 3
					Console.WriteLine("new coin")
					coins.Remove(activePictureBox)
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
		supergun.Visible = False
		lastItem1.Visible = False
		supergun.Enabled = False
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

		ProgressBar1.Value = 20 '??????????????????????????????????????????????????????????????????????????????????????????????ki li fr sa
		'My.Computer.Audio.Play(My.Resources.Dosseh___Le_bruit_du_silence__Clip_Officiel_, AudioPlayMode.BackgroundLoop) 

		ClassMyPublicShared.level = 1
		door2.Location = New Point(Me.Width - door2.Width / 2, door2.Location.Y)
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

		If (ProgressBar1.Value <= 0) Then
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


		ElseIf (startLife <= 0) Then
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

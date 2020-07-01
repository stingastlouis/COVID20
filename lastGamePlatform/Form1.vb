

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
		Dim itm As New ClassItems()
		itm.scanPredefineItem()


		Console.WriteLine("try with classbullet()")
		Dim bullet As New ClassBullets(player1)
		Dim bulletpb As PictureBox = bullet.generateBullet()
		Me.Controls.Add(bulletpb)




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
						updateLabels(Timer75ms, ProgressBar1, pScore, pLife, pItem, Score, startLife, Item_Collected)
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
			enemies.Clear()
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
				door1.Location = New Point(0 - (door1.Width / 2), door1.Location.Y)
				door2.Location = New Point(Me.Width - (door2.Width), door2.Location.Y)
				activePictureBox.Location = New Point(activePictureBox.Location.X + player1.Width + door1.Width / 2 - Me.Width, activePictureBox.Location.Y)
			Next

			Dim noOfEnemies As Integer = numberOfEnemies()
			While noOfEnemies > 0
				Dim enemy As New ClassEnemy(numberBetween(Me.Width / 5, Me.Width - (door2.Width / 2) - 1), numberBetween(0, ground1.Top - 1), "enemy" & noOfEnemies, 3)
				Dim en As PictureBox = enemy.generateEnemy()
				Me.Controls.Add(en)
				enemies.Add(en)

				noOfEnemies -= 1
			End While
			FastestTimer.Enabled = False
			Timer1000ms.Enabled = True
		End If



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


		For Each en In enemies
			Console.WriteLine(en.Name)
		Next

		Dim enemy As New ClassEnemy()
		enemy.makeEnemyMoves(enemies, player1) ''''movespeed pa p marC recheck sa


		'Dim mono As New PistoleBullet1(player1)
		'mono.bulletManager(Score, ProgressBar1, bullet1, player1, boss, enemies, coins, lifes, adns)

	End Sub


	'ohh makarena  bam bam ====


	'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++pren la jus k lot++++++sa banlamm ki p fr zoue la lourd la====248-370





	'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++jus k la++++++



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



	''' <summary>
	''' return true if the 2 obj collide else return false
	''' </summary>
	''' <param name="ob1"></param>
	''' <param name="ob2"></param>
	''' <returns></returns>





	'''''######################################################################################will be deleted
	Public Sub updateAllLists()
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
	Public Sub collisionChecker()
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
					If supergun0.Enabled = True Then
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
		updateLabels(Timer75ms, ProgressBar1, pScore, pLife, pItem, Score, startLife, Item_Collected)
	End Sub



	''' <summary>
	''' refresh all lables
	''' </summary>
	Private Sub updateLabels(ByRef timer As Timer, ByRef progressbar1 As ProgressBar, ByRef lblscore As Label, ByRef lbllife As Label, ByRef lblItem As Label, ByRef score As Integer, ByRef life As Integer, ByRef item As Integer)
		pScore.Text = "Score :" + CStr(score)
		pLife.Text = "X" + CStr(startLife)
		pItem.Text = "Item :" + CStr(Item_Collected)
		'Dim winOrlose As New Label
		'Dim btnSucess As New Button
		'Dim btnExit As New Button


		If progressbar1.Value <= 0 Then
			progressbar1.Value = 0
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

		End If

		If startLife <= 0 Then

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

		'If (progressbar1.Value <= 0) Then
		'	progressbar1.Value = 0
		'	Timer75ms.Enabled = False


		'	'	With winOrlose
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
		'	'		.Visible = True
		'	'		.Enabled = True

		'	'		.Top = Me.Height / 2 - 60
		'	'		.Left = Me.Width / 2 - 15
		'	'		.BringToFront()

		'	'	End With
		'	'	Me.Controls.Add(winOrlose)

		'	'	With btnSucess
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Text = "Continue"
		'	'		.Visible = True
		'	'		.Enabled = True


		'	'		.Top = Me.Height / 2
		'	'		.Left = Me.Width / 2
		'	'		.BringToFront()
		'	'	End With
		'	'	Me.Controls.Add(btnSucess)


		'	'	With btnExit
		'	'		.Text = "Abandon Mission"
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Top = Me.Height / 2 + 30
		'	'		.Left = Me.Width / 2
		'	'		.BringToFront()
		'	'		.Enabled = True
		'	'		.Visible = True
		'	'	End With
		'	'	Me.Controls.Add(btnExit)




		'	'ElseIf (startLife <= 0) Then

		'	'	With winOrlose
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Text = "You Lose!!" + vbNewLine + "Try better Next Time"
		'	'		.Visible = True
		'	'		.Enabled = True

		'	'		.Top = Me.Height / 2 - 60
		'	'		.Left = Me.Width / 2 - 15
		'	'		.BringToFront()

		'	'	End With
		'	'	Me.Controls.Add(winOrlose)
		' btnSucess.Click,addressOf btn_naame


		'	'	With btnSucess
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Text = "Restart"
		'	'		.Visible = True
		'	'		.Enabled = True
		'	'		.Top = Me.Height / 2
		'	'		.Left = Me.Width / 2
		'	'		.BringToFront()
		'	'	End With
		'	'	Me.Controls.Add(btnSucess)
		'	'	AddHandler btnSucess.Click,addressOf btn_naame 


		'	'	With btnExit
		'	'		.Text = "Abandon Mission"
		'	'		.Width = 165
		'	'		.Height = 65
		'	'		.Top = Me.Height / 2 + 30
		'	'		.Left = Me.Width / 2
		'	'		.BringToFront()
		'	'		.Enabled = True
		'	'		.Visible = True
		'	'	End With
		'	'	Me.Controls.Add(btnExit)
		'AddHandler btnSucess.Click,addressOf btn_naame

		'End If
	End Sub




End Class

﻿Public Class mainCamera
	'list
	Dim walls As New List(Of PictureBox)
	Dim grounds As New List(Of PictureBox)
	Dim enemies As New List(Of PictureBox)
	Dim coins As New List(Of PictureBox)
	Dim lifes As New List(Of PictureBox)
	Dim guns As New List(Of PictureBox)
	Dim adns As New List(Of PictureBox)


	Dim allMyControls As New List(Of Control)
	Dim allActivePictureBoxes As New List(Of PictureBox)


	'player vars
	Dim playerIsFalling As Boolean
	Dim Speed As Integer
	Dim gravitySpeed As Integer


	Dim moveTheBoss As Boolean = False


	'my items' scores
	Dim scoreGun As Integer
	Dim scoreEnemy As Integer











	Dim allowToshotShotGUNl As Boolean
	Dim bullet1(-1) As PistoleBullet1

	'Dim shotGun() As PictureBox
	'--------------------------

	'---------VARIABLE-----------
	Dim posLeft, posRight, IsJumping As Boolean
	Dim jumpHeight As Integer
	Dim Life_Point As Integer
	Dim Item_Collected As Integer
	Public Score As Integer
	Dim pointRegenerator As Point
	Public universalScore As Integer
	Dim pp As Player
	Dim bulletNumber As Integer
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
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
		'name taken from register form
		'Dim lvl1 = New MyGameManager("John") 'name or name,life,score,item
		setGame()
		setPictureBoxes()

	End Sub


	''' <summary>
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
		If RestartBtn.Text = "Restart" Then
			Me.Hide()
			Dim f1 = New mainCamera()
			f1.Show()
		End If
		If RestartBtn.Text = "Continue" Then
			Me.Close()
			Form2.Show()
		End If
	End Sub


	''' <summary>
	''' 
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
				If playerIsFalling = False Then
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














	Private Sub Timer75ms_Tick(sender As Object, e As EventArgs) Handles Timer75ms.Tick '50 - 20fps
		'------------------------------------------------------------------------------------bon
		If (ProgressBar1.Value <= 0) Or (Life_Point <= 0) Then
			loserWinner()
		End If

		collisionChecker()
		If playerIsFalling Then
			player1.Top += gravitySpeed
		End If

		If posRight Then
			If player1.Left <= beforeBoss.Left + beforeBoss.Width Then
				If player1.Left > Me.Width / 2 Then
					For Each ctrl As Control In allMyControls '????????????????????????????????????????????????bizin rod 1 moyen optimize sa li p ralenti zouee la
						If ctrl.Tag = "stayHere" Then
						Else
							ctrl.Left -= Speed
						End If
					Next
				End If
			Else
				Label1.Visible = True
				Label1.Enabled = True
				ProgressBar1.Enabled = True
				ProgressBar1.Visible = True
				boss.Enabled = True
				supergun.Enabled = True
				supergun.Visible = True
				moveTheBoss = True
			End If
			If moveTheBoss Then
				bossAndEnemiesMoveTowardPlayer(boss)
			End If

			player1.Left += Speed
			ElseIf posLeft Then
				player1.Left -= Speed
		End If



		'------------------------------------------------------------------------------------pa bon
		'makeEnemyMove() 'bien bizin clean --- slowing 
		bulletManager() 'too much loop
	End Sub



	'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++pren la jus k lot++++++sa banlamm ki p fr zoue la lourd la====248-370

	Private Sub makeEnemyMove()
		For Each enemy As PictureBox In enemies 'for all pictureboxes in List<enemies>
			bossAndEnemiesMoveTowardPlayer(enemy) 'Important Check Below
			For Each ground As PictureBox In grounds 'scan all controls present in form
				If Not checkforCollision(enemy, ground) Then
					enemy.Top += gravitySpeed
					For Each wall As PictureBox In walls
						If checkforCollision(enemy, wall) Then
							enemy.Top -= gravitySpeed
						End If
					Next
				Else
					enemy.Top -= gravitySpeed
				End If
			Next
		Next
	End Sub

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
					allActivePictureBoxes.Remove(enemy)
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
		If contaminer.Top + contaminer.Height > player1.Top Then
			contaminer.Top -= 1
		End If
		If contaminer.Top + contaminer.Height < player1.Top Then
			contaminer.Top += 1
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





























	''' <summary>
	''' used in timer
	''' gather all controls - select all pictureboxes give a score as per proper pictureboxes - delete collided pictureboxes and update the lables
	''' </summary>
	Private Sub collisionChecker()





		playerIsFalling = True
		For Each activePictureBox As PictureBox In allActivePictureBoxes 'list all controls in the form
			If activePictureBox IsNot player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					playerIsFalling = False
					Console.WriteLine("wall/ground")
					'????????????????????????????bizin dreC???????this code allow to pass through wall???? 1 zafr width sa???
				End If


				'@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@pou re me t sa
				'If otherPicBox.Name.Contains("enemy") Then
				'	Life_Point -= 1
				'	Console.WriteLine("new enemy")
				'	enemies.Remove(otherPicBox)
				'	removeOtherPictureBoxAndUpdateScore(otherPicBox)
				'	Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
				'End If
				'@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

				If activePictureBox.Name.Contains("boss") Then
					Life_Point -= 1
					Console.WriteLine("new boss")
					updateLabels()
					Exit For 'exit the for loop as picturebox name contains "boss" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("life") Then
					Item_Collected += 1
					Life_Point += 1
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
	''' display buttons / message if win or lost
	''' </summary>
	Private Sub loserWinner()
		If ProgressBar1.Value <= 0 Then
			universalScore = Score
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
		End If

		If Life_Point <= 0 Then
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



	''' <summary>
	''' set all picture box
	''' enemies
	''' boss
	''' randomise item to be collected
	''' </summary>
	Private Sub setGame()
		RestartBtn.Enabled = False
		scoreGun = 5
		scoreEnemy = 10
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
		Timer75ms.Enabled = True

		pp = New Player()
		Score = 0
		bulletNumber = -1
		ProgressBar1.Value = 20
		'My.Computer.Audio.Play(My.Resources.Dosseh___Le_bruit_du_silence__Clip_Officiel_, AudioPlayMode.BackgroundLoop) 
		allowToshotShotGUNl = False
		Speed = 15
		jumpHeight = 100
		gravitySpeed = 3
		Life_Point = 3
		IsJumping = False
	End Sub



	''' <summary>
	''' give images to pictureboxes and push to seperate list
	''' </summary>
	Private Sub setPictureBoxes()
		Dim randomPictureBoxArray As New List(Of PictureBox) ' PictureBox2, PictureBox3, PictureBox4.....
		For Each ctrl As Control In Me.Controls 'scan all controls present in form1
			If TypeOf (ctrl) Is PictureBox Then 'if the control is a picturebox then
				Dim controlName As String = ctrl.Name 'get the name of the picturebox

				If controlName.Contains("boss") OrElse controlName.Contains("player") OrElse controlName.Contains("instruction") Then 'all pictureboxes to exclude here
					allActivePictureBoxes.Add(ctrl) 'push to list
				ElseIf controlName.Contains("gun") Then 'e.g. gun1,lastgun...
					myPredefinePictureBoxes(ctrl, My.Resources.gun2) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					allActivePictureBoxes.Add(ctrl) 'push to list
				ElseIf controlName.Contains("ground") Then
					myPredefinePictureBoxes(ctrl, My.Resources.GrassCliffMid) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					allActivePictureBoxes.Add(ctrl) 'push to list
				ElseIf controlName.Contains("wall") Then
					myPredefinePictureBoxes(ctrl, My.Resources.Prop_6) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					allActivePictureBoxes.Add(ctrl) 'push to list
				ElseIf controlName.Contains("enemy") Then
					myPredefinePictureBoxes(ctrl, My.Resources._0_Ogre_Idle_000) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					allActivePictureBoxes.Add(ctrl) 'push to list
				Else 'pictureboxes to include
					randomPictureBoxArray.Add(ctrl) 'add the remaining control to List<randomPictureBoxArray> which will randomise the image to be inserted to the pictureboxes
				End If
			End If
			If TypeOf ctrl Is PictureBox Or TypeOf ctrl Is Label Then
				allMyControls.Add(ctrl)
			End If
		Next

		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\") 'get path of the directories and replace "\bin\Debug\" with "\Images\"
		Dim imagePathArray As String() = IO.Directory.GetFiles(imgPath) 'get all files' name in the imgPath
		Dim imgList As List(Of String) = imagePathArray.ToList() 'converting array to List
		Dim listCount As Integer = imgList.Count 'get number of item(s) in the List<imgList>

		Dim random As New Random()
		Dim i As Integer = 0
		For Each pb As PictureBox In randomPictureBoxArray 'for all pictureboxes in List<randomPictureBoxArray>
			i += 1
			Dim path As String = imgList(random.Next(0, listCount)) 'path = return random image path in Directory"Images" i.e. C:\...\lastGamePlatform\Images\coin.png for example
			Dim result As String = (IO.Path.GetFileNameWithoutExtension(path) & i).ToString() 'result = return the image name only with "i" added. e.g.coin1,adn2,coin3,...

			'the 2 comming lines are to give the pictureboxes nearly the same name of their images e.g. picturebox=adn10 and path=C:\...\adn.png
			pb.Name = result 'give a new name the pictureboxes that need to have randomised items refer to List<randomPictureBoxArray>
			pb.Image = Image.FromFile(path) 'insert the random image generated to picturebox

			allActivePictureBoxes.Add(pb) 'push to list

			pb.SizeMode = PictureBoxSizeMode.StretchImage 'to make the image fit the pictureboxes
			pb.BackColor = Color.Transparent 'set the background colour of the pictureboxes to transparent
		Next
		updateAllLists()
	End Sub



	''' <summary>
	''' updating all list of pictureboxes
	''' </summary>
	Private Sub updateAllLists()
		For Each activePictureBox As PictureBox In allActivePictureBoxes
			'seperating randompictureboxarray to specific ones
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



	''' <summary>
	''' inserting image to control
	''' </summary>
	''' <param name="ctrl">take control as parameter</param>
	''' <param name="img">take a bitmap as parameter from Resources Directory</param>
	Private Sub myPredefinePictureBoxes(ctrl As Control, img As Bitmap)
		Dim unused As New PictureBox
		Dim myPicBox As PictureBox = ctrl
		myPicBox.Image = img
		myPicBox.BackColor = Color.Transparent
		myPicBox.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub



	''' <summary>
	''' remove the pictureboxes that the player collided with and update the labels
	''' </summary>
	''' <param name="otherPicBox">picturebox to remove</param>
	Private Sub removeOtherPictureBoxAndUpdateScore(otherPicBox As PictureBox)
		'removing the control
		allActivePictureBoxes.Remove(otherPicBox)
		Me.Controls.Remove(otherPicBox)
		updateLabels()
	End Sub



	''' <summary>
	''' refresh all lables
	''' </summary>
	Private Sub updateLabels()
		pScore.Text = "Score :" + CStr(Score)
		pLife.Text = "X" + CStr(Life_Point)
		pItem.Text = "Item :" + CStr(Item_Collected)
	End Sub
End Class

Public Class mainCamera
	'list
	Dim walls, grounds, enemies, coins, lifes, guns, adns As New List(Of PictureBox)


	Dim allowToshotShotGUNl As Boolean
	Dim bullet1(-1) As PistoleBullet1

	'Dim shotGun() As PictureBox
	'--------------------------

	'---------VARIABLE-----------
	Dim posLeft, posRight, posUp, IsJumping As Boolean
	Dim Speed, JumpSpeed, gravitySpeed As Integer
	Dim count As Integer
	Dim Player_Name As String
	Dim Life_Point As Integer
	Dim Item_Collected As Integer
	Public Score As Integer
	Dim generator As Integer
	Dim pointRegenerator As Point

	Dim bulletNumber As Integer
	Dim bulletArray1ForShotGun(5) As PictureBox
	Dim count1 As Integer
	Private getPointShotGun As Integer
	Private getEnemyScore As Integer
	Dim timerCount As Integer

	Dim timer1, timer2, timer3 As Integer
	Dim ran1 As New System.Random
	Dim loc As New Integer
	Private timeLimit As Integer
	Private timeLimit2 As Integer
	Private timeLimit3 As Integer

	Public universalScore As Integer
	Dim pp As Player

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
	Private Sub mainCamera_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown 'execute once key is pressed on keyboard
		Select Case e.KeyValue
			Case Keys.Right
				posRight = True
			Case Keys.Left
				posLeft = True
			Case Keys.Up
				posUp = True
				count += 1

			Case Keys.Q
				If allowToshotShotGUNl = True And Item_Collected >= 2 Then
					ReDim Preserve bullet1(count1) '#############################################kieT sa#################################################
					Dim boulette As New PistoleBullet1(player1) '#############################################kieT sa#################################################
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
	End Sub


	''' <summary>
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub mainCamera_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'once key is release on keyboard
		Select Case e.KeyValue
			Case Keys.Right
				posRight = False
			Case Keys.Left
				posLeft = False
			Case Keys.Up
				posUp = False
		End Select
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





	'------------------reck
	''' <summary>
	''' It makes the enemies moves toward the user and checks if there is wall
	''' </summary>
	''' <param name="ob1"></param>
	''' <param name="ob2"></param>
	Private Sub contaminatePlayer(ByRef contaminer As Object)
		If contaminer.left + contaminer.Width > player1.Left Then
			contaminer.left -= 1
			For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
				If checkforCollision(contaminer, wall) Then
					contaminer.left += 1
				End If
			Next
		End If
		If contaminer.left + contaminer.Width < player1.Left Then
			contaminer.left += 1
			For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
				If checkforCollision(contaminer, wall) Then
					contaminer.left -= 1
				End If
			Next
		End If
		If contaminer.Top + contaminer.Height > player1.Top Then
			contaminer.Top -= 1
		End If
		If contaminer.Top + contaminer.Height < player1.Top Then
			contaminer.Top += 1
		End If
	End Sub

	Private Sub checkGravity()
		For Each ground As PictureBox In grounds 'for all pictureboxes in List<grounds>
			If Not checkforCollision(player1, ground) Then
				giveGravity()
			Else
				stopThatGravity()
				count = 0
			End If
		Next
	End Sub

	'----------All METHODS AND FUNCTIONS DOWN HERE---------------
	Private Sub gameManager_Tick(sender As Object, e As EventArgs) Handles gameManager.Tick
		moveMycamera()
		checkmovement()
		checkGun()
		checkGravity()
		makeEnemyMove()
		UpdatePlayer()
		loserWinner()
		bulletManager()
	End Sub

	Private Sub checkmovement()
		If posLeft Then
			player1.Left -= Speed
			If player1.Left < 0 Then
				player1.Left += Speed
			End If
			For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
				If checkforCollision(player1, wall) Then
					player1.Left += Speed
				End If
			Next
		End If
		If posRight Then
			player1.Left += Speed
			For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
				If checkforCollision(player1, wall) Then
					player1.Left -= Speed
				End If
			Next
		End If
		'---------------HERE THE COUNT IS VERY IMPORTANT-------------------
		If posUp And player1.Top > ground1.Top - 200 And Not count > 2 Then
			player1.Top -= JumpSpeed
		End If


		For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
			If posUp = True And player1.Bounds.IntersectsWith(wall.Bounds) Then
				player1.Top -= JumpSpeed
			End If
		Next
	End Sub

	'-------------Method for gravity----------------------
	Private Sub giveGravity()
		player1.Top += gravitySpeed
		For Each wall As PictureBox In walls 'for all pictureboxes in List<walls>
			If checkforCollision(player1, wall) Then
				player1.Top -= gravitySpeed
				If posUp Then
					player1.Top -= JumpSpeed + 60
				End If
			End If
		Next
	End Sub

	Private Sub stopThatGravity()
		player1.Top -= gravitySpeed
	End Sub


	'----------------------------------------------------

	'METHOD FOR COLLISION---------------------


	'-------------------------------------

	'--------MOVE ALL CONTENT UPON PLAYER LOCATION--------------
	Private Sub moveMycamera()
		If Not player1.Left >= beforeBoss.Left + beforeBoss.Width Then
			If player1.Left > Me.Width / 2 Then
				For Each m As Control In Me.Controls '????????????????????????????????????????????don 1 bon nom
					If TypeOf m Is PictureBox Or TypeOf m Is Label Then
						If m.Tag = "content" Then
							m.Left -= Speed
						End If
					End If
				Next
			End If
		Else
			If player1.Left + player1.Width >= Me.Width Then
				player1.Left -= Speed
			End If
			lastWave()
			If allowToshotShotGUNl = False Then
				Item_Collected = 2
				pItem.Text = "Item :" + CStr(Item_Collected)
				allowToshotShotGUNl = True
			End If
		End If
	End Sub

	Private Sub beforeRestart()
		If Not player1.Left <= Item2.Left And Item2.Enabled = False Then
			For Each m As Control In Me.Controls '??????????????????????????????????????????????????????????????????????????????
				If TypeOf m Is PictureBox Then
					If m.Tag = "content" Then
						m.Left += 15
					End If
				End If
			Next
		End If
	End Sub



	'-------------------MAin of enemy movements------------------------------
	Private Sub makeEnemyMove()
		For Each enemy As PictureBox In enemies 'for all pictureboxes in List<walls>
			contaminatePlayer(enemy) 'Important Check Below
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




	'----------------------------------------------------------------------------------
	Private Sub AssignRandomPosition(ByRef obj As Object)
		Dim ran As New Random
		generator = ran.Next(0, 1000) + 1

		obj.Top = 0
		obj.Left = Me.Width * 1 + generator
	End Sub


	Private Sub loserWinner()
		If ProgressBar1.Value <= 0 Then
			universalScore = Score
			ProgressBar1.Value = 0
			gameManager.Enabled = False
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

	Private Sub checkGun()
		For Each gun As PictureBox In guns
			If checkforCollision(player1, gun) And gun.Enabled Then
				Score += getPointShotGun
				updateLabels()
				gun.Enabled = True
				Me.Controls.Remove(gun)
				allowToshotShotGUNl = True
			End If
		Next
	End Sub

	Private Sub bulletManager()

		For x As Integer = 0 To bullet1.Length - 1
			bullet1(x).Shoot(player1)
			If checkforCollision(bullet1(x), boss) And boss.Enabled = True And bullet1(x).Enabled = True Then
				ProgressBar1.Value -= 1
				Score += 30 * 0.5
				updateLabels()
				bullet1(x).Enabled = False
				bullet1(x).Dispose() '?????????????????????????????????????????????????????????????????????????????????????
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
					Score += getEnemyScore
					pScore.Text = "Score :" + CStr(Score)
					bullet1(x).Dispose()
					bullet1(x).Enabled = False
					enemy.Enabled = False
					Me.Controls.Remove(enemy)
				End If
			Next

			'??????????????????????????????????????????????????????????????????????check sa 1 cout
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

	Private Sub lastWave()
		Label1.Visible = True
		Label1.Enabled = True
		ProgressBar1.Enabled = True
		ProgressBar1.Visible = True
		boss.Enabled = True
		gun.Enabled = True
		gun.Visible = True
		If player1.Left + player1.Width >= Me.Width Then
			player1.Left -= Speed
		End If
		contaminatePlayer(boss)
		If checkforCollision(player1, boss) Then
			Life_Point -= 1
			updateLabels()
		End If
		If checkforCollision(player1, gun) And gun.Enabled = True Then
			allowToshotShotGUNl = True
			Item_Collected = 2
			updateLabels()
		End If
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
	''' set all picture box
	''' enemies
	''' boss
	''' randomise item to be collected
	''' </summary>
	Private Sub setGame()
		RestartBtn.Enabled = False
		gun.Visible = False
		lastItem1.Visible = False
		gun.Enabled = False
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

		pp = New Player()
		Score = 0
		count = 0
		bulletNumber = -1
		ProgressBar1.Value = 20
		My.Computer.Audio.Play(My.Resources.Dosseh___Le_bruit_du_silence__Clip_Officiel_, AudioPlayMode.BackgroundLoop) 'give a background music to the game "looping music"
		allowToshotShotGUNl = False
		Speed = 15
		JumpSpeed = 10
		gravitySpeed = 3
		Life_Point = 3
		gameManager.Enabled = True
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
				ElseIf controlName.Contains("gun") Then 'e.g. gun1,lastgun...
					myPredefinePictureBoxes(ctrl, My.Resources.gun2) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					guns.Add(ctrl) 'push to list
				ElseIf controlName.Contains("ground") Then
					myPredefinePictureBoxes(ctrl, My.Resources.GrassCliffMid) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					grounds.Add(ctrl) 'push to list
				ElseIf controlName.Contains("wall") Then
					myPredefinePictureBoxes(ctrl, My.Resources.Prop_6) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					walls.Add(ctrl) 'push to list
				ElseIf controlName.Contains("enemy") Then
					myPredefinePictureBoxes(ctrl, My.Resources._0_Ogre_Idle_000) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					enemies.Add(ctrl) 'push to list
				Else 'pictureboxes to include
					randomPictureBoxArray.Add(ctrl) 'add the remaining control to List<randomPictureBoxArray> which will randomise the image to be inserted to the pictureboxes
				End If
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

			'seperating randompictureboxarray to specific ones
			If result.Contains("adn") Then
				adns.Add(pb)
			ElseIf result.Contains("coin") Then
				coins.Add(pb)
			ElseIf result.Contains("life") Then
				lifes.Add(pb)
			ElseIf result.Contains("gun") Then
				guns.Add(pb)
			End If

			pb.SizeMode = PictureBoxSizeMode.StretchImage 'to make the image fit the pictureboxes
			pb.BackColor = Color.Transparent 'set the background colour of the pictureboxes to transparent
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
	''' used in timer
	''' gather all controls - select all pictureboxes give a score as per proper pictureboxes - delete collided pictureboxes and update the lables
	''' </summary>
	Private Sub UpdatePlayer()
		For Each otherPicBox In Me.Controls 'list all controls in the form
			If TypeOf (otherPicBox) Is PictureBox Then 'if the control is a picturebox then
				If otherPicBox IsNot player1 AndAlso player1.Bounds.IntersectsWith(otherPicBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
					'If PictureBoxPlayer.Bounds.IntersectsWith(PictureBoxRed.Bounds) Then
					'	PictureBoxRed.Hide()
					'	PictureBoxRed.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
					'	MsgBox("You have hit the target")
					'	PictureBoxRed.Show()
					'End If
					If otherPicBox.name.Contains("enemy") Then
						Life_Point -= 1
						Console.WriteLine("new enemy")
						removeOtherPictureBoxAndUpdateScore(otherPicBox)
						Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
					End If
					If otherPicBox.name.Contains("boss") Then
						Life_Point -= 10
						Console.WriteLine("new boss")
						Exit For 'exit the for loop as picturebox name contains "boss" help in using less cpu power
					End If

					If otherPicBox.name.contains("life") Then
						Life_Point += 1
						Score += 1
						Console.WriteLine("new life")
						removeOtherPictureBoxAndUpdateScore(otherPicBox)
						Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
					End If
					If otherPicBox.name.Contains("gun") Then
						Console.WriteLine("new gun")
						removeOtherPictureBoxAndUpdateScore(otherPicBox)
						'??????????????????????????????????????????????????????????????????????????????li pa fr nanier sa part la
						Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
					End If
					If otherPicBox.name.Contains("adn") Then
						Item_Collected += 1
						Score += 5
						Console.WriteLine("new adn")
						removeOtherPictureBoxAndUpdateScore(otherPicBox)
						Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
					End If
					If otherPicBox.name.Contains("coin") Then
						Score += 3
						Console.WriteLine("new coin")
						removeOtherPictureBoxAndUpdateScore(otherPicBox)
						Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
					End If
				End If
			End If
		Next
		'If player1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
		'	PictureBox2.Hide()
		'	PictureBox2.Enabled = False
		'	PictureBox2.Dispose()
		'	Me.Controls.Remove(PictureBox2)
		'	Console.WriteLine(PictureBox2)
		'End If
	End Sub



	''' <summary>
	''' remove the pictureboxes that the player collided with and update the labels
	''' </summary>
	''' <param name="otherPicBox">picturebox to remove</param>
	Private Sub removeOtherPictureBoxAndUpdateScore(otherPicBox As PictureBox)
		'removing the control
		otherPicBox.Hide()
		otherPicBox.Dispose()
		Me.Controls.Remove(otherPicBox)
		otherPicBox.Enabled = False
		'updating Labels
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

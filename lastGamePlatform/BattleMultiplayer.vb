Public Class ground
    Private Sub ground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleGameManager.FormLoader(Me, 1)
    End Sub





    'Dim pistolet() As PictureBox
    'Dim shotGun() As PictureBox
    'Dim Life() As PictureBox
    'Dim wall() As PictureBox
    'Dim bulletArray1ForPistolet(1) As PictureBox
    'Dim bulletArray2ForPistolet(1) As PictureBox
    'Dim bulletArray1ForShotGun(5) As PictureBox
    'Dim bulletArray2ForShotGun(5) As PictureBox
    'Dim miniEnemy() As PictureBox
    'Dim miniworkEnemy() As PictureBox
    'Dim count As Integer
    'Dim gravitySpeed As Integer
    'Dim life_Point1, life_Point2 As Integer
    'Dim allowToshotPistolet As Boolean
    'Dim allowToshotShotGUNl As Boolean
    'Dim allowToshotPistolet2 As Boolean
    'Dim allowToshotShotGUN2 As Boolean
    'Dim Enemy1() As PictureBox
    'Dim Enemy2() As PictureBox
    'Dim getPointLife, getPointShotGun, getPointPistolet, getPointMiniEnemy, getPointkillPllayer, getPointKillBoss As Integer
    'Public n1 As String = multiplayerRegForm.p1Name
    'Public n2 As String = multiplayerRegForm.p2Name

    ''-PLAYERS MOVEMENT---------
    'Dim left1, right1, up1, shoot1 As Boolean
    'Dim left2, right2, up2, shoot2 As Boolean
    'Dim walkSpeed, jumpSpeed, gravityPlayer As Integer
    'Dim score1, score2 As Integer
    'Dim jumpCount1 As Integer = 0
    'Dim jumpCount2 As Integer = 0
    'Dim numBullet1 As Integer = -1
    'Dim numBullet2 As Integer = -1
    'Dim temp1, temp2 As Integer
    ''------------------------
    'Dim bullet1(-1) As PistoleBullet1
    'Dim count1 As Integer
    'Dim bullet2(-1) As PistoleBullet1
    'Dim count2 As Integer
    'Dim showWeapon() As PictureBox
    'Dim wholeGameTimer As Integer
    'Dim movRight As Image
    'Dim movLeft As Image

    'Dim stand As Bitmap

    'Private Sub BattleMultiplayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    setGame()
    'End Sub

    'Private Sub setGame()


    '    'My.Computer.Audio.Play(My.Resources.BackgroundMaybe1, AudioPlayMode.BackgroundLoop)
    '    movRight = My.Resources.Webp_net_gifmaker
    '    movLeft = My.Resources.leftGiff
    '    stand = My.Resources._3rdPlayer
    '    getPointLife = 3
    '    getPointShotGun = 10
    '    getPointPistolet = 5
    '    getPointMiniEnemy = 30
    '    getPointkillPllayer = 50
    '    getPointKillBoss = 100
    '    btnRestart.Enabled = False
    '    btnRestart.Visible = False
    '    gotoMain.Enabled = False
    '    gotoMain.Visible = False
    '    wiwin.Visible = False
    '    wiwin.Enabled = False
    '    player1.Left = 10
    '    player2.Left = 1040
    '    btnRestart.Enabled = False
    '    btnRestart.Visible = False
    '    wholeGameTimer = 0
    '    showWeapon = {bul1_1, bul1_2, bul1_3, bul1_4, bul1_5, bul1_6, bul1_7, bul2_1, bul2_2, bul2_3, bul2_4, bul2_5, bul2_6, bul2_7}
    '    miniEnemy = {en1_1, en1_2, en2_1, en2_2}
    '    For mon As Integer = 0 To miniEnemy.Length - 1
    '        miniEnemy(mon).Image = My.Resources._0_Ogre_Idle_000
    '        miniEnemy(mon).Visible = False
    '        miniEnemy(mon).Enabled = False

    '    Next
    '    miniworkEnemy = {mov1, mov2, mov3, mov4}
    '    For work As Integer = 0 To miniworkEnemy.Length - 1
    '        miniworkEnemy(work).Image = My.Resources._0_Ogre_Idle_000
    '        miniworkEnemy(work).Visible = False
    '        miniworkEnemy(work).Enabled = False

    '    Next
    '    lblBoss.Visible = False
    '    ProgressBar1.Visible = False
    '    ProgressBar1.Value = 15
    '    wiwin.Enabled = False
    '    allowToshotShotGUNl = False
    '    allowToshotShotGUN2 = False
    '    allowToshotPistolet = False
    '    allowToshotPistolet2 = False
    '    walkSpeed = 2
    '    jumpSpeed = 13
    '    life_Point1 = 3
    '    p1life.Text = "Life :" + CStr(life_Point1)
    '    life_Point2 = 3
    '    p2life.Text = "Life :" + CStr(life_Point2)
    '    gravitySpeed = 5
    '    gravityPlayer = 4
    '    pistolet = {gun1, gun2}
    '    shotGun = {mic1, mic2}
    '    Life = {life1, life2}
    '    score1 = 0
    '    score2 = 0
    '    wall = {wall1, wall2}
    '    player1.Image = multiplayerRegForm.player1Box.Image
    '    player2.Image = multiplayerRegForm.player2Box.Image

    '    p1Name.Text = n1
    '    p1Name.Visible = True
    '    p2label.Text = n2
    '    p2label.Visible = True
    '    BattleManager.Enabled = True

    '    For x As Integer = 0 To showWeapon.Length - 1
    '        showWeapon(x).Image = My.Resources._5a3719ae33d594_4783473215135604942123
    '        showWeapon(x).BackgroundImageLayout = ImageLayout.None

    '        showWeapon(x).BackColor = Color.Transparent
    '    Next


    'End Sub
    'Private Sub BattleManager_Tick(sender As Object, e As EventArgs) Handles BattleManager.Tick
    '    wholeGameTimer += 1
    '    Debug.WriteLine(CStr(wholeGameTimer))
    '    waveManager()
    '    ManagePlayers()
    '    moveCharacter()
    '    gravityForAll(pistolet)
    '    gravityForAll(shotGun)
    '    gravityForAll(Life)
    '    '--------Falling ITEMS ON THE GROUND----------------
    '    For x As Integer = 0 To pistolet.Length - 1
    '        ifOnground(pistolet(x))
    '    Next
    '    For y As Integer = 0 To pistolet.Length - 1
    '        ifOnground(shotGun(y))
    '    Next
    '    For z As Integer = 0 To pistolet.Length - 1
    '        ifOnground(Life(z))
    '    Next

    '    '********************************************************
    '    checkForPlayersLives()
    '    PLAYER1SHOTGUN()
    '    bulletManager()

    'End Sub
    ''--------GIVE A RANDOM POSITION TO THE OBJECT------------
    'Private Sub randomPosition(ByVal ob1 As Object)
    '    Dim ran As New System.Random
    '    Dim gen As Integer = ran.Next(250, 900) + 1
    '    ob1.TOP = 0
    '    ob1.Left = gen
    'End Sub

    'Private Sub randomPositionEnemy(ByVal ob1 As Object)
    '    Dim ran As New System.Random
    '    Dim gen As Integer = ran.Next(30, 1000) + 1
    '    ob1.TOP = 10
    '    ob1.Left = gen
    'End Sub


    ''********************************************************

    ''------Check if Items On Grounds-------------------------
    'Private Sub ifOnground(ByVal ob As Object)
    '    If ob.Bounds.IntersectsWith(terrain.Bounds) Then
    '        ob.top -= gravitySpeed
    '        makeTimer()
    '        If count >= 10000 Then
    '            count = 0
    '            randomPosition(ob)
    '        End If
    '    End If
    'End Sub
    ''********************************************************
    ''-------TIMER FOR OBJEC TO DISAPEAR---------------------
    'Private Sub makeTimer()
    '    count += 1
    'End Sub
    ''********************************************************
    'Private Sub gravityForAll(ByVal ar As Array)

    '    For x As Integer = 0 To ar.Length - 1
    '        ar(x).Top += gravitySpeed
    '    Next

    'End Sub



    'Private Sub ground_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    '    '------------PLAYER-2-----------------------------------------------
    '    Select Case e.KeyValue
    '        Case Keys.Up
    '            up2 = True
    '            jumpCount2 += 1



    '        Case Keys.Left
    '            left2 = True
    '            player2.Image = movLeft
    '        Case Keys.Right
    '            right2 = True
    '        Case Keys.M

    '            If allowToshotPistolet2 = True Then
    '                ReDim Preserve bullet2(count2)
    '                Dim boulette2 As New PistoleBullet1(player2)
    '                Controls.Add(boulette2)
    '                bullet2(count2) = boulette2
    '                count2 += 1
    '                If count2 = 2 Then
    '                    allowToshotPistolet2 = False
    '                    count2 = 0
    '                End If
    '            End If
    '            If allowToshotShotGUN2 = True Then
    '                ReDim Preserve bullet2(count2)
    '                Dim boulette2 As New PistoleBullet1(player2)
    '                Controls.Add(boulette2)
    '                bullet2(count2) = boulette2
    '                count2 += 1
    '                If count2 = 5 Then
    '                    allowToshotShotGUN2 = False
    '                    count2 = 0
    '                End If
    '            End If
    ''---------------------------------------------------------------------------------------------
    ''-----------------------PLAYER-1-----------------------------------------------------------------
    '        Case Keys.W Or (Keys.W And Keys.D) Or (Keys.W And Keys.A) Or (Keys.A And Keys.W) Or (Keys.D And Keys.W) Or (Keys.A And Keys.W And Keys.D)
    '            up1 = True
    '            jumpCount1 += 1
    '        Case Keys.A
    '            left1 = True
    '        Case Keys.D
    '            right1 = True

    '        Case Keys.Tab

    '            If allowToshotPistolet = True Then
    '                temp1 += 1
    '                shoot1 = True
    '                ReDim Preserve bullet1(count1)
    '                Dim boulette As New PistoleBullet1(player1)
    '                Controls.Add(boulette)
    '                bullet1(count1) = boulette
    '                count1 += 1
    '                If count1 = 2 Then
    '                    allowToshotPistolet = False
    '                    count1 = 0
    '                End If
    '            End If
    '            If allowToshotShotGUNl = True Then
    '                ReDim Preserve bullet1(count1)
    '                Dim boulette As New PistoleBullet1(player1)
    '                Controls.Add(boulette)
    '                bullet1(count1) = boulette
    '                count1 += 1
    '                If count1 = 5 Then
    '                    allowToshotShotGUNl = False
    '                    count1 = 0
    '                End If
    '            End If


    '    End Select
    'End Sub



    'Private Sub ground_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
    '    Select Case e.KeyValue
    '        Case Keys.Up
    '            up2 = False
    '        Case Keys.Left
    '            left2 = False
    '            player1.Image = stand
    '        Case Keys.Right
    '            right2 = False
    '            player2.Image = My.Resources._3rdPlayerLfet
    '        Case Keys.Alt
    '            shoot2 = False

    '        Case Keys.W
    '            up1 = False
    '        Case Keys.A
    '            left1 = False
    '        Case Keys.D
    '            player1.Image = stand
    '            right1 = False
    '        Case Keys.Tab
    '            shoot1 = False


    '    End Select
    'End Sub
    ''METHOD FOR COLLISION---------------------
    'Function checkforCollision(ByVal ob1 As Object, ByVal ob2 As Object) As Boolean
    '    Dim collided As Boolean = False
    '    If ob1.top + ob1.Height >= ob2.top And
    '        ob2.Top + ob2.Height >= ob1.Top And
    '        ob1.Left + ob1.Width >= ob2.Left And
    '        ob2.Left + ob2.Width >= ob1.Left Then
    '        collided = True
    '    End If
    '    Return collided
    'End Function
    ''-------------------------------------
    'Private Sub moveCharacter()

    '    If left1 Then
    '        player1.Left -= walkSpeed
    '        For a As Integer = 0 To wall.Length - 1
    '            If checkforCollision(player1, wall(a)) Then
    '                player1.Left += walkSpeed
    '            End If
    '        Next
    '    End If

    '    If right1 Then
    '        player1.Left += walkSpeed
    '        For x As Integer = 0 To wall.Length - 1
    '            If checkforCollision(player1, wall(x)) Then
    '                player1.Left -= walkSpeed
    '            End If
    '        Next
    '    End If
    '    If up1 And Not jumpCount1 > 1 Then
    '        player1.Top -= jumpSpeed

    '    End If
    '    If shoot1 Then
    '        'suspense
    '    End If



    '    If shoot2 Then
    '        'suspense
    '    End If
    '    If up2 And Not jumpCount2 > 2 Then
    '        player2.Top -= jumpSpeed

    '    End If
    '    If right2 Then
    '        player2.Left += walkSpeed
    '        For b As Integer = 0 To wall.Length - 1
    '            If checkforCollision(player2, wall(b)) Then
    '                player2.Left -= walkSpeed
    '            End If
    '        Next
    '    End If
    '    If left2 Then
    '        player2.Left -= walkSpeed
    '        For c As Integer = 0 To wall.Length - 1
    '            If checkforCollision(player2, wall(c)) Then
    '                player2.Left += walkSpeed
    '            End If
    '        Next

    '    End If

    'End Sub



    'Private Sub ManagePlayers()

    '    If player1.Left + player1.Width >= player2.Left Then
    '        player1.Left -= walkSpeed
    '    End If

    '    If player1.Left = player2.Left + player2.Width Then
    '        player1.Left += walkSpeed
    '    End If
    '    '------MAKE--SURE PLAYERS--DONT--GET--OUT--OF BOUNDARY----
    '    If player1.Top <= Me.Top Then
    '        player1.Top += jumpSpeed
    '    End If
    '    If player2.Top <= Me.Top Then
    '        player2.Top += jumpSpeed
    '    End If
    '    If player1.Left <= 0 Then
    '        player1.Left += walkSpeed
    '    End If
    '    If player1.Left >= Me.Width Then
    '        player1.Left -= walkSpeed
    '    End If

    '    If player2.Left <= 0 Then
    '        player2.Left += walkSpeed
    '    End If
    '    If player2.Left + player2.Width >= Me.Width Then
    '        player2.Left -= walkSpeed
    '    End If
    '    '---------------------------------------------------------
    '    For x As Integer = 0 To wall.Length - 1
    '        If checkforCollision(player1, terrain) = False And checkforCollision(player1, wall(x)) = False Then
    '            player1.Top += gravityPlayer

    '        Else
    '            jumpCount1 = 0
    '            player1.Top -= gravityPlayer

    '        End If
    '        If checkforCollision(player2, terrain) = False And checkforCollision(player2, wall(x)) = False Then
    '            player2.Top += gravityPlayer
    '        Else
    '            jumpCount2 = 0
    '            player2.Top -= gravityPlayer
    '        End If
    '    Next

    '    For y As Integer = 0 To Life.Length - 1
    '        If checkforCollision(player1, Life(y)) Then
    '            randomPosition(Life(y))
    '            score1 += getPointLife
    '            txtSc1.Text = "Score :" + CStr(score1)
    '            life_Point1 += 1
    '            p1life.Text = "Life :" + life_Point1.ToString

    '        End If
    '        If checkforCollision(player2, Life(y)) Then
    '            randomPosition(Life(y))
    '            score2 += getPointLife
    '            txtSc2.Text = "Score :" + CStr(score2)
    '            life_Point2 += 1
    '            p2life.Text = "Life :" + life_Point2.ToString
    '        End If
    '    Next
    '    For z As Integer = 0 To shotGun.Length - 1
    '        If checkforCollision(player1, shotGun(z)) Then
    '            score1 += getPointShotGun
    '            txtSc1.Text = "Score :" + CStr(score1)
    '            randomPosition(shotGun(z))

    '            allowToshotShotGUNl = True
    '        End If
    '        If checkforCollision(player2, shotGun(z)) Then
    '            score2 += getPointShotGun
    '            txtSc2.Text = "Score :" + CStr(score2)
    '            randomPosition(shotGun(z))
    '            allowToshotShotGUN2 = True

    '        End If
    '    Next

    '    For a As Integer = 0 To pistolet.Length - 1
    '        If checkforCollision(player1, pistolet(a)) Then
    '            score1 += getPointPistolet
    '            txtSc1.Text = "Score :" + CStr(score1)
    '            randomPosition(pistolet(a))

    '            allowToshotPistolet = True
    '        End If
    '        If checkforCollision(player2, pistolet(a)) Then
    '            score2 += getPointPistolet
    '            txtSc2.Text = "Score :" + CStr(score2)
    '            randomPosition(pistolet(a))

    '            allowToshotPistolet2 = True

    '        End If
    '    Next




    'End Sub

    'Private Sub gotoMain_Click(sender As Object, e As EventArgs) Handles gotoMain.Click
    '    Me.Close()
    '    startHere.Show()
    'End Sub

    'Private Sub PLAYER1SHOTGUN()
    '    '--------PLAYER1--------------------------------------
    '    If allowToshotShotGUNl = True Then
    '        bul1_6.Visible = True
    '        bul1_7.Visible = True
    '        bul1_3.Visible = True
    '        bul1_4.Visible = True
    '        bul1_5.Visible = True
    '    Else
    '        bul1_6.Visible = False
    '        bul1_7.Visible = False
    '        bul1_3.Visible = False
    '        bul1_4.Visible = False
    '        bul1_5.Visible = False

    '    End If
    '    If allowToshotPistolet = True Then
    '        bul1_1.Visible = True
    '        bul1_2.Visible = True
    '    Else
    '        bul1_1.Visible = False
    '        bul1_2.Visible = False

    '    End If
    '    If allowToshotShotGUNl And allowToshotPistolet Then
    '        allowToshotShotGUNl = True
    '        allowToshotPistolet = False
    '    End If
    '    '--------------------------------------------------------

    '    '--------------------PLAYER2-----------------------------
    '    If allowToshotPistolet2 = True Then
    '        bul2_1.Visible = True
    '        bul2_2.Visible = True
    '    Else
    '        bul2_1.Visible = False
    '        bul2_2.Visible = False
    '    End If
    '    If allowToshotShotGUN2 = True Then
    '        bul2_6.Visible = True
    '        bul2_7.Visible = True
    '        bul2_3.Visible = True
    '        bul2_4.Visible = True
    '        bul2_5.Visible = True
    '    Else
    '        bul2_6.Visible = False
    '        bul2_7.Visible = False
    '        bul2_3.Visible = False
    '        bul2_4.Visible = False
    '        bul2_5.Visible = False

    '    End If
    '    If allowToshotPistolet2 And allowToshotShotGUN2 Then
    '        allowToshotShotGUN2 = True
    '        allowToshotPistolet2 = False
    '    End If
    '    '--------------------------------------------------------

    'End Sub
    'Private Sub bulletManager()
    '    If temp1 = 1 Then
    '        My.Computer.Audio.Play(My.Resources._1, AudioPlayMode.Background)
    '        temp1 = 0
    '    End If
    '    If temp1 = 2 Then
    '        My.Computer.Audio.Play(My.Resources._2, AudioPlayMode.Background)
    '        temp1 = 0
    '    End If
    '    If temp1 = 3 Then
    '        My.Computer.Audio.Play(My.Resources._3, AudioPlayMode.Background)
    '        temp1 = 0
    '    End If
    '    If temp1 = 4 Then
    '        My.Computer.Audio.Play(My.Resources._4, AudioPlayMode.Background)
    '        temp1 = 0
    '    End If
    '    If temp1 = 5 Then
    '        My.Computer.Audio.Play(My.Resources._5, AudioPlayMode.Background)
    '        temp1 = 0
    '    End If



    '    For x As Integer = 0 To bullet1.Length - 1
    '        bullet1(x).Shoot(player1)
    '        '-----------KILL MINI ENEMY---------------------------------------
    '        For wo As Integer = 0 To miniEnemy.Length - 1
    '            If checkforCollision(bullet1(x), miniEnemy(wo)) And bullet1(x).Enabled = True And miniEnemy(wo).Enabled = True Then
    '                score1 += getPointMiniEnemy
    '                txtSc1.Text = "Score :" + CStr(score1)
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))
    '                bullet1(x).Enabled = False
    '                randomPositionEnemy(miniEnemy(wo))
    '            End If
    '        Next
    '        For wok As Integer = 0 To miniworkEnemy.Length - 1
    '            If checkforCollision(bullet1(x), miniworkEnemy(wok)) And bullet1(x).Enabled = True And miniworkEnemy(wok).Enabled = True Then
    '                score1 += getPointMiniEnemy
    '                txtSc1.Text = "Score :" + CStr(score1)
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))
    '                bullet1(x).Enabled = False
    '                randomPositionEnemy(miniworkEnemy(wok))
    '            End If
    '        Next

    '        '----------------------------------------------------------------



    '        '--------------------kill boss(player 1)------------------------------
    '        If checkforCollision(bullet1(x), finallBoss) And bullet1(x).Enabled = True And finallBoss.Enabled = True Then
    '            ProgressBar1.Value -= 1
    '            score1 += getPointKillBoss
    '            txtSc1.Text = "Score :" + CStr(score1)
    '            bullet1(x).Dispose()
    '            Me.Controls.Remove(bullet1(x))
    '            bullet1(x).Enabled = False
    '        End If
    '        '-------------------------------------------------------------

    '        For y As Integer = 0 To wall.Length - 1
    '            If bullet1(x).Bounds.IntersectsWith(wall(y).Bounds) Then
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))
    '                bullet1(x).Enabled = False



    '            End If
    '        Next

    '        For a As Integer = 0 To shotGun.Length - 1
    '            If checkforCollision(bullet1(x), shotGun(a)) And bullet1(x).Enabled = True Then
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))

    '                bullet1(x).Enabled = False
    '                randomPosition(shotGun(a))
    '            End If
    '        Next
    '        For b As Integer = 0 To pistolet.Length - 1
    '            If checkforCollision(bullet1(x), pistolet(b)) And bullet1(x).Enabled = True Then

    '                bullet1(x).Enabled = False
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))
    '                bullet1(x).Enabled = False
    '                randomPosition(pistolet(b))
    '            End If
    '        Next
    '        For c As Integer = 0 To Life.Length - 1
    '            If checkforCollision(bullet1(x), Life(c)) And bullet1(x).Enabled = True Then

    '                bullet1(x).Enabled = False
    '                bullet1(x).Dispose()
    '                Me.Controls.Remove(bullet1(x))
    '                bullet1(x).Enabled = False
    '                randomPosition(Life(c))
    '            End If
    '        Next

    '        If bullet1(x).Bounds.IntersectsWith(player2.Bounds) And bullet1(x).Enabled = True Then
    '            score1 += getPointkillPllayer
    '            txtSc1.Text = "Score :" + CStr(score1)
    '            life_Point2 -= 1
    '            bullet1(x).Enabled = False
    '            bullet1(x).Dispose()
    '            Me.Controls.Remove(bullet1(x))



    '            p2life.Text = "Life :" + CStr(life_Point2)



    '        End If
    '    Next

    '    For m As Integer = 0 To bullet1.Length - 1
    '        For n As Integer = 0 To bullet2.Length - 1
    '            If checkforCollision(bullet1(m), bullet2(n)) Then
    '                score1 += 5
    '                txtSc1.Text = "Score :" + CStr(score1)
    '                score1 += 5
    '                txtSc2.Text = "Score :" + CStr(score2)
    '                bullet1(m).Enabled = False
    '                bullet2(n).Enabled = False
    '                bullet1(m).Dispose()
    '                bullet2(n).Dispose()



    '            End If
    '        Next
    '    Next

    '    For i As Integer = 0 To bullet2.Length - 1
    '        bullet2(i).Shoot2(player2)

    '        '-----------KILL MINI ENEMY---------------------------------------
    '        For wo As Integer = 0 To miniEnemy.Length - 1
    '            If checkforCollision(bullet2(i), miniEnemy(wo)) And bullet2(i).Enabled = True And miniEnemy(wo).Enabled = True Then
    '                score2 += getPointMiniEnemy
    '                txtSc2.Text = "Score :" + CStr(score2)
    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False
    '                randomPositionEnemy(miniEnemy(wo))
    '            End If
    '        Next
    '        For wok As Integer = 0 To miniworkEnemy.Length - 1
    '            If checkforCollision(bullet2(i), miniworkEnemy(wok)) And bullet2(i).Enabled = True And miniworkEnemy(wok).Enabled = True Then
    '                score2 += getPointMiniEnemy
    '                txtSc2.Text = "Score :" + CStr(score2)
    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False
    '                randomPositionEnemy(miniworkEnemy(wok))
    '            End If
    '        Next

    '        '----------------------------------------------------------------

    '        '--------------------kill boss(player 2)------------------------------
    '        If checkforCollision(bullet2(i), finallBoss) And bullet2(i).Enabled = True And finallBoss.Enabled = True Then
    '            ProgressBar1.Value -= 1
    '            score2 += getPointKillBoss
    '            txtSc2.Text = "Score :" + CStr(score2)
    '            bullet2(i).Dispose()
    '            Me.Controls.Remove(bullet2(i))
    '            bullet2(i).Enabled = False
    '        End If
    '        '-------------------------------------------------------------d
    '        For y As Integer = 0 To wall.Length - 1
    '            If bullet2(i).Bounds.IntersectsWith(wall(y).Bounds) Then
    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False



    '            End If
    '        Next

    '        For a As Integer = 0 To shotGun.Length - 1
    '            If checkforCollision(bullet2(i), shotGun(a)) And bullet2(i).Enabled = True Then

    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False
    '                randomPosition(shotGun(a))
    '            End If
    '        Next
    '        For b As Integer = 0 To pistolet.Length - 1
    '            If checkforCollision(bullet2(i), pistolet(b)) And bullet2(i).Enabled = True Then

    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False
    '                randomPosition(pistolet(b))
    '            End If
    '        Next
    '        For c As Integer = 0 To Life.Length - 1
    '            If checkforCollision(bullet2(i), Life(c)) And bullet2(i).Enabled = True Then

    '                bullet2(i).Dispose()
    '                Me.Controls.Remove(bullet2(i))
    '                bullet2(i).Enabled = False
    '                randomPosition(Life(c))
    '            End If
    '        Next

    '        If bullet2(i).Bounds.IntersectsWith(player1.Bounds) And bullet2(i).Enabled = True Then
    '            score2 += getPointkillPllayer
    '            txtSc2.Text = "Score :" + CStr(score2)
    '            life_Point1 -= 1
    '            bullet2(i).Enabled = False
    '            bullet2(i).Dispose()
    '            Me.Controls.Remove(bullet2(i))



    '            p1life.Text = "Life :" + CStr(life_Point1)



    '        End If
    '    Next
    'End Sub
    'Private Sub FirstWave()





    '    For x As Integer = 0 To miniEnemy.Length - 1

    '        miniEnemy(x).Visible = True
    '        miniEnemy(x).Enabled = True
    '        ifOnground(miniEnemy(x))
    '        If checkforCollision(player1, miniEnemy(x)) Then
    '            randomPositionEnemy(miniEnemy(x))
    '            life_Point1 -= 1
    '            p1life.Text = "Life :" + CStr(life_Point1)
    '        End If
    '        If checkforCollision(player2, miniEnemy(x)) Then
    '            randomPositionEnemy(miniEnemy(x))
    '            life_Point2 -= 1
    '            p2life.Text = "Life :" + CStr(life_Point2)
    '        End If

    '    Next
    '    gravityForAll(miniEnemy)




    'End Sub
    'Private Sub SecondWave()




    '    For x As Integer = 0 To miniworkEnemy.Length - 1

    '        miniworkEnemy(x).Visible = True
    '        miniworkEnemy(x).Enabled = True

    '        ifOnground(miniworkEnemy(x))
    '        If checkforCollision(player1, miniworkEnemy(x)) Then
    '            randomPositionEnemy(miniworkEnemy(x))
    '            life_Point1 -= 1
    '            p1life.Text = "Life :" + CStr(life_Point1)
    '        End If
    '        If checkforCollision(player2, miniworkEnemy(x)) Then
    '            randomPositionEnemy(miniworkEnemy(x))
    '            life_Point2 -= 1
    '            p2life.Text = "Life :" + CStr(life_Point2)
    '        End If
    '        For a As Integer = 0 To wall.Length - 1
    '            If miniworkEnemy(x).Left <= wall(a).Left + wall(a).Width Then
    '                miniworkEnemy(x).Left += 1
    '            End If
    '            If miniworkEnemy(x).Top + miniworkEnemy(x).Height >= wall(a).Top Then
    '                miniworkEnemy(x).Top -= gravitySpeed
    '            End If
    '        Next
    '    Next
    '    gravityForAll(miniworkEnemy)
    '    contaminatePlayer(miniworkEnemy(0), player1)
    '    contaminatePlayer(miniworkEnemy(1), player1)
    '    contaminatePlayer(miniworkEnemy(2), player2)
    '    contaminatePlayer(miniworkEnemy(3), player2)

    'End Sub

    ''RUN AFTER PLAYER -----------------------
    'Private Sub contaminatePlayer(ByRef ob1 As Object, ByRef ob2 As Object)
    '    If ob1.left + ob1.Width > ob2.left Then
    '        ob1.left -= 1
    '    End If
    '    If ob1.left + ob1.Width < ob2.left Then
    '        ob1.left += 1
    '    End If
    '    If ob1.Top + ob1.Height > ob2.Top Then
    '        ob1.Top -= 1
    '    End If
    '    If ob1.Top + ob1.Height < ob2.Top Then
    '        ob1.Top += 1
    '    End If
    'End Sub
    ''-----------------------------------------
    'Private Sub ThirdWave()
    '    lblBoss.Visible = True
    '    ProgressBar1.Visible = True

    '    finallBoss.Image = My.Resources._0_Ogre_Idle_000

    '    finallBoss.Enabled = True

    '    finallBoss.Visible = True
    '    Me.BackColor = Color.GreenYellow
    '    life_Point1 -= 0.001
    '    p1life.Text = "Life :" + CStr(life_Point1)
    '    life_Point2 -= 0.001
    '    p2life.Text = "Life :" + CStr(life_Point2)

    '    If player1.Left >= 102 Then
    '        finallBoss.Left -= 3
    '        For x As Integer = 0 To wall.Length - 1
    '            If checkforCollision(finallBoss, wall(x)) Then
    '                finallBoss.Left += 3
    '            End If

    '        Next

    '    End If
    '    If player2.Left <= 1040 Then
    '        finallBoss.Left += 3
    '        For x As Integer = 0 To wall.Length - 1
    '            If checkforCollision(finallBoss, wall(x)) Then
    '                finallBoss.Left -= 3
    '            End If

    '        Next
    '    End If
    '    If player1.Left >= 140 And player2.Left <= 1040 Then
    '        finallBoss.Left -= 3
    '        For x As Integer = 0 To wall.Length - 1
    '            If checkforCollision(finallBoss, wall(x)) Then
    '                finallBoss.Left += 3
    '            End If
    '        Next
    '    End If
    '    If checkforCollision(finallBoss, player1) Then
    '        life_Point1 -= 2
    '        p1life.Text = "Life :" + CStr(life_Point1)
    '        player1.Left = 10
    '    End If
    '    If checkforCollision(finallBoss, player2) Then
    '        life_Point2 -= 2
    '        p2life.Text = "Life :" + CStr(life_Point2)
    '        player2.Left = 1040
    '    End If
    'End Sub

    'Private Sub waveManager()
    '    If wholeGameTimer >= 1500 And wholeGameTimer < 2000 Then
    '        FirstWave()
    '    Else

    '        For moon As Integer = 0 To miniEnemy.Length - 1
    '            miniEnemy(moon).Visible = False
    '            miniEnemy(moon).Enabled = False
    '            'randomPosition(miniEnemy(moon))
    '        Next

    '    End If
    '    If wholeGameTimer >= 2100 And wholeGameTimer < 3000 Then
    '        SecondWave()
    '    Else

    '        For moon As Integer = 0 To miniworkEnemy.Length - 1
    '            miniworkEnemy(moon).Visible = False
    '            miniworkEnemy(moon).Enabled = False
    '            ' randomPosition(miniworkEnemy(moon))
    '        Next


    '    End If


    '    If wholeGameTimer >= 3200 And Not ProgressBar1.Value = 0 Then
    '        ThirdWave()
    '    Else
    '        finallBoss.Enabled = False
    '        finallBoss.Visible = False
    '        Me.BackColor = Color.White

    '    End If

    'End Sub
    'Private Sub checkForPlayersLives()
    '    If life_Point1 <= 0 And life_Point2 <= 0 Then
    '        finallBoss.Enabled = False

    '        wiwin.Text = "Player 2 lOSE with " + CStr(life_Point2) + " life and " + CStr(score2) + " Score" + vbNewLine + "Player 1 LOSE with " + CStr(life_Point1) + " life and " + CStr(score1) + " Score" + vbNewLine + "You both idiots"
    '        wiwin.Left = Me.Width / 2 - 75
    '        wiwin.Top = Me.Height / 2 - 100
    '        wiwin.Visible = True
    '        wiwin.Enabled = True
    '        wiwin.BringToFront()

    '        CloseAll()
    '    End If
    '    If life_Point1 <= 0 Then
    '        life_Point1 = 0
    '        wiwin.Text = "Player 2 Wins with " + CStr(life_Point2) + " life and " + CStr(score2) + " Score"
    '        wiwin.Left = Me.Width / 2 - 75
    '        wiwin.Top = Me.Height / 2 - 40
    '        wiwin.Visible = True
    '        wiwin.Enabled = True
    '        wiwin.BringToFront()
    '        CloseAll()
    '    End If
    '    If life_Point2 <= 0 Then
    '        life_Point2 = 0
    '        wiwin.Text = "Player 1 Wins with " + CStr(life_Point1) + " life and " + CStr(score1) + " Score"
    '        wiwin.Left = Me.Width / 2 - 75
    '        wiwin.Top = Me.Height / 2 - 40
    '        wiwin.Visible = True
    '        wiwin.Enabled = True

    '        wiwin.BringToFront()
    '        CloseAll()
    '    End If

    '    If ProgressBar1.Value <= 0 Then
    '        ProgressBar1.Value = 0
    '        finallBoss.Enabled = False

    '        wiwin.Text = "Player 2 Wins with " + CStr(life_Point2) + " life and " + CStr(score2) + " Score" + vbNewLine + "Player 1 Wins with " + CStr(life_Point1) + " life and " + CStr(score1) + " Score"
    '        wiwin.Left = Me.Width / 2 - 75
    '        wiwin.Top = Me.Height / 2 - 50
    '        wiwin.Visible = True
    '        wiwin.Enabled = True

    '        wiwin.BringToFront()
    '        CloseAll()
    '    End If


    'End Sub
    'Private Sub CloseAll()
    '    needToWrite()
    '    btnRestart.Enabled = True
    '    btnRestart.Visible = True
    '    btnRestart.Left = Me.Width / 2
    '    btnRestart.Top = Me.Height / 2
    '    btnRestart.BringToFront()
    '    gotoMain.Enabled = True
    '    gotoMain.Visible = True
    '    gotoMain.Left = Me.Width / 2
    '    gotoMain.Top = Me.Height / 2 + 30
    '    BattleManager.Enabled = False
    'End Sub
    'Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

    '    setGame()
    '    BattleManager.Enabled = True
    'End Sub


    'Private Sub needToWrite()
    '    FileOpen(1, "scoreMultiplayer.txt", OpenMode.Append)
    '    PrintLine(1, "")
    '    PrintLine(1, "Player 1:" + n1 + " and his Score :" + CStr(score1) + "and his Life " + p1life.Text)
    '    PrintLine(1, "Player 2:" + n2 + " and his Score :" + CStr(score2) + "and his Life " + p2life.Text)
    '    PrintLine(1, "")
    '    FileClose(1)
    'End Sub


End Class
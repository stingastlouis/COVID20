Imports System.Random

Public Class Form2



    '--------Array-----------
    Dim wall() As PictureBox
    Dim Bonus() As PictureBox
    Dim ItemVaccin() As PictureBox
    Dim ground() As PictureBox
    Dim lifeBox() As PictureBox
    Dim platform() As PictureBox
    Dim Enemy() As PictureBox
    Dim player() As PictureBox
    Dim allowToshotShotGUNl As Boolean
    Dim bullet1(-1) As PistoleBullet1

    Dim shotGun() As PictureBox
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
    '----------------------------

    Private Sub mainCamera_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim lvl2 = New MyGameManager("John", previousLife, previousScore, previousItems) 'name or name,life,score,item
        setGame()
    End Sub
    Private Sub setGame()

        RestartBtn.Enabled = False
        lastGun.Visible = False
        lastItem1.Visible = False

        lastGun.Enabled = False
        lastItem1.Enabled = False
        Score = mainCamera.universalScore
        pScore.Text = "Score :" + CStr(Score)
        RestartBtn.Visible = False
        winorloseTxt.Visible = False
        extbtn.Visible = False
        count = 0
        bulletNumber = -1

        Label1.Visible = False
        Label1.Enabled = False
        finishLine.Enabled = False
        ProgressBar1.Value = 20
        ProgressBar1.Enabled = False
        ProgressBar1.Visible = False
        My.Computer.Audio.Play(My.Resources.Dosseh___Le_bruit_du_silence__Clip_Officiel_, AudioPlayMode.BackgroundLoop)
        shotGun = {gun1, gun2, lastGun}
        ground = {ground1, ground2}
        allowToshotShotGUNl = False
        Speed = 15
        JumpSpeed = 20
        gravitySpeed = 3
        Life_Point = 3
        gameManager.Enabled = True
        IsJumping = False
        wall = {wall1, wall2, wall5, wall3, wall4, wall7, wall6, wall8, wall9, wall10, wall11, wall12, wall14, wall15, wall16, wall17, wall22, wall23, wakk24, wall25, wall26, wall27, beforeBoss}
        ItemVaccin = {Item1, Item2, Item3, Item7, Item6, Item41, lastItem1}
        lifeBox = {life1, life2, lastLife}


        Bonus = {bonus1, bonus2, bonus3, bonus4, bonus5, bonus6, bonus9, bonus10, bonus13, bonus14, bonus15}
        Enemy = {enemy2, enemy3, enemy4, enemy5, enemy6, enemy7, enemy8, enemy9, enemy12, enemy15, enemy17, enemy40, enemy41}
        pointRegenerator = New Point(10, 10)
        For x As Integer = 0 To lifeBox.Length - 1
            lifeBox(x).Image = My.Resources.HP_Bonus_03
            lifeBox(x).BackColor = Color.Transparent
            lifeBox(x).SizeMode = PictureBoxSizeMode.StretchImage
        Next
        For y As Integer = 0 To Bonus.Length - 1
            Bonus(y).Image = My.Resources.image_1
            Bonus(y).BackColor = Color.Transparent
            Bonus(y).SizeMode = PictureBoxSizeMode.StretchImage
        Next
        For m As Integer = 0 To shotGun.Length - 1
            shotGun(m).Image = My.Resources.gun2
            shotGun(m).BackColor = Color.Transparent
            shotGun(m).SizeMode = PictureBoxSizeMode.StretchImage
        Next
        For b As Integer = 0 To wall.Length - 1
            wall(b).Image = My.Resources.Prop_6
            wall(b).BackColor = Color.Transparent
            wall(b).SizeMode = PictureBoxSizeMode.StretchImage
        Next
        For c As Integer = 0 To ItemVaccin.Length - 1
            ItemVaccin(c).Image = My.Resources.item
            ItemVaccin(c).BackColor = Color.Transparent
            ItemVaccin(c).SizeMode = PictureBoxSizeMode.StretchImage
        Next
        For d As Integer = 0 To Enemy.Length - 1
            Enemy(d).Image = My.Resources._0_Ogre_Idle_000
            Enemy(d).BackColor = Color.Transparent
            Enemy(d).SizeMode = PictureBoxSizeMode.StretchImage
            Enemy(d).BringToFront()

        Next
        For e As Integer = 0 To ground.Length - 1
            ground(e).Image = My.Resources.GrassCliffMid
            ground(e).BackColor = Color.Transparent
            ground(e).SizeMode = PictureBoxSizeMode.StretchImage
        Next
    End Sub



    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                posRight = True
                posLeft = False
            Case Keys.Left
                posLeft = True
                posRight = False
            Case Keys.Up
                posUp = True
                count += 1

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
                        pItem.Text = "Item: " + CStr(Item_Collected)
                    End If
                End If

            Case Keys.Escape
                Me.Close()
                startHere.Show()
        End Select
    End Sub



    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                posRight = False
                player1.Image = My.Resources.player1Mov
            Case Keys.Left
                posLeft = False
                player1.Image = My.Resources.player1Mov
            Case Keys.Up
                posUp = False

        End Select
    End Sub




    '----------All METHODS AND FUNCTIONS DOWN HERE---------------
    Private Sub gameManager_Tick(sender As Object, e As EventArgs) Handles gameManager.Tick
        'wantTogoOut()
        moveMycamera()
        checkmovement()
        checkGun()

        For x As Integer = 0 To ground.Length - 1
            If checkforCollision(player1, ground(x)) = False Then
                giveGravity(player1)
            Else
                stopThatGravity(player1)
                count = 0
            End If

        Next

        makeEnemyMove(player1)
        UpdatePlayer()
        'getObjectToground()
        loserWinner()
        bulletManager()
    End Sub



    Private Sub checkmovement()
        If posLeft Then
            player1.Left -= Speed
            player1.Image = My.Resources.walk
            If player1.Left < 0 Then
                player1.Left += Speed
            End If
            For x As Integer = 0 To wall.Length - 1
                If checkforCollision(player1, wall(x)) Then
                    player1.Left += Speed
                End If
            Next


        End If
        If posRight Then
            player1.Left += Speed
            player1.Image = My.Resources.walk
            For y As Integer = 0 To wall.Length - 1
                If checkforCollision(player1, wall(y)) Then
                    player1.Left -= Speed
                End If
            Next
        End If
        '---------------HERE THE COUNT IS VERY IMPORTANT-------------------
        If posUp And player1.Top > ground1.Top - 200 And Not count > 2 Then
            player1.Top -= JumpSpeed
            For x As Integer = 0 To wall.Length - 1

                If player1.Bounds.IntersectsWith(wall(x).Bounds) Then
                    player1.Top += JumpSpeed
                End If
            Next
        Else

        End If

        '-------------------------------------------------------------------
        If posUp And (posLeft Or posRight) Then
            player1.Top += JumpSpeed
        End If


    End Sub

    '-------------Method for gravity----------------------
    Private Sub giveGravity(ByVal ob1)
        ob1.Top += gravitySpeed

        For x As Integer = 0 To wall.Length - 1
            If checkforCollision(ob1, wall(x)) Then
                ob1.Top -= gravitySpeed
                If posUp Then
                    ob1.Top -= JumpSpeed + 90
                    If ob1.Top <= wall(x).Top + wall(x).Height Then
                        ob1.Top += JumpSpeed
                    End If

                End If
            End If

        Next

    End Sub
    Private Sub stopThatGravity(ByVal ob1)
        ob1.Top -= gravitySpeed
    End Sub


    '----------------------------------------------------

    'METHOD FOR COLLISION---------------------
    Function checkforCollision(ByVal ob1 As Object, ByVal ob2 As Object) As Boolean
        Dim collided As Boolean = False
        If ob1.Top + ob1.Height >= ob2.Top - 5 And
        ob2.Top + ob2.Height >= ob1.Top And
        ob1.Left + ob1.Width >= ob2.Left And
        ob2.Left + ob2.Width >= ob1.Left Then
            collided = True

        End If
        Return collided
    End Function
    '-------------------------------------

    '--------MOVE ALL CONTENT UPON PLAYER LOCATION--------------
    Private Sub moveMycamera()

        If player1.Left + player1.Width >= Me.Left + Me.Width Then
            Do While Not player1.Left <= 1
                Dim change As Integer = Me.HorizontalScroll.Value + Me.HorizontalScroll.SmallChange * 3
                Me.AutoScrollPosition = New Point(change, 0)
            Loop
        End If



        'If player1.Left + player1.Width >= Me.Left + Me.Width - 50 Then
        '    Do While Not player1.Left <= 1
        '        Me.BackColor = Color.Black

        '        posLeft = False
        '        posRight = False
        '        posUp = False
        '        allowToshotShotGUNl = False
        '        For Each content As Control In Me.Controls
        '            If TypeOf content Is PictureBox Or TypeOf content Is Label Then
        '                If content.Tag = "content" Then
        '                    content.BackColor = Color.Black
        '                    content.Left -= 30
        '                End If
        '            End If
        '        Next

        '    Loop
        'End If


        'If Not player1.Left >= beforeBoss.Left + beforeBoss.Width Then
        '    If player1.Left > Me.Width / 2 Then

        '        For Each m As Control In Me.Controls
        '            If TypeOf m Is PictureBox Or TypeOf m Is Label Then
        '                If m.Tag = "content" Then
        '                    m.Left -= Speed
        '                End If
        '            End If
        '        Next
        '    Else
        '    End If
        'Else
        '    If player1.Left + player1.Width >= Me.Width Then
        '        player1.Left -= Speed
        '    End If
        '    lastWave()
        '    If allowToshotShotGUNl = False Then
        '        Item_Collected = 2
        '        pItem.Text = "Item :" + CStr(Item_Collected)
        '        allowToshotShotGUNl = True
        '    End If
        'End If
    End Sub

    Private Sub beforeRestart()
        If Not player1.Left <= Item2.Left And Item2.Enabled = False Then
            For Each m As Control In Me.Controls
                If TypeOf m Is PictureBox Then
                    If m.Tag = "content" Then
                        m.Left += 15
                    End If
                End If
            Next
        Else

        End If


    End Sub

    Private Sub UpdatePlayer()

        'CHECK FOR COLLISION WITH CASH ----------------------
        For x As Integer = 0 To Bonus.Length - 1
            If checkforCollision(player1, Bonus(x)) And Bonus(x).Enabled = True Then
                Score += 3
                pScore.Text = "Score :" + CStr(Score)

                Me.Controls.Remove(Bonus(x))
                Bonus(x).Enabled = False



            End If
        Next
        '-------------------------------------

        'CHECK FOR COLLISION WITH LIFE ----------------
        For y As Integer = 0 To lifeBox.Length - 1
            If checkforCollision(player1, lifeBox(y)) And lifeBox(y).Enabled = True Then
                Life_Point += 1
                Score += 1
                pScore.Text = "Score :" + CStr(Score)
                pLife.Text = "X" + CStr(Life_Point)


                Me.Controls.Remove(lifeBox(y))
                lifeBox(y).Enabled = False


            End If
        Next
        '----------------------------------------------

        'CHECK FOR COLLISION WITH ITEM FOR VACCIN----------------
        For z As Integer = 0 To ItemVaccin.Length - 1
            If checkforCollision(player1, ItemVaccin(z)) And ItemVaccin(z).Enabled = True Then
                Item_Collected += 1
                Score += 5
                pScore.Text = "Score :" + CStr(Score)
                pItem.Text = "Item :" + CStr(Item_Collected)


                Me.Controls.Remove(ItemVaccin(z))
                ItemVaccin(z).Enabled = False


            End If
        Next
        '----------------------------------------------


        'CHECK FOR COLLISION WITH ENEMY ----------------------
        For a As Integer = 0 To Enemy.Length - 1
            If checkforCollision(player1, Enemy(a)) And Enemy(a).Enabled = True Then
                Life_Point -= 1
                pLife.Text = "X" + CStr(Life_Point)


                Me.Controls.Remove(Enemy(a))
                Enemy(a).Enabled = False


            End If
        Next

        '-------------------------------------
    End Sub

    Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        If RestartBtn.Text = "Restart" Then
            Me.Hide()
            Dim f1 = New mainCamera()
            f1.Show()
        End If
        If RestartBtn.Text = "Continue" Then
            Me.Close()
            Form3.Show()
        End If
    End Sub




    '-------------------MAin of enemy movements------------------------------
    Private Sub makeEnemyMove(ByVal pyer As Object)
        For x As Integer = 0 To Enemy.Length - 1

            contaminatePlayer(Enemy(x), pyer) 'Important Check Below

            For y As Integer = 0 To ground.Length - 1
                If checkforCollision(Enemy(x), ground(y)) = False Then
                    Enemy(x).Top += gravitySpeed
                    For z As Integer = 0 To wall.Length - 1
                        If Enemy(x).Bounds.IntersectsWith(wall(z).Bounds) Then
                            Enemy(x).Top -= 15
                        End If
                    Next
                Else
                    Enemy(x).Top -= gravitySpeed
                End If

            Next

        Next

    End Sub




    '------------------------------------------------------------------------

    '---It makes the enemies moves toward the user and checks if there is wall --------
    Private Sub contaminatePlayer(ByRef ob1 As Object, ByRef ob2 As Object)
        If ob1.left + ob1.Width > ob2.left Then
            ob1.left -= 1
            For m As Integer = 0 To wall.Length - 1
                If checkforCollision(ob1, wall(m)) Then
                    ob1.left += 1
                End If
            Next
        End If
        If ob1.left + ob1.Width < ob2.left Then
            ob1.left += 1
            For m As Integer = 0 To wall.Length - 1
                If checkforCollision(ob1, wall(m)) Then
                    ob1.left -= 1
                End If
            Next
        End If
        If ob1.Top + ob1.Height > ob2.Top Then
            ob1.Top -= 1
        End If
        If ob1.Top + ob1.Height < ob2.Top Then
            ob1.Top += 1
        End If
    End Sub


















    '----------------------------------------------------------------------------------
    Private Sub AssignRandomPosition(ByRef obj As Object)
        Dim ran As New Random
        generator = ran.Next(0, 1000) + 1


        obj.Top = 0
        obj.Left = Me.Width * 1 + generator

    End Sub
    'Private Sub getObjectToground()
    '    For x As Integer = 0 To ground.Length - 1
    '        For y As Integer = 0 To Bonus.Length - 1
    '            If checkforCollision(ground(x), Bonus(y)) = False Then
    '                Bonus(y).Top += 1
    '                For z As Integer = 0 To wall.Length - 1
    '                    If checkforCollision(Bonus(y), wall(z)) Then
    '                        Bonus(y).Top -= 1

    '                    End If
    '                Next
    '            Else
    '                Bonus(y).Top -= 1
    '            End If
    '        Next

    '        For m As Integer = 0 To lifeBox.Length - 1
    '            If checkforCollision(ground(x), lifeBox(m)) = False Then
    '                lifeBox(m).Top += 1
    '                For n As Integer = 0 To wall.Length - 1
    '                    If checkforCollision(lifeBox(m), wall(n)) Then
    '                        lifeBox(m).Top -= 1
    '                    End If
    '                Next
    '            Else
    '                lifeBox(m).Top -= 1
    '            End If
    '        Next

    '        For mo As Integer = 0 To ItemVaccin.Length - 1
    '            If checkforCollision(ground(x), ItemVaccin(mo)) = False Then
    '                ItemVaccin(mo).Top += 1
    '                For no As Integer = 0 To wall.Length - 1
    '                    If checkforCollision(ItemVaccin(mo), wall(no)) Then
    '                        ItemVaccin(mo).Top -= 1
    '                    End If
    '                Next
    '            Else
    '                ItemVaccin(mo).Top -= 1
    '            End If
    '        Next
    '    Next




    'End Sub

    Private Sub loserWinner()
        If ProgressBar1.Value <= 0 Then
            posRight = False
            posLeft = False
            posUp = False
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
            posRight = False
            posLeft = False
            posUp = False
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
        For z As Integer = 0 To shotGun.Length - 1
            If checkforCollision(player1, shotGun(z)) And shotGun(z).Enabled = True Then
                Score += getPointShotGun
                pScore.Text = "Score :" + CStr(Score)
                shotGun(z).Enabled = True
                Me.Controls.Remove(shotGun(z))

                allowToshotShotGUNl = True
            End If
        Next
    End Sub

    Private Sub bulletManager()

        For x As Integer = 0 To bullet1.Length - 1
            bullet1(x).Shoot(player1)

            If bullet1(x).Left = Me.Width Then
                bullet1(x).Enabled = False
                bullet1(x).Dispose()

            End If
            If checkforCollision(bullet1(x), finishLine) And finishLine.Enabled = True And bullet1(x).Enabled = True Then
                ProgressBar1.Value -= 1
                Score += 30 * 0.5
                pScore.Text = "Score: " + CStr(Score)
                bullet1(x).Enabled = False
                bullet1(x).Dispose()

                finishLine.Enabled = False
            End If
            '--------------------------------------------
            '----kill enemy------------------------------
            For y As Integer = 0 To Enemy.Length - 1
                If checkforCollision(bullet1(x), Enemy(y)) And bullet1(x).Enabled = True And Enemy(y).Enabled = True Then
                    Score += getEnemyScore
                    pScore.Text = "Score :" + CStr(Score)
                    bullet1(x).Dispose()
                    bullet1(x).Enabled = False
                    Enemy(y).Enabled = False
                    Me.Controls.Remove(Enemy(y))

                End If
            Next
            '-------------------------------------------
            '----------objects--Collision---------------
            For a As Integer = 0 To Bonus.Length - 1
                If checkforCollision(bullet1(x), Bonus(a)) And bullet1(x).Enabled = True And Bonus(a).Enabled = True Then
                    bullet1(x).Dispose()
                    Me.Controls.Remove(bullet1(x))
                    bullet1(x).Enabled = False
                End If
            Next
            For b As Integer = 0 To lifeBox.Length - 1
                If checkforCollision(bullet1(x), Bonus(b)) And bullet1(x).Enabled = True And lifeBox(b).Enabled = True Then
                    bullet1(x).Dispose()
                    Me.Controls.Remove(bullet1(x))
                    bullet1(x).Enabled = False
                End If
            Next
            For c As Integer = 0 To ItemVaccin.Length - 1
                If checkforCollision(bullet1(x), ItemVaccin(c)) And bullet1(x).Enabled = True And ItemVaccin(c).Enabled = True Then
                    bullet1(x).Dispose()
                    Me.Controls.Remove(bullet1(x))
                    bullet1(x).Enabled = False
                End If
            Next
            '-------------------------------------------
        Next
    End Sub
    Dim timer1, timer2, timer3 As Integer



    Private Sub extbtn_Click(sender As Object, e As EventArgs) Handles extbtn.Click
        Me.Hide()
        startHere.ShowDialog()
    End Sub

    Dim ran1 As New System.Random
    Dim loc As New Integer
    Private timeLimit As Integer
    Private timeLimit2 As Integer
    Private timeLimit3 As Integer

    Private Sub lastWave()
        Label1.Visible = True
        Label1.Enabled = True
        ProgressBar1.Enabled = True
        ProgressBar1.Visible = True
        finishLine.Enabled = True
        lastGun.Enabled = True
        lastGun.Visible = True
        If player1.Left + player1.Width >= Me.Width Then
            player1.Left -= Speed
        End If
        contaminatePlayer(finishLine, player1)
        If checkforCollision(player1, finishLine) Then
            Life_Point -= 1
            pLife.Text = "X " + CStr(Life_Point)
            pScore.Text = "Score :" + CStr(Score)
            pItem.Text = "Item :" + CStr(Item_Collected)

        End If
        If checkforCollision(player1, lastGun) And lastGun.Enabled = True Then
            allowToshotShotGUNl = True
            Item_Collected = 2
            pItem.Text = "Item :" + CStr(Item_Collected)

        End If







    End Sub



End Class

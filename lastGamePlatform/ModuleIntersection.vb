

Module ModuleIntersection

	Public Sub bulletIntersectsWithBoss(ByRef pro As ProgressBar, ByRef bullets As List(Of PictureBox), ByVal boss As Object)
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(boss.Bounds) AndAlso boss.Visible Then
				ClassPlayer.score += ClassItems.scoreBoss
				If pro.Value > 0 Then
					pro.Value -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
					ClassPlayer.score += ClassItems.scoreBoss
				End If
				If pro.Value <= 0 Then


					Console.WriteLine("oo boss dead")


					ModuleGameManager.RemovePictureBoxAndUpdateScore(boss)
				End If
				bullets.Remove(bullet)
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub
	Public Sub bulletIntersectsWithBossMultiP1(ByRef pro As ProgressBar, ByRef bullets As List(Of PictureBox), ByVal boss As Object)
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(boss.Bounds) AndAlso boss.Visible Then

				'ClassPlayer.score += ClassItems.scoreBoss
				'multiplayerRegForm.p2.playerScore += ClassItems.scoreBoss
				If pro.Value > 0 Then
					pro.Value -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
					'ClassPlayer.score += ClassItems.scoreBoss
					multiplayerRegForm.p1.playerScore += ClassItems.scoreBoss
					ModuleGameManager.p1Score.Text = "SCORE " + CStr(multiplayerRegForm.p1.playerScore)
				End If
				If pro.Value <= 0 Then

					Console.WriteLine("oo boss dead")


					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(boss)
				End If
				bullets.Remove(bullet)
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub
	Public Sub bulletIntersectsWithBossMultiP2(ByRef pro As ProgressBar, ByRef bullets As List(Of PictureBox), ByVal boss As Object)
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(boss.Bounds) AndAlso boss.Visible Then

				'ClassPlayer.score += ClassItems.scoreBoss
				'multiplayerRegForm.p2.playerScore += ClassItems.scoreBoss
				If pro.Value > 0 Then
					pro.Value -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
					'ClassPlayer.score += ClassItems.scoreBoss
					multiplayerRegForm.p2.playerScore += ClassItems.scoreBoss
					ModuleGameManager.p2Score.Text = "SCORE " + CStr(multiplayerRegForm.p2.playerScore)
				End If
				If pro.Value <= 0 Then

					Console.WriteLine("oo boss dead")


					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(boss)
				End If
				bullets.Remove(bullet)
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub
	Public Sub bulletIntersectsWithMultiP2(ByRef bullets As List(Of PictureBox), ByVal player As Object)
		'player 1 shoot player2 
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(player.Bounds) AndAlso bullet.Enabled AndAlso player.Visible Then

				bullet.Visible = False
				bullet.Enabled = False

				bullet.Dispose()
				'ClassPlayer.score += ClassItems.scoreBoss
				'multiplayerRegForm.p2.playerScore += 5
				If multiplayerRegForm.p2.playerLife > 0 Then

					player2.Location = New Point(player2.Location.X + 10, player2.Location.Y)

					multiplayerRegForm.p2.playerLife -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")

					multiplayerRegForm.p1.playerScore += 5
					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(bullet)
				End If
				If multiplayerRegForm.p2.playerLife <= 0 Then

					Console.WriteLine("oo player2 dead")


					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(player)
					player.visible = False

				End If
				bullets.Remove(bullet)
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub
	Public Sub bulletIntersectsWithMultiP1(ByRef bullets As List(Of PictureBox), ByRef player As Object)
		'PLAYER 2 HIT PLAYER 1 
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(player.Bounds) AndAlso player.Visible Then

				'ClassPlayer.score += ClassItems.scoreBoss
				'multiplayerRegForm.p2.playerScore += ClassItems.scoreBoss
				If multiplayerRegForm.p1.playerLife > 0 Then
					player1.Location = New Point(player1.Location.X - 10, player1.Location.Y)


					multiplayerRegForm.p1.playerLife -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
					'ClassPlayer.score += ClassItems.scoreBoss
					multiplayerRegForm.p2.playerScore += 5
					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(bullet)
				End If

				If multiplayerRegForm.p1.playerLife <= 0 Then

					Console.WriteLine("oo boss dead")
					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(player)
				End If
				bullets.Remove(bullet)
				ModuleGameManager.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub


	Public Sub playerIntersectWithStaticPictureBoxesSingle()
		ClassPlayer.playerIsFalling = True


		For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes 'list all controls in the form
			If (activePictureBox IsNot ModuleGameManager.player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds)) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					If player1.Top > activePictureBox.Top - player1.Height Then 'to stay on top of ground and wall
						player1.Location = New Point(player1.Location.X, activePictureBox.Top - player1.Height)
						ClassPlayer.playerIsFalling = False


					End If

					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then

					ClassPlayer.score += ClassItems.scoreLife
					ClassPlayer.life += 1
					ClassPlayer.item += 1
					RemovePictureBoxAndUpdateScore(activePictureBox)


					'Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("gun") Then
					If activePictureBox.Name.Contains("supergun") Then
						ClassPlayer.score += ClassItems.scoreSuperGun
					Else
						ClassPlayer.score += ClassItems.scoreGun
					End If
					ClassPlayer.item += 1
					RemovePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					ClassPlayer.item += 1
					ClassPlayer.score += ClassItems.scoreAdn
					Console.WriteLine("new adn")
					RemovePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then
					ClassPlayer.item += 1
					ClassPlayer.score += ClassItems.scoreCoin
					Console.WriteLine("new coin")
					ModuleGameManager.RemovePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If

			End If
		Next
	End Sub

	Public Sub playerIntersectWithStaticPictureBoxes()
		ClassPlayer.playerIsFalling = True
		multiplayerRegForm.p1.playerFall = True '=============================

		For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes 'list all controls in the form
			If (activePictureBox IsNot ModuleGameManager.player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds)) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					If player1.Top > activePictureBox.Top - player1.Height Then 'to stay on top of ground and wall
						player1.Location = New Point(player1.Location.X, activePictureBox.Top - player1.Height)
						ClassPlayer.playerIsFalling = False
						multiplayerRegForm.p1.playerFall = False '====================

					End If

					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then
					multiplayerRegForm.p1.playerLife += 1
					multiplayerRegForm.p1.playerScore += ClassItems.scoreLife


					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					'Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("gun") Then
					If activePictureBox.Name.Contains("supergun") Then
						multiplayerRegForm.p1.playerScore += ClassItems.scoreSuperGun
					Else
						multiplayerRegForm.p1.playerScore += ClassItems.scoreGun
					End If

					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					ClassPlayer.item += 1
					multiplayerRegForm.p1.playerScore += ClassItems.scoreAdn
					Console.WriteLine("new adn")
					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then

					multiplayerRegForm.p1.playerScore += ClassItems.scoreCoin
					Console.WriteLine("new coin")
					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("player2") Then
					player1.Location = New Point(player1.Location.X - 10, player1.Location.Y)
					player2.Location = New Point(player2.Location.X + 10, player2.Location.Y)
					multiplayerRegForm.p1.playerScore -= 5
					multiplayerRegForm.p1.playerLife -= 1
					multiplayerRegForm.p2.playerScore -= 5
					multiplayerRegForm.p2.playerLife -= 1
					ModuleGameManager.p1Score.Text = "SCORE: " + CStr(multiplayerRegForm.p1.playerScore)
					ModuleGameManager.p2Score.Text = "SCORE: " + CStr(multiplayerRegForm.p2.playerScore)
					ModuleGameManager.p1Life.Text = "LIFE: " + CStr(multiplayerRegForm.p1.playerLife)
					ModuleGameManager.p2Life.Text = "LIFE: " + CStr(multiplayerRegForm.p2.playerLife)


					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
			End If
		Next
	End Sub
	Public Sub playerIntersectWithStaticPictureBoxes2()

		multiplayerRegForm.p2.playerFall = True '=============================
		For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes 'list all controls in the form
			If (activePictureBox IsNot ModuleGameManager.player2 AndAlso player2.Bounds.IntersectsWith(activePictureBox.Bounds)) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then

					If player2.Top > activePictureBox.Top - player2.Height Then 'to stay on top of ground and wall
						player2.Location = New Point(player2.Location.X, activePictureBox.Top - player2.Height)

						multiplayerRegForm.p2.playerFall = False '====================
					End If
					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then

					multiplayerRegForm.p2.playerLife += 1
					multiplayerRegForm.p2.playerScore += ClassItems.scoreLife


					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					'Module1.removePictureBoxandUpdateScore(activePictureBox, Me, pScore, pLife, pItem)
					Exit For 'exit the for loop as picturebox name contains "life" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("gun") Then
					If activePictureBox.Name.Contains("supergun") Then
						multiplayerRegForm.p2.playerScore += ClassItems.scoreSuperGun
					Else
						multiplayerRegForm.p2.playerScore += ClassItems.scoreGun
					End If



					multiplayerRegForm.p2.playerScore += ClassItems.scoreGun

					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then

					multiplayerRegForm.p2.playerScore += ClassItems.scoreAdn
					Console.WriteLine("new adn")
					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then


					multiplayerRegForm.p2.playerScore += ClassItems.scoreCoin
					Console.WriteLine("new coin")
					ModuleGameManager.removeItemPictureMBoxMulti(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("Player1") Then

					'p1Life.Text = "LIFE :" + CStr(multiplayerRegForm.p1.playerLife)
					'p2Life.Text = "LIFE :" + CStr(multiplayerRegForm.p2.playerLife)
					'p1Score.Text = "SCORE : " + CStr(multiplayerRegForm.p1.playerScore)
					'p2Score.Text = "SCORE : " + CStr(multiplayerRegForm.p2.playerScore)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
			End If
		Next
	End Sub

	Public Sub BulletIntersectWithEnemy()
		For Each bullet In ModuleGameManager.bullets
			For Each enemy In ModuleGameManager.enemies
				If enemy.Bounds.IntersectsWith(bullet.Bounds) And enemy.Enabled Then 'if bullet intersect with enemies 
					Dim enemyLocation As Point = enemy.Location
					Dim enemySize As Size = enemy.Size
					Console.WriteLine("bullet intersect enemy")
					ClassPlayer.score += ClassItems.scoreEnemy
					ModuleGameManager.RemovePictureBoxAndUpdateScore(bullet)
					ModuleGameManager.RemovePictureBoxAndUpdateScore(enemy)
					generateExplosion(enemySize, enemyLocation)


					Exit For 'break as current <> has been modified
				End If
			Next
			'Exit For 'break as current <> has been modified
		Next
	End Sub

	Private Sub generateExplosion(enemySize As Size, enemyLocation As Point)
		Dim pb As New PictureBox With {
			.Size = enemySize,
			.Name = "EneExplosion",
			.Location = enemyLocation
		}
		Dim explosion As New ClassAnimation(pb)
		myForm.Controls.Add(pb)
	End Sub
	Private Sub generateExplosionmulti(enemySize As Size, enemyLocation As Point)
		Dim pb As New PictureBox With {
			.Size = enemySize,
			.Name = "EneExplosion",
			.Location = enemyLocation
		}
		Dim explosion As New ClassAnimation(pb, "gotyou")
		myForm.Controls.Add(pb)
	End Sub

	Public Sub EnemyIntersectWithPlayer()
		For Each enemy In ModuleGameManager.enemies
			If ModuleGameManager.player1 IsNot enemy AndAlso enemy.Bounds.IntersectsWith(ModuleGameManager.player1.Bounds) And enemy.Enabled Then
				ClassPlayer.life -= 1
				Console.WriteLine("player intersect with enemy")
				Dim enemyLocation As Point = enemy.Location
				Dim enemySize As Size = enemy.Size
				multiplayerRegForm.p1.playerScore += ClassItems.scoreEnemy

				generateExplosionmulti(enemySize, enemyLocation)
				ModuleGameManager.enemies.Remove(enemy)
				ModuleGameManager.RemovePictureBoxAndUpdateScore(enemy)
				Exit For
			End If
		Next
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
		'			removePictureBoxandUpdateScore(activePictureBox)
		'			Exit For 'exit the for loop as picturebox name contains "enemy" help in using less cpu power
		'		End If

		'	End If
		'Next
	End Sub

	Public Sub bulletIntersectStaticItem1()
		For Each bullet In ModuleGameManager.bullets
			For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes
				If activePictureBox.Name.Contains("wall2") Then 'if bullet intersect with enemies 
					If bullet.Bounds.IntersectsWith(activePictureBox.Bounds) Then
						ModuleGameManager.bullets.Remove(bullet) 'remove fro bullets<>
						ModuleGameManager.allPictureBoxes.Remove(bullet)
						bullet.Dispose()
						bullet.Visible = False
					End If


					'Exit For 'break as current <> has been modified
					Exit For
				End If
			Next
			'Exit For 'break as current <> has been modified
			Exit For
		Next





	End Sub

	Public Sub bulletIntersectStaticItem2()
		For Each bullet In ModuleGameManager.bullets2
			For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes
				If activePictureBox.Name.Contains("wall1") Then 'if bullet intersect with enemies 
					If bullet.Bounds.IntersectsWith(activePictureBox.Bounds) Then
						ModuleGameManager.bullets2.Remove(bullet) 'remove fro bullets<>
						ModuleGameManager.allPictureBoxes.Remove(bullet)
						bullet.Visible = False
						bullet.Dispose()
					End If


					'Exit For 'break as current <> has been modified
					Exit For
				End If
			Next
			'Exit For 'break as current <> has been modified
			Exit For
		Next





	End Sub
	Public Sub BulletIntersectWithEnenyBullet1()
		For Each bullet In ModuleGameManager.bullets
			For Each enemy In ModuleGameManager.bulletsEnemy2
				If enemy.Bounds.IntersectsWith(bullet.Bounds) And enemy.Enabled Then 'if bullet intersect with enemies 
					Dim enemyLocation As Point = enemy.Location
					Dim enemySize As Size = enemy.Size
					Console.WriteLine("bullet intersect enemy")
					multiplayerRegForm.p1.playerScore += ClassItems.scoreEnemy

					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(bullet)
					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(enemy)
					generateExplosionmulti(enemySize, enemyLocation)

					'Exit For 'break as current <> has been modified
				End If
				Exit For
			Next
			'Exit For 'break as current <> has been modified
			Exit For
		Next
	End Sub
	Public Sub BulletIntersectWithEnenyBullet2()
		For Each bullet In ModuleGameManager.bullets2
			For Each enemy In ModuleGameManager.bulletsEnemy
				If enemy.Bounds.IntersectsWith(bullet.Bounds) And enemy.Enabled Then 'if bullet intersect with enemies 
					Dim enemyLocation As Point = enemy.Location
					Dim enemySize As Size = enemy.Size
					Console.WriteLine("bullet intersect enemy")
					multiplayerRegForm.p1.playerScore += ClassItems.scoreEnemy

					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(bullet)
					ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(enemy)
					generateExplosionmulti(enemySize, enemyLocation)

					'Exit For 'break as current <> has been modified
				End If
				Exit For
			Next
			'Exit For 'break as current <> has been modified
			Exit For
		Next
	End Sub
	Public Sub EnemyIntersectPlayer2()

		For Each enemy In ModuleGameManager.bulletsEnemy
			If enemy.Bounds.IntersectsWith(player2.Bounds) And enemy.Enabled And player1.Enabled Then 'if bullet intersect with enemies 

				Console.WriteLine("bullet intersect enemy")
				multiplayerRegForm.p2.playerLife -= 1


				ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(enemy)

				'Exit For 'break as current <> has been modified
			End If
			Exit For
		Next
		'Exit For 'break as current <> has been modified

	End Sub
	Public Sub EnemyIntersectPlayer1()

		For Each enemy In ModuleGameManager.bulletsEnemy2
			If enemy.Bounds.IntersectsWith(player1.Bounds) And enemy.Enabled And player1.Enabled Then 'if bullet intersect with enemies 

				Console.WriteLine("bullet intersect enemy")
				multiplayerRegForm.p1.playerLife -= 1


				ModuleGameManager.RemovePictureBoxAndUpdateScoremulti(enemy)

				'Exit For 'break as current <> has been modified
			End If
			Exit For
		Next
		'Exit For 'break as current <> has been modified

	End Sub


	Public Sub player1hitBoss()


		If boss.Bounds.IntersectsWith(player1.Bounds) And boss.Enabled And player1.Enabled Then


			multiplayerRegForm.p1.playerLife -= 1

			ModuleGameManager.p1Life.Text = "LIFE: " + CStr(multiplayerRegForm.p1.playerLife)
			ModuleGameManager.CheckIfWinOrLoseMulti()
		End If

	End Sub
	Public Sub player2hitBoss()


		If boss.Bounds.IntersectsWith(player2.Bounds) And boss.Enabled And player2.Enabled Then


			multiplayerRegForm.p2.playerLife -= 1

			ModuleGameManager.p2Life.Text = "LIFE: " + CStr(multiplayerRegForm.p2.playerLife)
			ModuleGameManager.CheckIfWinOrLoseMulti()
		End If

	End Sub

	Public Sub outofscreen()
		If player1.Left <= 0 Then
			player1.Location = New Point(player1.Location.X + 10, player1.Location.Y)
		End If
	End Sub
	Public Sub outofscreen2()
		If player2.Left + player2.Width >= myForm.Width Then
			player2.Location = New Point(player2.Location.X - 10, player2.Location.Y)
		End If
	End Sub
End Module

Module ModuleIntersection









	Public Sub bulletIntersectsWithBoss(ByRef pro As ProgressBar, ByRef bullets As List(Of PictureBox), ByVal boss As Object)
		For Each bullet In bullets
			If bullet.Bounds.IntersectsWith(boss.Bounds) AndAlso boss.Visible Then
				ClassPlayer.score += ClassItems.scoreBoss
				If pro.Value > 0 Then
					pro.Value -= 1
					Console.WriteLine("boooooooommmmmmmm bullet touch with boss")
				End If
				If pro.Value <= 0 Then
					pro.Value = 0
					Console.WriteLine("oo boss dead")
					ClassPlayer.score += ClassItems.scoreBoss
					ClassMyPublicShared.allPictureBoxes.Remove(boss)

				End If
				bullets.Remove(bullet)
				ClassMyPublicShared.allPictureBoxes.Remove(bullet)
				bullet.Dispose()
				Exit For 'break as current <> has been modified
			End If
		Next
	End Sub






	Public Sub playerIntersectWithStaticPictureBoxes()
		ClassPlayer.playerIsFalling = True
		For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
			If activePictureBox IsNot ModuleGameManager.player1 AndAlso player1.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
				If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
					If player1.Top > activePictureBox.Top - player1.Height Then 'to stay on top of ground and wall
						player1.Location = New Point(player1.Location.X, activePictureBox.Top - player1.Height)
						ClassPlayer.playerIsFalling = False
					End If
					Exit For
				End If
				If activePictureBox.Name.Contains("life") Then
					ClassPlayer.item += 1
					ClassPlayer.life += 1 'updated
					ClassPlayer.score += ClassItems.scoreLife
					Console.WriteLine("new life")
					ModuleGameManager.removePictureBoxAndUpdateScore(activePictureBox)
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
					Console.WriteLine("new gun")
					ModuleGameManager.removePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "gun" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("adn") Then
					ClassPlayer.item += 1
					ClassPlayer.score += ClassItems.scoreAdn
					Console.WriteLine("new adn")
					ModuleGameManager.removePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "adn" help in using less cpu power
				End If
				If activePictureBox.Name.Contains("coin") Then
					ClassPlayer.item += 1
					ClassPlayer.score += ClassItems.scoreCoin
					Console.WriteLine("new coin")
					ModuleGameManager.removePictureBoxAndUpdateScore(activePictureBox)
					Exit For 'exit the for loop as picturebox name contains "coin" help in using less cpu power
				End If
			End If
		Next
	End Sub


	Public Sub bulletIntersectWithEnemy()
		For Each enemy In ModuleGameManager.enemies
			For Each bullet In ModuleGameManager.bullets
				If bullet IsNot enemy AndAlso enemy.Bounds.IntersectsWith(bullet.Bounds) Then 'if bullet intersect with enemies 
					Console.WriteLine("bullet intersect enemy")
					ClassPlayer.score += ClassItems.scoreEnemy
					ModuleGameManager.bullets.Remove(bullet) 'remove from bullets<>
					ModuleGameManager.enemies.Remove(enemy) 'remove from enemies<>
					ModuleGameManager.removePictureBoxAndUpdateScore(bullet)
					ModuleGameManager.removePictureBoxAndUpdateScore(enemy)
					Exit For 'break as current <> has been modified
				End If
			Next
			Exit For 'break as current <> has been modified
		Next
	End Sub



	Public Sub enemyIntersectWithPlayer()
		For Each enemy In ModuleGameManager.enemies
			If ModuleGameManager.player1 IsNot enemy AndAlso enemy.Bounds.IntersectsWith(player1.Bounds) Then
				Console.WriteLine("player intersect with enemy")
				ModuleGameManager.enemies.remove(enemy)
				ModuleGameManager.removePictureBoxAndUpdateScore(enemy)
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
End Module

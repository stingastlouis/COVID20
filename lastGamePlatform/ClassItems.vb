Public Class ClassItems
	'vars
	Private itemName As String
	Private itemImageLocation As String
	Public Shared scoreGun As Integer = 5
	Public Shared scoreSuperGun As Integer = 5
	Public Shared scoreEnemy As Integer = 10
	Public Shared scoreLife As Integer = 3
	Public Shared scoreCoin As Integer = 5
	Public Shared scoreAdn As Integer = 5
	Public Shared scoreBoss As Integer = 50











	'constructors
	Public Sub New()
	End Sub

	'fn
	Public Sub itemsInForm(myForm As Form)
		Dim i As Integer = 0
		For Each ctrl As Control In myForm.Controls 'scan all controls present in myform
			If TypeOf (ctrl) Is PictureBox Then 'if the control is a picturebox then
				Dim path As String = ""
				If ctrl.Name.Contains("boss") OrElse ctrl.Name.Contains("player") OrElse ctrl.Name.Contains("instruction") OrElse ctrl.Name.Contains("ground") OrElse ctrl.Name.Contains("door") Then 'all pictureboxes to exclude here
					ModuleGameManager.allPictureBoxes.Add(ctrl) 'push to list

				ElseIf ctrl.Name.Contains("supergun") Then 'e.g. gun1,lastgun...
					path = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\superGun.png")
					Dim pb As New ClassPictureBox(ctrl, path)

				ElseIf ctrl.Name.Contains("wall") Then
					path = ModuleRandomiser.randomWallImages(NumberBetween(0, ModuleRandomiser.randomWallImages.Count - 1)) 'path = return random image path in "classmypublicshared"
					Dim pb As New ClassPictureBox(ctrl, path)

				Else 'pictureboxes to include
					i += 1
					path = ModuleRandomiser.randomItemImages(NumberBetween(0, ModuleRandomiser.randomItemImages.Count - 1)) 'path = return random image path in "classmypublicshared" i.e. C:\...\lastGamePlatform\Images\coin.png for example
					Dim result As String = (IO.Path.GetFileNameWithoutExtension(path) & i).ToString() 'result = return the image name only with "i" added. e.g.coin1,adn2,coin3,...
					ctrl.Name = result 'give a new name the pictureboxes that need to have randomised items 
					Dim pb As New ClassPictureBox(ctrl, path)

				End If
			End If
		Next
	End Sub
	Public Sub updateLists(walls, enemies, enemiesSpeed)
		For Each activePictureBox As PictureBox In ModuleGameManager.allPictureBoxes
			'seperating randomPictureBoxes to specific ones
			If activePictureBox.Name.Contains("wall") Then
				walls.Add(activePictureBox) 'push to list
			ElseIf activePictureBox.Name.Contains("enemy") Then
				enemies.Add(activePictureBox)
				enemiesSpeed.Add(1)
			End If
		Next
	End Sub

End Class

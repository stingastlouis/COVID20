Public Class ClassItems




	'functions
	''' <summary>
	''' give images to pictureboxes and push to seperate list
	''' </summary>
	Public Sub populatingAllPictureBoxes()
		Dim randomPictureBoxes As New List(Of PictureBox) ' PictureBox2, PictureBox3, PictureBox4.....
		Dim myForm As Form = startHere
		If ClassMyPublicShared.level = 1 Then
			myForm = Form1
		ElseIf ClassMyPublicShared.level = 2 Then
			myForm = Form2
		ElseIf ClassMyPublicShared.level = 3 Then
			myForm = Form3
		End If
		For Each ctrl As Control In myForm.Controls 'scan all controls present in myform
			If TypeOf (ctrl) Is PictureBox Then 'if the control is a picturebox then

				If ctrl.Name.Contains("boss") OrElse ctrl.Name.Contains("player") OrElse ctrl.Name.Contains("instruction") Then 'all pictureboxes to exclude here
					ClassMyPublicShared.allPictureBoxes.Add(ctrl) 'push to list

				ElseIf ctrl.Name.Contains("gun") Then 'e.g. gun1,lastgun...
					myPredefinePictureBoxes(ctrl, My.Resources.gun2) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					ClassMyPublicShared.allPictureBoxes.Add(ctrl) 'push to list

				ElseIf ctrl.Name.Contains("ground") Then
					myPredefinePictureBoxes(ctrl, My.Resources.GrassCliffMid) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					ClassMyPublicShared.allPictureBoxes.Add(ctrl) 'push to list

				ElseIf ctrl.Name.Contains("wall") Then
					myPredefinePictureBoxes(ctrl, My.Resources.Prop_6) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					ClassMyPublicShared.allPictureBoxes.Add(ctrl) 'push to list

				ElseIf ctrl.Name.Contains("door2") Then

					myPredefinePictureBoxes(ctrl, My.Resources.door2) 'pass the control"picturebox" and the image to this method that will insert the image in the picturebox
					ClassMyPublicShared.allPictureBoxes.Add(ctrl) 'push to list

				Else 'pictureboxes to include
					randomPictureBoxes.Add(ctrl) 'add the remaining control to List<randomPictureBoxes> which will randomise the image to be inserted to the pictureboxes
				End If
			End If
		Next

		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\ItemsImages\") 'get path of the directories and replace "\bin\Debug\" with "\Images\"
		Dim imagePathArray As String() = IO.Directory.GetFiles(imgPath) 'get all files' name in the imgPath
		Dim imgList As List(Of String) = imagePathArray.ToList() 'converting array to List
		Dim listCount As Integer = imgList.Count 'get number of item(s) in the List<imgList>

		Dim i As Integer = 0
		For Each pb As PictureBox In randomPictureBoxes 'for all pictureboxes in List<randomPictureBoxes>
			i += 1
			Dim path As String = imgList(numberBetween(0, listCount - 1)) 'path = return random image path in Directory"Images" i.e. C:\...\lastGamePlatform\Images\coin.png for example
			Dim result As String = (IO.Path.GetFileNameWithoutExtension(path) & i).ToString() 'result = return the image name only with "i" added. e.g.coin1,adn2,coin3,...

			'the 2 comming lines are to give the pictureboxes nearly the same name of their images e.g. picturebox=adn10 and path=C:\...\adn.png
			pb.Name = result 'give a new name the pictureboxes that need to have randomised items refer to List<randomPictureBoxes>

			Dim img As Bitmap = Image.FromFile(path) 'insert the random image generated to picturebox
			myPredefinePictureBoxes(pb, img)

			ClassMyPublicShared.allPictureBoxes.Add(pb) 'push to list
		Next

		randomPictureBoxes = Nothing
		imgPath = Nothing
		imagePathArray = Nothing
		imgList = Nothing
		listCount = Nothing

	End Sub


	''' <summary>
	''' inserting image to control
	''' </summary>
	''' <param name="img">take a bitmap as parameter from Resources Directory</param>
	Private Sub myPredefinePictureBoxes(myPicBox As PictureBox, img As Bitmap)
		myPicBox.Image = img
		myPicBox.BackColor = Color.Transparent
		myPicBox.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub

End Class

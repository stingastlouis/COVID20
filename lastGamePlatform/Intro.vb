

Public Class Intro
	Dim myChangingLabel As New List(Of String)
	Dim myChangingPictureBoxPath As New List(Of String)
	Dim i As Integer = 0
	Dim imgPath As String = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Intro\")

	Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
		i += 1
		If i < myChangingPictureBoxPath.Count Then
			displayTextAndImage()
		Else
			NextButton.Enabled = False
		End If
	End Sub

	Private Sub GameButton_Click(sender As Object, e As EventArgs) Handles GameButton.Click
		AxWindowsMediaPlayer1.Dispose()
		Me.Hide()
		Form1.Show()
	End Sub

	Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AxWindowsMediaPlayer1.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Intro\IntroSound.mp3")
		AxWindowsMediaPlayer1.settings.setMode("Loop", True)
		myChangingLabel.Add("Le 31 Dec 2019, la novel coronavirus fait son apparition, causant des crise dans le monde.")
		myChangingPictureBoxPath.Add(imgPath & "introAfter.png")

		myChangingLabel.Add("10 mois plus tard, tou reprend a la normale.")
		myChangingPictureBoxPath.Add(imgPath & "introBefore.png")

		myChangingLabel.Add("2 semains apres cela, le virus évolue en covid-20 a un point qu'il faut un échantillon de sang des porteurs originels pour pouvoir produire un vaccin.")
		myChangingPictureBoxPath.Add(imgPath & "definition.png")

		myChangingLabel.Add("Mr. Johny dotait de compétence technique et intellectuel est le plu taillé pour affronter ce job. Il est diplomé avec excellence du MIT(Massachusetts Institute of Technology) en 'Bioengineering And Biomedical Engineering'. Ayant aussi acquis des compétences techniques tant que meilleur agent au 'US Navy SEALs'")
		myChangingPictureBoxPath.Add(imgPath & "player.png")

		displayTextAndImage()
	End Sub

	Private Sub displayTextAndImage()
		ChangingLabel.Text = myChangingLabel(i)
		ChangingPictureBox.Image = Image.FromFile(myChangingPictureBoxPath(i))
		ChangingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub

End Class


Public Class bonusForm
	Private Sub bonusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Form1.Close()
		Form2.Close()
		Form3.Close()
		BonusScenePlayer.URL = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\BonusVideo\bonusScene.mp4")
		MainMenu.BringToFront()
	End Sub

	Private Sub MainMenu_Click(sender As Object, e As EventArgs) Handles MainMenu.Click
		Me.Close()
		startHere.Show()
	End Sub

	Private Sub bonusForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Me.Dispose()
		startHere.Show()
	End Sub
End Class
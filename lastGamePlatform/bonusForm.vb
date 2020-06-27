

Public Class bonusForm
	Private Sub bonusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		BonusScenePlayer.URL = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\AudioVideo\bonusScene.mp4")
		MainMenu.BringToFront()
	End Sub


End Class
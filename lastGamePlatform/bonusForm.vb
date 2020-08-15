

Public Class bonusForm
	Private Sub bonusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Form1.Close()
		Form2.Close()
		Form3.Close()
		BonusScenePlayer.URL = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Resources\BonusVideo\bonusScene.mp4")
		MainMenu.BringToFront()
	End Sub


End Class
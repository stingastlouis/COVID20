Public Class Form3
	Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Form1.Close()
		ModuleGameManager.FormLoader(Me, 3)
	End Sub
End Class
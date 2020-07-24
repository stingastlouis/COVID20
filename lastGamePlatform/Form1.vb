Public Class Form1

	''' <summary>
	''' when the form is loading
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' 
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		ModuleGameManager.FormLoader(Me, 1)
	End Sub
End Class

Public Class FormMainMenu
	Private Sub ButtonReader_Click(sender As Object, e As EventArgs) Handles ButtonReader.Click
		Me.Hide()
		FormExcelReader.Show()
	End Sub

	Private Sub ButtonWriter_Click(sender As Object, e As EventArgs) Handles ButtonWriter.Click
		Me.Hide()
		FormExcelWriter.Show()
	End Sub
End Class
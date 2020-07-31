Public Class FormMenu
	Private Sub ButtonListBox_Click(sender As Object, e As EventArgs) Handles ButtonListBox.Click
		Me.Hide()
		FormListBox.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		FormTextBox.Show()
	End Sub
End Class

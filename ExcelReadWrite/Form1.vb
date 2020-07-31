Public Class FormMenu

	Public Shared excelFile As String
	Private Sub ButtonListBox_Click(sender As Object, e As EventArgs) Handles ButtonListBox.Click
		Me.Hide()
		FormListBox.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTextboxes.Click
		Me.Hide()
		FormTextBox.Show()
	End Sub

	Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ButtonTextboxes.Enabled = False
		ButtonListBox.Enabled = False
		excelFile = ChooseExcel()
	End Sub
	Private Function ChooseExcel()
		Dim excelFile As String = ""
		OpenFileDialog1.Filter = "Excel Worksheets|*.xlsx"
		OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		OpenFileDialog1.Title = "Please select an Excel document."
		If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
			ButtonTextboxes.Enabled = True
			ButtonListBox.Enabled = True
			excelFile = OpenFileDialog1.FileName
		End If
		Return excelFile
	End Function
End Class

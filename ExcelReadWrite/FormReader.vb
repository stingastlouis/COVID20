﻿Public Class FormExcelReader

	Public Shared excelFile As String
	Private Sub ButtonListBox_Click(sender As Object, e As EventArgs) Handles ButtonListBox.Click
		Me.Hide()
		FormListBox.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTextboxes.Click
		Me.Hide()
		FormTextBox.Show()




	End Sub
	'Dim afterTime As DateTime
	'Dim endTime As DateTime
	Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Timer1.Enabled = True
		'afterTime.AddSeconds(2)
		'endTime = afterTime
		'endTime.AddSeconds(15)

		'ButtonTextboxes.Enabled = False
		'ButtonListBox.Enabled = False
		'Button1.Enabled = False
		'Button2.Enabled = False

		If excelFile = "" Then
			Me.Close()
			MsgBox("error the path is empty")
			FormMainMenu.Show()
		Else
			MsgBox("Your file is saved." & vbNewLine & excelFile)
		End If





	End Sub

	Private Sub FormExcelReader_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Me.Hide()
		FormMainMenu.Show()
	End Sub

	'Private Function ChooseExcel()
	'	Timer1.Enabled = False
	'	Dim excelFile As String = ""
	'	OpenFileDialog1.FileName = "Ajit_Rishi.xlsx" ' Default file name
	'	OpenFileDialog1.Filter = "Excel Worksheets|*.xlsx"
	'	OpenFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
	'	OpenFileDialog1.Title = "Please select an Excel document."

	'	If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
	'		ButtonTextboxes.Enabled = True
	'		ButtonListBox.Enabled = True
	'		Button1.Enabled = True
	'		Button2.Enabled = True

	'		excelFile = OpenFileDialog1.FileName

	'	End If
	'	Return excelFile
	'End Function

	'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
	'	Dim nowTime As DateTime = DateTime.Now


	'	If nowTime >= afterTime Then
	'		excelFile = ChooseExcel()


	'	End If

	'End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Hide()
		gridView.Show()
	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		Process.Start(excelFile)
	End Sub
End Class

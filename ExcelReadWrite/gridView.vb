
Imports ExcelDataReader
Imports System.IO
Public Class gridView

	Dim Str As String = FormExcelReader.excelFile
	Dim corresPondinColumn As Integer
	Dim corresPondinRows As Integer
	Dim canColor As Boolean
	Dim dtDetails As New DataTable
	Dim dtHead As New DataTable
	'Dim tables As DataTableCollection
	Dim path As String = (AppDomain.CurrentDomain.BaseDirectory + "compiledoutput.xlsx")

	Private Sub pophead()
		Dim stream2 As Stream = File.OpenRead(path)
		Dim reader2 As IExcelDataReader = ExcelReaderFactory.CreateReader(stream2)
		Dim result2 As DataSet = reader2.AsDataSet()
		Dim tables2 As DataTableCollection = result2.Tables
		dtHead = tables2(0)

		dataName.DataSource = dtHead
		dataName.ColumnHeadersVisible = False
		dataName.AllowUserToResizeColumns = False


		For r As Integer = 0 To dataName.Rows.Count - 1

			For col As Integer = 0 To dataName.Columns.Count - 1
				dataName.Columns(col).Width = 85
				If r >= 2 Then

					dataName.Rows(r).Cells(col).Value = Nothing

				End If
			Next


		Next
	End Sub
	Private Sub gridView_Load(sender As Object, e As EventArgs) Handles Me.Load

		Dim stream1 As Stream = File.OpenRead(path)
		Dim reader1 As IExcelDataReader = ExcelReaderFactory.CreateReader(stream1)
		Dim result1 As DataSet = reader1.AsDataSet()
		Dim tables1 As DataTableCollection = result1.Tables

		dtDetails = tables1(0)

		dtDetails.Rows.RemoveAt(2)
		dtDetails.Rows.RemoveAt(1)
		dtDetails.Rows.RemoveAt(0)
		dataOpener.DataSource = dtDetails
		For i As Integer = 0 To dataOpener.Columns.Count - 1
			With dataOpener
				.Columns(i).HeaderText = dataOpener.Rows(0).Cells(i).Value
			End With
		Next
		dataOpener.Rows.RemoveAt(0)

		For i As Integer = 0 To dataOpener.Rows.Count - 1
			ComboBox1.Items.Add(dataOpener.Rows(i).Cells(0).Value)
		Next



		If dataOpener.Rows.Count > 0 Then
			For rows As Integer = 0 To dataOpener.Rows.Count - 1
				For columns As Integer = 0 To dataOpener.Columns.Count - 1
					dataOpener.Columns(columns).Width = 85
					Dim CellChange As String = dataOpener.Rows(rows).Cells(columns).Value.ToString().Trim()

					If rows >= 1 Then
						If columns = 1 Or columns = 4 Then
							If CInt(CellChange) >= 38 And CInt(CellChange) < 40 Then

								corresPondinColumn = columns + 1
								corresPondinRows = rows
								canColor = True

							End If

						End If



					End If
					If canColor Then
						If rows = corresPondinRows And columns = corresPondinColumn Then
							With dataOpener
								.Rows(corresPondinRows).Cells(corresPondinColumn).Style.BackColor = System.Drawing.Color.Green
							End With
						End If
					End If

				Next
			Next
		End If




		pophead()

	End Sub
	Dim txtBox(1000, 1000) As String



	Private Sub gridView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Me.Dispose()
		FormExcelReader.Show()
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		Dim Studname As String = ComboBox1.Text.ToString
		For i As Integer = 0 To dataOpener.Rows.Count - 1
			If dataOpener.Rows(i).Cells(0).Value = Studname Then
				dataOpener.Rows(i).Selected = True
			End If
		Next
	End Sub

	'Private Sub txtName_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp
	'	DataGridView1.DataSource = Me.PopulateDataGridView()
	'End Sub
End Class
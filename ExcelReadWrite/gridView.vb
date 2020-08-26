Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging
Imports System.ComponentModel
Imports System.Drawing
Imports ExcelDataReader
Imports System.IO
Public Class gridView

	Dim Str As String = FormExcelReader.excelFile
	Dim corresPondinColumn As Integer
	Dim corresPondinRows As Integer
	Dim canColor As Boolean
	Dim tables As DataTableCollection


	Private Function GetAllWorksheets(ByVal fileName As String) As Sheets
		Dim theSheets As Sheets
		Using document As SpreadsheetDocument =
			SpreadsheetDocument.Open(fileName, False)
			Dim wbPart As WorkbookPart = document.WorkbookPart
			theSheets = wbPart.Workbook.Sheets()
		End Using
		Return theSheets
	End Function


	Private Sub PopulateListBox(myfile As String)

		Dim sheetDocList As New List(Of SLDocument)

		Dim totalColumn As Integer = 0
		Dim lastRow As Integer = 0 'use to know how many lines there will be in listbox
		Dim lastColumn As Integer = 0
		'Try
		For Each sh As Sheet In GetAllWorksheets(myfile) 'get the last row and col
			Dim sd As New SLDocument(myfile, sh.Name)
			sheetDocList.Add(sd)
			totalColumn += sd.GetWorksheetStatistics.EndColumnIndex 'last cell with value
			Dim currentRow As Integer = sd.GetWorksheetStatistics.EndRowIndex
			If currentRow > lastRow Then
				lastRow = currentRow 'get last row in case 1 sheet is longer
			End If
			Dim currentColumn As Integer = sd.GetWorksheetStatistics.EndColumnIndex
			If currentColumn > lastColumn Then
				lastColumn = currentColumn 'get last column in case 1 sheet is longer
			End If
		Next


		Console.WriteLine("lastRow" & lastRow)
		Console.WriteLine("lastcol" & lastColumn)
		For rows As Integer = 1 To lastRow - 1
			Dim myText As String = ""
			For Each sdl As SLDocument In sheetDocList
				For columns As Integer = 1 To lastColumn - 1

					myText = sdl.GetCellValueAsString(rows, columns)
					If myText.Length < 1 Then
						myText = "xxxx"
					End If
					dataOpener.Rows(rows).Cells(columns).Value = myText
					'merge the cols to make it a single row
					'Console.WriteLine(rows & " " & columns)

				Next
			Next
			'myListBox.Items.Add(myText) 'add the single row to listbox


		Next


		'Catch ex As Exception
		'	Me.Hide()
		'	MsgBox("An error occur go to main menu " & ex.ToString)
		'	FormMainMenu.Show()
		'End Try

	End Sub


	Private Sub gridView_Load(sender As Object, e As EventArgs) Handles Me.Load
		'PopulateListBox(AppDomain.CurrentDomain.BaseDirectory + "compiledoutput.xlsx")
		Try
			Dim stream As Stream
			Dim reader As IExcelDataReader
			Dim result As DataSet
			Dim tables As DataTableCollection
			Dim dt As DataTable
			stream = File.Open(Str, FileMode.Open, FileAccess.Read)
			reader = ExcelReaderFactory.CreateReader(stream)
			result = reader.AsDataSet()
			tables = result.Tables
			dt = tables(0)


			dataOpener.DataSource = dt
			'Using stream = File.Open(Str, FileMode.Open, FileAccess.Read)
			'Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
			'		Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {.ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {.UseHeaderRow = True}})
			'		tables = result.Tables

			'	End Using
			'End Using
			'Dim dt As DataTable = tables(0)

			'dataOpener.DataSource = dt


			'With dataOpener
			'	.Columns(2).HeaderText = "sdfsdfsdf"
			'	.Columns(3).HeaderText = Nothing
			'	.Columns(5).HeaderText = Nothing
			'	.Columns(6).HeaderText = Nothing


			'End With





			'If dataOpener.Rows.Count > 0 Then
			'	For rows As Integer = 3 To dataOpener.Rows.Count - 1
			'		For columns As Integer = 0 To dataOpener.Columns.Count - 1
			'			Dim CellChange As String = dataOpener.Rows(rows).Cells(columns).Value.ToString().Trim()

			'			If rows >= 3 Then
			'				If columns = 1 Or columns = 4 Then
			'					If CInt(CellChange) >= 38 And CInt(CellChange) < 39.5 Then

			'						corresPondinColumn = columns + 1
			'						corresPondinRows = rows
			'						canColor = True

			'					End If

			'				End If



			'			End If
			'			If canColor Then
			'				If rows = corresPondinRows And columns = corresPondinColumn Then
			'					With dataOpener
			'						.Rows(corresPondinRows).Cells(corresPondinColumn).Style.BackColor = System.Drawing.Color.Green
			'					End With
			'				End If
			'			End If

			'		Next
			'	Next
			'End If

		Catch ex As Exception

		End Try




	End Sub
	Dim txtBox(1000, 1000) As String



	Private Sub gridView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Me.Dispose()
		FormExcelReader.Show()
	End Sub
End Class
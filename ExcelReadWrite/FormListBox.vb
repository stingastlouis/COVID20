Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging

Public Class FormListBox
    Private sheetDocList As New List(Of SLDocument)
    Private Sub FormListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateListBox(FormMenu.excelFile, ListBox1)
    End Sub
    Private Sub PopulateListBox(myfile As String, myListBox As ListBox)
        Dim totalColumn As Integer = 0
        Dim lastRow As Integer = 0 'use to know how many lines there will be in listbox
        Dim lastColumn As Integer = 0

        For Each sh As Sheet In GetAllWorksheets(myfile)
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

        For rows As Integer = 1 To lastRow
            Dim myText As String = ""
            For Each sdl As SLDocument In sheetDocList
                For columns As Integer = 1 To lastColumn
                    myText += sdl.GetCellValueAsString(rows, columns) + vbTab + vbTab
                Next
            Next
            myListBox.Items.Add(myText)
        Next
        myListBox.SetSelected(0, True)
    End Sub

    Private Function GetAllWorksheets(ByVal fileName As String) As Sheets
        Dim theSheets As Sheets
        Using document As SpreadsheetDocument =
            SpreadsheetDocument.Open(fileName, False)
            Dim wbPart As WorkbookPart = document.WorkbookPart
            theSheets = wbPart.Workbook.Sheets()
        End Using
        Return theSheets
    End Function
End Class



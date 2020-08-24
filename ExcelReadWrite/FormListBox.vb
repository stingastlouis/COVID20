Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging
Imports System.ComponentModel

Public Class FormListBox

    Private Sub FormListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateListBox(FormExcelReader.excelFile, ListBox1)

    End Sub
    Private Sub PopulateListBox(myfile As String, myListBox As ListBox)

        Dim sheetDocList As New List(Of SLDocument)

        Dim totalColumn As Integer = 0
        Dim lastRow As Integer = 0 'use to know how many lines there will be in listbox
        Dim lastColumn As Integer = 0
        Try
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



            For rows As Integer = 1 To lastRow
                Dim myText As String = ""
                For Each sdl As SLDocument In sheetDocList
                    For columns As Integer = 1 To lastColumn
                        myText += sdl.GetCellValueAsString(rows, columns) + vbTab + vbTab 'merge the cols to make it a single row


                    Next
                Next
                myListBox.Items.Add(myText) 'add the single row to listbox


            Next
            myListBox.SetSelected(0, True)
        Catch ex As Exception
            Me.Hide()
            MsgBox("An error occur go to main menu")
            FormMainMenu.Show()
        End Try

    End Sub

    Private Sub FormListBox_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormExcelReader.Show()
        Me.Hide()
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



Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging
Imports System.ComponentModel

Public Class FormTextBox

    Dim newbox As TextBox

    Private Function GetAllWorksheets(ByVal fileName As String) As Sheets
        Dim theSheets As Sheets
        Using document As SpreadsheetDocument =
            SpreadsheetDocument.Open(fileName, False)
            Dim wbPart As WorkbookPart = document.WorkbookPart
            theSheets = wbPart.Workbook.Sheets()
        End Using
        Return theSheets
    End Function

    Dim txt() As TextBox
    Private boxes(100, 100) As TextBox
    Private Sub populateTextBoxes(myfile As String)
        Dim sheetDocList As New List(Of SLDocument)

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
                    'newbox = New TextBox
                    'newbox.Size = New System.Drawing.Size(100, 20)
                    'newbox.Location = New Point(10 + 100 * rows, 10 + 25 * columns)
                    'newbox.Name = "TextBox" & rows & "_" & columns
                    'newbox.Text = sdl.GetCellValueAsString(rows, columns) + vbTab + vbTab
                    'boxes(rows, columns) = newbox
                    'Me.Controls.Add(newbox)

                    newbox = New TextBox
                    newbox.Size = New System.Drawing.Size(100, 20)
                    newbox.Location = New Point(10 + 100 * columns, 10 + 25 * rows)
                    newbox.Name = "TextBox" & rows & "_" & columns
                    Dim x, y As Integer
                    newbox.Text = sdl.GetCellValueAsString(rows, columns)
                    If columns = 2 Or columns = 5 Then
                        If rows >= 5 Then
                            If CInt(newbox.Text) >= 38 And CInt(newbox.Text) <= 39.5 Then
                                y = columns + 1
                                x = rows

                            End If
                        End If
                    End If
                    If columns = y And rows = x Then
                        newbox.BackColor = System.Drawing.Color.Green
                    End If

                    'If sdl.GetCellValueAsString(rows, columns) = "40" Then
                    '    newbox.BackColor = System.Drawing.Color.Green
                    'End If

                    boxes(rows, columns) = newbox
                    Me.Controls.Add(newbox)



                Next
            Next


        Next


    End Sub

    Private Sub FormTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateTextBoxes(FormExcelReader.excelFile)
    End Sub

    Private Sub FormTextBox_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        FormExcelReader.Show()
    End Sub
End Class
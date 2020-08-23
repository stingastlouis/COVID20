Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging
Imports System.ComponentModel

Public Class FormTextBox

    Dim geneNewBox As TextBox
    Private txtBox(1000, 1000) As TextBox
    Private Function GetAllWorksheets(ByVal fileName As String) As Sheets
        Dim theSheets As Sheets
        Using document As SpreadsheetDocument =
            SpreadsheetDocument.Open(fileName, False)
            Dim wbPart As WorkbookPart = document.WorkbookPart
            theSheets = wbPart.Workbook.Sheets()
        End Using
        Return theSheets
    End Function



    Private Sub populateTextBoxes(myfile As String)
        Dim sheetDocList As New List(Of SLDocument)

        Dim totalColumn As Integer = 0
        Dim lastRow As Integer = 0 'use to know how many lines there will be in listbox
        Dim lastColumn As Integer = 0
        Try
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


                        geneNewBox = New TextBox
                        geneNewBox.Size = New System.Drawing.Size(100, 20)
                        geneNewBox.Location = New Point(10 + 100 * columns, 10 + 25 * rows)
                        geneNewBox.Name = "TextBox" & rows & "_" & columns
                        Dim x, y As Integer
                        geneNewBox.Text = sdl.GetCellValueAsString(rows, columns)
                        If columns = 2 Or columns = 5 Then
                            If rows >= 5 Then
                                If CInt(geneNewBox.Text) >= 38 And CInt(geneNewBox.Text) <= 39.5 Then
                                    y = columns + 1
                                    x = rows

                                End If
                            End If
                        End If
                        If columns = y And rows = x Then
                            geneNewBox.BackColor = System.Drawing.Color.Green
                        End If


                        txtBox(rows, columns) = geneNewBox
                        Me.Controls.Add(geneNewBox)



                    Next
                Next
                If rows <= 2 Then
                    Me.Width += rows * 2
                End If
                If rows > 2 Then
                    Me.Width += rows * 2
                End If
            Next
        Catch ex As Exception
            Me.Hide()
            FormMainMenu.Show()
        End Try



    End Sub

    Private Sub FormTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateTextBoxes(FormExcelReader.excelFile)
    End Sub

    Private Sub FormTextBox_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        FormExcelReader.Show()
    End Sub
End Class
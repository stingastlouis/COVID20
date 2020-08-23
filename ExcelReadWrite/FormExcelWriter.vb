Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class FormExcelWriter
    Private rowToBold As Integer
    Private excelfile1 As String
    Private excelfile2 As String


    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        Try
            Dim OpenFileDlg1 As New OpenFileDialog
            OpenFileDlg1.FileName = "Ajit.xlsx" ' Default file name
            OpenFileDlg1.DefaultExt = ".xlsx" ' Default file extension
            OpenFileDlg1.Filter = "Excel Documents (*.XLSX)|*.XLSX"
            OpenFileDlg1.Title = "Please select first Excel document."
            If (OpenFileDlg1.ShowDialog() = DialogResult.OK) Then
                excelfile1 = OpenFileDlg1.FileName

                Dim OpenFileDlg2 As New OpenFileDialog
                OpenFileDlg2.FileName = "Rishi.xlsx" ' Default file name
                OpenFileDlg2.DefaultExt = ".xlsx" ' Default file extension
                OpenFileDlg2.Filter = "Excel Documents (*.XLSX)|*.XLSX"
                OpenFileDlg2.Title = "Please select second Excel document."
                If (OpenFileDlg2.ShowDialog() = DialogResult.OK) Then
                    excelfile2 = OpenFileDlg2.FileName
                    StartJoining()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occur please restart the program")
            Me.Hide()
            FormMainMenu.Show()
        End Try

    End Sub




    Private Sub StartJoining()

        Dim file1 As String = excelfile1
        Dim file2 As String = excelfile2
        Dim outFile = AppDomain.CurrentDomain.BaseDirectory + "compiledoutput.xlsx"
        Dim outdir = AppDomain.CurrentDomain.BaseDirectory
        Dim myExcel As New SLDocument()
        myExcel.SaveAs(outFile)
        AddUpdatedGrade(file1, 0, outFile)
        AddUpdatedGrade(file2, 1, outFile)
        BoldRow(outFile, rowToBold)
        AutoFit(outFile)
        Try
            'Process.Start(outdir)
            Process.Start(outFile)
            MsgBox("Your file is located in:\n " + outFile)
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Me.Close()
        'FormExcelReader.Show()
    End Sub
    Private Function GetGrade(marks As Decimal) As String
        Dim Grade As String
        If marks >= 0 AndAlso marks < 38 Then
            Grade = "F"
        ElseIf marks >= 38 AndAlso marks < 50 Then
            Grade = "D"
        ElseIf marks >= 50 AndAlso marks < 60 Then
            Grade = "C"
        ElseIf marks >= 60 AndAlso marks < 70 Then
            Grade = "B"
        ElseIf marks >= 70 AndAlso marks < 80 Then
            Grade = "A"
        ElseIf marks >= 80 AndAlso marks < 100 Then
            Grade = "A+"
        Else
            Grade = "Not In Range"
        End If
        Return Grade
    End Function
    Private Sub AddUpdatedGrade(fileToBeGraded As String, indexColumnToDelete As Integer, outfile As String)
        Try
            Dim myExcel As New SLDocument(outfile)
            Dim f1 As New SLDocument(fileToBeGraded)
            f1.DeleteColumn(indexColumnToDelete, 1)
            Dim startColumn As Integer = myExcel.GetWorksheetStatistics.EndColumnIndex
            If startColumn < 1 Then : startColumn = 0
            End If
            Dim startRow As Integer = myExcel.GetWorksheetStatistics.EndRowIndex
            If startRow < 1 Then : startColumn = 0
            End If
            Dim verifyAfterColumn As Int16 = 0
            Dim startVerification As Boolean = False
            Dim f1rows As Int16 = f1.GetWorksheetStatistics.EndRowIndex
            Dim f1columns As Int16 = f1.GetWorksheetStatistics.EndColumnIndex
            For rows As Int16 = 1 To f1rows
                For columns As Int16 = 1 To (f1columns)
                    Dim currentCellValue As String = f1.GetCellValueAsString(rows, columns)
                    myExcel.SetCellValue(rows, startColumn + columns, currentCellValue)
                    If (currentCellValue = "Marks") Then
                        rowToBold = rows
                        verifyAfterColumn = columns
                        startVerification = True
                        myExcel.SetCellValue(rows, startColumn + verifyAfterColumn + 1, "Updated")
                        myExcel.SetCellValue(rows, startColumn + verifyAfterColumn + 2, "Grade")
                        Exit For
                    End If
                    If (startVerification) Then
                        currentCellValue = f1.GetCellValueAsString(rows, verifyAfterColumn)
                        myExcel.SetCellValue(rows, startColumn + verifyAfterColumn, currentCellValue)
                        Dim myVal As Decimal = CDec(Val(currentCellValue))
                        If (myVal >= 38 AndAlso myVal < 40) Then
                            Dim mystyle As SLStyle = myExcel.CreateStyle()




                            'mystyle.Fill.SetPattern(PatternValues.Solid, SLThemeColorIndexValues.Accent2Color, SLThemeColorIndexValues.Accent4Color)
                            mystyle.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Green, System.Drawing.Color.Green)

                            myExcel.SetCellStyle(rows, startColumn + verifyAfterColumn + 1, mystyle)
                            ' myExcel.SetCellStyle(rows, startColumn + verifyAfterColumn + 1, styleColor)
                            myExcel.SetCellValue(rows, startColumn + verifyAfterColumn + 1, "40")

                        Else
                            myExcel.SetCellValue(rows, startColumn + verifyAfterColumn + 1, currentCellValue)
                        End If
                        myExcel.SetCellValue(rows, startColumn + verifyAfterColumn + 2, GetGrade(myVal))
                        Exit For
                    End If
                Next
            Next
            FormMainMenu.Hide()
            myExcel.SaveAs(outfile)
        Catch ex As Exception
            MsgBox("An error occur please restart the program")
            Me.Hide()
            FormMainMenu.Show()
        End Try

    End Sub
    Private Sub AutoFit(outfile As String)
        Try
            Dim myExcel As New SLDocument(outfile)
            For i As Integer = 1 To myExcel.GetWorksheetStatistics.EndColumnIndex
                myExcel.AutoFitColumn(i)
            Next
            myExcel.SaveAs(outfile)
        Catch ex As Exception
            MsgBox("An error occur please restart the program")
            Me.Hide()
            FormMainMenu.Show()
        End Try

    End Sub
    Private Sub BoldRow(outfile As String, rowIndex As Integer)
        Dim myExcel As New SLDocument(outfile)
        Dim style As SLStyle = myExcel.CreateStyle
        style.Font.Bold = True
        myExcel.SetRowStyle(rowIndex, style)
        myExcel.SaveAs(outfile)
    End Sub

    Private Sub FormExcelWriter_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        FormMainMenu.Show()


    End Sub
End Class
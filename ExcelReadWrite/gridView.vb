Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.Packaging
Imports System.ComponentModel
Imports System.Drawing
Public Class gridView

    Dim conn As OleDb.OleDbConnection
    Dim dta As OleDb.OleDbDataAdapter
    Dim dt As DataSet
    Dim Str As String = FormExcelReader.excelFile
    Dim corresPondinColumn As Integer
    Dim corresPondinRows As Integer
    Dim canColor As Boolean
    Private Sub gridView_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' populateTextBoxes(FormExcelReader.excelFile)

        conn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Str + ";Extended Properties=Excel 12.0;")
        dta = New OleDb.OleDbDataAdapter("select * from [sheet1$]", conn)
        dt = New DataSet
        dta.Fill(dt, "[sheet1$]")
        dataOpener.DataSource = dt
        dataOpener.DataMember = "[sheet1$]"
        conn.Close()
        With dataOpener
            .Columns(2).HeaderText = Nothing
            .Columns(3).HeaderText = Nothing
            .Columns(5).HeaderText = Nothing
            .Columns(6).HeaderText = Nothing


        End With
        If dataOpener.Rows.Count > 0 Then
            For rows As Integer = 0 To dataOpener.Rows.Count - 1
                For columns As Integer = 0 To dataOpener.Columns.Count - 1
                    Dim CellChange As String = dataOpener.Rows(rows).Cells(columns).Value.ToString().Trim()

                    If rows >= 3 Then
                        If columns = 1 Or columns = 4 Then
                            If CInt(CellChange) >= 38 And CInt(CellChange) < 39.5 Then

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




    End Sub

    Private Sub gridView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        FormExcelReader.Show()
    End Sub
End Class
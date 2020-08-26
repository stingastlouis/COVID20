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
    Private Sub gridView_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try



            Using stream = File.Open(Str, FileMode.Open, FileAccess.Read)
                Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                    Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                             .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                             .UseHeaderRow = True}})
                    tables = result.Tables

                End Using
            End Using
            Dim dt As DataTable = tables(0)

            dataOpener.DataSource = dt


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

        Catch ex As Exception

        End Try




    End Sub
    Dim txtBox(1000, 1000) As String



    Private Sub gridView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        FormExcelReader.Show()
    End Sub
End Class
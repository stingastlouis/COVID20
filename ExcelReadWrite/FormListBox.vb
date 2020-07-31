
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight


Public Class FormListBox

    Dim excelFile As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChooseExcel()
        Dim sl As New SLDocument(excelFile.ToString, "Sheet1")
        MessageBox.Show(sl.GetWorksheetStatistics.EndRowIndex)
        'MessageBox.Show(excelFile.ToString)
    End Sub

    Private Sub FormListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ChooseExcel()
        OpenFileDialog1.Filter = "Excel Worksheets|*.xlsx"
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        OpenFileDialog1.Title = "Please select an Excel document."
        'excelFile = OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            excelFile = OpenFileDialog1.FileName
        End If
    End Sub



    'Dim dtStrongTyping As DataTable = New DataTable("ProductStrongTyping")
    '    Dim dtSchwarzeneggerTyping As ProductTable = New ProductTable("ProductSchwarzeneggerTyping")

    '    dtStrongTyping.Columns.Add(New DataColumn("ProductID"))
    '    dtStrongTyping.Columns.Add(New DataColumn("ProductDescription"))
    '    dtStrongTyping.Columns.Add(New DataColumn("DateAdded"))
    '    dtStrongTyping.Columns.Add(New DataColumn("Price"))

    '    Dim row As Integer
    '    Dim prodrow As ProductRow
    '    Dim sl As SLDocument
    '    sl = New SLDocument("ExportToDataTableExample.xlsx", "Sheet1")
    '    Using (sl)
    '        Dim stats As SLWorksheetStatistics = sl.GetWorksheetStatistics()
    '        Dim iStartColumnIndex As Integer = stats.StartColumnIndex
    '        For row = stats.StartRowIndex + 1 To stats.EndRowIndex
    '            dtStrongTyping.Rows.Add(sl.GetCellValueAsInt32(row, iStartColumnIndex), sl.GetCellValueAsString(row, iStartColumnIndex + 1), sl.GetCellValueAsDateTime(row, iStartColumnIndex + 2), sl.GetCellValueAsDecimal(row, iStartColumnIndex + 3))
    '        Next
    '        For row = stats.StartRowIndex + 1 To stats.EndRowIndex
    '            prodrow = dtSchwarzeneggerTyping.CreateNewRow()
    '            prodrow.ProductID = sl.GetCellValueAsInt32(row, iStartColumnIndex)
    '            prodrow.ProductDescription = sl.GetCellValueAsString(row, iStartColumnIndex + 1)
    '            prodrow.DateAdded = sl.GetCellValueAsDateTime(row, iStartColumnIndex + 2)
    '            prodrow.Price = sl.GetCellValueAsDecimal(row, iStartColumnIndex + 3)
    '            dtSchwarzeneggerTyping.Rows.Add(prodrow)
    '        Next
    '    End Using
    '    dtStrongTyping.Rows.Add(1024, "I change keyboards every month because they can't handle my strong typing skills", DateTime.Now.AddMonths(1), 2.78)

    '    prodrow = dtSchwarzeneggerTyping.CreateNewRow()
    '    prodrow.ProductID = 2048
    '    prodrow.ProductDescription = "I'll be back"
    '    prodrow.DateAdded = New DateTime(2029, 1, 1)
    '    prodrow.Price = 78371200
    '    dtSchwarzeneggerTyping.Rows.Add(prodrow)


    '    dtStrongTyping.WriteXml("ExportToDataTableExampleStrongTyping.xml")
    '    dtSchwarzeneggerTyping.WriteXml("ExportToDataTableExampleSchwarzeneggerTyping.xml")

    '    Console.WriteLine("End of program")
    '    Console.ReadLine()
    'End Sub
End Class


Public Class ProductRow
    Inherits DataRow

    Public Property ProductID As Integer
        Get
            Return CInt(Me("ProductID"))
        End Get
        Set(ByVal value As Integer)
            Me("ProductID") = value
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return CStr(Me("ProductDescription"))
        End Get
        Set(ByVal value As String)
            Me("ProductDescription") = value
        End Set
    End Property

    Public Property DateAdded As DateTime
        Get
            Return CType(Me("DateAdded"), DateTime)
        End Get
        Set(ByVal value As DateTime)
            Me("DateAdded") = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return CDec(Me("Price"))
        End Get
        Set(ByVal value As Decimal)
            Me("Price") = value
        End Set
    End Property

    Friend Sub New(ByVal builder As DataRowBuilder)
        MyBase.New(builder)
        Me.ProductID = 0
        Me.ProductDescription = String.Empty
        Me.DateAdded = DateTime.Now
        Me.Price = 0
    End Sub
End Class
Public Class ProductTable
    Inherits DataTable

    Public Sub New(ByVal TableName As String)
        Me.TableName = TableName
        Me.Columns.Add(New DataColumn("ProductID", GetType(Integer)))
        Me.Columns.Add(New DataColumn("ProductDescription", GetType(String)))
        Me.Columns.Add(New DataColumn("DateAdded", GetType(DateTime)))
        Me.Columns.Add(New DataColumn("Price", GetType(Decimal)))
    End Sub

    Public Function CreateNewRow() As ProductRow
        Return CType(NewRow(), ProductRow)
    End Function

    Protected Overrides Function GetRowType() As Type
        Return GetType(ProductRow)
    End Function

    Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
        Return New ProductRow(builder)
    End Function
End Class

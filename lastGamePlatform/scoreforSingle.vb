Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class scoreforSingle
    Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sting\Source\Repos\stingastlouis\COVID20\lastGamePlatform\Database1.mdf
                    ;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        startHere.Show()
    End Sub

    Private Sub scoreforSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.single_Table' table. You can move, or remove it, as needed.
        Dim con As New SqlClient.SqlConnection(Str)
        Dim cmdd As New SqlClient.SqlCommand
        cmdd.Connection = con
        cmdd.CommandText = "Select max(score) AS highScore from single_Table ORDERBY  "
        con.Open()
        'cmdd.ExecuteReader()
        Dim lrd As SqlClient.SqlDataReader = cmdd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read
                lblGreater.Text = "YOUR HIGHER SCORE IS :" & CStr(lrd("highScore"))

            End While
        End If
        con.Close()
        Timer1.Enabled = True
        FileOpen(1, "singleScore.txt", OpenMode.Input)
        While Not EOF(1)
            Label1.Text += LineInput(1) + vbNewLine
        End While
        FileClose(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Top -= 2
        If Label1.Top + Label1.Height <= 0 Then
            Label1.Top = Me.Height
        End If
    End Sub
    Private Sub Single_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Single_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub
End Class
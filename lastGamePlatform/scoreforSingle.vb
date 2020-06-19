Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class scoreforSingle
    Dim sall As MySqlDataReader
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        startHere.Show()
    End Sub

    Private Sub scoreforSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        you.Text = CStr(mainCamera.Score)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=db4free.net;userid=stinga_pascal;password=Alphaetomega123;database=jojo_3499;port=3306;pooling=true;old guids= true"
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
            If conn.State = ConnectionState.Connecting Then

            End If
            showRecords()

        Catch ex As Exception
            Me.Show()
            Try
                Do While conn.State = ConnectionState.Connecting Or conn.State = ConnectionState.Closed
                    conn.Open()
                    showRecords()
                Loop
            Catch er As Exception

            End Try



        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Sub showRecords()
        Try
            ListView1.Items.Clear()
            Dim i As Integer
            cmd = New MySqlCommand("select * from playerTable ORDER BY SCORE DESC ", conn)
            sall = cmd.ExecuteReader

            While sall.Read
                i += 1
                ListView1.Items.Add(New ListViewItem({sall.Item("NAME").ToString, sall.Item("SCORE").ToString}))
            End While
            sall.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If Not TextBox1.Text = Nothing Then
            ListView1.FindItemWithText(TextBox1.Text).BackColor = Color.Red
        End If
    End Sub
End Class
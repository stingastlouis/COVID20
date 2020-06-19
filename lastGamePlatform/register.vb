Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class register
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim age As Integer
    Dim strGender As String
    Dim finish As Boolean = False

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=db4free.net;userid=stinga_pascal;password=Alphaetomega123;database=jojo_3499;port=3306;pooling=true;old guids= true"
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
            If conn.State = ConnectionState.Connecting Then
                Me.Show()
            End If


        Catch ex As Exception
            MessageBox.Show("Something went wrong with the connection.. Retry to ")


        End Try

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        age = NumericUpDown1.Value


        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=db4free.net;userid=stinga_pascal;password=Alphaetomega123;database=jojo_3499;port=3306;pooling=true;old guids= true"
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If


            cmd = New MySqlCommand("INSERT INTO playerTable(NAME,EMAIL,AGE,GENDER,SCORE)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & age & "','" & strGender & "','" & mainCamera.Score & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("1 NEW RECORD")
            finish = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            finish = False
        End Try
        If finish = True Then
            Me.Close()
            scoreforSingle.Show()
        End If

    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        If radMale.Checked = True Then
            strGender = "Male"

        End If
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged

        If radFemale.Checked = True Then
            strGender = "Female"

        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = Nothing Then
            Empty.SetError(TextBox1, "Please enter your name ")
            btnContinue.Enabled = False
        Else
            btnContinue.Enabled = True
            Empty.Dispose()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = Nothing Then
            Empty.SetError(TextBox2, "Please enter your email")
            btnContinue.Enabled = False
        Else
            btnContinue.Enabled = True
            Empty.Dispose()

        End If
    End Sub
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        Dim str As String = TextBox2.Text
        If Not str.Contains("@") Then
            If Not str.Contains(".com") Then
                Empty.SetError(TextBox2, "Not a valid email address")
                btnContinue.Enabled = False
            Else
                btnContinue.Enabled = True
            End If

        End If
    End Sub
End Class
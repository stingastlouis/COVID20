
Imports System.Data
Imports System.Data.SqlClient





Public Class multiplayerRegForm


    Public p1 As New mulPLayerClass()
    Public p2 As New mulPLayerClass()
    Public pp1 As String
    Public pp2 As String
    Dim dbProvider As String
    Dim dbSource As String
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String





    Private Sub multiplayerRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As String = IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Database1.mdf")
        dbSource = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path & ";Integrated Security=True"

        conn.ConnectionString = dbSource

        PictureBox1.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\KEYS.png"))
        ' Database1DataSet.User_Table.AcceptChanges()




        multiPlayerPLayForm.Dispose()
        player1Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov.png"))
        p1.playerImage = player1Box.Image


        player2Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov2.png"))
        p2.playerImage = player2Box.Image

        multiPlayerPLayForm.Close()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        pp1 = player1.Text.Trim
        pp2 = player2.Text.Trim
        p1.playerLife = 3
        p2.playerLife = 3
        p1.playerImage = player1Box.Image
        p2.playerImage = player2Box.Image
        p1.playerName = player1.Text.Trim
        p2.playerName = player2.Text.Trim
        If player1.Text.Trim = Nothing Then
            p1.playerName = "Timon"
        End If
        If player2.Text.Trim = Nothing Then
            p2.playerName = "Pumba"
        End If


        Try
            cmd.CommandText = "Insert INTO User_Table VALUES(@p1name,@p2name,@p1score,@p2score,@date)"
            cmd.Parameters.AddWithValue("@p1name", p1.playerName)
            cmd.Parameters.AddWithValue("@p2name", p2.playerName)
            cmd.Parameters.AddWithValue("@p1score", 0)
            cmd.Parameters.AddWithValue("@p2score", 0)
            cmd.Parameters.AddWithValue("@date", DateAndTime.Now.Date)
            cmd.Connection = conn
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
            MessageBox.Show("Your have been registered", "Information", MessageBoxButtons.OK)
            'player1.Select()


            Dim battle As New multiPlayerPLayForm
            Me.Hide()
            battle.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub


End Class
Public Class multiplayerRegForm


    Public p1 As New mulPLayerClass()
    Public p2 As New mulPLayerClass()





    Private Sub multiplayerRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player1Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov.png"))
        p1.playerImage = player1Box.Image


        player2Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov2.png"))
        p2.playerImage = player2Box.Image

        multiPlayerPLayForm.Close()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
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

        Dim battle As New multiPlayerPLayForm
        Me.Hide()
        battle.ShowDialog()




    End Sub





End Class
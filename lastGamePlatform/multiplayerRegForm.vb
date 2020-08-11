Public Class multiplayerRegForm
    Public pl1 As Bitmap
    Public pl2 As Bitmap
    Public pl3 As Bitmap
    Public pl4 As Bitmap
    Dim bool1 As Boolean
    Dim bool2 As Boolean
    Public p1Name, p2Name As String
    Public p1 As New mulPLayerClass
    Public p2 As New mulPLayerClass

    Private Sub player1Box_Click(sender As Object, e As EventArgs) Handles player1Box.Click



        If bool1 = True Then
            player1Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\3rdPlayer.png"))
            bool1 = False
        Else
            player1Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov.png"))
            bool1 = True
        End If
        p1.playerImage = player1Box.Image
    End Sub

    Private Sub player2Box_Click(sender As Object, e As EventArgs) Handles player2Box.Click

        If bool2 = True Then
            player2Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\3rdPlayerLfet.png"))
            bool2 = False
        Else
            player2Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov2.png"))
            bool2 = True
        End If
        p2.playerImage = player2Box.Image
    End Sub

    Private Sub player2_TextChanged(sender As Object, e As EventArgs) Handles player2.TextChanged

    End Sub

    Private Sub multiplayerRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov.png"))
        p1.playerImage = player1Box.Image
        bool1 = True

        player2Box.Image = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\player1Mov2.png"))
        p2.playerImage = player2Box.Image
        bool2 = True

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        p1.playerImage = player1Box.Image
        p2.playerImage = player2Box.Image
        p1.playerName = player1.Text.Trim
        p2.playerName = player2.Text.Trim

        p1.playerScore = 0
        p2.playerScore = 0
        p1.playerLife = 3
        p2.playerLife = 3
        p1.playerItem = 0
        p2.playerItem = 0

        Dim battle As New multiPlayerPLayForm
        Me.Hide()
        battle.Show()




    End Sub





End Class
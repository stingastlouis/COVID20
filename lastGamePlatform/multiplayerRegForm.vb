Public Class multiplayerRegForm
    Public pl1 As Bitmap
    Public pl2 As Bitmap
    Public pl3 As Bitmap
    Public pl4 As Bitmap
    Dim bool1 As Boolean
    Dim bool2 As Boolean
    Public p1Name, p2Name As String

    Private Sub multiplayerRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkContent.Enabled = True
        pl1 = My.Resources.player1Mov
        pl2 = My.Resources._3rdPlayer


        pl3 = My.Resources._3rdPlayerLfet
        pl4 = My.Resources.player1Mov2

        player1Box.Image = pl1
        bool1 = True
        player2Box.Image = pl3
        bool2 = True
    End Sub

    Private Sub player1Box_Click(sender As Object, e As EventArgs) Handles player1Box.Click
        If bool1 = True Then
            player1Box.Image = pl2
            bool1 = False
        Else
            player1Box.Image = pl1
            bool1 = True
        End If



    End Sub

    Private Sub player2Box_Click(sender As Object, e As EventArgs) Handles player2Box.Click
        If bool2 = True Then
            player2Box.Image = pl3
            bool2 = False
        Else
            player2Box.Image = pl4
            bool2 = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ground.Show()
    End Sub

    Private Sub checkContent_Tick(sender As Object, e As EventArgs) Handles checkContent.Tick
        If player1.Text = Nothing Or player2.Text = Nothing Then
            Button1.Enabled = False
        Else
            p1Name = player1.Text
            p2Name = player2.Text
            Button1.Enabled = True

        End If
    End Sub



End Class
Public Class startHere
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSinglePlayerPlay.Click
        Me.Hide()
        Intro.Show()
        'jkjp;
    End Sub
    'testing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonMultiPlayerPlay.Click
        Me.Hide()
        'multiplayerRegForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonMultiPlayerScore.Click
        Me.Hide()
        ' MultiScorep.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonSinglePlayerScore.Click
        Me.Hide()
        'scoreforSingle.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonBonus.Click
        Me.Hide()
        'bonusForm.Show()
    End Sub

    Private Sub startHere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
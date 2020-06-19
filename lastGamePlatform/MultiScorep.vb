Public Class MultiScorep
    Private Sub MultiScorep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        FileOpen(1, "scoreMultiplayer.txt", OpenMode.Input)
        While Not EOF(1)
            Label1.Text += LineInput(1) + vbNewLine
        End While
        FileClose(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Top -= 5
        If Label1.Top + Label1.Height <= 0 Then
            Label1.Top = 518
        End If
    End Sub
End Class
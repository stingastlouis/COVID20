Public Class MultiScorep
    Private Sub MultiScorep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.User_Table' table. You can move, or remove it, as needed.
        Me.User_TableTableAdapter1.Fill(Me.Database1DataSet1.User_Table)

        'Timer1.Enabled = True
        'FileOpen(1, "scoreMultiplayer.txt", OpenMode.Input)
        'While Not EOF(1)
        '    Label1.Text += LineInput(1) + vbNewLine
        'End While
        'FileClose(1)
    End Sub



    Private Sub MultiScorep_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        startHere.Show()
    End Sub

    Private Sub User_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles User_TableDataGridView.CellContentClick

    End Sub
End Class
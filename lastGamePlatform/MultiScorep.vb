Public Class MultiScorep

    Private Sub MultiScorep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.User_Table' table. You can move, or remove it, as needed.
        Me.User_TableTableAdapter1.Fill(Me.Database1DataSet1.User_Table)


    End Sub



    Private Sub MultiScorep_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        startHere.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Sort player 1 by maximum value" Then
            User_TableDataGridView.Sort(DataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Descending)
            Button1.Text = "Sort player 1 by minimum value"
        ElseIf Button1.Text = "Sort player 1 by minimum value" Then
            User_TableDataGridView.Sort(DataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Ascending)
            Button1.Text = "Sort player 1 by maximum value"

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Sort player 2 by maximum value" Then
            User_TableDataGridView.Sort(DataGridViewTextBoxColumn5, System.ComponentModel.ListSortDirection.Descending)
            Button2.Text = "Sort player 2 by minimum value"
        ElseIf Button2.Text = "Sort player 2 by minimum value" Then
            User_TableDataGridView.Sort(DataGridViewTextBoxColumn5, System.ComponentModel.ListSortDirection.Ascending)
            Button2.Text = "Sort player 2 by maximum value"

        End If
    End Sub
End Class
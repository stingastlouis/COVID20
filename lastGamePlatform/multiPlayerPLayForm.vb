Public Class multiPlayerPLayForm

    Private Sub multiPlayerPLayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleGameManager.load_multiPlayer(Me)
        multiplayerRegForm.Close()
    End Sub
End Class
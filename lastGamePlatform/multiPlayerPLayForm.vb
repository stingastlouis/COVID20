Public Class multiPlayerPLayForm
    Public p1 As New mulPLayerClass
    Public p2 As New mulPLayerClass

    Private Sub multiPlayerPLayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleGameManager.load_multiPlayer(Me)

    End Sub
End Class
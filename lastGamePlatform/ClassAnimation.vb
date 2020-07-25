
'https://www.vbforums.com/showthread.php?626072-Loop-Once-Through-an-Animated-GIF



Public Class ClassAnimation
	Private gIFAnim As Image
	Private frames As Integer
	Private picBox As PictureBox

	Public Sub New(picBox As PictureBox)
		Me.picBox = picBox
		Me.gIFAnim = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Enemies\Enemy" & ModuleGameManager.level & "Explosion.gif"))
		Me.frames = gIFAnim.GetFrameCount(Imaging.FrameDimension.Time)
		AddHandler picBox.Paint, AddressOf picBox_Paint
		ImageAnimator.Animate(gIFAnim, AddressOf paintFrame)
	End Sub

	Private Sub paintFrame(ByVal sender As Object, ByVal e As EventArgs)
		If Me.frames > 0 Then Me.picBox.Invalidate() Else ImageAnimator.StopAnimate(gIFAnim, AddressOf StopAnim)
	End Sub

	Private Sub StopAnim(ByVal sender As Object, ByVal e As EventArgs)
		Me.picBox.Invalidate()
	End Sub

	Private Sub picBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
		If Me.frames > 1 Then
			ImageAnimator.UpdateFrames()
			e.Graphics.DrawImage(gIFAnim, 0, 0, picBox.Width, picBox.Height)
			Me.frames -= 1
		ElseIf Me.frames <= 1 Then
			e.Graphics.Clear(picBox.BackColor)
			ImageAnimator.StopAnimate(gIFAnim, AddressOf StopAnim)
			Me.picBox.SendToBack()
			Me.picBox.Enabled = False
			Me.picBox.Visible = False
			Me.picBox.Dispose()
		End If
	End Sub
End Class

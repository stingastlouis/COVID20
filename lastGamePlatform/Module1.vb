'Module Module1
'	Public Function checkforCollision(ByVal ob1 As Object, ByVal ob2 As Object) As Boolean
'		If ob1.Top + ob1.Height >= ob2.Top - 5 And ob2.Top + ob2.Height >= ob1.Top And ob1.Left + ob1.Width >= ob2.Left And ob2.Left + ob2.Width >= ob1.Left Then
'			Return True
'		End If
'		Return False
'	End Function

'	Public Sub removePictureBoxandUpdateScore(ByRef picbox As PictureBox, ByRef menu As Form, ByRef pscore As Label, ByRef plife As Label, ByRef pitem As Label)
'		ClassMyPublicShared.allPictureBoxes.Remove(picbox)
'		menu.Controls.Remove(picbox)
'		picbox.Dispose()

'		pscore.Text = "Score :" + CStr(ClassPlayer.score)
'		plife.Text = "Score :" + CStr(ClassPlayer.life)
'		pitem.Text = "Score :" + CStr(ClassPlayer.item)


'	End Sub
'	Dim rest As New Button
'	Dim winorlosetText As New Label
'	Dim exitBtn As New Label
'	Dim fo As Form



'	Public Sub checkGameStatus(ByRef pro As ProgressBar, ByRef life As Integer, ByRef timer As Timer)

'		If ClassMyPublicShared.level = 1 Then
'			fo = Form1
'		ElseIf ClassMyPublicShared.level = 2 Then
'			fo = Form2
'		ElseIf ClassMyPublicShared.level = 3 Then
'			fo = Form3
'		End If



'		If pro.Value <= 0 Then
'			pro.Value = 0
'			timer.Enabled = False

'			With winorlosetText
'				.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
'				.Visible = True
'				.Top = fo.Height / 2 - 60
'				.Left = fo.Width / 2 - 15
'				.Enabled = True
'				.BringToFront()

'			End With
'			With rest
'				.Text = "Continue"
'				.Visible = True
'				.Enabled = True
'				.Top = fo.Height / 2
'				.Left = fo.Width / 2
'				.BringToFront()

'			End With
'			With exitBtn
'				.Text = "Abandon Mission"
'				.Visible = True
'				.Enabled = True
'				.Top = fo.Height / 2 + 30
'				.Left = fo.Width / 2
'				.BringToFront()
'			End With
'			fo.Controls.Add(winorlosetText)
'			fo.Controls.Add(rest)
'			fo.Controls.Add(exitBtn)
'			AddHandler rest.Click, AddressOf RestartBtn_Click




'		End If
'	End Sub


'	Private Sub RestartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'		Dim btn As New Button
'		btn = CType(sender, Button) 'convert obj to button
'		If btn.Text = "Restart" Then
'			fo.Close()

'			Dim f1 = New Form1()
'			f1.Show()
'		End If
'		If btn.Text = "Continue" Then

'			Form2.Show()
'		End If
'	End Sub














'	'Private Sub removePictureBoxAndUpdateScore()
'	'	

'	'	pScore.Text = "Score :" + CStr(clPlayer.playerScore)
'	'	'pLife.Text = "X" + CStr(startLife)
'	'	pLife.Text = "X" + CStr(clPlayer.playerLife)
'	'	pItem.Text = "Item :" + CStr(clPlayer.playerItem)

'	'	If ProgressBar1.Value <= 0 Then
'	'		ProgressBar1.Value = 0
'	'		Timer75ms.Enabled = False
'	'		winorloseTxt.Text = "You win!!" + vbNewLine + "Ready For Next Level?"
'	'		winorloseTxt.Visible = True

'	'		RestartBtn.Text = "Continue"
'	'		RestartBtn.Visible = True
'	'		RestartBtn.Enabled = True
'	'		winorloseTxt.Top = Me.Height / 2 - 60
'	'		winorloseTxt.Left = Me.Width / 2 - 15
'	'		RestartBtn.BringToFront()
'	'		RestartBtn.Top = Me.Height / 2
'	'		RestartBtn.Left = Me.Width / 2


'	'		extbtn.Visible = True
'	'		extbtn.Enabled = True
'	'		extbtn.Text = "Abandon Mission"
'	'		extbtn.Top = Me.Height / 2 + 30
'	'		extbtn.Left = Me.Width / 2
'	'		extbtn.BringToFront()

'	'	ElseIf clPlayer.playerLife <= 0 Then
'	'		winorloseTxt.Text = "You Lose!!" + vbNewLine + "Try better Next Time"
'	'		winorloseTxt.Visible = True

'	'		RestartBtn.Text = "Restart"
'	'		RestartBtn.Visible = True
'	'		RestartBtn.Enabled = True
'	'		RestartBtn.BringToFront()
'	'		winorloseTxt.Top = Me.Height / 2 - 60
'	'		winorloseTxt.Left = Me.Width / 2 - 15
'	'		RestartBtn.Top = Me.Height / 2
'	'		RestartBtn.Left = Me.Width / 2
'	'		extbtn.Visible = True
'	'		extbtn.Enabled = True
'	'		extbtn.Text = "Abandon Mission"
'	'		extbtn.Top = Me.Height / 2 + 30
'	'		extbtn.Left = Me.Width / 2
'	'		extbtn.BringToFront()
'	'	End If
'	'End Sub


'End Module

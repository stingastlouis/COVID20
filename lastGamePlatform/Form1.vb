﻿

Public Class Form1






	'Public Score As Int16



	''' <summary>
	''' when the form is loading
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' 
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		ModuleGameManager.formLoader(Me, 1)
	End Sub


	Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Me.Dispose()
		startHere.Show()
	End Sub




End Class

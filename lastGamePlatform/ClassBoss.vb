Public Class ClassBoss
	Inherits ClassEnemies

	Private width As Integer
	Private height As Integer
	Private xPosition As Integer
	Private yPosition As Integer
	Private name As String
	Private moveSpeed As Integer
	Private image As Bitmap








	'constructors
	Public Sub New()
	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer)
		Me.width = 87
		Me.height = 62
		Me.image = My.Resources._0_Ogre_Idle_000

		Me.xPosition = xPosition
		Me.yPosition = yPosition
		Me.name = name
		Me.moveSpeed = moveSpeed
	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer, image As Bitmap) 'for new enemies image use this constructor
		Me.width = 87
		Me.height = 62
		Me.image = image

		Me.xPosition = xPosition
		Me.yPosition = yPosition
		Me.name = name
		Me.moveSpeed = moveSpeed
	End Sub














	'functions
	Public Function generateBoss()
		Dim pb As New ClassPictureBox(Width1, Height1, Name1, XPosition1, YPosition1, Image1)
		Return pb.showPictureBox()
	End Function




	Public Sub bossAndEnemiesMoveTowardPlayer(ByRef contaminer As PictureBox, ByRef player As Object)
		If contaminer.Left + contaminer.Width > player.Left Then
			contaminer.Left -= moveSpeed
		End If
		If contaminer.Left + contaminer.Width < player.Left Then
			contaminer.Left += moveSpeed
		End If

	End Sub














	'Public Sub bossCollision(ByRef boss As PictureBox, ByRef player As PictureBox)
	'    bossAndEnemiesMoveTowardPlayer(boss, player)
	'    For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes 'list all controls in the form
	'        If activePictureBox IsNot boss AndAlso boss.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
	'            If activePictureBox.Name.Contains("wall") Then
	'                If boss.Left + boss.Width > player.Left Then
	'                    boss.Left += 1
	'                End If
	'                If boss.Left + boss.Width < player.Left Then
	'                    boss.Left -= 1
	'                End If
	'            End If
	'        End If
	'    Next
	'End Sub



End Class

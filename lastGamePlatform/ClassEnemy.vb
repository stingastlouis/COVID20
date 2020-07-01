Public Class ClassEnemy
	Private width As Integer
	Private height As Integer
	Private xPosition As Integer
	Private yPosition As Integer
	Private name As String
	Private moveSpeed As Integer
	Private image As Bitmap
	Dim playerlives As Integer = 0


	'constructors
	Sub New()

	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer)
		Me.width = 87
		Me.height = 62
		Me.image = My.Resources._0_Ogre_Idle_000

		Me.xPosition = xPosition
		Me.yPosition = yPosition
		Me.name = name
		Me.moveSpeed = moveSpeed

		'Controls.Add(pb)
	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer, image As Bitmap)
		Me.width = 87
		Me.height = 62
		Me.image = image

		Me.xPosition = xPosition
		Me.yPosition = yPosition
		Me.name = name
		Me.moveSpeed = moveSpeed


	End Sub


	'setters and getters
	Public Property Width1 As Integer
		Get
			Return width
		End Get
		Set(value As Integer)
			width = value
		End Set
	End Property

	Public Property Height1 As Integer
		Get
			Return height
		End Get
		Set(value As Integer)
			height = value
		End Set
	End Property

	Public Property XPosition1 As Integer
		Get
			Return xPosition
		End Get
		Set(value As Integer)
			xPosition = value
		End Set
	End Property

	Public Property YPosition1 As Integer
		Get
			Return yPosition
		End Get
		Set(value As Integer)
			yPosition = value
		End Set
	End Property

	Public Property Name1 As String
		Get
			Return name
		End Get
		Set(value As String)
			name = value
		End Set
	End Property

	Public Property MoveSpeed1 As Integer
		Get
			Return moveSpeed
		End Get
		Set(value As Integer)
			moveSpeed = value
		End Set
	End Property

	Public Property Image1 As Bitmap
		Get
			Return image
		End Get
		Set(value As Bitmap)
			image = value
		End Set
	End Property







	'functions
	Public Function generateEnemy()
		Dim pb As New ClassPictureBox(Width1, Height1, Name1, XPosition1, YPosition1, Image1)
		Return pb.showPictureBox()
	End Function


	'Public Sub makeEnemyMoves(enemy As List(Of PictureBox), player1 As PictureBox)
	'	Dim speed As Integer = 1
	'	For Each ene As PictureBox In enemy
	'		'For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes  'list all controls in the form
	'		'	If activePictureBox IsNot ene AndAlso ene.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
	'		'		If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
	'		'			Console.WriteLine("wall/ground")

	'		'			If ene.Top > activePictureBox.Top - ene.Height Then 'to stay on top of ground and wall
	'		'				ene.Location = New Point(ene.Location.X, activePictureBox.Top - ene.Height)
	'		'			End If
	'		'			Exit For
	'		'		End If
	'		'	End If
	'		'Next
	'		If ene.Left > player1.Left Then
	'			ene.Left -= speed
	'		ElseIf ene.Left < player1.Left Then
	'			ene.Left += speed
	'		End If
	'		If ene.Top > player1.Top Then
	'			ene.Top -= speed
	'		ElseIf ene.Top < player1.Top Then
	'			ene.Top += speed
	'		End If
	'	Next
	'End Sub

	Public Sub collisionPlayer(ByVal player As Object, ByVal enemy As List(Of PictureBox))
		For Each x As PictureBox In enemy
			If Module1.checkforCollision(player, x) And x.Enabled = True Then
				x.Dispose()
				x.Enabled = False
				Me.playerlives -= 1

			End If
		Next

	End Sub

	Public Sub getLives(ByRef life As Integer)
		Me.playerlives = life
	End Sub
	Public Function submitLives() As Integer
		Return Me.playerlives
	End Function


End Class

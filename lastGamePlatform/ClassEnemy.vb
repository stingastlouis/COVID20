Public Class ClassEnemy
	Private Width As Integer
	Private Height As Integer
	Private XPosition As Integer
	Private YPosition As Integer
	Private Name As String
	Private MoveSpeed As Integer
	Private Image As Bitmap



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
	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer, image As Bitmap)
		Me.width = 87
		Me.height = 62
		Me.image = Me.image

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



	'function
	Public Function generatePictureBox()
		Dim enemyPictureBox As New PictureBox
		With enemyPictureBox
			.Width = Me.width
			.Height = Me.height
			.Name = Me.name
			.Location = New Point(Me.xPosition, Me.yPosition)
			.Image = Me.image
			.BackColor = Color.Transparent
			.SizeMode = PictureBoxSizeMode.StretchImage
			.BringToFront()
		End With
		Return enemyPictureBox
	End Function


	Public Sub makeEnemyMoves(ByVal enemy As List(Of PictureBox), ByVal player1 As Object)
		Dim speed As Integer = 1
		For Each ene As PictureBox In enemy
			For Each activePictureBox As PictureBox In ClassMyPublicShared.allPictureBoxes  'list all controls in the form
				If activePictureBox IsNot ene AndAlso ene.Bounds.IntersectsWith(activePictureBox.Bounds) Then 'if player picturebox intersects with other pictureboxes
					If activePictureBox.Name.Contains("ground") OrElse activePictureBox.Name.Contains("wall") Then
						Console.WriteLine("wall/ground")

						If ene.Top > activePictureBox.Top - ene.Height Then 'to stay on top of ground and wall
							ene.Location = New Point(ene.Location.X, activePictureBox.Top - ene.Height)
						End If
						Exit For
					End If
				End If
			Next
			If ene.Left > player1.Left Then
				ene.Left -= speed
			ElseIf ene.Left < player1.Left Then
				ene.Left += speed
			End If
			If ene.Top > player1.Top Then
				ene.Top -= speed
			ElseIf ene.Top < player1.Top Then
				ene.Top += speed
			End If
		Next
	End Sub



End Class

Public Class ClassEnemy
	Private width As Integer
	Private height As Integer
	Private xPosition As Integer
	Private yPosition As Integer
	Private name As String
	Private moveSpeed As Integer
	Private image As Bitmap



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






End Class

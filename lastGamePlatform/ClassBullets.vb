Public Class ClassBullets
	Private width As Integer
	Private height As Integer
	Private xPosition As Integer
	Private yPosition As Integer
	Private name As String
	Private moveSpeed As Integer
	Private img As Bitmap





	'constructors
	Public Sub New()
		Me.width = 15
		Me.height = 25
		Me.name = "bullet"
		Me.moveSpeed = 10
		Me.img = My.Resources._5a3719ae33d594_4783473215135604942123
	End Sub
	Public Sub New(player As PictureBox)
		Me.width = 15
		Me.height = 25
		Me.xPosition = player.Location.X
		Me.yPosition = player.Location.Y
		Me.name = "bullet"
		Me.moveSpeed = 10
		Me.img = My.Resources._5a3719ae33d594_4783473215135604942123
	End Sub







	'setters getters
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

	Public Property Img1 As Bitmap
		Get
			Return img
		End Get
		Set(value As Bitmap)
			img = value
		End Set
	End Property









	'functions
	Public Function generateBullet()
		Dim pb As New ClassPictureBox(Width1, Height1, Name1, XPosition1, YPosition1, Img1)
		Return pb.showPictureBox()
	End Function


End Class

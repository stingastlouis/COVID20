Public Class ClassEnemies
	Private width As Integer
	Private height As Integer
	Private xPosition As Integer
	Private yPosition As Integer
	Private name As String
	Private moveSpeed As Integer
	Private img As Bitmap








	'constructors
	Public Sub New()
	End Sub
	Public Sub New(xPosition As Integer, yPosition As Integer, name As String, moveSpeed As Integer)
		Me.width = 87
		Me.height = 62
		Me.img = Image.FromFile(IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Enemies\Enemy" & level & ".png"))
		Me.xPosition = xPosition - 87
		Me.yPosition = yPosition - 62
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

	Public Property img1 As Bitmap
		Get
			Return img
		End Get
		Set(value As Bitmap)
			img = value
		End Set
	End Property












	'functions
	Public Function generateEnemy()
		Dim pb As New ClassPictureBox(Width1, Height1, Name1, XPosition1, YPosition1, img1)
		Return pb.showPictureBox()
	End Function





End Class

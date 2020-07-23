Public Class ClassPictureBox
	Private width As Integer
	Private height As Integer
	Private name As String
	Private xPosition As Integer
	Private yPosition As Integer
	Private img As Bitmap

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

	Public Property Name1 As String
		Get
			Return name
		End Get
		Set(value As String)
			name = value
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

	Public Property Img1 As Bitmap
		Get
			Return img
		End Get
		Set(value As Bitmap)
			img = value
		End Set
	End Property



	'constructors
	Public Sub New()
	End Sub
	Public Sub New(width As Integer, height As Integer, name As String, xPosition As Integer, yPosition As Integer, img As Bitmap)
		Me.width = width
		Me.height = height
		Me.name = name
		Me.xPosition = xPosition
		Me.yPosition = yPosition
		Me.img = img
	End Sub
	Public Sub New(picBox As PictureBox, imagePath As String)
		Me.width = picBox.Width
		Me.height = picBox.Height
		Me.name = picBox.Name
		Me.xPosition = picBox.Location.X
		Me.yPosition = picBox.Location.Y
		Me.img = Image.FromFile(imagePath)
		showPictureBox(picBox)
	End Sub




	'fns
	Private Function showPictureBox(pb As PictureBox)
		pb.Width = Width1
		pb.Height = Height1
		pb.Name = Name1
		pb.Location = New Point(XPosition1, YPosition1)
		pb.Image = Img1
		pb.BackColor = Color.Transparent
		pb.SizeMode = PictureBoxSizeMode.StretchImage
		pb.BringToFront()
		ClassMyPublicShared.allPictureBoxes.Add(pb) 'push to list
		Return pb
	End Function


	Public Function showPictureBox()
		Dim pb As New PictureBox With {
			.Width = Width1,
			.Height = Height1,
			.Name = Name1,
			.Location = New Point(XPosition1, YPosition1),
			.Image = Img1,
			.BackColor = Color.Transparent,
			.SizeMode = PictureBoxSizeMode.StretchImage
		}
		pb.BringToFront()
		ClassMyPublicShared.allPictureBoxes.Add(pb) 'push to list
		Return pb
	End Function

	Public Function showPictureBoxNoAdd()
		Dim pb As New PictureBox With {
			.Width = Width1,
			.Height = Height1,
			.Name = Name1,
			.Location = New Point(XPosition1, YPosition1),
			.Image = Img1,
			.BackColor = Color.Transparent,
			.SizeMode = PictureBoxSizeMode.StretchImage
		}
		pb.BringToFront()
		Return pb
	End Function





End Class

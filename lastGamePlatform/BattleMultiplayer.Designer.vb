<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ground
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.player2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSc1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSc2 = New System.Windows.Forms.Label()
        Me.p1label = New System.Windows.Forms.Label()
        Me.p2label = New System.Windows.Forms.Label()
        Me.BattleManager = New System.Windows.Forms.Timer(Me.components)
        Me.terrain = New System.Windows.Forms.PictureBox()
        Me.gun1 = New System.Windows.Forms.PictureBox()
        Me.gun2 = New System.Windows.Forms.PictureBox()
        Me.mic1 = New System.Windows.Forms.PictureBox()
        Me.mic2 = New System.Windows.Forms.PictureBox()
        Me.wall1 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.life1 = New System.Windows.Forms.PictureBox()
        Me.life2 = New System.Windows.Forms.PictureBox()
        Me.p2life = New System.Windows.Forms.Label()
        Me.p1life = New System.Windows.Forms.Label()
        Me.bul1_1 = New System.Windows.Forms.PictureBox()
        Me.bul1_2 = New System.Windows.Forms.PictureBox()
        Me.bul1_3 = New System.Windows.Forms.PictureBox()
        Me.bul1_4 = New System.Windows.Forms.PictureBox()
        Me.bul1_5 = New System.Windows.Forms.PictureBox()
        Me.bul2_5 = New System.Windows.Forms.PictureBox()
        Me.bul2_4 = New System.Windows.Forms.PictureBox()
        Me.bul2_3 = New System.Windows.Forms.PictureBox()
        Me.bul2_2 = New System.Windows.Forms.PictureBox()
        Me.bul2_1 = New System.Windows.Forms.PictureBox()
        Me.bul1_7 = New System.Windows.Forms.PictureBox()
        Me.bul1_6 = New System.Windows.Forms.PictureBox()
        Me.bul2_7 = New System.Windows.Forms.PictureBox()
        Me.bul2_6 = New System.Windows.Forms.PictureBox()
        Me.p1Name = New System.Windows.Forms.Label()
        Me.en1_1 = New System.Windows.Forms.PictureBox()
        Me.en1_2 = New System.Windows.Forms.PictureBox()
        Me.en2_1 = New System.Windows.Forms.PictureBox()
        Me.en2_2 = New System.Windows.Forms.PictureBox()
        Me.finallBoss = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.wiwin = New System.Windows.Forms.Label()
        Me.whoWin = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblBoss = New System.Windows.Forms.Label()
        Me.gotoMain = New System.Windows.Forms.Button()
        Me.mov1 = New System.Windows.Forms.PictureBox()
        Me.mov2 = New System.Windows.Forms.PictureBox()
        Me.mov3 = New System.Windows.Forms.PictureBox()
        Me.mov4 = New System.Windows.Forms.PictureBox()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.terrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gun2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.life1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.life2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul1_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bul2_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finallBoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mov1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mov2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mov3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mov4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.Transparent
        Me.player1.Location = New System.Drawing.Point(190, 143)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(65, 50)
        Me.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player1.TabIndex = 3
        Me.player1.TabStop = False
        Me.player1.Tag = "content"
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.Color.Transparent
        Me.player2.Location = New System.Drawing.Point(1062, 349)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(65, 50)
        Me.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player2.TabIndex = 4
        Me.player2.TabStop = False
        Me.player2.Tag = "content"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name :"
        '
        'txtSc1
        '
        Me.txtSc1.AutoSize = True
        Me.txtSc1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSc1.Location = New System.Drawing.Point(307, 22)
        Me.txtSc1.Name = "txtSc1"
        Me.txtSc1.Size = New System.Drawing.Size(52, 24)
        Me.txtSc1.TabIndex = 6
        Me.txtSc1.Text = "Score :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(808, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name :"
        '
        'txtSc2
        '
        Me.txtSc2.AutoSize = True
        Me.txtSc2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSc2.Location = New System.Drawing.Point(1058, 22)
        Me.txtSc2.Name = "txtSc2"
        Me.txtSc2.Size = New System.Drawing.Size(52, 24)
        Me.txtSc2.TabIndex = 8
        Me.txtSc2.Text = "Score :"
        '
        'p1label
        '
        Me.p1label.AutoSize = True
        Me.p1label.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1label.Location = New System.Drawing.Point(103, -19)
        Me.p1label.Name = "p1label"
        Me.p1label.Size = New System.Drawing.Size(0, 24)
        Me.p1label.TabIndex = 9
        Me.p1label.Visible = False
        '
        'p2label
        '
        Me.p2label.AutoSize = True
        Me.p2label.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2label.Location = New System.Drawing.Point(864, 22)
        Me.p2label.Name = "p2label"
        Me.p2label.Size = New System.Drawing.Size(14, 24)
        Me.p2label.TabIndex = 10
        Me.p2label.Text = " "
        '
        'BattleManager
        '
        Me.BattleManager.Interval = 50
        '
        'terrain
        '
        Me.terrain.BackColor = System.Drawing.Color.Maroon
        Me.terrain.Location = New System.Drawing.Point(-3, 418)
        Me.terrain.Name = "terrain"
        Me.terrain.Size = New System.Drawing.Size(1151, 50)
        Me.terrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.terrain.TabIndex = 11
        Me.terrain.TabStop = False
        Me.terrain.Tag = "content"
        '
        'gun1
        '
        Me.gun1.BackColor = System.Drawing.Color.Silver
        Me.gun1.Location = New System.Drawing.Point(384, 77)
        Me.gun1.Name = "gun1"
        Me.gun1.Size = New System.Drawing.Size(65, 50)
        Me.gun1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gun1.TabIndex = 12
        Me.gun1.TabStop = False
        Me.gun1.Tag = "content"
        '
        'gun2
        '
        Me.gun2.BackColor = System.Drawing.Color.Silver
        Me.gun2.Location = New System.Drawing.Point(605, 77)
        Me.gun2.Name = "gun2"
        Me.gun2.Size = New System.Drawing.Size(65, 50)
        Me.gun2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gun2.TabIndex = 13
        Me.gun2.TabStop = False
        Me.gun2.Tag = "content"
        '
        'mic1
        '
        Me.mic1.BackColor = System.Drawing.Color.Silver
        Me.mic1.Location = New System.Drawing.Point(384, 12)
        Me.mic1.Name = "mic1"
        Me.mic1.Size = New System.Drawing.Size(65, 50)
        Me.mic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mic1.TabIndex = 14
        Me.mic1.TabStop = False
        Me.mic1.Tag = "content"
        '
        'mic2
        '
        Me.mic2.BackColor = System.Drawing.Color.Silver
        Me.mic2.Location = New System.Drawing.Point(102, 304)
        Me.mic2.Name = "mic2"
        Me.mic2.Size = New System.Drawing.Size(65, 50)
        Me.mic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mic2.TabIndex = 15
        Me.mic2.TabStop = False
        Me.mic2.Tag = "content"
        '
        'wall1
        '
        Me.wall1.BackColor = System.Drawing.Color.Maroon
        Me.wall1.Location = New System.Drawing.Point(141, 360)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(65, 61)
        Me.wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall1.TabIndex = 16
        Me.wall1.TabStop = False
        Me.wall1.Tag = "content"
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.Maroon
        Me.wall2.Location = New System.Drawing.Point(964, 360)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(65, 61)
        Me.wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall2.TabIndex = 17
        Me.wall2.TabStop = False
        Me.wall2.Tag = "content"
        '
        'life1
        '
        Me.life1.BackColor = System.Drawing.Color.Silver
        Me.life1.Location = New System.Drawing.Point(294, 77)
        Me.life1.Name = "life1"
        Me.life1.Size = New System.Drawing.Size(65, 50)
        Me.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.life1.TabIndex = 18
        Me.life1.TabStop = False
        Me.life1.Tag = "content"
        '
        'life2
        '
        Me.life2.BackColor = System.Drawing.Color.Silver
        Me.life2.Location = New System.Drawing.Point(536, 121)
        Me.life2.Name = "life2"
        Me.life2.Size = New System.Drawing.Size(65, 50)
        Me.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.life2.TabIndex = 19
        Me.life2.TabStop = False
        Me.life2.Tag = "content"
        '
        'p2life
        '
        Me.p2life.AutoSize = True
        Me.p2life.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2life.Location = New System.Drawing.Point(943, 22)
        Me.p2life.Name = "p2life"
        Me.p2life.Size = New System.Drawing.Size(35, 24)
        Me.p2life.TabIndex = 20
        Me.p2life.Text = "Life :"
        '
        'p1life
        '
        Me.p1life.AutoSize = True
        Me.p1life.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1life.Location = New System.Drawing.Point(232, 23)
        Me.p1life.Name = "p1life"
        Me.p1life.Size = New System.Drawing.Size(35, 24)
        Me.p1life.TabIndex = 21
        Me.p1life.Text = "Life :"
        '
        'bul1_1
        '
        Me.bul1_1.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_1.Location = New System.Drawing.Point(32, 14)
        Me.bul1_1.Name = "bul1_1"
        Me.bul1_1.Size = New System.Drawing.Size(10, 33)
        Me.bul1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_1.TabIndex = 22
        Me.bul1_1.TabStop = False
        Me.bul1_1.Tag = "content"
        Me.bul1_1.Visible = False
        '
        'bul1_2
        '
        Me.bul1_2.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_2.Location = New System.Drawing.Point(48, 14)
        Me.bul1_2.Name = "bul1_2"
        Me.bul1_2.Size = New System.Drawing.Size(10, 33)
        Me.bul1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_2.TabIndex = 23
        Me.bul1_2.TabStop = False
        Me.bul1_2.Tag = "content"
        Me.bul1_2.Visible = False
        '
        'bul1_3
        '
        Me.bul1_3.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_3.Location = New System.Drawing.Point(64, 14)
        Me.bul1_3.Name = "bul1_3"
        Me.bul1_3.Size = New System.Drawing.Size(10, 33)
        Me.bul1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_3.TabIndex = 24
        Me.bul1_3.TabStop = False
        Me.bul1_3.Tag = "content"
        Me.bul1_3.Visible = False
        '
        'bul1_4
        '
        Me.bul1_4.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_4.Location = New System.Drawing.Point(80, 14)
        Me.bul1_4.Name = "bul1_4"
        Me.bul1_4.Size = New System.Drawing.Size(10, 33)
        Me.bul1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_4.TabIndex = 25
        Me.bul1_4.TabStop = False
        Me.bul1_4.Tag = "content"
        Me.bul1_4.Visible = False
        '
        'bul1_5
        '
        Me.bul1_5.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_5.Location = New System.Drawing.Point(96, 14)
        Me.bul1_5.Name = "bul1_5"
        Me.bul1_5.Size = New System.Drawing.Size(10, 33)
        Me.bul1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_5.TabIndex = 26
        Me.bul1_5.TabStop = False
        Me.bul1_5.Tag = "content"
        Me.bul1_5.Visible = False
        '
        'bul2_5
        '
        Me.bul2_5.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_5.Location = New System.Drawing.Point(772, 14)
        Me.bul2_5.Name = "bul2_5"
        Me.bul2_5.Size = New System.Drawing.Size(10, 33)
        Me.bul2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_5.TabIndex = 31
        Me.bul2_5.TabStop = False
        Me.bul2_5.Tag = "content"
        Me.bul2_5.Visible = False
        '
        'bul2_4
        '
        Me.bul2_4.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_4.Location = New System.Drawing.Point(756, 14)
        Me.bul2_4.Name = "bul2_4"
        Me.bul2_4.Size = New System.Drawing.Size(10, 33)
        Me.bul2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_4.TabIndex = 30
        Me.bul2_4.TabStop = False
        Me.bul2_4.Tag = "content"
        Me.bul2_4.Visible = False
        '
        'bul2_3
        '
        Me.bul2_3.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_3.Location = New System.Drawing.Point(740, 14)
        Me.bul2_3.Name = "bul2_3"
        Me.bul2_3.Size = New System.Drawing.Size(10, 33)
        Me.bul2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_3.TabIndex = 29
        Me.bul2_3.TabStop = False
        Me.bul2_3.Tag = "content"
        Me.bul2_3.Visible = False
        '
        'bul2_2
        '
        Me.bul2_2.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_2.Location = New System.Drawing.Point(724, 14)
        Me.bul2_2.Name = "bul2_2"
        Me.bul2_2.Size = New System.Drawing.Size(10, 33)
        Me.bul2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_2.TabIndex = 28
        Me.bul2_2.TabStop = False
        Me.bul2_2.Tag = "content"
        Me.bul2_2.Visible = False
        '
        'bul2_1
        '
        Me.bul2_1.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_1.Location = New System.Drawing.Point(709, 14)
        Me.bul2_1.Name = "bul2_1"
        Me.bul2_1.Size = New System.Drawing.Size(10, 33)
        Me.bul2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_1.TabIndex = 27
        Me.bul2_1.TabStop = False
        Me.bul2_1.Tag = "content"
        Me.bul2_1.Visible = False
        '
        'bul1_7
        '
        Me.bul1_7.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_7.Location = New System.Drawing.Point(48, 14)
        Me.bul1_7.Name = "bul1_7"
        Me.bul1_7.Size = New System.Drawing.Size(10, 33)
        Me.bul1_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_7.TabIndex = 32
        Me.bul1_7.TabStop = False
        Me.bul1_7.Tag = "content"
        Me.bul1_7.Visible = False
        '
        'bul1_6
        '
        Me.bul1_6.BackColor = System.Drawing.Color.Fuchsia
        Me.bul1_6.Location = New System.Drawing.Point(32, 14)
        Me.bul1_6.Name = "bul1_6"
        Me.bul1_6.Size = New System.Drawing.Size(10, 33)
        Me.bul1_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul1_6.TabIndex = 33
        Me.bul1_6.TabStop = False
        Me.bul1_6.Tag = "content"
        Me.bul1_6.Visible = False
        '
        'bul2_7
        '
        Me.bul2_7.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_7.Location = New System.Drawing.Point(724, 14)
        Me.bul2_7.Name = "bul2_7"
        Me.bul2_7.Size = New System.Drawing.Size(10, 33)
        Me.bul2_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_7.TabIndex = 34
        Me.bul2_7.TabStop = False
        Me.bul2_7.Tag = "content"
        Me.bul2_7.Visible = False
        '
        'bul2_6
        '
        Me.bul2_6.BackColor = System.Drawing.Color.Fuchsia
        Me.bul2_6.Location = New System.Drawing.Point(709, 14)
        Me.bul2_6.Name = "bul2_6"
        Me.bul2_6.Size = New System.Drawing.Size(10, 33)
        Me.bul2_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bul2_6.TabIndex = 35
        Me.bul2_6.TabStop = False
        Me.bul2_6.Tag = "content"
        Me.bul2_6.Visible = False
        '
        'p1Name
        '
        Me.p1Name.AutoSize = True
        Me.p1Name.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1Name.Location = New System.Drawing.Point(173, 23)
        Me.p1Name.Name = "p1Name"
        Me.p1Name.Size = New System.Drawing.Size(14, 24)
        Me.p1Name.TabIndex = 36
        Me.p1Name.Text = " "
        '
        'en1_1
        '
        Me.en1_1.BackColor = System.Drawing.Color.Transparent
        Me.en1_1.Enabled = False
        Me.en1_1.Location = New System.Drawing.Point(331, 49)
        Me.en1_1.Name = "en1_1"
        Me.en1_1.Size = New System.Drawing.Size(47, 33)
        Me.en1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en1_1.TabIndex = 37
        Me.en1_1.TabStop = False
        Me.en1_1.Tag = "content"
        Me.en1_1.Visible = False
        '
        'en1_2
        '
        Me.en1_2.BackColor = System.Drawing.Color.Transparent
        Me.en1_2.Enabled = False
        Me.en1_2.Location = New System.Drawing.Point(455, 49)
        Me.en1_2.Name = "en1_2"
        Me.en1_2.Size = New System.Drawing.Size(43, 33)
        Me.en1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en1_2.TabIndex = 38
        Me.en1_2.TabStop = False
        Me.en1_2.Tag = "content"
        Me.en1_2.Visible = False
        '
        'en2_1
        '
        Me.en2_1.BackColor = System.Drawing.Color.Transparent
        Me.en2_1.Enabled = False
        Me.en2_1.Location = New System.Drawing.Point(554, 39)
        Me.en2_1.Name = "en2_1"
        Me.en2_1.Size = New System.Drawing.Size(47, 33)
        Me.en2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en2_1.TabIndex = 39
        Me.en2_1.TabStop = False
        Me.en2_1.Tag = "content"
        Me.en2_1.Visible = False
        '
        'en2_2
        '
        Me.en2_2.BackColor = System.Drawing.Color.Transparent
        Me.en2_2.Enabled = False
        Me.en2_2.Location = New System.Drawing.Point(719, 49)
        Me.en2_2.Name = "en2_2"
        Me.en2_2.Size = New System.Drawing.Size(47, 33)
        Me.en2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en2_2.TabIndex = 40
        Me.en2_2.TabStop = False
        Me.en2_2.Tag = "content"
        Me.en2_2.Visible = False
        '
        'finallBoss
        '
        Me.finallBoss.BackColor = System.Drawing.Color.Transparent
        Me.finallBoss.Enabled = False
        Me.finallBoss.Location = New System.Drawing.Point(477, 193)
        Me.finallBoss.Name = "finallBoss"
        Me.finallBoss.Size = New System.Drawing.Size(273, 225)
        Me.finallBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.finallBoss.TabIndex = 41
        Me.finallBoss.TabStop = False
        Me.finallBoss.Tag = "content"
        Me.finallBoss.Visible = False
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(435, 244)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(84, 30)
        Me.btnRestart.TabIndex = 42
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'wiwin
        '
        Me.wiwin.AutoSize = True
        Me.wiwin.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiwin.Location = New System.Drawing.Point(446, 217)
        Me.wiwin.Name = "wiwin"
        Me.wiwin.Size = New System.Drawing.Size(33, 24)
        Me.wiwin.TabIndex = 43
        Me.wiwin.Text = "hey "
        Me.wiwin.Visible = False
        '
        'whoWin
        '
        Me.whoWin.AutoSize = True
        Me.whoWin.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whoWin.Location = New System.Drawing.Point(572, 221)
        Me.whoWin.Name = "whoWin"
        Me.whoWin.Size = New System.Drawing.Size(0, 24)
        Me.whoWin.TabIndex = 44
        Me.whoWin.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(554, 24)
        Me.ProgressBar1.Maximum = 15
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(107, 23)
        Me.ProgressBar1.TabIndex = 45
        Me.ProgressBar1.Visible = False
        '
        'lblBoss
        '
        Me.lblBoss.AutoSize = True
        Me.lblBoss.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoss.Location = New System.Drawing.Point(478, 23)
        Me.lblBoss.Name = "lblBoss"
        Me.lblBoss.Size = New System.Drawing.Size(68, 24)
        Me.lblBoss.TabIndex = 46
        Me.lblBoss.Text = "Boss Life :"
        Me.lblBoss.Visible = False
        '
        'gotoMain
        '
        Me.gotoMain.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotoMain.Location = New System.Drawing.Point(435, 280)
        Me.gotoMain.Name = "gotoMain"
        Me.gotoMain.Size = New System.Drawing.Size(84, 30)
        Me.gotoMain.TabIndex = 47
        Me.gotoMain.Text = "Main Menu"
        Me.gotoMain.UseVisualStyleBackColor = True
        Me.gotoMain.Visible = False
        '
        'mov1
        '
        Me.mov1.BackColor = System.Drawing.Color.Transparent
        Me.mov1.Enabled = False
        Me.mov1.Location = New System.Drawing.Point(141, 77)
        Me.mov1.Name = "mov1"
        Me.mov1.Size = New System.Drawing.Size(47, 33)
        Me.mov1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mov1.TabIndex = 48
        Me.mov1.TabStop = False
        Me.mov1.Tag = "content"
        Me.mov1.Visible = False
        '
        'mov2
        '
        Me.mov2.BackColor = System.Drawing.Color.Transparent
        Me.mov2.Enabled = False
        Me.mov2.Location = New System.Drawing.Point(982, 77)
        Me.mov2.Name = "mov2"
        Me.mov2.Size = New System.Drawing.Size(47, 33)
        Me.mov2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mov2.TabIndex = 49
        Me.mov2.TabStop = False
        Me.mov2.Tag = "content"
        Me.mov2.Visible = False
        '
        'mov3
        '
        Me.mov3.BackColor = System.Drawing.Color.Transparent
        Me.mov3.Enabled = False
        Me.mov3.Location = New System.Drawing.Point(312, 143)
        Me.mov3.Name = "mov3"
        Me.mov3.Size = New System.Drawing.Size(47, 33)
        Me.mov3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mov3.TabIndex = 50
        Me.mov3.TabStop = False
        Me.mov3.Tag = "content"
        Me.mov3.Visible = False
        '
        'mov4
        '
        Me.mov4.BackColor = System.Drawing.Color.Transparent
        Me.mov4.Enabled = False
        Me.mov4.Location = New System.Drawing.Point(831, 143)
        Me.mov4.Name = "mov4"
        Me.mov4.Size = New System.Drawing.Size(47, 33)
        Me.mov4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mov4.TabIndex = 51
        Me.mov4.TabStop = False
        Me.mov4.Tag = "content"
        Me.mov4.Visible = False
        '
        'ground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 466)
        Me.Controls.Add(Me.mov4)
        Me.Controls.Add(Me.mov3)
        Me.Controls.Add(Me.mov2)
        Me.Controls.Add(Me.mov1)
        Me.Controls.Add(Me.gotoMain)
        Me.Controls.Add(Me.txtSc2)
        Me.Controls.Add(Me.lblBoss)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.whoWin)
        Me.Controls.Add(Me.wiwin)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.finallBoss)
        Me.Controls.Add(Me.en2_2)
        Me.Controls.Add(Me.en2_1)
        Me.Controls.Add(Me.en1_2)
        Me.Controls.Add(Me.en1_1)
        Me.Controls.Add(Me.p1Name)
        Me.Controls.Add(Me.bul2_6)
        Me.Controls.Add(Me.bul2_7)
        Me.Controls.Add(Me.bul1_6)
        Me.Controls.Add(Me.bul1_7)
        Me.Controls.Add(Me.bul2_5)
        Me.Controls.Add(Me.bul2_4)
        Me.Controls.Add(Me.bul2_3)
        Me.Controls.Add(Me.bul2_2)
        Me.Controls.Add(Me.bul2_1)
        Me.Controls.Add(Me.bul1_5)
        Me.Controls.Add(Me.bul1_4)
        Me.Controls.Add(Me.bul1_3)
        Me.Controls.Add(Me.bul1_2)
        Me.Controls.Add(Me.bul1_1)
        Me.Controls.Add(Me.p1life)
        Me.Controls.Add(Me.p2life)
        Me.Controls.Add(Me.life2)
        Me.Controls.Add(Me.life1)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.mic2)
        Me.Controls.Add(Me.mic1)
        Me.Controls.Add(Me.gun2)
        Me.Controls.Add(Me.gun1)
        Me.Controls.Add(Me.terrain)
        Me.Controls.Add(Me.p2label)
        Me.Controls.Add(Me.p1label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.txtSc1)
        Me.Name = "ground"
        Me.Text = "BattleMultiplayer"
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.terrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gun2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.life1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.life2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul1_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bul2_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finallBoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mov1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mov2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mov3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mov4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player1 As PictureBox
    Friend WithEvents player2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSc1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSc2 As Label
    Friend WithEvents p1label As Label
    Friend WithEvents p2label As Label
    Friend WithEvents BattleManager As Timer
    Friend WithEvents terrain As PictureBox
    Friend WithEvents gun1 As PictureBox
    Friend WithEvents gun2 As PictureBox
    Friend WithEvents mic1 As PictureBox
    Friend WithEvents mic2 As PictureBox
    Friend WithEvents wall1 As PictureBox
    Friend WithEvents wall2 As PictureBox
    Friend WithEvents life1 As PictureBox
    Friend WithEvents life2 As PictureBox
    Friend WithEvents p2life As Label
    Friend WithEvents p1life As Label
    Friend WithEvents bul1_1 As PictureBox
    Friend WithEvents bul1_2 As PictureBox
    Friend WithEvents bul1_3 As PictureBox
    Friend WithEvents bul1_4 As PictureBox
    Friend WithEvents bul1_5 As PictureBox
    Friend WithEvents bul2_5 As PictureBox
    Friend WithEvents bul2_4 As PictureBox
    Friend WithEvents bul2_3 As PictureBox
    Friend WithEvents bul2_2 As PictureBox
    Friend WithEvents bul2_1 As PictureBox
    Friend WithEvents bul1_7 As PictureBox
    Friend WithEvents bul1_6 As PictureBox
    Friend WithEvents bul2_7 As PictureBox
    Friend WithEvents bul2_6 As PictureBox
    Friend WithEvents p1Name As Label
    Friend WithEvents en1_1 As PictureBox
    Friend WithEvents en1_2 As PictureBox
    Friend WithEvents en2_1 As PictureBox
    Friend WithEvents en2_2 As PictureBox
    Friend WithEvents finallBoss As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents wiwin As Label
    Friend WithEvents whoWin As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblBoss As Label
    Friend WithEvents gotoMain As Button
    Friend WithEvents mov1 As PictureBox
    Friend WithEvents mov2 As PictureBox
    Friend WithEvents mov3 As PictureBox
    Friend WithEvents mov4 As PictureBox
End Class

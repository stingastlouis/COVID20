<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer75ms = New System.Windows.Forms.Timer(Me.components)
        Me.pName = New System.Windows.Forms.Label()
        Me.pItem = New System.Windows.Forms.Label()
        Me.pLife = New System.Windows.Forms.Label()
        Me.pScore = New System.Windows.Forms.Label()
        Me.winorloseTxt = New System.Windows.Forms.Label()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.extbtn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FastestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1000ms = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.supergun0 = New System.Windows.Forms.PictureBox()
        Me.wall24 = New System.Windows.Forms.PictureBox()
        Me.door1 = New System.Windows.Forms.PictureBox()
        Me.door2 = New System.Windows.Forms.PictureBox()
        Me.instruction = New System.Windows.Forms.PictureBox()
        Me.boss = New System.Windows.Forms.PictureBox()
        Me.wall12 = New System.Windows.Forms.PictureBox()
        Me.wall11 = New System.Windows.Forms.PictureBox()
        Me.wall9 = New System.Windows.Forms.PictureBox()
        Me.wall7 = New System.Windows.Forms.PictureBox()
        Me.wall6 = New System.Windows.Forms.PictureBox()
        Me.wall5 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.ground1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supergun0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.instruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ground1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer75ms
        '
        Me.Timer75ms.Enabled = True
        '
        'pName
        '
        Me.pName.AutoSize = True
        Me.pName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pName.Location = New System.Drawing.Point(35, 9)
        Me.pName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pName.Name = "pName"
        Me.pName.Size = New System.Drawing.Size(82, 29)
        Me.pName.TabIndex = 19
        Me.pName.Tag = "stayHere"
        Me.pName.Text = "Johny "
        '
        'pItem
        '
        Me.pItem.AutoSize = True
        Me.pItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pItem.Location = New System.Drawing.Point(332, 12)
        Me.pItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(77, 29)
        Me.pItem.TabIndex = 20
        Me.pItem.Tag = "stayHere"
        Me.pItem.Text = "Item : "
        '
        'pLife
        '
        Me.pLife.AutoSize = True
        Me.pLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pLife.Location = New System.Drawing.Point(116, 12)
        Me.pLife.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pLife.Name = "pLife"
        Me.pLife.Size = New System.Drawing.Size(49, 29)
        Me.pLife.TabIndex = 21
        Me.pLife.Tag = "stayHere"
        Me.pLife.Text = "X 3"
        '
        'pScore
        '
        Me.pScore.AutoSize = True
        Me.pScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pScore.Location = New System.Drawing.Point(189, 12)
        Me.pScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pScore.Name = "pScore"
        Me.pScore.Size = New System.Drawing.Size(95, 29)
        Me.pScore.TabIndex = 22
        Me.pScore.Tag = "stayHere"
        Me.pScore.Text = "Score : "
        '
        'winorloseTxt
        '
        Me.winorloseTxt.AutoSize = True
        Me.winorloseTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winorloseTxt.Location = New System.Drawing.Point(4128, -48)
        Me.winorloseTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.winorloseTxt.Name = "winorloseTxt"
        Me.winorloseTxt.Size = New System.Drawing.Size(86, 29)
        Me.winorloseTxt.TabIndex = 37
        Me.winorloseTxt.Text = "Label1"
        Me.winorloseTxt.Visible = False
        '
        'RestartBtn
        '
        Me.RestartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartBtn.Location = New System.Drawing.Point(4075, -15)
        Me.RestartBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(165, 46)
        Me.RestartBtn.TabIndex = 38
        Me.RestartBtn.Text = "Button1"
        Me.RestartBtn.UseVisualStyleBackColor = True
        Me.RestartBtn.Visible = False
        '
        'extbtn
        '
        Me.extbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extbtn.Location = New System.Drawing.Point(4075, 38)
        Me.extbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.extbtn.Name = "extbtn"
        Me.extbtn.Size = New System.Drawing.Size(165, 46)
        Me.extbtn.TabIndex = 39
        Me.extbtn.Text = "Button1"
        Me.extbtn.UseVisualStyleBackColor = True
        Me.extbtn.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(587, 12)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Maximum = 18
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(133, 28)
        Me.ProgressBar1.TabIndex = 96
        Me.ProgressBar1.Tag = "stayHere"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 97
        Me.Label1.Tag = "stayHere"
        Me.Label1.Text = "Boss Life : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 321)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 29)
        Me.Label6.TabIndex = 111
        Me.Label6.Tag = "content"
        Me.Label6.Text = "Collect 2 Item and a gun to shoot"
        '
        'FastestTimer
        '
        Me.FastestTimer.Enabled = True
        Me.FastestTimer.Interval = 10
        '
        'Timer1000ms
        '
        Me.Timer1000ms.Interval = 1000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(308, 245)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1, 1)
        Me.AxWindowsMediaPlayer1.TabIndex = 121
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'supergun0
        '
        Me.supergun0.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.supergun0.Location = New System.Drawing.Point(2351, 241)
        Me.supergun0.Margin = New System.Windows.Forms.Padding(4)
        Me.supergun0.Name = "supergun0"
        Me.supergun0.Size = New System.Drawing.Size(101, 81)
        Me.supergun0.TabIndex = 120
        Me.supergun0.TabStop = False
        '
        'wall24
        '
        Me.wall24.BackColor = System.Drawing.Color.Maroon
        Me.wall24.Location = New System.Drawing.Point(1772, 459)
        Me.wall24.Margin = New System.Windows.Forms.Padding(4)
        Me.wall24.Name = "wall24"
        Me.wall24.Size = New System.Drawing.Size(87, 41)
        Me.wall24.TabIndex = 119
        Me.wall24.TabStop = False
        Me.wall24.Tag = "content"
        '
        'door1
        '
        Me.door1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.door1.Location = New System.Drawing.Point(3020, 49)
        Me.door1.Margin = New System.Windows.Forms.Padding(4)
        Me.door1.Name = "door1"
        Me.door1.Size = New System.Drawing.Size(79, 443)
        Me.door1.TabIndex = 118
        Me.door1.TabStop = False
        '
        'door2
        '
        Me.door2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.door2.Location = New System.Drawing.Point(2933, 49)
        Me.door2.Margin = New System.Windows.Forms.Padding(4)
        Me.door2.Name = "door2"
        Me.door2.Size = New System.Drawing.Size(79, 443)
        Me.door2.TabIndex = 116
        Me.door2.TabStop = False
        '
        'instruction
        '
        Me.instruction.BackColor = System.Drawing.Color.Transparent
        Me.instruction.Image = Global.lastGamePlatform.My.Resources.Resources.instruction1
        Me.instruction.Location = New System.Drawing.Point(151, 70)
        Me.instruction.Margin = New System.Windows.Forms.Padding(4)
        Me.instruction.Name = "instruction"
        Me.instruction.Size = New System.Drawing.Size(420, 172)
        Me.instruction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.instruction.TabIndex = 107
        Me.instruction.TabStop = False
        Me.instruction.Tag = "content"
        '
        'boss
        '
        Me.boss.BackColor = System.Drawing.Color.Transparent
        Me.boss.Location = New System.Drawing.Point(3011, 378)
        Me.boss.Margin = New System.Windows.Forms.Padding(4)
        Me.boss.Name = "boss"
        Me.boss.Size = New System.Drawing.Size(173, 117)
        Me.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boss.TabIndex = 90
        Me.boss.TabStop = False
        Me.boss.Tag = "content"
        '
        'wall12
        '
        Me.wall12.BackColor = System.Drawing.Color.Maroon
        Me.wall12.Location = New System.Drawing.Point(927, 418)
        Me.wall12.Margin = New System.Windows.Forms.Padding(4)
        Me.wall12.Name = "wall12"
        Me.wall12.Size = New System.Drawing.Size(87, 86)
        Me.wall12.TabIndex = 17
        Me.wall12.TabStop = False
        Me.wall12.Tag = "content"
        '
        'wall11
        '
        Me.wall11.BackColor = System.Drawing.Color.Maroon
        Me.wall11.Location = New System.Drawing.Point(757, 466)
        Me.wall11.Margin = New System.Windows.Forms.Padding(4)
        Me.wall11.Name = "wall11"
        Me.wall11.Size = New System.Drawing.Size(87, 38)
        Me.wall11.TabIndex = 16
        Me.wall11.TabStop = False
        Me.wall11.Tag = "content"
        '
        'wall9
        '
        Me.wall9.BackColor = System.Drawing.Color.Maroon
        Me.wall9.Location = New System.Drawing.Point(1933, 459)
        Me.wall9.Margin = New System.Windows.Forms.Padding(4)
        Me.wall9.Name = "wall9"
        Me.wall9.Size = New System.Drawing.Size(87, 43)
        Me.wall9.TabIndex = 14
        Me.wall9.TabStop = False
        Me.wall9.Tag = "content"
        '
        'wall7
        '
        Me.wall7.BackColor = System.Drawing.Color.Maroon
        Me.wall7.Location = New System.Drawing.Point(1933, 265)
        Me.wall7.Margin = New System.Windows.Forms.Padding(4)
        Me.wall7.Name = "wall7"
        Me.wall7.Size = New System.Drawing.Size(87, 38)
        Me.wall7.TabIndex = 12
        Me.wall7.TabStop = False
        Me.wall7.Tag = "content"
        '
        'wall6
        '
        Me.wall6.BackColor = System.Drawing.Color.Maroon
        Me.wall6.Location = New System.Drawing.Point(1013, 393)
        Me.wall6.Margin = New System.Windows.Forms.Padding(4)
        Me.wall6.Name = "wall6"
        Me.wall6.Size = New System.Drawing.Size(87, 112)
        Me.wall6.TabIndex = 11
        Me.wall6.TabStop = False
        Me.wall6.Tag = "content"
        '
        'wall5
        '
        Me.wall5.BackColor = System.Drawing.Color.Maroon
        Me.wall5.Location = New System.Drawing.Point(844, 443)
        Me.wall5.Margin = New System.Windows.Forms.Padding(4)
        Me.wall5.Name = "wall5"
        Me.wall5.Size = New System.Drawing.Size(87, 62)
        Me.wall5.TabIndex = 10
        Me.wall5.TabStop = False
        Me.wall5.Tag = "content"
        '
        'wall3
        '
        Me.wall3.BackColor = System.Drawing.Color.Maroon
        Me.wall3.Location = New System.Drawing.Point(2019, 441)
        Me.wall3.Margin = New System.Windows.Forms.Padding(4)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(87, 62)
        Me.wall3.TabIndex = 5
        Me.wall3.TabStop = False
        Me.wall3.Tag = "content"
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.Transparent
        Me.player1.Image = Global.lastGamePlatform.My.Resources.Resources.player1Mov
        Me.player1.Location = New System.Drawing.Point(40, 235)
        Me.player1.Margin = New System.Windows.Forms.Padding(4)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(87, 62)
        Me.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player1.TabIndex = 2
        Me.player1.TabStop = False
        Me.player1.Tag = "content"
        '
        'ground1
        '
        Me.ground1.BackColor = System.Drawing.Color.Maroon
        Me.ground1.Location = New System.Drawing.Point(0, 500)
        Me.ground1.Margin = New System.Windows.Forms.Padding(4)
        Me.ground1.Name = "ground1"
        Me.ground1.Size = New System.Drawing.Size(4224, 62)
        Me.ground1.TabIndex = 0
        Me.ground1.TabStop = False
        Me.ground1.Tag = "content"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(279, 321)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(411, 393)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 62)
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(411, 272)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox3.TabIndex = 124
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(541, 368)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox4.TabIndex = 125
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(645, 245)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox5.TabIndex = 126
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1140, 666)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.supergun0)
        Me.Controls.Add(Me.wall24)
        Me.Controls.Add(Me.door1)
        Me.Controls.Add(Me.door2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.instruction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.boss)
        Me.Controls.Add(Me.extbtn)
        Me.Controls.Add(Me.RestartBtn)
        Me.Controls.Add(Me.winorloseTxt)
        Me.Controls.Add(Me.pScore)
        Me.Controls.Add(Me.pLife)
        Me.Controls.Add(Me.pItem)
        Me.Controls.Add(Me.pName)
        Me.Controls.Add(Me.wall12)
        Me.Controls.Add(Me.wall11)
        Me.Controls.Add(Me.wall9)
        Me.Controls.Add(Me.wall7)
        Me.Controls.Add(Me.wall6)
        Me.Controls.Add(Me.wall5)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.ground1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Tag = "content"
        Me.Text = "Form1"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supergun0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.instruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ground1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents player1 As PictureBox
	Friend WithEvents Timer75ms As Timer
	Friend WithEvents wall3 As PictureBox
	Friend WithEvents wall5 As PictureBox
	Friend WithEvents wall6 As PictureBox
	Friend WithEvents wall7 As PictureBox
	Friend WithEvents wall9 As PictureBox
	Friend WithEvents wall11 As PictureBox
	Friend WithEvents wall12 As PictureBox
	Friend WithEvents pName As Label
	Friend WithEvents pItem As Label
	Friend WithEvents pLife As Label
	Friend WithEvents pScore As Label
	Friend WithEvents winorloseTxt As Label
	Friend WithEvents RestartBtn As Button
	Friend WithEvents extbtn As Button
	Friend WithEvents ground1 As PictureBox
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Label1 As Label
	Friend WithEvents instruction As PictureBox
	Friend WithEvents Label6 As Label
	Friend WithEvents door2 As PictureBox
	Friend WithEvents FastestTimer As Timer
	Friend WithEvents boss As PictureBox
	Friend WithEvents door1 As PictureBox
	Friend WithEvents Timer1000ms As Timer
	Friend WithEvents wall24 As PictureBox
	Friend WithEvents supergun0 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox5 As PictureBox
End Class

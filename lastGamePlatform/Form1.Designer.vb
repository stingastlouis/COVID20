﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.FastestTimer = New System.Windows.Forms.Timer(Me.components)
		Me.Timer1000ms = New System.Windows.Forms.Timer(Me.components)
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
		Me.supergun0 = New System.Windows.Forms.PictureBox()
		Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
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
		CType(Me.supergun0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.pName.Location = New System.Drawing.Point(26, 7)
		Me.pName.Name = "pName"
		Me.pName.Size = New System.Drawing.Size(66, 24)
		Me.pName.TabIndex = 19
		Me.pName.Tag = "stayHere"
		Me.pName.Text = "Johny "
		'
		'pItem
		'
		Me.pItem.AutoSize = True
		Me.pItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pItem.Location = New System.Drawing.Point(249, 10)
		Me.pItem.Name = "pItem"
		Me.pItem.Size = New System.Drawing.Size(60, 24)
		Me.pItem.TabIndex = 20
		Me.pItem.Tag = "stayHere"
		Me.pItem.Text = "Item : "
		'
		'pLife
		'
		Me.pLife.AutoSize = True
		Me.pLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pLife.Location = New System.Drawing.Point(87, 10)
		Me.pLife.Name = "pLife"
		Me.pLife.Size = New System.Drawing.Size(39, 24)
		Me.pLife.TabIndex = 21
		Me.pLife.Tag = "stayHere"
		Me.pLife.Text = "X 3"
		'
		'pScore
		'
		Me.pScore.AutoSize = True
		Me.pScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pScore.Location = New System.Drawing.Point(132, 9)
		Me.pScore.Name = "pScore"
		Me.pScore.Size = New System.Drawing.Size(75, 24)
		Me.pScore.TabIndex = 22
		Me.pScore.Tag = "stayHere"
		Me.pScore.Text = "Score : "
		'
		'winorloseTxt
		'
		Me.winorloseTxt.AutoSize = True
		Me.winorloseTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.winorloseTxt.Location = New System.Drawing.Point(3096, -39)
		Me.winorloseTxt.Name = "winorloseTxt"
		Me.winorloseTxt.Size = New System.Drawing.Size(66, 24)
		Me.winorloseTxt.TabIndex = 37
		Me.winorloseTxt.Text = "Label1"
		Me.winorloseTxt.Visible = False
		'
		'RestartBtn
		'
		Me.RestartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RestartBtn.Location = New System.Drawing.Point(3056, -12)
		Me.RestartBtn.Name = "RestartBtn"
		Me.RestartBtn.Size = New System.Drawing.Size(124, 37)
		Me.RestartBtn.TabIndex = 38
		Me.RestartBtn.Text = "Button1"
		Me.RestartBtn.UseVisualStyleBackColor = True
		Me.RestartBtn.Visible = False
		'
		'extbtn
		'
		Me.extbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.extbtn.Location = New System.Drawing.Point(3056, 31)
		Me.extbtn.Name = "extbtn"
		Me.extbtn.Size = New System.Drawing.Size(124, 37)
		Me.extbtn.TabIndex = 39
		Me.extbtn.Text = "Button1"
		Me.extbtn.UseVisualStyleBackColor = True
		Me.extbtn.Visible = False
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(440, 10)
		Me.ProgressBar1.Maximum = 18
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
		Me.ProgressBar1.TabIndex = 96
		Me.ProgressBar1.Tag = "stayHere"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(362, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(100, 24)
		Me.Label1.TabIndex = 97
		Me.Label1.Tag = "stayHere"
		Me.Label1.Text = "Boss Life : "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(138, 97)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(48, 24)
		Me.Label2.TabIndex = 106
		Me.Label2.Tag = "content"
		Me.Label2.Text = "Use "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(249, 97)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 24)
		Me.Label3.TabIndex = 108
		Me.Label3.Tag = "content"
		Me.Label3.Text = "To move "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(183, 137)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(107, 24)
		Me.Label4.TabIndex = 109
		Me.Label4.Tag = "content"
		Me.Label4.Text = "Q To Shoot"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(144, 160)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(258, 24)
		Me.Label5.TabIndex = 110
		Me.Label5.Tag = "content"
		Me.Label5.Text = """Esc"" To return to main menu"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(434, 261)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(283, 24)
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
		'wall24
		'
		Me.wall24.BackColor = System.Drawing.Color.Maroon
		Me.wall24.Location = New System.Drawing.Point(1329, 373)
		Me.wall24.Name = "wall24"
		Me.wall24.Size = New System.Drawing.Size(65, 33)
		Me.wall24.TabIndex = 119
		Me.wall24.TabStop = False
		Me.wall24.Tag = "content"
		'
		'door1
		'
		Me.door1.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.door1.Location = New System.Drawing.Point(2265, 40)
		Me.door1.Name = "door1"
		Me.door1.Size = New System.Drawing.Size(59, 360)
		Me.door1.TabIndex = 118
		Me.door1.TabStop = False
		'
		'door2
		'
		Me.door2.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.door2.Location = New System.Drawing.Point(2200, 40)
		Me.door2.Name = "door2"
		Me.door2.Size = New System.Drawing.Size(59, 360)
		Me.door2.TabIndex = 116
		Me.door2.TabStop = False
		'
		'instruction
		'
		Me.instruction.BackColor = System.Drawing.Color.Transparent
		Me.instruction.Image = Global.lastGamePlatform.My.Resources.Resources.arrow_keys
		Me.instruction.Location = New System.Drawing.Point(178, 84)
		Me.instruction.Name = "instruction"
		Me.instruction.Size = New System.Drawing.Size(65, 50)
		Me.instruction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.instruction.TabIndex = 107
		Me.instruction.TabStop = False
		Me.instruction.Tag = "content"
		'
		'boss
		'
		Me.boss.BackColor = System.Drawing.Color.Olive
		Me.boss.Location = New System.Drawing.Point(2013, 108)
		Me.boss.Name = "boss"
		Me.boss.Size = New System.Drawing.Size(130, 95)
		Me.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.boss.TabIndex = 90
		Me.boss.TabStop = False
		Me.boss.Tag = "content"
		'
		'wall12
		'
		Me.wall12.BackColor = System.Drawing.Color.Maroon
		Me.wall12.Location = New System.Drawing.Point(695, 340)
		Me.wall12.Name = "wall12"
		Me.wall12.Size = New System.Drawing.Size(65, 70)
		Me.wall12.TabIndex = 17
		Me.wall12.TabStop = False
		Me.wall12.Tag = "content"
		'
		'wall11
		'
		Me.wall11.BackColor = System.Drawing.Color.Maroon
		Me.wall11.Location = New System.Drawing.Point(568, 379)
		Me.wall11.Name = "wall11"
		Me.wall11.Size = New System.Drawing.Size(65, 31)
		Me.wall11.TabIndex = 16
		Me.wall11.TabStop = False
		Me.wall11.Tag = "content"
		'
		'wall9
		'
		Me.wall9.BackColor = System.Drawing.Color.Maroon
		Me.wall9.Location = New System.Drawing.Point(1450, 373)
		Me.wall9.Name = "wall9"
		Me.wall9.Size = New System.Drawing.Size(65, 35)
		Me.wall9.TabIndex = 14
		Me.wall9.TabStop = False
		Me.wall9.Tag = "content"
		'
		'wall7
		'
		Me.wall7.BackColor = System.Drawing.Color.Maroon
		Me.wall7.Location = New System.Drawing.Point(1450, 215)
		Me.wall7.Name = "wall7"
		Me.wall7.Size = New System.Drawing.Size(65, 31)
		Me.wall7.TabIndex = 12
		Me.wall7.TabStop = False
		Me.wall7.Tag = "content"
		'
		'wall6
		'
		Me.wall6.BackColor = System.Drawing.Color.Maroon
		Me.wall6.Location = New System.Drawing.Point(760, 319)
		Me.wall6.Name = "wall6"
		Me.wall6.Size = New System.Drawing.Size(65, 91)
		Me.wall6.TabIndex = 11
		Me.wall6.TabStop = False
		Me.wall6.Tag = "content"
		'
		'wall5
		'
		Me.wall5.BackColor = System.Drawing.Color.Maroon
		Me.wall5.Location = New System.Drawing.Point(633, 360)
		Me.wall5.Name = "wall5"
		Me.wall5.Size = New System.Drawing.Size(65, 50)
		Me.wall5.TabIndex = 10
		Me.wall5.TabStop = False
		Me.wall5.Tag = "content"
		'
		'wall3
		'
		Me.wall3.BackColor = System.Drawing.Color.Maroon
		Me.wall3.Location = New System.Drawing.Point(1514, 358)
		Me.wall3.Name = "wall3"
		Me.wall3.Size = New System.Drawing.Size(65, 50)
		Me.wall3.TabIndex = 5
		Me.wall3.TabStop = False
		Me.wall3.Tag = "content"
		'
		'player1
		'
		Me.player1.BackColor = System.Drawing.Color.Transparent
		Me.player1.Image = Global.lastGamePlatform.My.Resources.Resources.player1Mov
		Me.player1.Location = New System.Drawing.Point(30, 191)
		Me.player1.Name = "player1"
		Me.player1.Size = New System.Drawing.Size(65, 50)
		Me.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.player1.TabIndex = 2
		Me.player1.TabStop = False
		Me.player1.Tag = "content"
		'
		'ground1
		'
		Me.ground1.BackColor = System.Drawing.Color.Maroon
		Me.ground1.Location = New System.Drawing.Point(0, 406)
		Me.ground1.Name = "ground1"
		Me.ground1.Size = New System.Drawing.Size(2259, 50)
		Me.ground1.TabIndex = 0
		Me.ground1.TabStop = False
		Me.ground1.Tag = "content"
		'
		'supergun0
		'
		Me.supergun0.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.supergun0.Location = New System.Drawing.Point(1763, 196)
		Me.supergun0.Name = "supergun0"
		Me.supergun0.Size = New System.Drawing.Size(76, 66)
		Me.supergun0.TabIndex = 120
		Me.supergun0.TabStop = False
		'
		'AxWindowsMediaPlayer1
		'
		Me.AxWindowsMediaPlayer1.Enabled = True
		Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(308, 245)
		Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
		Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1, 1)
		Me.AxWindowsMediaPlayer1.TabIndex = 121
		Me.AxWindowsMediaPlayer1.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(855, 507)
		Me.Controls.Add(Me.AxWindowsMediaPlayer1)
		Me.Controls.Add(Me.supergun0)
		Me.Controls.Add(Me.wall24)
		Me.Controls.Add(Me.door1)
		Me.Controls.Add(Me.door2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.instruction)
		Me.Controls.Add(Me.Label2)
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
		Me.Name = "Form1"
		Me.Tag = "content"
		Me.Text = "Form1"
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
		CType(Me.supergun0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents Label2 As Label
	Friend WithEvents instruction As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents door2 As PictureBox
	Friend WithEvents FastestTimer As Timer
	Friend WithEvents boss As PictureBox
	Friend WithEvents door1 As PictureBox
	Friend WithEvents Timer1000ms As Timer
	Friend WithEvents wall24 As PictureBox
	Friend WithEvents supergun0 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class

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
		Me.Timer75ms = New System.Windows.Forms.Timer(Me.components)
		Me.winorloseTxt = New System.Windows.Forms.Label()
		Me.FastestTimer = New System.Windows.Forms.Timer(Me.components)
		Me.Timer1000ms = New System.Windows.Forms.Timer(Me.components)
		Me.wall24 = New System.Windows.Forms.PictureBox()
		Me.wall12 = New System.Windows.Forms.PictureBox()
		Me.wall11 = New System.Windows.Forms.PictureBox()
		Me.wall9 = New System.Windows.Forms.PictureBox()
		Me.wall7 = New System.Windows.Forms.PictureBox()
		Me.wall6 = New System.Windows.Forms.PictureBox()
		Me.wall5 = New System.Windows.Forms.PictureBox()
		Me.wall3 = New System.Windows.Forms.PictureBox()
		CType(Me.wall24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Timer75ms
		'
		Me.Timer75ms.Enabled = True
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
		Me.wall24.Location = New System.Drawing.Point(1329, 364)
		Me.wall24.Name = "wall24"
		Me.wall24.Size = New System.Drawing.Size(65, 33)
		Me.wall24.TabIndex = 119
		Me.wall24.TabStop = False
		Me.wall24.Tag = "content"
		'
		'wall12
		'
		Me.wall12.BackColor = System.Drawing.Color.Maroon
		Me.wall12.Location = New System.Drawing.Point(695, 331)
		Me.wall12.Name = "wall12"
		Me.wall12.Size = New System.Drawing.Size(65, 70)
		Me.wall12.TabIndex = 17
		Me.wall12.TabStop = False
		Me.wall12.Tag = "content"
		'
		'wall11
		'
		Me.wall11.BackColor = System.Drawing.Color.Maroon
		Me.wall11.Location = New System.Drawing.Point(568, 370)
		Me.wall11.Name = "wall11"
		Me.wall11.Size = New System.Drawing.Size(65, 31)
		Me.wall11.TabIndex = 16
		Me.wall11.TabStop = False
		Me.wall11.Tag = "content"
		'
		'wall9
		'
		Me.wall9.BackColor = System.Drawing.Color.Maroon
		Me.wall9.Location = New System.Drawing.Point(1450, 364)
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
		Me.wall6.Location = New System.Drawing.Point(760, 310)
		Me.wall6.Name = "wall6"
		Me.wall6.Size = New System.Drawing.Size(65, 91)
		Me.wall6.TabIndex = 11
		Me.wall6.TabStop = False
		Me.wall6.Tag = "content"
		'
		'wall5
		'
		Me.wall5.BackColor = System.Drawing.Color.Maroon
		Me.wall5.Location = New System.Drawing.Point(633, 351)
		Me.wall5.Name = "wall5"
		Me.wall5.Size = New System.Drawing.Size(65, 50)
		Me.wall5.TabIndex = 10
		Me.wall5.TabStop = False
		Me.wall5.Tag = "content"
		'
		'wall3
		'
		Me.wall3.BackColor = System.Drawing.Color.Maroon
		Me.wall3.Location = New System.Drawing.Point(1514, 349)
		Me.wall3.Name = "wall3"
		Me.wall3.Size = New System.Drawing.Size(65, 50)
		Me.wall3.TabIndex = 5
		Me.wall3.TabStop = False
		Me.wall3.Tag = "content"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(780, 419)
		Me.Controls.Add(Me.wall11)
		Me.Controls.Add(Me.wall24)
		Me.Controls.Add(Me.winorloseTxt)
		Me.Controls.Add(Me.wall12)
		Me.Controls.Add(Me.wall9)
		Me.Controls.Add(Me.wall7)
		Me.Controls.Add(Me.wall6)
		Me.Controls.Add(Me.wall5)
		Me.Controls.Add(Me.wall3)
		Me.DoubleBuffered = True
		Me.Name = "Form1"
		Me.Tag = "content"
		Me.Text = "Form1"
		CType(Me.wall24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Timer75ms As Timer
    Friend WithEvents wall3 As PictureBox
    Friend WithEvents wall5 As PictureBox
    Friend WithEvents wall6 As PictureBox
    Friend WithEvents wall7 As PictureBox
    Friend WithEvents wall9 As PictureBox
    Friend WithEvents wall11 As PictureBox
    Friend WithEvents wall12 As PictureBox
    Friend WithEvents winorloseTxt As Label
    Friend WithEvents FastestTimer As Timer
    Friend WithEvents Timer1000ms As Timer
    Friend WithEvents wall24 As PictureBox
End Class

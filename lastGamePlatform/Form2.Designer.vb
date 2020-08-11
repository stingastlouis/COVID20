<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.wall1 = New System.Windows.Forms.PictureBox()
		Me.wall2 = New System.Windows.Forms.PictureBox()
		Me.wall3 = New System.Windows.Forms.PictureBox()
		Me.wall5 = New System.Windows.Forms.PictureBox()
		Me.wall4 = New System.Windows.Forms.PictureBox()
		Me.wall6 = New System.Windows.Forms.PictureBox()
		CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wall6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'wall1
		'
		Me.wall1.BackColor = System.Drawing.Color.Blue
		Me.wall1.Location = New System.Drawing.Point(12, 263)
		Me.wall1.Name = "wall1"
		Me.wall1.Size = New System.Drawing.Size(100, 156)
		Me.wall1.TabIndex = 0
		Me.wall1.TabStop = False
		'
		'wall2
		'
		Me.wall2.AccessibleName = "wall"
		Me.wall2.BackColor = System.Drawing.Color.Blue
		Me.wall2.Location = New System.Drawing.Point(208, 360)
		Me.wall2.Name = "wall2"
		Me.wall2.Size = New System.Drawing.Size(100, 59)
		Me.wall2.TabIndex = 1
		Me.wall2.TabStop = False
		'
		'wall3
		'
		Me.wall3.AccessibleName = "wall"
		Me.wall3.BackColor = System.Drawing.Color.Blue
		Me.wall3.Location = New System.Drawing.Point(549, 338)
		Me.wall3.Name = "wall3"
		Me.wall3.Size = New System.Drawing.Size(380, 81)
		Me.wall3.TabIndex = 2
		Me.wall3.TabStop = False
		'
		'wall5
		'
		Me.wall5.AccessibleName = "wall"
		Me.wall5.BackColor = System.Drawing.Color.Blue
		Me.wall5.Location = New System.Drawing.Point(1213, 360)
		Me.wall5.Name = "wall5"
		Me.wall5.Size = New System.Drawing.Size(100, 59)
		Me.wall5.TabIndex = 3
		Me.wall5.TabStop = False
		'
		'wall4
		'
		Me.wall4.AccessibleName = "wall"
		Me.wall4.BackColor = System.Drawing.Color.Blue
		Me.wall4.Location = New System.Drawing.Point(1012, 263)
		Me.wall4.Name = "wall4"
		Me.wall4.Size = New System.Drawing.Size(100, 59)
		Me.wall4.TabIndex = 5
		Me.wall4.TabStop = False
		'
		'wall6
		'
		Me.wall6.AccessibleName = "wall"
		Me.wall6.BackColor = System.Drawing.Color.Blue
		Me.wall6.Location = New System.Drawing.Point(1391, 360)
		Me.wall6.Name = "wall6"
		Me.wall6.Size = New System.Drawing.Size(100, 59)
		Me.wall6.TabIndex = 6
		Me.wall6.TabStop = False
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(780, 419)
		Me.Controls.Add(Me.wall6)
		Me.Controls.Add(Me.wall4)
		Me.Controls.Add(Me.wall5)
		Me.Controls.Add(Me.wall3)
		Me.Controls.Add(Me.wall2)
		Me.Controls.Add(Me.wall1)
		Me.Name = "Form2"
		Me.Text = "Form2"
		CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wall6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents wall1 As PictureBox
	Friend WithEvents wall2 As PictureBox
	Friend WithEvents wall3 As PictureBox
	Friend WithEvents wall5 As PictureBox
	Friend WithEvents wall4 As PictureBox
	Friend WithEvents wall6 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
		Me.ChangingPictureBox = New System.Windows.Forms.PictureBox()
		Me.ChangingLabel = New System.Windows.Forms.Label()
		Me.NextButton = New System.Windows.Forms.Button()
		Me.GameButton = New System.Windows.Forms.Button()
		CType(Me.ChangingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ChangingPictureBox
		'
		Me.ChangingPictureBox.Location = New System.Drawing.Point(12, 118)
		Me.ChangingPictureBox.Name = "ChangingPictureBox"
		Me.ChangingPictureBox.Size = New System.Drawing.Size(505, 280)
		Me.ChangingPictureBox.TabIndex = 0
		Me.ChangingPictureBox.TabStop = False
		'
		'ChangingLabel
		'
		Me.ChangingLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChangingLabel.Location = New System.Drawing.Point(12, 9)
		Me.ChangingLabel.Name = "ChangingLabel"
		Me.ChangingLabel.Size = New System.Drawing.Size(725, 106)
		Me.ChangingLabel.TabIndex = 1
		Me.ChangingLabel.Text = "Label1"
		'
		'NextButton
		'
		Me.NextButton.Location = New System.Drawing.Point(662, 346)
		Me.NextButton.Name = "NextButton"
		Me.NextButton.Size = New System.Drawing.Size(75, 23)
		Me.NextButton.TabIndex = 2
		Me.NextButton.Text = "Next"
		Me.NextButton.UseVisualStyleBackColor = True
		'
		'GameButton
		'
		Me.GameButton.Location = New System.Drawing.Point(662, 375)
		Me.GameButton.Name = "GameButton"
		Me.GameButton.Size = New System.Drawing.Size(75, 23)
		Me.GameButton.TabIndex = 3
		Me.GameButton.Text = "Lunch Game"
		Me.GameButton.UseVisualStyleBackColor = True
		'
		'Intro
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(749, 410)
		Me.Controls.Add(Me.GameButton)
		Me.Controls.Add(Me.NextButton)
		Me.Controls.Add(Me.ChangingLabel)
		Me.Controls.Add(Me.ChangingPictureBox)
		Me.Name = "Intro"
		Me.Text = "Intro"
		CType(Me.ChangingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ChangingPictureBox As PictureBox
	Friend WithEvents ChangingLabel As Label
	Friend WithEvents NextButton As Button
	Friend WithEvents GameButton As Button
End Class

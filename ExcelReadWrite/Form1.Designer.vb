<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ButtonListBox = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.LabelTitle = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.LabelTitle)
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.ButtonListBox)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(585, 270)
		Me.Panel1.TabIndex = 0
		'
		'ButtonListBox
		'
		Me.ButtonListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonListBox.AutoSize = True
		Me.ButtonListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonListBox.Location = New System.Drawing.Point(12, 219)
		Me.ButtonListBox.Name = "ButtonListBox"
		Me.ButtonListBox.Size = New System.Drawing.Size(235, 39)
		Me.ButtonListBox.TabIndex = 0
		Me.ButtonListBox.Text = "View in List Boxes"
		Me.ButtonListBox.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button2.AutoEllipsis = True
		Me.Button2.AutoSize = True
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(335, 219)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(238, 39)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "View in TextBoxes"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'LabelTitle
		'
		Me.LabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelTitle.AutoSize = True
		Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelTitle.Location = New System.Drawing.Point(49, 18)
		Me.LabelTitle.Name = "LabelTitle"
		Me.LabelTitle.Size = New System.Drawing.Size(486, 55)
		Me.LabelTitle.TabIndex = 2
		Me.LabelTitle.Text = "Excel Reader/ Writer"
		Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'FormMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(585, 270)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormMenu"
		Me.Text = "Menu"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelTitle As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents ButtonListBox As Button
End Class

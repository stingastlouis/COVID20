<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExcelWriter
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
		Me.ButtonSelect = New System.Windows.Forms.Button()
		Me.LabelTitle = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.ButtonSelect)
		Me.Panel1.Controls.Add(Me.LabelTitle)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(624, 243)
		Me.Panel1.TabIndex = 0
		'
		'ButtonSelect
		'
		Me.ButtonSelect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonSelect.AutoSize = True
		Me.ButtonSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonSelect.Location = New System.Drawing.Point(191, 160)
		Me.ButtonSelect.Name = "ButtonSelect"
		Me.ButtonSelect.Size = New System.Drawing.Size(243, 39)
		Me.ButtonSelect.TabIndex = 4
		Me.ButtonSelect.Text = "Select 2 .xlsx files."
		Me.ButtonSelect.UseVisualStyleBackColor = True
		'
		'LabelTitle
		'
		Me.LabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelTitle.AutoSize = True
		Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelTitle.Location = New System.Drawing.Point(166, 28)
		Me.LabelTitle.Name = "LabelTitle"
		Me.LabelTitle.Size = New System.Drawing.Size(293, 55)
		Me.LabelTitle.TabIndex = 3
		Me.LabelTitle.Text = "Excel Writer"
		Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'FormExcelWriter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(624, 243)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormExcelWriter"
		Me.Text = "FormExcelWriter"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelTitle As Label
	Friend WithEvents ButtonSelect As Button
End Class

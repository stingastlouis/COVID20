<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExcelReader
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
		Me.LabelTitle = New System.Windows.Forms.Label()
		Me.ButtonTextboxes = New System.Windows.Forms.Button()
		Me.ButtonListBox = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.LabelTitle)
		Me.Panel1.Controls.Add(Me.ButtonTextboxes)
		Me.Panel1.Controls.Add(Me.ButtonListBox)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(585, 270)
		Me.Panel1.TabIndex = 0
		'
		'LabelTitle
		'
		Me.LabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelTitle.AutoSize = True
		Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelTitle.Location = New System.Drawing.Point(130, 18)
		Me.LabelTitle.Name = "LabelTitle"
		Me.LabelTitle.Size = New System.Drawing.Size(325, 55)
		Me.LabelTitle.TabIndex = 2
		Me.LabelTitle.Text = "Excel Reader"
		Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'ButtonTextboxes
		'
		Me.ButtonTextboxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonTextboxes.AutoSize = True
		Me.ButtonTextboxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonTextboxes.Location = New System.Drawing.Point(335, 219)
		Me.ButtonTextboxes.Name = "ButtonTextboxes"
		Me.ButtonTextboxes.Size = New System.Drawing.Size(238, 39)
		Me.ButtonTextboxes.TabIndex = 1
		Me.ButtonTextboxes.Text = "View in TextBoxes"
		Me.ButtonTextboxes.UseVisualStyleBackColor = True
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
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "Excel.xlsx"
		'
		'FormExcelReader
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(585, 270)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormExcelReader"
		Me.Text = "Reader"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelTitle As Label
	Friend WithEvents ButtonTextboxes As Button
	Friend WithEvents ButtonListBox As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

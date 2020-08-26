<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMainMenu
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ButtonWriter = New System.Windows.Forms.Button()
		Me.LabelTitle = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.ButtonWriter)
		Me.Panel1.Controls.Add(Me.LabelTitle)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(588, 294)
		Me.Panel1.TabIndex = 0
		'
		'ButtonWriter
		'
		Me.ButtonWriter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonWriter.AutoSize = True
		Me.ButtonWriter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonWriter.Location = New System.Drawing.Point(54, 203)
		Me.ButtonWriter.Name = "ButtonWriter"
		Me.ButtonWriter.Size = New System.Drawing.Size(480, 39)
		Me.ButtonWriter.TabIndex = 5
		Me.ButtonWriter.Text = "Start Here"
		Me.ButtonWriter.UseVisualStyleBackColor = True
		'
		'LabelTitle
		'
		Me.LabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelTitle.AutoSize = True
		Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelTitle.Location = New System.Drawing.Point(51, 50)
		Me.LabelTitle.Name = "LabelTitle"
		Me.LabelTitle.Size = New System.Drawing.Size(486, 55)
		Me.LabelTitle.TabIndex = 3
		Me.LabelTitle.Text = "Excel Reader/ Writer"
		Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'FormMainMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(588, 294)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormMainMenu"
		Me.Text = "Excel Reader/ Writer Main Menu "
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelTitle As Label
	Friend WithEvents ButtonWriter As Button
End Class

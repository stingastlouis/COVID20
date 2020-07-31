<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListBox
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
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
		Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.VScrollBar1)
		Me.Panel1.Controls.Add(Me.HScrollBar1)
		Me.Panel1.Controls.Add(Me.ListBox1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(817, 448)
		Me.Panel1.TabIndex = 0
		'
		'ListBox1
		'
		Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(0, 0)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(817, 448)
		Me.ListBox1.TabIndex = 2
		'
		'HScrollBar1
		'
		Me.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.HScrollBar1.Location = New System.Drawing.Point(0, 431)
		Me.HScrollBar1.Name = "HScrollBar1"
		Me.HScrollBar1.Size = New System.Drawing.Size(817, 17)
		Me.HScrollBar1.TabIndex = 3
		'
		'VScrollBar1
		'
		Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
		Me.VScrollBar1.Location = New System.Drawing.Point(800, 0)
		Me.VScrollBar1.Name = "VScrollBar1"
		Me.VScrollBar1.Size = New System.Drawing.Size(17, 431)
		Me.VScrollBar1.TabIndex = 4
		'
		'FormListBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(817, 448)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormListBox"
		Me.Text = "FormListBox"
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents VScrollBar1 As VScrollBar
	Friend WithEvents HScrollBar1 As HScrollBar
End Class

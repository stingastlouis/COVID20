<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gridView
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
		Me.dataOpener = New System.Windows.Forms.DataGridView()
		Me.dataName = New System.Windows.Forms.DataGridView()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dataName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dataOpener
		'
		Me.dataOpener.AllowUserToAddRows = False
		Me.dataOpener.AllowUserToDeleteRows = False
		Me.dataOpener.AllowUserToOrderColumns = True
		Me.dataOpener.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dataOpener.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dataOpener.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dataOpener.BackgroundColor = System.Drawing.SystemColors.ButtonFace
		Me.dataOpener.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataOpener.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataOpener.Location = New System.Drawing.Point(27, 133)
		Me.dataOpener.Margin = New System.Windows.Forms.Padding(2)
		Me.dataOpener.Name = "dataOpener"
		Me.dataOpener.ReadOnly = True
		Me.dataOpener.RowHeadersWidth = 51
		Me.dataOpener.RowTemplate.Height = 24
		Me.dataOpener.Size = New System.Drawing.Size(686, 135)
		Me.dataOpener.TabIndex = 0
		'
		'dataName
		'
		Me.dataName.AllowUserToAddRows = False
		Me.dataName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dataName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dataName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dataName.BackgroundColor = System.Drawing.SystemColors.ButtonFace
		Me.dataName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dataName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataName.Enabled = False
		Me.dataName.Location = New System.Drawing.Point(27, 75)
		Me.dataName.Name = "dataName"
		Me.dataName.ReadOnly = True
		Me.dataName.RowHeadersWidth = 51
		Me.dataName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dataName.Size = New System.Drawing.Size(686, 61)
		Me.dataName.TabIndex = 2
		'
		'ComboBox1
		'
		Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Default
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(573, 26)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
		Me.ComboBox1.TabIndex = 4
		Me.ComboBox1.Text = "Select Student Name"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(32, 21)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(270, 26)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Search by student Name : "
		'
		'gridView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(736, 293)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dataOpener)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.dataName)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MaximumSize = New System.Drawing.Size(1504, 332)
		Me.MinimumSize = New System.Drawing.Size(128, 332)
		Me.Name = "gridView"
		Me.Text = "gridView"
		CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dataName, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dataOpener As DataGridView
    Friend WithEvents dataName As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class

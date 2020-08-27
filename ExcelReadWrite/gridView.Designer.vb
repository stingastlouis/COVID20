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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dataOpener
		'
		Me.dataOpener.AllowUserToAddRows = False
		Me.dataOpener.AllowUserToDeleteRows = False
		Me.dataOpener.AllowUserToOrderColumns = True
		Me.dataOpener.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dataOpener.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dataOpener.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataOpener.Location = New System.Drawing.Point(0, 132)
		Me.dataOpener.Margin = New System.Windows.Forms.Padding(2)
		Me.dataOpener.Name = "dataOpener"
		Me.dataOpener.ReadOnly = True
		Me.dataOpener.RowHeadersWidth = 51
		Me.dataOpener.RowTemplate.Height = 24
		Me.dataOpener.Size = New System.Drawing.Size(665, 135)
		Me.dataOpener.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(550, 11)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(104, 28)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Search"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(0, 53)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(665, 82)
		Me.DataGridView1.TabIndex = 2
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(342, 11)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(203, 28)
		Me.TextBox1.TabIndex = 3
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(12, 18)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
		Me.ComboBox1.TabIndex = 4
		'
		'gridView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(665, 327)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.dataOpener)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "gridView"
		Me.Text = "gridView"
		CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dataOpener As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class

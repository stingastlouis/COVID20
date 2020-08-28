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
        Me.dataName = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataName, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dataOpener.Location = New System.Drawing.Point(0, 162)
        Me.dataOpener.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dataOpener.Name = "dataOpener"
        Me.dataOpener.ReadOnly = True
        Me.dataOpener.RowHeadersWidth = 51
        Me.dataOpener.RowTemplate.Height = 24
        Me.dataOpener.Size = New System.Drawing.Size(887, 166)
        Me.dataOpener.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(733, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dataName
        '
        Me.dataName.AllowUserToAddRows = False
        Me.dataName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataName.Location = New System.Drawing.Point(0, 65)
        Me.dataName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataName.Name = "dataName"
        Me.dataName.ReadOnly = True
        Me.dataName.RowHeadersWidth = 51
        Me.dataName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataName.Size = New System.Drawing.Size(887, 101)
        Me.dataName.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(456, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 34)
        Me.TextBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 22)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'gridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 402)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dataName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataOpener)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "gridView"
        Me.Text = "gridView"
        CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataOpener As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dataName As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class

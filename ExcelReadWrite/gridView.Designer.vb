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
        CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dataOpener.Location = New System.Drawing.Point(0, 0)
        Me.dataOpener.Name = "dataOpener"
        Me.dataOpener.ReadOnly = True
        Me.dataOpener.RowHeadersWidth = 51
        Me.dataOpener.RowTemplate.Height = 24
        Me.dataOpener.Size = New System.Drawing.Size(887, 329)
        Me.dataOpener.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 403)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataOpener)
        Me.Name = "gridView"
        Me.Text = "gridView"
        CType(Me.dataOpener, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataOpener As DataGridView
    Friend WithEvents Button1 As Button
End Class

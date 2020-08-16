<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreforSingle
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
        Me.components = New System.ComponentModel.Container()
        Me.you = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Database1DataSet2 = New lastGamePlatform.Database1DataSet2()
        Me.Single_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Single_TableTableAdapter = New lastGamePlatform.Database1DataSet2TableAdapters.single_TableTableAdapter()
        Me.TableAdapterManager = New lastGamePlatform.Database1DataSet2TableAdapters.TableAdapterManager()
        Me.lblGreater = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Single_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'you
        '
        Me.you.AutoSize = True
        Me.you.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.you.Location = New System.Drawing.Point(319, 148)
        Me.you.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.you.Name = "you"
        Me.you.Size = New System.Drawing.Size(17, 28)
        Me.you.TabIndex = 4
        Me.you.Text = " "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Single_TableBindingSource
        '
        Me.Single_TableBindingSource.DataMember = "single_Table"
        Me.Single_TableBindingSource.DataSource = Me.Database1DataSet2
        '
        'Single_TableTableAdapter
        '
        Me.Single_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.single_TableTableAdapter = Me.Single_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = lastGamePlatform.Database1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_TableTableAdapter = Nothing
        '
        'lblGreater
        '
        Me.lblGreater.AutoSize = True
        Me.lblGreater.Location = New System.Drawing.Point(2, 50)
        Me.lblGreater.Name = "lblGreater"
        Me.lblGreater.Size = New System.Drawing.Size(51, 17)
        Me.lblGreater.TabIndex = 5
        Me.lblGreater.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'scoreforSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGreater)
        Me.Controls.Add(Me.you)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scoreforSingle"
        Me.Text = "Your score"
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Single_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents you As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Database1DataSet2 As Database1DataSet2
    Friend WithEvents Single_TableBindingSource As BindingSource
    Friend WithEvents Single_TableTableAdapter As Database1DataSet2TableAdapters.single_TableTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents lblGreater As Label
    Friend WithEvents Label1 As Label
End Class

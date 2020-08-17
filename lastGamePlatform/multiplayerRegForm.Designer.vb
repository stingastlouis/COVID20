<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class multiplayerRegForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(multiplayerRegForm))
		Me.submit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.player1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.player2 = New System.Windows.Forms.TextBox()
		Me.player1Box = New System.Windows.Forms.PictureBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.player2Box = New System.Windows.Forms.PictureBox()
		Me.checkContent = New System.Windows.Forms.Timer(Me.components)
		Me.Database1DataSet = New lastGamePlatform.Database1DataSet()
		Me.User_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.User_TableTableAdapter = New lastGamePlatform.Database1DataSetTableAdapters.User_TableTableAdapter()
		Me.TableAdapterManager = New lastGamePlatform.Database1DataSetTableAdapters.TableAdapterManager()
		Me.User_TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.User_TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
		CType(Me.player1Box, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.player2Box, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.User_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.User_TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.User_TableBindingNavigator.SuspendLayout()
		Me.SuspendLayout()
		'
		'submit
		'
		Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.submit.Location = New System.Drawing.Point(92, 380)
		Me.submit.Name = "submit"
		Me.submit.Size = New System.Drawing.Size(123, 40)
		Me.submit.TabIndex = 0
		Me.submit.Text = "Validate"
		Me.submit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(24, 34)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(244, 25)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Choose Your Character "
		'
		'player1
		'
		Me.player1.Location = New System.Drawing.Point(188, 80)
		Me.player1.Name = "player1"
		Me.player1.Size = New System.Drawing.Size(168, 20)
		Me.player1.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(33, 76)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(149, 24)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "PLayer 1 Name :"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(33, 230)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(149, 24)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "PLayer 2 Name :"
		'
		'player2
		'
		Me.player2.Location = New System.Drawing.Point(188, 235)
		Me.player2.Name = "player2"
		Me.player2.Size = New System.Drawing.Size(168, 20)
		Me.player2.TabIndex = 4
		'
		'player1Box
		'
		Me.player1Box.Location = New System.Drawing.Point(162, 108)
		Me.player1Box.Name = "player1Box"
		Me.player1Box.Size = New System.Drawing.Size(94, 104)
		Me.player1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.player1Box.TabIndex = 6
		Me.player1Box.TabStop = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(33, 108)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(101, 24)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Character :"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(33, 266)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(101, 24)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Character :"
		'
		'player2Box
		'
		Me.player2Box.Location = New System.Drawing.Point(162, 266)
		Me.player2Box.Name = "player2Box"
		Me.player2Box.Size = New System.Drawing.Size(94, 108)
		Me.player2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.player2Box.TabIndex = 8
		Me.player2Box.TabStop = False
		'
		'checkContent
		'
		Me.checkContent.Interval = 10
		'
		'Database1DataSet
		'
		Me.Database1DataSet.DataSetName = "Database1DataSet"
		Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'User_TableBindingSource
		'
		Me.User_TableBindingSource.DataMember = "User_Table"
		Me.User_TableBindingSource.DataSource = Me.Database1DataSet
		'
		'User_TableTableAdapter
		'
		Me.User_TableTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.UpdateOrder = lastGamePlatform.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		Me.TableAdapterManager.User_TableTableAdapter = Me.User_TableTableAdapter
		'
		'User_TableBindingNavigator
		'
		Me.User_TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
		Me.User_TableBindingNavigator.BindingSource = Me.User_TableBindingSource
		Me.User_TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.User_TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.User_TableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.User_TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.User_TableBindingNavigatorSaveItem})
		Me.User_TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
		Me.User_TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.User_TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.User_TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.User_TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.User_TableBindingNavigator.Name = "User_TableBindingNavigator"
		Me.User_TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.User_TableBindingNavigator.Size = New System.Drawing.Size(368, 22)
		Me.User_TableBindingNavigator.TabIndex = 10
		Me.User_TableBindingNavigator.Text = "BindingNavigator1"
		Me.User_TableBindingNavigator.Visible = False
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 19)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
		'
		'User_TableBindingNavigatorSaveItem
		'
		Me.User_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.User_TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("User_TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
		Me.User_TableBindingNavigatorSaveItem.Name = "User_TableBindingNavigatorSaveItem"
		Me.User_TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
		Me.User_TableBindingNavigatorSaveItem.Text = "Save Data"
		'
		'multiplayerRegForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(368, 436)
		Me.Controls.Add(Me.User_TableBindingNavigator)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.player2Box)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.player1Box)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.player2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.player1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.submit)
		Me.Name = "multiplayerRegForm"
		Me.Text = "Register"
		CType(Me.player1Box, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.player2Box, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.User_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.User_TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.User_TableBindingNavigator.ResumeLayout(False)
		Me.User_TableBindingNavigator.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents player1Box As PictureBox
    Public WithEvents player2Box As PictureBox
    Friend WithEvents checkContent As Timer
    Public WithEvents player1 As TextBox
    Public WithEvents player2 As TextBox
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents User_TableBindingSource As BindingSource
    Friend WithEvents User_TableTableAdapter As Database1DataSetTableAdapters.User_TableTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents User_TableBindingNavigatorSaveItem As ToolStripButton
End Class

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
        Me.Button1 = New System.Windows.Forms.Button()
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
        CType(Me.player1Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(92, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Validate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Your Character "
        '
        'player1
        '
        Me.player1.Location = New System.Drawing.Point(162, 82)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(100, 20)
        Me.player1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PLayer 1 Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PLayer 2 Name :"
        '
        'player2
        '
        Me.player2.Location = New System.Drawing.Point(162, 236)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(100, 20)
        Me.player2.TabIndex = 4
        '
        'player1Box
        '
        Me.player1Box.Location = New System.Drawing.Point(162, 108)
        Me.player1Box.Name = "player1Box"
        Me.player1Box.Size = New System.Drawing.Size(83, 72)
        Me.player1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player1Box.TabIndex = 6
        Me.player1Box.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Character :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Character :"
        '
        'player2Box
        '
        Me.player2Box.Location = New System.Drawing.Point(162, 266)
        Me.player2Box.Name = "player2Box"
        Me.player2Box.Size = New System.Drawing.Size(83, 72)
        Me.player2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player2Box.TabIndex = 8
        Me.player2Box.TabStop = False
        '
        'checkContent
        '
        Me.checkContent.Interval = 10
        '
        'multiplayerRegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(309, 432)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.player2Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.player1Box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "multiplayerRegForm"
        Me.Text = "multiplayerRegForm"
        CType(Me.player1Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class startHere
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startHere))
        Me.ButtonSinglePlayerPlay = New System.Windows.Forms.Button()
        Me.ButtonMultiPlayerPlay = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonMultiPlayerScore = New System.Windows.Forms.Button()
        Me.ButtonSinglePlayerScore = New System.Windows.Forms.Button()
        Me.ButtonBonus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSinglePlayerPlay
        '
        Me.ButtonSinglePlayerPlay.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSinglePlayerPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSinglePlayerPlay.Location = New System.Drawing.Point(20, 21)
        Me.ButtonSinglePlayerPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSinglePlayerPlay.Name = "ButtonSinglePlayerPlay"
        Me.ButtonSinglePlayerPlay.Size = New System.Drawing.Size(248, 44)
        Me.ButtonSinglePlayerPlay.TabIndex = 0
        Me.ButtonSinglePlayerPlay.Text = "Play Here"
        Me.ButtonSinglePlayerPlay.UseVisualStyleBackColor = False
        '
        'ButtonMultiPlayerPlay
        '
        Me.ButtonMultiPlayerPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiPlayerPlay.Location = New System.Drawing.Point(20, 28)
        Me.ButtonMultiPlayerPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMultiPlayerPlay.Name = "ButtonMultiPlayerPlay"
        Me.ButtonMultiPlayerPlay.Size = New System.Drawing.Size(248, 44)
        Me.ButtonMultiPlayerPlay.TabIndex = 2
        Me.ButtonMultiPlayerPlay.Text = "Play Here"
        Me.ButtonMultiPlayerPlay.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(148, 329)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(248, 44)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonMultiPlayerScore
        '
        Me.ButtonMultiPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiPlayerScore.Location = New System.Drawing.Point(20, 84)
        Me.ButtonMultiPlayerScore.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMultiPlayerScore.Name = "ButtonMultiPlayerScore"
        Me.ButtonMultiPlayerScore.Size = New System.Drawing.Size(248, 39)
        Me.ButtonMultiPlayerScore.TabIndex = 4
        Me.ButtonMultiPlayerScore.Text = "Score"
        Me.ButtonMultiPlayerScore.UseVisualStyleBackColor = True
        '
        'ButtonSinglePlayerScore
        '
        Me.ButtonSinglePlayerScore.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSinglePlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSinglePlayerScore.Location = New System.Drawing.Point(20, 85)
        Me.ButtonSinglePlayerScore.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSinglePlayerScore.Name = "ButtonSinglePlayerScore"
        Me.ButtonSinglePlayerScore.Size = New System.Drawing.Size(248, 39)
        Me.ButtonSinglePlayerScore.TabIndex = 5
        Me.ButtonSinglePlayerScore.Text = "Score"
        Me.ButtonSinglePlayerScore.UseVisualStyleBackColor = False
        '
        'ButtonBonus
        '
        Me.ButtonBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBonus.Location = New System.Drawing.Point(496, 329)
        Me.ButtonBonus.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBonus.Name = "ButtonBonus"
        Me.ButtonBonus.Size = New System.Drawing.Size(248, 44)
        Me.ButtonBonus.TabIndex = 6
        Me.ButtonBonus.Text = "Bonus"
        Me.ButtonBonus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonMultiPlayerScore)
        Me.Panel1.Controls.Add(Me.ButtonMultiPlayerPlay)
        Me.Panel1.Location = New System.Drawing.Point(563, 177)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 144)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ButtonSinglePlayerPlay)
        Me.Panel2.Controls.Add(Me.ButtonSinglePlayerScore)
        Me.Panel2.Location = New System.Drawing.Point(43, 177)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(289, 144)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.lastGamePlatform.My.Resources.Resources.blackSingle
        Me.PictureBox1.Location = New System.Drawing.Point(19, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.lastGamePlatform.My.Resources.Resources.multi_black
        Me.PictureBox2.Location = New System.Drawing.Point(496, 82)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(381, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.lastGamePlatform.My.Resources.Resources.TITLE_White
        Me.PictureBox3.Location = New System.Drawing.Point(253, 12)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(381, 73)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'startHere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.lastGamePlatform.My.Resources.Resources.bluedegrading
        Me.ClientSize = New System.Drawing.Size(895, 405)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonBonus)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "startHere"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSinglePlayerPlay As Button
    Friend WithEvents ButtonMultiPlayerPlay As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonMultiPlayerScore As Button
    Friend WithEvents ButtonSinglePlayerScore As Button
    Friend WithEvents ButtonBonus As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

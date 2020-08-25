<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bonusForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bonusForm))
        Me.MainMenu = New System.Windows.Forms.Button()
        Me.BonusScenePlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.BonusScenePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Location = New System.Drawing.Point(724, 446)
        Me.MainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(100, 28)
        Me.MainMenu.TabIndex = 4
        Me.MainMenu.Text = "Main Menu"
        Me.MainMenu.UseVisualStyleBackColor = True
        '
        'BonusScenePlayer
        '
        Me.BonusScenePlayer.Enabled = True
        Me.BonusScenePlayer.Location = New System.Drawing.Point(12, 12)
        Me.BonusScenePlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BonusScenePlayer.Name = "BonusScenePlayer"
        Me.BonusScenePlayer.OcxState = CType(resources.GetObject("BonusScenePlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.BonusScenePlayer.Size = New System.Drawing.Size(627, 398)
        Me.BonusScenePlayer.TabIndex = 5
        '
        'bonusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 519)
        Me.Controls.Add(Me.BonusScenePlayer)
        Me.Controls.Add(Me.MainMenu)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "bonusForm"
        Me.Text = "bonusForm"
        CType(Me.BonusScenePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenu As Button
	Friend WithEvents BonusScenePlayer As AxWMPLib.AxWindowsMediaPlayer
End Class

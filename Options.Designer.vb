<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuitToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_aboutUs = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToMainMenuToolStripMenuItem, Me.QuitToDesktopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(274, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitToMainMenuToolStripMenuItem
        '
        Me.QuitToMainMenuToolStripMenuItem.Name = "QuitToMainMenuToolStripMenuItem"
        Me.QuitToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.QuitToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'QuitToDesktopToolStripMenuItem
        '
        Me.QuitToDesktopToolStripMenuItem.Name = "QuitToDesktopToolStripMenuItem"
        Me.QuitToDesktopToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.QuitToDesktopToolStripMenuItem.Text = "Quit to Desktop"
        '
        'btn_aboutUs
        '
        Me.btn_aboutUs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_aboutUs.BackColor = System.Drawing.Color.White
        Me.btn_aboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aboutUs.FlatAppearance.BorderSize = 2
        Me.btn_aboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aboutUs.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btn_aboutUs.Location = New System.Drawing.Point(52, 78)
        Me.btn_aboutUs.Name = "btn_aboutUs"
        Me.btn_aboutUs.Size = New System.Drawing.Size(162, 115)
        Me.btn_aboutUs.TabIndex = 14
        Me.btn_aboutUs.Text = "About Us"
        Me.btn_aboutUs.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(274, 251)
        Me.Controls.Add(Me.btn_aboutUs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuitToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_aboutUs As Button
End Class

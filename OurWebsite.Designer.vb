<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OurWebsite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OurWebsite))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuitToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BackToOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToMainMenuToolStripMenuItem, Me.QuitToDesktopToolStripMenuItem, Me.BackToOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitToMainMenuToolStripMenuItem
        '
        Me.QuitToMainMenuToolStripMenuItem.Name = "QuitToMainMenuToolStripMenuItem"
        Me.QuitToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.QuitToMainMenuToolStripMenuItem.Text = "Quit to Main Menu"
        '
        'QuitToDesktopToolStripMenuItem
        '
        Me.QuitToDesktopToolStripMenuItem.Name = "QuitToDesktopToolStripMenuItem"
        Me.QuitToDesktopToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.QuitToDesktopToolStripMenuItem.Text = "Quit to Desktop"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 24)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(861, 538)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Url = New System.Uri("https://www.google.com/search?q=google&rlz=1C1CHBF_en-GBAU895AU895&oq=google&aqs=" &
        "chrome.0.69i59j35i39j69i59j0l3j69i60j69i65.1145j0j7&sourceid=chrome&ie=UTF-8", System.UriKind.Absolute)
        '
        'BackToOptionsToolStripMenuItem
        '
        Me.BackToOptionsToolStripMenuItem.Name = "BackToOptionsToolStripMenuItem"
        Me.BackToOptionsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.BackToOptionsToolStripMenuItem.Text = "Back to Options"
        '
        'OurWebsite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(861, 562)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OurWebsite"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OurWebsite"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuitToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BackToOptionsToolStripMenuItem As ToolStripMenuItem
End Class

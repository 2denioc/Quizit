<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectionScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuitToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_CreateCueCards = New System.Windows.Forms.Button()
        Me.btn_StartQuiz = New System.Windows.Forms.Button()
        Me.btn_StartPopupQuiz = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToMainMenuToolStripMenuItem, Me.QuitToDesktopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'btn_CreateCueCards
        '
        Me.btn_CreateCueCards.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_CreateCueCards.BackColor = System.Drawing.Color.White
        Me.btn_CreateCueCards.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CreateCueCards.FlatAppearance.BorderSize = 2
        Me.btn_CreateCueCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CreateCueCards.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btn_CreateCueCards.Location = New System.Drawing.Point(86, 56)
        Me.btn_CreateCueCards.Name = "btn_CreateCueCards"
        Me.btn_CreateCueCards.Size = New System.Drawing.Size(365, 119)
        Me.btn_CreateCueCards.TabIndex = 13
        Me.btn_CreateCueCards.Text = "Create Cue Cards"
        Me.btn_CreateCueCards.UseVisualStyleBackColor = False
        '
        'btn_StartQuiz
        '
        Me.btn_StartQuiz.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_StartQuiz.BackColor = System.Drawing.Color.White
        Me.btn_StartQuiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_StartQuiz.FlatAppearance.BorderSize = 2
        Me.btn_StartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_StartQuiz.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btn_StartQuiz.Location = New System.Drawing.Point(110, 191)
        Me.btn_StartQuiz.Name = "btn_StartQuiz"
        Me.btn_StartQuiz.Size = New System.Drawing.Size(309, 92)
        Me.btn_StartQuiz.TabIndex = 14
        Me.btn_StartQuiz.Text = "Start Quiz"
        Me.btn_StartQuiz.UseVisualStyleBackColor = False
        '
        'btn_StartPopupQuiz
        '
        Me.btn_StartPopupQuiz.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_StartPopupQuiz.BackColor = System.Drawing.Color.White
        Me.btn_StartPopupQuiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_StartPopupQuiz.FlatAppearance.BorderSize = 2
        Me.btn_StartPopupQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_StartPopupQuiz.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btn_StartPopupQuiz.Location = New System.Drawing.Point(110, 289)
        Me.btn_StartPopupQuiz.Name = "btn_StartPopupQuiz"
        Me.btn_StartPopupQuiz.Size = New System.Drawing.Size(309, 92)
        Me.btn_StartPopupQuiz.TabIndex = 15
        Me.btn_StartPopupQuiz.Text = "Start Popup Quiz"
        Me.btn_StartPopupQuiz.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_StartPopupQuiz)
        Me.GroupBox1.Controls.Add(Me.btn_CreateCueCards)
        Me.GroupBox1.Controls.Add(Me.btn_StartQuiz)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 411)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'SelectionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(572, 489)
        Me.MinimumSize = New System.Drawing.Size(572, 489)
        Me.Name = "SelectionScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectionScreen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuitToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_CreateCueCards As Button
    Friend WithEvents btn_StartQuiz As Button
    Friend WithEvents btn_StartPopupQuiz As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class

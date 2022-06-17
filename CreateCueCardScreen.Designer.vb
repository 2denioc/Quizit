<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateCueCardScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateCueCardScreen))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.QuitToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToSelectionScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_BackHeader = New System.Windows.Forms.Label()
        Me.lbl_Back = New System.Windows.Forms.Label()
        Me.grp_CardBack = New System.Windows.Forms.GroupBox()
        Me.lbl_FrontHeaderText = New System.Windows.Forms.Label()
        Me.lbl_FrontText = New System.Windows.Forms.Label()
        Me.grp_CardFront = New System.Windows.Forms.GroupBox()
        Me.lbl_Front = New System.Windows.Forms.Label()
        Me.lbl_FrontHeader = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.History = New System.Windows.Forms.TabPage()
        Me.Computing = New System.Windows.Forms.TabPage()
        Me.Science = New System.Windows.Forms.TabPage()
        Me.Geography = New System.Windows.Forms.TabPage()
        Me.tab_ControlMenu5 = New System.Windows.Forms.TabControl()
        Me.Mathematics = New System.Windows.Forms.TabPage()
        Me.English = New System.Windows.Forms.TabPage()
        Me.UserCreateCueCard1 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard2 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard7 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard8 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard9 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard10 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard3 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard4 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard5 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.UserCreateCueCard6 = New Quizit_Dom_Luca_Peter.UserCreateCueCard()
        Me.MenuStrip.SuspendLayout()
        Me.grp_CardBack.SuspendLayout()
        Me.grp_CardFront.SuspendLayout()
        Me.History.SuspendLayout()
        Me.Computing.SuspendLayout()
        Me.Science.SuspendLayout()
        Me.Geography.SuspendLayout()
        Me.tab_ControlMenu5.SuspendLayout()
        Me.Mathematics.SuspendLayout()
        Me.English.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToMainMenuToolStripMenuItem, Me.QuitToDesktopToolStripMenuItem, Me.BackToSelectionScreenToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MaximumSize = New System.Drawing.Size(818, 24)
        Me.MenuStrip.MinimumSize = New System.Drawing.Size(818, 24)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(818, 24)
        Me.MenuStrip.TabIndex = 10
        Me.MenuStrip.Text = "MenuStrip1"
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
        'BackToSelectionScreenToolStripMenuItem
        '
        Me.BackToSelectionScreenToolStripMenuItem.Name = "BackToSelectionScreenToolStripMenuItem"
        Me.BackToSelectionScreenToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.BackToSelectionScreenToolStripMenuItem.Text = "Back to Selection Screen"
        '
        'lbl_BackHeader
        '
        Me.lbl_BackHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BackHeader.Location = New System.Drawing.Point(6, 16)
        Me.lbl_BackHeader.Name = "lbl_BackHeader"
        Me.lbl_BackHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_BackHeader.Size = New System.Drawing.Size(358, 41)
        Me.lbl_BackHeader.TabIndex = 16
        Me.lbl_BackHeader.Text = "Back Header"
        '
        'lbl_Back
        '
        Me.lbl_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Back.Location = New System.Drawing.Point(12, 57)
        Me.lbl_Back.Name = "lbl_Back"
        Me.lbl_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Back.Size = New System.Drawing.Size(277, 136)
        Me.lbl_Back.TabIndex = 17
        Me.lbl_Back.Text = "Back Text"
        '
        'grp_CardBack
        '
        Me.grp_CardBack.Controls.Add(Me.lbl_FrontHeaderText)
        Me.grp_CardBack.Controls.Add(Me.lbl_Back)
        Me.grp_CardBack.Controls.Add(Me.lbl_FrontText)
        Me.grp_CardBack.Controls.Add(Me.lbl_BackHeader)
        Me.grp_CardBack.Location = New System.Drawing.Point(431, 274)
        Me.grp_CardBack.Name = "grp_CardBack"
        Me.grp_CardBack.Size = New System.Drawing.Size(370, 196)
        Me.grp_CardBack.TabIndex = 17
        Me.grp_CardBack.TabStop = False
        Me.grp_CardBack.Visible = False
        '
        'lbl_FrontHeaderText
        '
        Me.lbl_FrontHeaderText.AutoSize = True
        Me.lbl_FrontHeaderText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FrontHeaderText.Location = New System.Drawing.Point(88, -187)
        Me.lbl_FrontHeaderText.Name = "lbl_FrontHeaderText"
        Me.lbl_FrontHeaderText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_FrontHeaderText.Size = New System.Drawing.Size(186, 31)
        Me.lbl_FrontHeaderText.TabIndex = 12
        Me.lbl_FrontHeaderText.Text = "Front Header"
        Me.lbl_FrontHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_FrontText
        '
        Me.lbl_FrontText.AutoSize = True
        Me.lbl_FrontText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FrontText.Location = New System.Drawing.Point(125, -156)
        Me.lbl_FrontText.Name = "lbl_FrontText"
        Me.lbl_FrontText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_FrontText.Size = New System.Drawing.Size(101, 25)
        Me.lbl_FrontText.TabIndex = 14
        Me.lbl_FrontText.Text = "Front Text"
        Me.lbl_FrontText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_CardFront
        '
        Me.grp_CardFront.Controls.Add(Me.lbl_Front)
        Me.grp_CardFront.Controls.Add(Me.lbl_FrontHeader)
        Me.grp_CardFront.Location = New System.Drawing.Point(431, 72)
        Me.grp_CardFront.Name = "grp_CardFront"
        Me.grp_CardFront.Size = New System.Drawing.Size(370, 196)
        Me.grp_CardFront.TabIndex = 16
        Me.grp_CardFront.TabStop = False
        Me.grp_CardFront.Visible = False
        '
        'lbl_Front
        '
        Me.lbl_Front.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Front.Location = New System.Drawing.Point(12, 57)
        Me.lbl_Front.Name = "lbl_Front"
        Me.lbl_Front.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Front.Size = New System.Drawing.Size(271, 136)
        Me.lbl_Front.TabIndex = 19
        Me.lbl_Front.Text = "Front Text"
        '
        'lbl_FrontHeader
        '
        Me.lbl_FrontHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FrontHeader.Location = New System.Drawing.Point(6, 16)
        Me.lbl_FrontHeader.Name = "lbl_FrontHeader"
        Me.lbl_FrontHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_FrontHeader.Size = New System.Drawing.Size(358, 41)
        Me.lbl_FrontHeader.TabIndex = 18
        Me.lbl_FrontHeader.Text = "Front Header"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'History
        '
        Me.History.Controls.Add(Me.UserCreateCueCard10)
        Me.History.Location = New System.Drawing.Point(4, 22)
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(406, 410)
        Me.History.TabIndex = 5
        Me.History.Text = "History"
        Me.History.UseVisualStyleBackColor = True
        '
        'Computing
        '
        Me.Computing.Controls.Add(Me.UserCreateCueCard9)
        Me.Computing.Location = New System.Drawing.Point(4, 22)
        Me.Computing.Name = "Computing"
        Me.Computing.Size = New System.Drawing.Size(406, 410)
        Me.Computing.TabIndex = 4
        Me.Computing.Text = "Computing"
        Me.Computing.UseVisualStyleBackColor = True
        '
        'Science
        '
        Me.Science.Controls.Add(Me.UserCreateCueCard8)
        Me.Science.Location = New System.Drawing.Point(4, 22)
        Me.Science.Name = "Science"
        Me.Science.Size = New System.Drawing.Size(406, 410)
        Me.Science.TabIndex = 3
        Me.Science.Text = "Science"
        Me.Science.UseVisualStyleBackColor = True
        '
        'Geography
        '
        Me.Geography.Controls.Add(Me.UserCreateCueCard7)
        Me.Geography.Location = New System.Drawing.Point(4, 22)
        Me.Geography.Name = "Geography"
        Me.Geography.Size = New System.Drawing.Size(406, 410)
        Me.Geography.TabIndex = 2
        Me.Geography.Text = "Geography"
        Me.Geography.UseVisualStyleBackColor = True
        '
        'tab_ControlMenu5
        '
        Me.tab_ControlMenu5.Controls.Add(Me.Mathematics)
        Me.tab_ControlMenu5.Controls.Add(Me.English)
        Me.tab_ControlMenu5.Controls.Add(Me.Geography)
        Me.tab_ControlMenu5.Controls.Add(Me.Science)
        Me.tab_ControlMenu5.Controls.Add(Me.Computing)
        Me.tab_ControlMenu5.Controls.Add(Me.History)
        Me.tab_ControlMenu5.Location = New System.Drawing.Point(11, 44)
        Me.tab_ControlMenu5.Name = "tab_ControlMenu5"
        Me.tab_ControlMenu5.SelectedIndex = 0
        Me.tab_ControlMenu5.Size = New System.Drawing.Size(414, 436)
        Me.tab_ControlMenu5.TabIndex = 0
        '
        'Mathematics
        '
        Me.Mathematics.Controls.Add(Me.UserCreateCueCard1)
        Me.Mathematics.Location = New System.Drawing.Point(4, 22)
        Me.Mathematics.Name = "Mathematics"
        Me.Mathematics.Padding = New System.Windows.Forms.Padding(3)
        Me.Mathematics.Size = New System.Drawing.Size(406, 410)
        Me.Mathematics.TabIndex = 0
        Me.Mathematics.Text = "Mathematics"
        Me.Mathematics.UseVisualStyleBackColor = True
        '
        'English
        '
        Me.English.Controls.Add(Me.UserCreateCueCard2)
        Me.English.Location = New System.Drawing.Point(4, 22)
        Me.English.Name = "English"
        Me.English.Padding = New System.Windows.Forms.Padding(3)
        Me.English.Size = New System.Drawing.Size(406, 410)
        Me.English.TabIndex = 1
        Me.English.Text = "English"
        Me.English.UseVisualStyleBackColor = True
        '
        'UserCreateCueCard1
        '
        Me.UserCreateCueCard1.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard1.Name = "UserCreateCueCard1"
        Me.UserCreateCueCard1.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard1.TabIndex = 3
        '
        'UserCreateCueCard2
        '
        Me.UserCreateCueCard2.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard2.Name = "UserCreateCueCard2"
        Me.UserCreateCueCard2.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard2.TabIndex = 2
        '
        'UserCreateCueCard7
        '
        Me.UserCreateCueCard7.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard7.Name = "UserCreateCueCard7"
        Me.UserCreateCueCard7.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard7.TabIndex = 3
        '
        'UserCreateCueCard8
        '
        Me.UserCreateCueCard8.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard8.Name = "UserCreateCueCard8"
        Me.UserCreateCueCard8.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard8.TabIndex = 3
        '
        'UserCreateCueCard9
        '
        Me.UserCreateCueCard9.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard9.Name = "UserCreateCueCard9"
        Me.UserCreateCueCard9.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard9.TabIndex = 3
        '
        'UserCreateCueCard10
        '
        Me.UserCreateCueCard10.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard10.Name = "UserCreateCueCard10"
        Me.UserCreateCueCard10.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard10.TabIndex = 3
        '
        'UserCreateCueCard3
        '
        Me.UserCreateCueCard3.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard3.Name = "UserCreateCueCard3"
        Me.UserCreateCueCard3.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard3.TabIndex = 2
        '
        'UserCreateCueCard4
        '
        Me.UserCreateCueCard4.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard4.Name = "UserCreateCueCard4"
        Me.UserCreateCueCard4.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard4.TabIndex = 2
        '
        'UserCreateCueCard5
        '
        Me.UserCreateCueCard5.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard5.Name = "UserCreateCueCard5"
        Me.UserCreateCueCard5.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard5.TabIndex = 2
        '
        'UserCreateCueCard6
        '
        Me.UserCreateCueCard6.Location = New System.Drawing.Point(5, 6)
        Me.UserCreateCueCard6.Name = "UserCreateCueCard6"
        Me.UserCreateCueCard6.Size = New System.Drawing.Size(397, 399)
        Me.UserCreateCueCard6.TabIndex = 2
        '
        'CreateCueCardScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(818, 489)
        Me.Controls.Add(Me.grp_CardBack)
        Me.Controls.Add(Me.grp_CardFront)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.tab_ControlMenu5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateCueCardScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateCueCardScreen"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.grp_CardBack.ResumeLayout(False)
        Me.grp_CardBack.PerformLayout()
        Me.grp_CardFront.ResumeLayout(False)
        Me.History.ResumeLayout(False)
        Me.Computing.ResumeLayout(False)
        Me.Science.ResumeLayout(False)
        Me.Geography.ResumeLayout(False)
        Me.tab_ControlMenu5.ResumeLayout(False)
        Me.Mathematics.ResumeLayout(False)
        Me.English.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents QuitToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToSelectionScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_BackHeader As Label
    Friend WithEvents lbl_Back As Label
    Friend WithEvents grp_CardBack As GroupBox
    Friend WithEvents lbl_FrontText As Label
    Friend WithEvents lbl_FrontHeaderText As Label
    Friend WithEvents grp_CardFront As GroupBox
    Friend WithEvents Timer1 As Timer
    Public WithEvents History As TabPage
    Public WithEvents Computing As TabPage
    Public WithEvents Science As TabPage
    Public WithEvents Geography As TabPage
    Public WithEvents English As TabPage
    Public WithEvents Mathematics As TabPage
    Friend WithEvents lbl_Front As Label
    Friend WithEvents lbl_FrontHeader As Label
    Public WithEvents UserCreateCueCard6 As UserCreateCueCard
    Public WithEvents UserCreateCueCard5 As UserCreateCueCard
    Public WithEvents UserCreateCueCard4 As UserCreateCueCard
    Public WithEvents UserCreateCueCard3 As UserCreateCueCard
    Public WithEvents UserCreateCueCard2 As UserCreateCueCard
    Public WithEvents UserCreateCueCard1 As UserCreateCueCard
    Public WithEvents tab_ControlMenu5 As TabControl
    Public WithEvents UserCreateCueCard10 As UserCreateCueCard
    Public WithEvents UserCreateCueCard9 As UserCreateCueCard
    Public WithEvents UserCreateCueCard8 As UserCreateCueCard
    Public WithEvents UserCreateCueCard7 As UserCreateCueCard
End Class

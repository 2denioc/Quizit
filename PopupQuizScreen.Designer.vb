<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopupQuizScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupQuizScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_StartQuiz = New System.Windows.Forms.Button()
        Me.grp_Categories = New System.Windows.Forms.GroupBox()
        Me.cbx_History = New System.Windows.Forms.CheckBox()
        Me.cbx_Computing = New System.Windows.Forms.CheckBox()
        Me.cbx_Science = New System.Windows.Forms.CheckBox()
        Me.cbx_Geography = New System.Windows.Forms.CheckBox()
        Me.cbx_ = New System.Windows.Forms.CheckBox()
        Me.cbx_Mathematics = New System.Windows.Forms.CheckBox()
        Me.grp_TimeIntervals = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Randomness = New System.Windows.Forms.TextBox()
        Me.cbx_Randomness = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Interval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_Other = New System.Windows.Forms.GroupBox()
        Me.cbx_AllowSkip = New System.Windows.Forms.CheckBox()
        Me.cbx_Repeat = New System.Windows.Forms.CheckBox()
        Me.cbx_Feedback = New System.Windows.Forms.CheckBox()
        Me.cbx_Sound = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grp_Categories.SuspendLayout()
        Me.grp_TimeIntervals.SuspendLayout()
        Me.grp_Other.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem, Me.QuitToDesktopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'QuitToDesktopToolStripMenuItem
        '
        Me.QuitToDesktopToolStripMenuItem.Name = "QuitToDesktopToolStripMenuItem"
        Me.QuitToDesktopToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.QuitToDesktopToolStripMenuItem.Text = "Quit to Desktop"
        '
        'btn_StartQuiz
        '
        Me.btn_StartQuiz.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_StartQuiz.Location = New System.Drawing.Point(148, 228)
        Me.btn_StartQuiz.Name = "btn_StartQuiz"
        Me.btn_StartQuiz.Size = New System.Drawing.Size(189, 61)
        Me.btn_StartQuiz.TabIndex = 1
        Me.btn_StartQuiz.Text = "Start"
        Me.btn_StartQuiz.UseVisualStyleBackColor = True
        '
        'grp_Categories
        '
        Me.grp_Categories.Controls.Add(Me.cbx_History)
        Me.grp_Categories.Controls.Add(Me.cbx_Computing)
        Me.grp_Categories.Controls.Add(Me.cbx_Science)
        Me.grp_Categories.Controls.Add(Me.cbx_Geography)
        Me.grp_Categories.Controls.Add(Me.cbx_)
        Me.grp_Categories.Controls.Add(Me.cbx_Mathematics)
        Me.grp_Categories.Location = New System.Drawing.Point(12, 27)
        Me.grp_Categories.Name = "grp_Categories"
        Me.grp_Categories.Size = New System.Drawing.Size(145, 195)
        Me.grp_Categories.TabIndex = 2
        Me.grp_Categories.TabStop = False
        Me.grp_Categories.Text = "Choose Categories"
        '
        'cbx_History
        '
        Me.cbx_History.AutoSize = True
        Me.cbx_History.Location = New System.Drawing.Point(6, 134)
        Me.cbx_History.Name = "cbx_History"
        Me.cbx_History.Size = New System.Drawing.Size(58, 17)
        Me.cbx_History.TabIndex = 11
        Me.cbx_History.Text = "History"
        Me.cbx_History.UseVisualStyleBackColor = True
        '
        'cbx_Computing
        '
        Me.cbx_Computing.AutoSize = True
        Me.cbx_Computing.Location = New System.Drawing.Point(6, 111)
        Me.cbx_Computing.Name = "cbx_Computing"
        Me.cbx_Computing.Size = New System.Drawing.Size(76, 17)
        Me.cbx_Computing.TabIndex = 10
        Me.cbx_Computing.Text = "Computing"
        Me.cbx_Computing.UseVisualStyleBackColor = True
        '
        'cbx_Science
        '
        Me.cbx_Science.AutoSize = True
        Me.cbx_Science.Location = New System.Drawing.Point(6, 88)
        Me.cbx_Science.Name = "cbx_Science"
        Me.cbx_Science.Size = New System.Drawing.Size(65, 17)
        Me.cbx_Science.TabIndex = 9
        Me.cbx_Science.Text = "Science"
        Me.cbx_Science.UseVisualStyleBackColor = True
        '
        'cbx_Geography
        '
        Me.cbx_Geography.AutoSize = True
        Me.cbx_Geography.Location = New System.Drawing.Point(6, 65)
        Me.cbx_Geography.Name = "cbx_Geography"
        Me.cbx_Geography.Size = New System.Drawing.Size(78, 17)
        Me.cbx_Geography.TabIndex = 8
        Me.cbx_Geography.Text = "Geography"
        Me.cbx_Geography.UseVisualStyleBackColor = True
        '
        'cbx_
        '
        Me.cbx_.AutoSize = True
        Me.cbx_.Location = New System.Drawing.Point(6, 42)
        Me.cbx_.Name = "cbx_"
        Me.cbx_.Size = New System.Drawing.Size(60, 17)
        Me.cbx_.TabIndex = 7
        Me.cbx_.Text = "English"
        Me.cbx_.UseVisualStyleBackColor = True
        '
        'cbx_Mathematics
        '
        Me.cbx_Mathematics.AutoSize = True
        Me.cbx_Mathematics.Location = New System.Drawing.Point(6, 19)
        Me.cbx_Mathematics.Name = "cbx_Mathematics"
        Me.cbx_Mathematics.Size = New System.Drawing.Size(86, 17)
        Me.cbx_Mathematics.TabIndex = 6
        Me.cbx_Mathematics.Text = "Mathematics"
        Me.cbx_Mathematics.UseVisualStyleBackColor = True
        '
        'grp_TimeIntervals
        '
        Me.grp_TimeIntervals.Controls.Add(Me.Label5)
        Me.grp_TimeIntervals.Controls.Add(Me.Label4)
        Me.grp_TimeIntervals.Controls.Add(Me.Label3)
        Me.grp_TimeIntervals.Controls.Add(Me.lbl_Randomness)
        Me.grp_TimeIntervals.Controls.Add(Me.cbx_Randomness)
        Me.grp_TimeIntervals.Controls.Add(Me.Label2)
        Me.grp_TimeIntervals.Controls.Add(Me.lbl_Interval)
        Me.grp_TimeIntervals.Controls.Add(Me.Label1)
        Me.grp_TimeIntervals.Location = New System.Drawing.Point(169, 27)
        Me.grp_TimeIntervals.Name = "grp_TimeIntervals"
        Me.grp_TimeIntervals.Size = New System.Drawing.Size(145, 195)
        Me.grp_TimeIntervals.TabIndex = 6
        Me.grp_TimeIntervals.TabStop = False
        Me.grp_TimeIntervals.Text = "Interval Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "each interval."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "minutes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "+/- up to"
        '
        'lbl_Randomness
        '
        Me.lbl_Randomness.Enabled = False
        Me.lbl_Randomness.Location = New System.Drawing.Point(54, 92)
        Me.lbl_Randomness.MaxLength = 2
        Me.lbl_Randomness.Name = "lbl_Randomness"
        Me.lbl_Randomness.Size = New System.Drawing.Size(44, 20)
        Me.lbl_Randomness.TabIndex = 4
        '
        'cbx_Randomness
        '
        Me.cbx_Randomness.AutoSize = True
        Me.cbx_Randomness.Location = New System.Drawing.Point(7, 75)
        Me.cbx_Randomness.Name = "cbx_Randomness"
        Me.cbx_Randomness.Size = New System.Drawing.Size(110, 17)
        Me.cbx_Randomness.TabIndex = 3
        Me.cbx_Randomness.Text = "Add Randomness"
        Me.cbx_Randomness.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "minutes"
        '
        'lbl_Interval
        '
        Me.lbl_Interval.Location = New System.Drawing.Point(7, 39)
        Me.lbl_Interval.MaxLength = 2
        Me.lbl_Interval.Name = "lbl_Interval"
        Me.lbl_Interval.Size = New System.Drawing.Size(44, 20)
        Me.lbl_Interval.TabIndex = 1
        Me.lbl_Interval.Text = "5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Interval Between Questions"
        '
        'grp_Other
        '
        Me.grp_Other.Controls.Add(Me.cbx_AllowSkip)
        Me.grp_Other.Controls.Add(Me.cbx_Repeat)
        Me.grp_Other.Controls.Add(Me.cbx_Feedback)
        Me.grp_Other.Controls.Add(Me.cbx_Sound)
        Me.grp_Other.Location = New System.Drawing.Point(326, 27)
        Me.grp_Other.Name = "grp_Other"
        Me.grp_Other.Size = New System.Drawing.Size(145, 195)
        Me.grp_Other.TabIndex = 6
        Me.grp_Other.TabStop = False
        Me.grp_Other.Text = "Other"
        '
        'cbx_AllowSkip
        '
        Me.cbx_AllowSkip.AutoSize = True
        Me.cbx_AllowSkip.Location = New System.Drawing.Point(6, 91)
        Me.cbx_AllowSkip.Name = "cbx_AllowSkip"
        Me.cbx_AllowSkip.Size = New System.Drawing.Size(125, 17)
        Me.cbx_AllowSkip.TabIndex = 3
        Me.cbx_AllowSkip.Text = "Allow Skip Questions"
        Me.cbx_AllowSkip.UseVisualStyleBackColor = True
        '
        'cbx_Repeat
        '
        Me.cbx_Repeat.AutoSize = True
        Me.cbx_Repeat.Location = New System.Drawing.Point(6, 68)
        Me.cbx_Repeat.Name = "cbx_Repeat"
        Me.cbx_Repeat.Size = New System.Drawing.Size(111, 17)
        Me.cbx_Repeat.TabIndex = 2
        Me.cbx_Repeat.Text = "Repeat Questions"
        Me.cbx_Repeat.UseVisualStyleBackColor = True
        '
        'cbx_Feedback
        '
        Me.cbx_Feedback.AutoSize = True
        Me.cbx_Feedback.Location = New System.Drawing.Point(6, 45)
        Me.cbx_Feedback.Name = "cbx_Feedback"
        Me.cbx_Feedback.Size = New System.Drawing.Size(74, 17)
        Me.cbx_Feedback.TabIndex = 1
        Me.cbx_Feedback.Text = "Feedback"
        Me.cbx_Feedback.UseVisualStyleBackColor = True
        '
        'cbx_Sound
        '
        Me.cbx_Sound.AutoSize = True
        Me.cbx_Sound.Location = New System.Drawing.Point(6, 21)
        Me.cbx_Sound.Name = "cbx_Sound"
        Me.cbx_Sound.Size = New System.Drawing.Size(92, 17)
        Me.cbx_Sound.TabIndex = 0
        Me.cbx_Sound.Text = "Sound effects"
        Me.cbx_Sound.UseVisualStyleBackColor = True
        '
        'PopupQuizScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(483, 301)
        Me.Controls.Add(Me.grp_Other)
        Me.Controls.Add(Me.grp_TimeIntervals)
        Me.Controls.Add(Me.grp_Categories)
        Me.Controls.Add(Me.btn_StartQuiz)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PopupQuizScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PopupQuizScreen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grp_Categories.ResumeLayout(False)
        Me.grp_Categories.PerformLayout()
        Me.grp_TimeIntervals.ResumeLayout(False)
        Me.grp_TimeIntervals.PerformLayout()
        Me.grp_Other.ResumeLayout(False)
        Me.grp_Other.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_StartQuiz As Button
    Friend WithEvents grp_Categories As GroupBox
    Friend WithEvents grp_TimeIntervals As GroupBox
    Friend WithEvents grp_Other As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_Randomness As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Interval As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Randomness As TextBox
    Friend WithEvents cbx_Sound As CheckBox
    Friend WithEvents cbx_AllowSkip As CheckBox
    Friend WithEvents cbx_Repeat As CheckBox
    Friend WithEvents cbx_Feedback As CheckBox
    Friend WithEvents cbx_Mathematics As CheckBox
    Friend WithEvents cbx_ As CheckBox
    Friend WithEvents cbx_Science As CheckBox
    Friend WithEvents cbx_Geography As CheckBox
    Friend WithEvents cbx_History As CheckBox
    Friend WithEvents cbx_Computing As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserCreateCueCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grp_Options = New System.Windows.Forms.GroupBox()
        Me.combox_Category = New System.Windows.Forms.ComboBox()
        Me.lbl_CategoryTitle = New System.Windows.Forms.Label()
        Me.txtbox_CueCardName = New System.Windows.Forms.TextBox()
        Me.lbl_CueCardNameTitle = New System.Windows.Forms.Label()
        Me.grp_Front = New System.Windows.Forms.GroupBox()
        Me.txtbox_FrontText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_FrontHeader = New System.Windows.Forms.TextBox()
        Me.lbl_HeaderFrontTitle = New System.Windows.Forms.Label()
        Me.grp_Back = New System.Windows.Forms.GroupBox()
        Me.txtbox_backtext = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_BackHeader = New System.Windows.Forms.TextBox()
        Me.lbl_HeaderBackTitle = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grp_Options.SuspendLayout()
        Me.grp_Front.SuspendLayout()
        Me.grp_Back.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Options
        '
        Me.grp_Options.Controls.Add(Me.combox_Category)
        Me.grp_Options.Controls.Add(Me.lbl_CategoryTitle)
        Me.grp_Options.Controls.Add(Me.txtbox_CueCardName)
        Me.grp_Options.Controls.Add(Me.lbl_CueCardNameTitle)
        Me.grp_Options.Location = New System.Drawing.Point(3, 39)
        Me.grp_Options.Name = "grp_Options"
        Me.grp_Options.Size = New System.Drawing.Size(388, 96)
        Me.grp_Options.TabIndex = 11
        Me.grp_Options.TabStop = False
        Me.grp_Options.Text = "Options"
        Me.grp_Options.Visible = False
        '
        'combox_Category
        '
        Me.combox_Category.FormattingEnabled = True
        Me.combox_Category.Items.AddRange(New Object() {"Mathematics", "English", "Geography", "Science", "Computing", "History"})
        Me.combox_Category.Location = New System.Drawing.Point(200, 39)
        Me.combox_Category.Name = "combox_Category"
        Me.combox_Category.Size = New System.Drawing.Size(175, 21)
        Me.combox_Category.TabIndex = 13
        Me.combox_Category.Text = "Select"
        '
        'lbl_CategoryTitle
        '
        Me.lbl_CategoryTitle.AutoSize = True
        Me.lbl_CategoryTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoryTitle.Location = New System.Drawing.Point(197, 22)
        Me.lbl_CategoryTitle.Name = "lbl_CategoryTitle"
        Me.lbl_CategoryTitle.Size = New System.Drawing.Size(61, 13)
        Me.lbl_CategoryTitle.TabIndex = 12
        Me.lbl_CategoryTitle.Text = "Category:"
        '
        'txtbox_CueCardName
        '
        Me.txtbox_CueCardName.Location = New System.Drawing.Point(6, 40)
        Me.txtbox_CueCardName.Name = "txtbox_CueCardName"
        Me.txtbox_CueCardName.Size = New System.Drawing.Size(175, 20)
        Me.txtbox_CueCardName.TabIndex = 9
        Me.txtbox_CueCardName.Text = "MyCueCard1"
        '
        'lbl_CueCardNameTitle
        '
        Me.lbl_CueCardNameTitle.AutoSize = True
        Me.lbl_CueCardNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CueCardNameTitle.Location = New System.Drawing.Point(6, 26)
        Me.lbl_CueCardNameTitle.Name = "lbl_CueCardNameTitle"
        Me.lbl_CueCardNameTitle.Size = New System.Drawing.Size(99, 13)
        Me.lbl_CueCardNameTitle.TabIndex = 10
        Me.lbl_CueCardNameTitle.Text = "Cue Card Name:"
        '
        'grp_Front
        '
        Me.grp_Front.Controls.Add(Me.txtbox_FrontText)
        Me.grp_Front.Controls.Add(Me.Label5)
        Me.grp_Front.Controls.Add(Me.txtbox_FrontHeader)
        Me.grp_Front.Controls.Add(Me.lbl_HeaderFrontTitle)
        Me.grp_Front.Location = New System.Drawing.Point(3, 141)
        Me.grp_Front.Name = "grp_Front"
        Me.grp_Front.Size = New System.Drawing.Size(194, 189)
        Me.grp_Front.TabIndex = 10
        Me.grp_Front.TabStop = False
        Me.grp_Front.Text = "Front"
        Me.grp_Front.Visible = False
        '
        'txtbox_FrontText
        '
        Me.txtbox_FrontText.Location = New System.Drawing.Point(13, 83)
        Me.txtbox_FrontText.Name = "txtbox_FrontText"
        Me.txtbox_FrontText.Size = New System.Drawing.Size(175, 20)
        Me.txtbox_FrontText.TabIndex = 6
        Me.txtbox_FrontText.Text = "Front Text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Subtext:"
        '
        'txtbox_FrontHeader
        '
        Me.txtbox_FrontHeader.Location = New System.Drawing.Point(13, 35)
        Me.txtbox_FrontHeader.Name = "txtbox_FrontHeader"
        Me.txtbox_FrontHeader.Size = New System.Drawing.Size(175, 20)
        Me.txtbox_FrontHeader.TabIndex = 3
        Me.txtbox_FrontHeader.Text = "Front Header"
        '
        'lbl_HeaderFrontTitle
        '
        Me.lbl_HeaderFrontTitle.AutoSize = True
        Me.lbl_HeaderFrontTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HeaderFrontTitle.Location = New System.Drawing.Point(10, 16)
        Me.lbl_HeaderFrontTitle.Name = "lbl_HeaderFrontTitle"
        Me.lbl_HeaderFrontTitle.Size = New System.Drawing.Size(52, 13)
        Me.lbl_HeaderFrontTitle.TabIndex = 4
        Me.lbl_HeaderFrontTitle.Text = "Header:"
        '
        'grp_Back
        '
        Me.grp_Back.Controls.Add(Me.txtbox_backtext)
        Me.grp_Back.Controls.Add(Me.Label6)
        Me.grp_Back.Controls.Add(Me.txtbox_BackHeader)
        Me.grp_Back.Controls.Add(Me.lbl_HeaderBackTitle)
        Me.grp_Back.Location = New System.Drawing.Point(203, 141)
        Me.grp_Back.Name = "grp_Back"
        Me.grp_Back.Size = New System.Drawing.Size(188, 189)
        Me.grp_Back.TabIndex = 9
        Me.grp_Back.TabStop = False
        Me.grp_Back.Text = "Back"
        Me.grp_Back.Visible = False
        '
        'txtbox_backtext
        '
        Me.txtbox_backtext.Location = New System.Drawing.Point(9, 83)
        Me.txtbox_backtext.Name = "txtbox_backtext"
        Me.txtbox_backtext.Size = New System.Drawing.Size(162, 20)
        Me.txtbox_backtext.TabIndex = 8
        Me.txtbox_backtext.Text = "Back Text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Subtext:"
        '
        'txtbox_BackHeader
        '
        Me.txtbox_BackHeader.Location = New System.Drawing.Point(9, 35)
        Me.txtbox_BackHeader.Name = "txtbox_BackHeader"
        Me.txtbox_BackHeader.Size = New System.Drawing.Size(162, 20)
        Me.txtbox_BackHeader.TabIndex = 3
        Me.txtbox_BackHeader.Text = "Back Header"
        '
        'lbl_HeaderBackTitle
        '
        Me.lbl_HeaderBackTitle.AutoSize = True
        Me.lbl_HeaderBackTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HeaderBackTitle.Location = New System.Drawing.Point(6, 16)
        Me.lbl_HeaderBackTitle.Name = "lbl_HeaderBackTitle"
        Me.lbl_HeaderBackTitle.Size = New System.Drawing.Size(52, 13)
        Me.lbl_HeaderBackTitle.TabIndex = 4
        Me.lbl_HeaderBackTitle.Text = "Header:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(388, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btn_Edit)
        Me.GroupBox3.Controls.Add(Me.btn_Add)
        Me.GroupBox3.Controls.Add(Me.btn_save)
        Me.GroupBox3.Controls.Add(Me.btn_Remove)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 333)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 63)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(56, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 39)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Clear All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Edit.Enabled = False
        Me.btn_Edit.Font = New System.Drawing.Font("Agency FB", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(209, 19)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(87, 38)
        Me.btn_Edit.TabIndex = 17
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.Font = New System.Drawing.Font("Agency FB", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(298, 19)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(87, 38)
        Me.btn_Add.TabIndex = 16
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(116, 19)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(87, 38)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save and Close"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_Remove
        '
        Me.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove.Enabled = False
        Me.btn_Remove.Font = New System.Drawing.Font("Agency FB", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Remove.Location = New System.Drawing.Point(6, 18)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(49, 39)
        Me.btn_Remove.TabIndex = 8
        Me.btn_Remove.Text = "Delete"
        Me.btn_Remove.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(13, 199)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Subtext"
        '
        'UserCreateCueCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_Options)
        Me.Controls.Add(Me.grp_Front)
        Me.Controls.Add(Me.grp_Back)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "UserCreateCueCard"
        Me.Size = New System.Drawing.Size(397, 399)
        Me.grp_Options.ResumeLayout(False)
        Me.grp_Options.PerformLayout()
        Me.grp_Front.ResumeLayout(False)
        Me.grp_Front.PerformLayout()
        Me.grp_Back.ResumeLayout(False)
        Me.grp_Back.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_Options As GroupBox
    Friend WithEvents lbl_CategoryTitle As Label
    Friend WithEvents lbl_CueCardNameTitle As Label
    Friend WithEvents grp_Front As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_HeaderFrontTitle As Label
    Friend WithEvents grp_Back As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_HeaderBackTitle As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents combox_Category As ComboBox
    Public WithEvents txtbox_CueCardName As TextBox
    Public WithEvents txtbox_FrontText As TextBox
    Public WithEvents txtbox_FrontHeader As TextBox
    Public WithEvents txtbox_backtext As TextBox
    Public WithEvents txtbox_BackHeader As TextBox
    Public WithEvents btn_Edit As Button
    Public WithEvents btn_Add As Button
    Public WithEvents btn_save As Button
    Public WithEvents btn_Remove As Button
    Public WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CueCard1
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
        Me.lbl_FrontText = New System.Windows.Forms.Label()
        Me.lbl_FrontHeaderText = New System.Windows.Forms.Label()
        Me.btn_CardFlip = New System.Windows.Forms.Button()
        Me.btn_CloseCard = New System.Windows.Forms.Button()
        Me.btn_StopQuiz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_FrontText
        '
        Me.lbl_FrontText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FrontText.Location = New System.Drawing.Point(17, 44)
        Me.lbl_FrontText.Name = "lbl_FrontText"
        Me.lbl_FrontText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_FrontText.Size = New System.Drawing.Size(260, 143)
        Me.lbl_FrontText.TabIndex = 19
        Me.lbl_FrontText.Text = "Front Text"
        '
        'lbl_FrontHeaderText
        '
        Me.lbl_FrontHeaderText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FrontHeaderText.Location = New System.Drawing.Point(12, 9)
        Me.lbl_FrontHeaderText.Name = "lbl_FrontHeaderText"
        Me.lbl_FrontHeaderText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_FrontHeaderText.Size = New System.Drawing.Size(346, 31)
        Me.lbl_FrontHeaderText.TabIndex = 18
        Me.lbl_FrontHeaderText.Text = "Front Header"
        '
        'btn_CardFlip
        '
        Me.btn_CardFlip.Location = New System.Drawing.Point(283, 161)
        Me.btn_CardFlip.Name = "btn_CardFlip"
        Me.btn_CardFlip.Size = New System.Drawing.Size(75, 23)
        Me.btn_CardFlip.TabIndex = 20
        Me.btn_CardFlip.Text = "Flip"
        Me.btn_CardFlip.UseVisualStyleBackColor = True
        '
        'btn_CloseCard
        '
        Me.btn_CloseCard.Location = New System.Drawing.Point(283, 132)
        Me.btn_CloseCard.Name = "btn_CloseCard"
        Me.btn_CloseCard.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseCard.TabIndex = 21
        Me.btn_CloseCard.Text = "Close Card"
        Me.btn_CloseCard.UseVisualStyleBackColor = True
        '
        'btn_StopQuiz
        '
        Me.btn_StopQuiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_StopQuiz.Location = New System.Drawing.Point(283, 87)
        Me.btn_StopQuiz.Name = "btn_StopQuiz"
        Me.btn_StopQuiz.Size = New System.Drawing.Size(75, 39)
        Me.btn_StopQuiz.TabIndex = 22
        Me.btn_StopQuiz.Text = "Close Card Stop Quiz"
        Me.btn_StopQuiz.UseVisualStyleBackColor = False
        '
        'CueCard1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 196)
        Me.Controls.Add(Me.btn_StopQuiz)
        Me.Controls.Add(Me.btn_CloseCard)
        Me.Controls.Add(Me.btn_CardFlip)
        Me.Controls.Add(Me.lbl_FrontText)
        Me.Controls.Add(Me.lbl_FrontHeaderText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CueCard1"
        Me.Text = "CueCard1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_FrontText As Label
    Friend WithEvents lbl_FrontHeaderText As Label
    Friend WithEvents btn_CardFlip As Button
    Friend WithEvents btn_CloseCard As Button
    Friend WithEvents btn_StopQuiz As Button
End Class

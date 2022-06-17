<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuScreen))
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.btn_quitgame = New System.Windows.Forms.Button()
        Me.Pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_credits = New System.Windows.Forms.Label()
        CType(Me.Pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.White
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatAppearance.BorderSize = 20
        Me.btn_start.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn_start.ForeColor = System.Drawing.Color.Black
        Me.btn_start.Location = New System.Drawing.Point(12, 12)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(162, 115)
        Me.btn_start.TabIndex = 9
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_options
        '
        Me.btn_options.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_options.BackColor = System.Drawing.Color.White
        Me.btn_options.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_options.FlatAppearance.BorderSize = 20
        Me.btn_options.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_options.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn_options.ForeColor = System.Drawing.Color.Black
        Me.btn_options.Location = New System.Drawing.Point(12, 168)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(162, 115)
        Me.btn_options.TabIndex = 12
        Me.btn_options.Text = "Options"
        Me.btn_options.UseVisualStyleBackColor = False
        '
        'btn_quitgame
        '
        Me.btn_quitgame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_quitgame.BackColor = System.Drawing.Color.White
        Me.btn_quitgame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitgame.FlatAppearance.BorderSize = 20
        Me.btn_quitgame.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btn_quitgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_quitgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_quitgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitgame.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btn_quitgame.ForeColor = System.Drawing.Color.Black
        Me.btn_quitgame.Location = New System.Drawing.Point(12, 323)
        Me.btn_quitgame.Name = "btn_quitgame"
        Me.btn_quitgame.Size = New System.Drawing.Size(162, 115)
        Me.btn_quitgame.TabIndex = 13
        Me.btn_quitgame.Text = "Quit"
        Me.btn_quitgame.UseVisualStyleBackColor = False
        '
        'Pic_logo
        '
        Me.Pic_logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_logo.BackColor = System.Drawing.Color.Silver
        Me.Pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Pic_logo.Image = CType(resources.GetObject("Pic_logo.Image"), System.Drawing.Image)
        Me.Pic_logo.Location = New System.Drawing.Point(214, 15)
        Me.Pic_logo.Name = "Pic_logo"
        Me.Pic_logo.Size = New System.Drawing.Size(304, 426)
        Me.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_logo.TabIndex = 14
        Me.Pic_logo.TabStop = False
        '
        'lbl_credits
        '
        Me.lbl_credits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_credits.AutoSize = True
        Me.lbl_credits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credits.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_credits.Location = New System.Drawing.Point(389, 417)
        Me.lbl_credits.Name = "lbl_credits"
        Me.lbl_credits.Size = New System.Drawing.Size(155, 24)
        Me.lbl_credits.TabIndex = 15
        Me.lbl_credits.Text = "Dom, Luca, Peter"
        '
        'MainMenuScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.lbl_credits)
        Me.Controls.Add(Me.Pic_logo)
        Me.Controls.Add(Me.btn_quitgame)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(572, 489)
        Me.MinimumSize = New System.Drawing.Size(572, 489)
        Me.Name = "MainMenuScreen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.Pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_options As Button
    Friend WithEvents btn_quitgame As Button
    Friend WithEvents Pic_logo As PictureBox
    Friend WithEvents lbl_credits As Label
End Class


'For exporting to text files'
Imports System.IO

Public Class UserCreateCueCard

    'Boolean Variables'
    Public EditMode As Boolean = False
    Dim MessageBoxResponse


    Public Category As String = "Mathematics"
    Public Label(5) As String



    Public Resources As String

    'Flip flop on the add button to convert it to a cancel button'
    Public Sub btn_Add_Click_1(sender As Object, e As EventArgs) Handles btn_Add.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)


        If EditMode = False Then

            'Toggle Visibility To "Edit Mode"
            grp_Front.Visible = True
            grp_Back.Visible = True
            grp_Options.Visible = True


            'For optimization, change the add button to a cancel button
            btn_Add.Text = "Cancel"
            EditMode = True

        Else

            'Warning for user just in case - they accidentally hit the cancel button
            MessageBoxResponse = MsgBox("Are you sure you want to cancel the current cue card?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
            If MessageBoxResponse = vbYes Then

                'Toggle Visibility To "Viewing/Selection Mode"
                grp_Front.Visible = False
                grp_Back.Visible = False
                grp_Options.Visible = False

                'For optimization, change the cancel button to a add button'
                btn_Add.Text = "Add"
                EditMode = False
            Else
            End If
        End If
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click

        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MessageBoxResponse = MsgBox("Are you sure you want to delete" + ComboBox1.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then

            ComboBox1.Items.Remove(ComboBox1.Text)
            ComboBox1.Text = ""

            'Toggle Visibility To "Viewing/Selection Mode"
            grp_Front.Visible = False
            grp_Back.Visible = False
            grp_Options.Visible = False

            'For optimization, change the cancel button to a add button'
            btn_Add.Text = "Add"
            EditMode = False

            btn_Remove.Enabled = False

        End If
    End Sub

    Public Sub txtbox_CueCardName_TextChanged(sender As Object, e As EventArgs)

        Label(0) = txtbox_CueCardName.Text

    End Sub

    Public Sub txtbox_FrontHeader_TextChanged(sender As Object, e As EventArgs) Handles txtbox_FrontHeader.TextChanged

        Label(1) = txtbox_FrontHeader.Text

    End Sub

    Public Sub txtbox_BackHeader_TextChanged(sender As Object, e As EventArgs) Handles txtbox_BackHeader.TextChanged

        Label(2) = txtbox_BackHeader.Text

    End Sub

    Public Sub txtbox_FrontText_TextChanged(sender As Object, e As EventArgs) Handles txtbox_FrontText.TextChanged

        Label(3) = txtbox_FrontText.Text

    End Sub

    Public Sub txtbox_backtext_TextChanged(sender As Object, e As EventArgs) Handles txtbox_backtext.TextChanged

        Label(4) = txtbox_backtext.Text

    End Sub



    'Variables wouldn't go inside the OpenText function so its a case switch based on the category variable'
    Public Sub UserCreateCueCard_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case Category

            Case "Mathematics"
                Dim CategoryFile As StreamReader = File.OpenText("Mathematics.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()


            Case "English"
                Dim CategoryFile As StreamReader = File.OpenText("English.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()

            Case "Geography"
                Dim CategoryFile As StreamReader = File.OpenText("Geography.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()

            Case "Science"
                Dim CategoryFile As StreamReader = File.OpenText("Science.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()

            Case "Computing"
                Dim CategoryFile As StreamReader = File.OpenText("Computing.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()


            Case "History"
                Dim CategoryFile As StreamReader = File.OpenText("History.txt")
                Do While CategoryFile.Peek <> -1
                    ComboBox1.Items.Add(CategoryFile.ReadLine())
                Loop
                CategoryFile.Close()

        End Select
        combox_Category.Text = Category




    End Sub

    'Save button'
    Public Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        Dim CueCardName = (txtbox_CueCardName.Text, txtbox_FrontHeader.Text, txtbox_FrontText.Text, txtbox_BackHeader.Text, txtbox_backtext.Text, combox_Category.Text)


        ComboBox1.Items.Add(txtbox_CueCardName.Text)

        Dim CategoryFile As StreamWriter = File.CreateText(Resources)
        For Each Name As Object In ComboBox1.Items
            CategoryFile.WriteLine(CueCardName)
        Next
        CategoryFile.Close()


    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        If EditMode = False Then

            'Toggle Visibility To "Edit Mode"
            grp_Front.Visible = True
            grp_Back.Visible = True
            grp_Options.Visible = True
            btn_Edit.Enabled = False
            btn_save.Enabled = True

            'For optimization, change the add button to a cancel button
            btn_Add.Text = "Cancel"
            EditMode = True
            btn_Edit.Enabled = False
        Else

            'Warning for user just in case - they accidentally hit the cancel button
            MessageBoxResponse = MsgBox("Are you sure you want to cancel editing the current cue card?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
            If MessageBoxResponse = vbYes Then

                'Toggle Visibility To "Viewing/Selection Mode"
                grp_Front.Visible = False
                grp_Back.Visible = False
                grp_Options.Visible = False

                'For optimization, change the cancel button to a add button'
                btn_Add.Text = "Add"
                EditMode = False
                btn_Edit.Enabled = True
                btn_save.Enabled = False
                btn_Edit.Enabled = True
            Else

            End If

            ComboBoxEmptyCheckEvent()

        End If








    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBoxEmptyCheckEvent()

    End Sub

    Private Sub combox_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_Category.SelectedIndexChanged
        Category = combox_Category.Text

    End Sub



    Public Sub ComboBoxEmptyCheckEvent()

        If (String.IsNullOrEmpty(ComboBox1.SelectedText)) Then

            btn_Remove.Enabled = True

            btn_Edit.Enabled = True

            btn_save.Enabled = False

        Else

            btn_Remove.Enabled = False

            btn_Edit.Enabled = False

            btn_save.Enabled = True


        End If

    End Sub

    Private Sub btn_Add_MouseEnter(sender As Object, e As EventArgs) Handles btn_Add.MouseEnter

    End Sub
End Class


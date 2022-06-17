Imports System.IO

Public Class CreateCueCardScreen

    'String'
    Dim MessageBoxResponse

    'Quit To Seleciton Screen'
    Private Sub BackToSelectionScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToSelectionScreenToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        SelectionScreen.Show()
        Me.Hide()
    End Sub

    'When the quit button is clicked a message box appears
    Private Sub QuitToDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToDesktopToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MessageBoxResponse = MsgBox("Quit To Desktop?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then
            End
        End If
    End Sub

    'When the main menu button is clicked the menu opens
    Private Sub QuitToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToMainMenuToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MainMenuScreen.Show()
        Me.Hide()
    End Sub

    'Set Categories'
    Private Sub CreateCueCardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserCreateCueCard1.Category = "Mathematics"
        UserCreateCueCard2.Category = "English"
        UserCreateCueCard3.Category = "Geography"
        UserCreateCueCard4.Category = "Science"
        UserCreateCueCard5.Category = "Computing"
        UserCreateCueCard6.Category = "History"


        'UserCreateCueCard1.Resources = "Mathematics.txt"
        'UserCreateCueCard2.Resources = "English.txt"
        'UserCreateCueCard3.Resources = "Geography.txt"
        'UserCreateCueCard4.Resources = "Science.txt"
        'UserCreateCueCard5.Resources = "Computing.txt"
        'UserCreateCueCard6.Resources = "History.txt"

    End Sub

    'Every second update the cue cards. - REALLY UNOPTIMIZED FIX'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If UserCreateCueCard1.EditMode = True Or
            UserCreateCueCard2.EditMode = True Or
            UserCreateCueCard3.EditMode = True Or
            UserCreateCueCard4.EditMode = True Or
            UserCreateCueCard5.EditMode = True Or
            UserCreateCueCard6.EditMode = True Then

            grp_CardFront.Visible = True
            grp_CardBack.Visible = True

            If tab_ControlMenu5.SelectedIndex = 0 Then
                lbl_FrontHeader.Text = UserCreateCueCard1.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard1.Label(2)
                lbl_Front.Text = UserCreateCueCard1.Label(3)
                lbl_Back.Text = UserCreateCueCard1.Label(4)
            End If


            If tab_ControlMenu5.SelectedIndex = 1 Then
                lbl_FrontHeader.Text = UserCreateCueCard2.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard2.Label(2)
                lbl_Front.Text = UserCreateCueCard2.Label(3)
                lbl_Back.Text = UserCreateCueCard2.Label(4)
            End If

            If tab_ControlMenu5.SelectedIndex = 2 Then
                lbl_FrontHeader.Text = UserCreateCueCard3.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard3.Label(2)
                lbl_Front.Text = UserCreateCueCard3.Label(3)
                lbl_Back.Text = UserCreateCueCard3.Label(4)
            End If

            If tab_ControlMenu5.SelectedIndex = 3 Then
                lbl_FrontHeader.Text = UserCreateCueCard4.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard4.Label(2)
                lbl_Front.Text = UserCreateCueCard4.Label(3)
                lbl_Back.Text = UserCreateCueCard4.Label(4)
            End If

            If tab_ControlMenu5.SelectedIndex = 4 Then
                lbl_FrontHeader.Text = UserCreateCueCard5.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard5.Label(2)
                lbl_Front.Text = UserCreateCueCard5.Label(3)
                lbl_Back.Text = UserCreateCueCard5.Label(4)
            End If

            If tab_ControlMenu5.SelectedIndex = 5 Then
                lbl_FrontHeader.Text = UserCreateCueCard6.Label(1)
                lbl_BackHeader.Text = UserCreateCueCard6.Label(2)
                lbl_Front.Text = UserCreateCueCard6.Label(3)
                lbl_Back.Text = UserCreateCueCard6.Label(4)
            End If

        End If



    End Sub

End Class





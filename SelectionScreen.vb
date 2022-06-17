Public Class SelectionScreen

    Dim MessageBoxResponse

    'When the quit button is clicked a message box appears
    Private Sub QuitToDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToDesktopToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MessageBoxResponse = MsgBox("Quit To Desktop?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then End
    End Sub

    'When the quit button is clicked the main menu opens.
    Private Sub QuitToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToMainMenuToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MainMenuScreen.Show()
        Me.Close()
    End Sub

    'When cue card button is pressed the cue card screen opens.
    Private Sub btn_CreateCueCards_Click_1(sender As Object, e As EventArgs) Handles btn_CreateCueCards.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        CreateCueCardScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btn_CreateCueCards_MouseEnter(sender As Object, e As EventArgs) Handles btn_CreateCueCards.MouseEnter
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_CreateCueCards.BackColor = Color.Gray
    End Sub

    Private Sub btn_CreateCueCards_MouseLeave(sender As Object, e As EventArgs) Handles btn_CreateCueCards.MouseLeave
        'On hover change colour to white
        btn_CreateCueCards.BackColor = Color.White
    End Sub

    Private Sub btn_StartPopupQuiz_Click(sender As Object, e As EventArgs) Handles btn_StartPopupQuiz.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        PopupQuizScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btn_StartPopupQuiz_MouseEnter(sender As Object, e As EventArgs) Handles btn_StartPopupQuiz.MouseEnter
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_StartPopupQuiz.BackColor = Color.Gray
    End Sub

    Private Sub btn_StartPopupQuiz_MouseLeave(sender As Object, e As EventArgs) Handles btn_StartPopupQuiz.MouseLeave
        'On hover change colour to white
        btn_StartPopupQuiz.BackColor = Color.White
    End Sub

    'Play sound effect on hover'

    Private Sub QuitToDesktopToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles QuitToDesktopToolStripMenuItem.MouseHover
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

    End Sub

    'Play sound effect on hover'
    Private Sub QuitToMainMenuToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles QuitToMainMenuToolStripMenuItem.MouseHover
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

    End Sub

    Private Sub btn_StartQuiz_Click(sender As Object, e As EventArgs) Handles btn_StartQuiz.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)
    End Sub

    Private Sub btn_StartQuiz_MouseEnter(sender As Object, e As EventArgs) Handles btn_StartQuiz.MouseEnter
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_StartQuiz.BackColor = Color.Gray
    End Sub

    Private Sub btn_StartQuiz_MouseLeave(sender As Object, e As EventArgs) Handles btn_StartQuiz.MouseLeave
        'On hover change colour to white
        btn_StartQuiz.BackColor = Color.White
    End Sub
End Class
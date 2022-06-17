Public Class PopupQuizScreen

    Dim MessageBoxResponse

    'Back to the main menu button.
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'Play sound effect
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MainMenuScreen.Show()
        Me.Hide()
    End Sub

    'When the quit button is clicked the program ends.
    Private Sub QuitToDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToDesktopToolStripMenuItem.Click
        'Play sound effect
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MessageBoxResponse = MsgBox("Quit To Desktop?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then End
    End Sub

    Private Sub btn_StartQuiz_Click(sender As Object, e As EventArgs) Handles btn_StartQuiz.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)
    End Sub
End Class
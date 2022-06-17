Public Class OurWebsite

    Dim MessageBoxResponse

    Private Sub QuitToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToMainMenuToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MainMenuScreen.Show()
        Me.Hide()
    End Sub

    'When the quit button is clicked a message box appears
    Private Sub QuitToDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToDesktopToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        MessageBoxResponse = MsgBox("Quit To Desktop?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then End
    End Sub

    Private Sub BackToOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToOptionsToolStripMenuItem.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        Options.Show()
        Me.Hide()
    End Sub
End Class
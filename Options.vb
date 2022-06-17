Public Class Options
    Dim MessageBoxResponse

    'When the main menu button is clicked the menu opens
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

    Private Sub btn_aboutUs_Click(sender As Object, e As EventArgs) Handles btn_aboutUs.Click
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        OurWebsite.Show()
        Me.Hide()
    End Sub

    Private Sub btn_aboutUs_MouseEnter(sender As Object, e As EventArgs) Handles btn_aboutUs.MouseEnter
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_aboutUs.BackColor = Color.Gray
    End Sub

    Private Sub btn_aboutUs_MouseLeave(sender As Object, e As EventArgs) Handles btn_aboutUs.MouseLeave
        'On hover change colour to white
        btn_aboutUs.BackColor = Color.White
    End Sub
End Class
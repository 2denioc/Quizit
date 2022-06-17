Imports System

Public Class MainMenuScreen

    Dim MessageBoxResponse


    'When the start button is clicked the selection screen opens
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        SelectionScreen.Show()
        Me.Hide()

    End Sub

    Private Sub btn_start_MouseEnter(sender As Object, e As EventArgs) Handles btn_start.MouseHover
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_start.BackColor = Color.Gray

    End Sub

    Private Sub btn_start_MouseLeave(sender As Object, e As EventArgs) Handles btn_start.MouseLeave
        'Change colour back when the mouse leaves'
        btn_start.BackColor = Color.White
    End Sub

    'When the options button is clicked the options menu opens
    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click

        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)

        Options.Show()
        Me.Hide()
    End Sub

    Private Sub btn_options_MouseEnter(sender As Object, e As EventArgs) Handles btn_options.MouseHover
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_options.BackColor = Color.Gray

    End Sub


    Private Sub btn_options_DragLeave(sender As Object, e As EventArgs) Handles btn_options.DragLeave



    End Sub

    'When the quit button is clicked a message box appears
    Private Sub btn_quitgame_Click(sender As Object, e As EventArgs) Handles btn_quitgame.Click

        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.NotInteractable,
        AudioPlayMode.Background)


        MessageBoxResponse = MsgBox("Quit To Desktop?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If MessageBoxResponse = vbYes Then End
    End Sub

    Private Sub btn_quitgame_MouseEnter(sender As Object, e As EventArgs) Handles btn_quitgame.MouseHover
        'Play sound effect'
        My.Computer.Audio.Play(My.Resources.PlayerHit,
        AudioPlayMode.Background)

        'On hover change colour to grey
        btn_quitgame.BackColor = Color.Gray
    End Sub

    Private Sub btn_quitgame_MouseLeave(sender As Object, e As EventArgs) Handles btn_quitgame.MouseLeave
        'Change colour back when the mouse leaves'
        btn_quitgame.BackColor = Color.White
    End Sub

    Private Sub btn_options_MouseLeave(sender As Object, e As EventArgs) Handles btn_options.MouseLeave
        'Change colour back when the mouse leaves'
        btn_options.BackColor = Color.White
    End Sub
End Class

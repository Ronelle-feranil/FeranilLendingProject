Public Class main
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        black.Show()
        users.Show()
    End Sub

    Private Sub btnOnboarding_Click(sender As Object, e As EventArgs) Handles btnOnboarding.Click
        black.Show()
        onboard.Show()
    End Sub

    Private Sub main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLoginPage.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        black.Show()
        reports.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        black.Show()
        settings.Show()
    End Sub
End Class
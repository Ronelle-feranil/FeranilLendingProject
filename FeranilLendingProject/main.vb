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

    Private Sub btnEnterCode_Click(sender As Object, e As EventArgs) Handles btnEnterCode.Click
        black.Show()
        collect.Show()

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lblTotalCollection.Text = "0.00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeAndDate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub

    Public Sub UpdateRecords()
        'Update the total collections label on main dashboard and the list of gridview
    End Sub
End Class
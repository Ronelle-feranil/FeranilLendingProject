Public Class reports
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        black.Close()
    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCode.Focus()
        txtAmontBorrowed.Text = "0.00"
        txtAmountSettled.Text = "0.00"
        lblBalance.Text = "0.00"
    End Sub
End Class
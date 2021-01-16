Public Class collect
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCode.Text = ""
        txtAmount.Text = ""
        txtCode.Focus()
    End Sub

    Private Sub btnCollect_Click(sender As Object, e As EventArgs) Handles btnCollect.Click
        MessageBox.Show("Collection Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CloseForm()

        main.UpdateRecords()
    End Sub

    Private Sub CloseForm()
        Me.Close()
        black.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CloseForm()
    End Sub
End Class
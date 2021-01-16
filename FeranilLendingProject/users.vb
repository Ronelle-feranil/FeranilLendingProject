Public Class users

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        black.Close()
    End Sub

    Private Sub users_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            black.Close()
        End If
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
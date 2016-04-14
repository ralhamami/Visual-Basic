Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTalk_Click(sender As Object, e As EventArgs) Handles btnTalk.Click
        lblMessage.Text = "Greetings from Rayan Al-Hammami."
    End Sub
End Class

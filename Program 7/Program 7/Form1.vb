Public Class Form1
    Dim time As Integer = 15
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (time > 0) Then
            time -= 1
        Else
            Timer1.Stop()
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class

Public Class ScratchPad

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim result As DialogResult = FontDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click
        Dim result As DialogResult = ColorDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Dim result As DialogResult = ColorDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            TextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class
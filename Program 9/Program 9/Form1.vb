Imports System.IO

Public Class Form1
    Dim estimatedHours As New ArrayList

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim hoursInput As Double = CDbl(txtEstimatedHours.Text)
            If cboJobs.Text.Length < 0 Or hoursInput < 0 Then
                Throw New Exception
            Else
                cboJobs.Items.Add(cboJobs.Text)
                cboJobs.Text = ""
                txtEstimatedHours.Clear()
                estimatedHours.Add(hoursInput)
                MessageBox.Show("Job Added!")
                getTotalHours()
                cboJobs.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Please check the value for job or hours and try again." + ex.Message)
        End Try
    End Sub

    Private Sub cboJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJobs.SelectedIndexChanged
        Dim index As Integer = cboJobs.SelectedIndex
        If index < 0 Then
            txtEstimatedHours.Text = "0"
        Else
            txtEstimatedHours.Text = estimatedHours.Item(index).ToString()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim file As New StreamWriter(saveFileDialog.FileName)
            For i = 0 To cboJobs.Items.Count - 1
                file.WriteLine(cboJobs.Items.Item(i))
                file.WriteLine(estimatedHours.Item(i).ToString())
            Next
            file.Close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            cboJobs.Items.Clear()
            estimatedHours.Clear()
            Dim file As New StreamReader(openFileDialog.FileName)
            While Not file.EndOfStream
                cboJobs.Items.Add(file.ReadLine())
                estimatedHours.Add(file.ReadLine())
            End While
            file.Close()
            getTotalHours()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        estimatedHours.Item(cboJobs.SelectedIndex) = txtEstimatedHours.Text
        getTotalHours()
        MessageBox.Show("Hours for the selected job have been changed.")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        estimatedHours.RemoveAt(cboJobs.SelectedIndex)
        cboJobs.Items.RemoveAt(cboJobs.SelectedIndex)
        getTotalHours()
        txtEstimatedHours.Clear()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        cboJobs.Items.Clear()
        estimatedHours.Clear()
        cboJobs.Text = ""
        txtEstimatedHours.Clear()
        getTotalHours()
        cboJobs.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As Integer
        result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question, "Quit?")
        If result = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub getTotalHours()
        Dim total As Double = 0
        For Each value In estimatedHours
            total += value
        Next
        lblTotalHours.Text = total.ToString()
    End Sub
End Class

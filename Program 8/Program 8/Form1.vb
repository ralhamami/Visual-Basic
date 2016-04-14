Public Class Form1
    'Declare List variables to store student names and grades
    Dim studentNames As New List(Of String)
    Dim grades As New List(Of Double)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Try to add the student name currently in textbox
        'as well as parse and add grade from textbox
        'then clear and return focus
        Try
            studentNames.Add(txtStudentName.Text)
            grades.Add(Double.Parse(txtGrade.Text))
            txtStudentName.Clear()
            txtGrade.Clear()
            txtStudentName.Focus()
        Catch ex As Exception
            MessageBox.Show("Please enter a valid student name and grade.")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Clear the normalized grades textbox
        txtNormalGrades.Clear()

        'Declare a new List for the curved grades
        Dim curveGrades As New List(Of Double)

        'Declare variable to store the max grade
        Dim max As Double = grades.Max()

        'Declare variable to store the curve amount
        Dim curve As Double = 100 - max

        'Loop through all the students and add the curve
        'then add the values to the normalized text box
        For i = 0 To studentNames.Count - 1
            curveGrades.Add(grades(i) + curve)
            txtNormalGrades.Text += studentNames(i) + ControlChars.Tab + curveGrades(i).ToString() + ControlChars.CrLf
        Next
    End Sub
End Class

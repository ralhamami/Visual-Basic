Public Structure Student
    Dim name, earned_t1, earned_t2, earned_t3, possible_t1, possible_t2, possible_t3 As String
End Structure

Public Class Form1
    Public std As New List(Of Student)
    Public multiStudent As Integer = 1
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ' enables textboxes/buttons
        enableAll()
        resetDefault()
        lstStudent.SelectedIndex = -1
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        ' Program goes to the next structure in the list and displays contents in the text boxes
        '   If the last structure is the one current displayed, the Find button displays the first structure
        Dim stdIndex As Integer = findIndex()

        If stdIndex = std.Count Then
            txtStudentName.Text = std(0).name
            txtEarned_T1.Text = std(0).earned_t1
            txtPossible_T1.Text = std(0).possible_t1
            txtEarned_T2.Text = std(0).earned_t2
            txtPossible_T2.Text = std(0).possible_t2
            txtEarned_T3.Text = std(0).earned_t3
            txtPossible_T3.Text = std(0).possible_t3
            lstStudent.SelectedIndex = 0
        Else
            txtStudentName.Text = std(stdIndex).name
            txtEarned_T1.Text = std(stdIndex).earned_t1
            txtPossible_T1.Text = std(stdIndex).possible_t1
            txtEarned_T2.Text = std(stdIndex).earned_t2
            txtPossible_T2.Text = std(stdIndex).possible_t2
            txtEarned_T3.Text = std(stdIndex).earned_t3
            txtPossible_T3.Text = std(stdIndex).possible_t3
            lstStudent.SelectedIndex = stdIndex
        End If


    End Sub
    Private Function findIndex()
        Dim index As Integer
        ' checks to see if user changed selected index of the student list
        ' if user changed selected index, searches by the list
        If txtStudentName.Text <> lstStudent.SelectedItem Then
            index = lstStudent.SelectedIndex
        Else
            ' else loops through the list of students
            For counter As Integer = 0 To std.Count - 1
                ' compares if the current student loaded is the same as the name in the structure
                If std(counter).name.ToString() = txtStudentName.Text.Trim() Then
                    ' sets index to the next structure in list
                    index = counter + 1
                    Exit For
                Else
                    ' sets default index to last structure added
                    index = 0
                End If
            Next
        End If
        Return index
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim newStudent As New Student

        If txtStudentName.Text.Trim() <> "" Then
            If lstStudent.Items.Contains(txtStudentName.Text.Trim()) Then
                MessageBox.Show("Student already exists, add anyways?", "Already Exists", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    multiStudent = 0
                    For x As Integer = 1 To lstStudent.Items.Count
                        If lstStudent.Items(x - 1).ToString().Contains(txtStudentName.Text.Trim()) Then
                            multiStudent += 1
                        End If
                    Next
                    newStudent.name = txtStudentName.Text.Trim() + "(" + multiStudent.ToString() + ")"
                    newStudent.earned_t1 = txtEarned_T1.Text.Trim()
                    newStudent.possible_t1 = txtPossible_T1.Text.Trim()
                    newStudent.earned_t2 = txtEarned_T2.Text.Trim()
                    newStudent.possible_t2 = txtPossible_T2.Text.Trim()
                    newStudent.earned_t3 = txtEarned_T3.Text.Trim()
                    newStudent.possible_t3 = txtPossible_T3.Text.Trim()
                    ' adds the newStudent structure to list of structures
                    std.Add(newStudent)
                    ' adds student name to list box of students
                    lstStudent.Items.Add(txtStudentName.Text.Trim() + "(" + multiStudent.ToString() + ")")
                    ' resets textboxes to their default values/sets focus to student name textbox
                    resetDefault()
                    btnFind.Enabled = True


                    Exit Sub
                End If
            Else
                ' creates new instance of the student structure and saves data
                newStudent.name = txtStudentName.Text.Trim()
                newStudent.earned_t1 = txtEarned_T1.Text.Trim()
                newStudent.possible_t1 = txtPossible_T1.Text.Trim()
                newStudent.earned_t2 = txtEarned_T2.Text.Trim()
                newStudent.possible_t2 = txtPossible_T2.Text.Trim()
                newStudent.earned_t3 = txtEarned_T3.Text.Trim()
                newStudent.possible_t3 = txtPossible_T3.Text.Trim()
                ' adds the newStudent structure to list of structures
                std.Add(newStudent)
                ' adds student name to list box of students
                lstStudent.Items.Add(txtStudentName.Text.Trim())
                ' resets textboxes to their default values/sets focus to student name textbox
                resetDefault()
                btnFind.Enabled = True
                Exit Sub
            End If
        Else
            MessageBox.Show("You must enter a Student Name", "ERROR")
            txtStudentName.Focus()
        End If
    End Sub

    Private Sub enableAll()
        ' btnFind.Enabled = True
        btnSave.Enabled = True
        txtEarned_T1.Enabled = True
        txtPossible_T1.Enabled = True
        txtEarned_T2.Enabled = True
        txtPossible_T2.Enabled = True
        txtEarned_T3.Enabled = True
        txtPossible_T3.Enabled = True
        txtStudentName.Enabled = True
        txtStudentName.Focus()
    End Sub
    Private Sub resetDefault()
        txtStudentName.Focus()
        txtStudentName.Clear()
        txtEarned_T1.Text = "0"
        txtPossible_T1.Text = "0"
        txtEarned_T2.Text = "0"
        txtPossible_T2.Text = "0"
        txtEarned_T3.Text = "0"
        txtPossible_T3.Text = "0"
    End Sub

    Private Sub lblTest3_Click(sender As Object, e As EventArgs) Handles lblTest3.Click

    End Sub

    Private Sub lblTest2_Click(sender As Object, e As EventArgs) Handles lblTest2.Click

    End Sub

    Private Sub lblTest1_Click(sender As Object, e As EventArgs) Handles lblTest1.Click

    End Sub

    Private Sub txtPossible_T1_TextChanged(sender As Object, e As EventArgs) Handles txtPossible_T1.TextChanged

    End Sub

    Private Sub txtPossible_T2_TextChanged(sender As Object, e As EventArgs) Handles txtPossible_T2.TextChanged

    End Sub

    Private Sub txtPossible_T3_TextChanged(sender As Object, e As EventArgs) Handles txtPossible_T3.TextChanged

    End Sub

    Private Sub txtEarned_T3_TextChanged(sender As Object, e As EventArgs) Handles txtEarned_T3.TextChanged

    End Sub

    Private Sub txtEarned_T2_TextChanged(sender As Object, e As EventArgs) Handles txtEarned_T2.TextChanged

    End Sub

    Private Sub txtEarned_T1_TextChanged(sender As Object, e As EventArgs) Handles txtEarned_T1.TextChanged

    End Sub

    Private Sub lblPointsPossible_Click(sender As Object, e As EventArgs) Handles lblPointsPossible.Click

    End Sub

    Private Sub lblPointsEarned_Click(sender As Object, e As EventArgs) Handles lblPointsEarned.Click

    End Sub

    Private Sub txtStudentName_TextChanged(sender As Object, e As EventArgs) Handles txtStudentName.TextChanged

    End Sub

    Private Sub lstStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudent.SelectedIndexChanged

    End Sub

    Private Sub lblStudentName_Click(sender As Object, e As EventArgs) Handles lblStudentName.Click

    End Sub
End Class

Public Class Form1
    'Variable to hold grand total
    Dim grandTotal As Double

    'Form load event to set form title to specified along with current date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Flooring Cost Estimate " + Now()
    End Sub

    'Calculate button click that calls calculator subroutine 3 times for each room
    'and displays the grand total
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grandTotal = 0
        calculator(txtLength1, txtWidth1, chkInstall1, chkFinish1, lblTotal1)
        calculator(txtLength2, txtWidth2, chkInstall2, chkFinish2, lblTotal2)
        calculator(txtLength3, txtWidth3, chkInstall3, chkFinish3, lblTotal3)
        lblGrandTotal.Text = grandTotal.ToString("c2")
    End Sub

    'Calculator subroutine that takes 5 arguments pertaining to
    'form data for room, exits the routine if there is no data (i.e. room calculation not needed)
    'Displays message box if values are invalid, and calculates the room total as well as 
    'adds to the running grand total
    Private Sub calculator(length As TextBox, width As TextBox, install As CheckBox, finish As CheckBox, total As Label)
        Try
            If (length.Text.Length < 1) Then
                Exit Sub
            End If
            Dim baseCostPerSqft As Double = 5.0
            Dim lenValue As Double = Double.Parse(length.Text)
            Dim widValue As Double = Double.Parse(width.Text)
            If (install.Checked) Then
                baseCostPerSqft += 1.5
            End If
            If (finish.Checked) Then
                baseCostPerSqft += 2.0
            End If
            Dim currentTotal As Double = (lenValue * widValue) * baseCostPerSqft
            grandTotal += currentTotal
            total.Text = currentTotal.ToString("c2")
        Catch ex As Exception
            MessageBox.Show("Please check input for room and try again.")
            length.Focus()
            length.SelectAll()
        End Try
    End Sub
End Class

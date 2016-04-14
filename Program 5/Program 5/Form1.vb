Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaring all useful or necessary variables here
        Dim monthlyInterest As Double
        Dim amountOwed As Double
        Dim totalPaid As Double = 0
        Dim monthCounter As Integer = 0
        Dim monthlyPayment As Double

        'Set of conditional statments to try and parse text entered
        'or display an error message if there is a problem for each individual one
        If (Double.TryParse(txtInterestRate.Text, monthlyInterest)) Then
            If (Double.TryParse(txtBorrowed.Text, amountOwed)) Then
                If (Double.TryParse(txtMonthlyPayment.Text, monthlyPayment)) Then

                    'Calculate the monthly interest as a decimal
                    monthlyInterest /= 100
                    monthlyInterest /= 12

                    'Begin while loop until amount owed is 0
                    While amountOwed > 0

                        'If the monthly interest is as much or more than the payment
                        'then don't accept the input
                        If (amountOwed * monthlyInterest) >= monthlyPayment Then
                            MessageBox.Show("Loan will never be paid. Payments are too low.")
                            Exit Sub
                        End If

                        'Otherwise calculate the new amount with interest
                        amountOwed *= (1 + monthlyInterest)

                        'If the remaining is less than the monthly payment
                        'Then don't take the full payment
                        If amountOwed < monthlyPayment Then
                            totalPaid += amountOwed
                            amountOwed = 0

                            'Otherwise proceed as normal
                        Else
                            amountOwed -= monthlyPayment
                            totalPaid += monthlyPayment
                        End If
                        monthCounter += 1
                    End While
                Else
                    MessageBox.Show("Please enter a valid number for monthly payment")
                    txtMonthlyPayment.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid number for amount borrowed")
                txtBorrowed.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid number for the interest rate.")
            txtInterestRate.Focus()
            Exit Sub
        End If

        'Display the results in the textboxes
        txtTotalPaid.Text = totalPaid.ToString("c")
        txtMonthsToRepay.Text = monthCounter.ToString() + " (" + (monthCounter / 12).ToString("F2") + " years)"
    End Sub

    'Focus handlers for selecting all text
    Private Sub Borrowed_GotFocus(sender As Object, e As EventArgs) _
     Handles txtBorrowed.GotFocus
        txtBorrowed.SelectAll()
    End Sub

    Private Sub Interest_GotFocus(sender As Object, e As EventArgs) _
     Handles txtInterestRate.GotFocus
        txtInterestRate.SelectAll()
    End Sub

    Private Sub Payment_GotFocus(sender As Object, e As EventArgs) _
     Handles txtMonthlyPayment.GotFocus
        txtMonthlyPayment.SelectAll()
    End Sub
End Class

Public Class Form1
    Dim dblTotalListPrice As Double = 0
    Dim dblTotalDiscount As Double = 0
    Dim dblTotalTax As Double = 0
    Dim dblTotalNet As Double = 0
    Const TAX_RATE As Double = 0.05
    Private Sub btnAddToTotals_Click(sender As Object, e As EventArgs) Handles btnAddToTotals.Click
        Dim dblListPrice As Double = 0
        Dim dblDiscount As Double = 0
        Try
            If Not Double.TryParse(txtListPrice.Text, dblListPrice) Or dblListPrice < 0 Then
                MessageBox.Show("Please enter a valid positive number for List Price.")
                txtListPrice.Clear()
                txtListPrice.Focus()
            ElseIf Not Double.TryParse(txtDiscount.Text, dblDiscount) Or dblDiscount < 0 Then
                MessageBox.Show("Please enter a valid positive number for Discount Percentage.")
                txtDiscount.Clear()
                txtDiscount.Focus()
            Else
                dblTotalListPrice += dblListPrice
                lblTotalListPrice.Text = dblTotalListPrice.ToString("c")
                dblDiscount = (dblDiscount / 100) * dblListPrice
                dblTotalDiscount += dblDiscount
                lblTotalDiscAmount.Text = dblTotalDiscount.ToString("c")
                dblTotalTax += (dblTotalListPrice - dblTotalDiscount) * TAX_RATE
                lblTotalTax.Text = dblTotalTax.ToString("c")
                dblTotalNet = dblTotalListPrice - dblTotalDiscount + dblTotalTax
                lblTotalNetPrice.Text = dblTotalNet.ToString("c")
                txtDiscount.Clear()
                txtListPrice.Clear()
                txtListPrice.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Data")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotalDiscAmount.Text = "$0.00"
        lblTotalListPrice.Text = "$0.00"
        lblTotalNetPrice.Text = "$0.00"
        lblTotalTax.Text = "$0.00"
        dblTotalDiscount = 0
        dblTotalListPrice = 0
        dblTotalNet = 0
        dblTotalTax = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Program ended")
        Me.Close()
    End Sub
End Class

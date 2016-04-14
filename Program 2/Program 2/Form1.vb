Public Class Form1
    
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblLength As Double = txtLength.Text
        Dim dblWidth As Double = txtWidth.Text
        Dim dblCoats As Double = txtCoats.Text
        Dim dblPaintCap As Double = txtPaintCap.Text
        Dim dblPaintCost As Double = txtPaintCost.Text
        Dim dblTotalArea As Double = dblLength * dblWidth * dblCoats
        Dim dblGallonsNeeded As Double = Math.Ceiling(dblTotalArea / dblPaintCap) 'Using ceiling function to get whole number paint can requirement
        Dim dblTotalCost As Double = dblGallonsNeeded * dblPaintCost
        lblGallonsNeeded.Text = dblGallonsNeeded.ToString()
        lblTotalCost.Text = dblTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCoats.Clear()
        txtLength.Clear()
        txtPaintCap.Clear()
        txtPaintCost.Clear()
        txtWidth.Clear()
        lblGallonsNeeded.Text = ""
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

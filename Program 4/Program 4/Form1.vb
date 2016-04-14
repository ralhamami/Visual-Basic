Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        lstAddedToppings.Items.Add(lstToppings.SelectedItem)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstAddedToppings.SelectedIndex > -1 Then
            lstAddedToppings.Items.RemoveAt(lstAddedToppings.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove to proceed.")
        End If
    End Sub

    Private Sub btnOrderIn_Click(sender As Object, e As EventArgs) Handles btnOrderIn.Click
        'Var to keep track of total cost
        Dim dblTotal As Double = 0
        'Size button
        Dim rbtnSize As RadioButton =
        grpSize.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)

        'Crust button
        Dim rbtnCrust As RadioButton =
        grpCrust.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)

        'Gather total cost for size
        If rbtnSize.Text = "Small" Then
            dblTotal += 7
        ElseIf rbtnSize.Text = "Medium" Then
            dblTotal += 13
        ElseIf rbtnSize.Text = "Large" Then
            dblTotal += 16.5
        End If

        'Gather total cost for crust
        If rbtnCrust.Text = "Thick" Then
            dblTotal += 1
        ElseIf rbtnCrust.Text = "Pan" Then
            dblTotal += 1.5
        End If

        'Gather Cost for side orders
        dblTotal += (1.5 * clbSideOrders.CheckedItems.Count)

        'Gather Cost for toppings
        dblTotal += (0.5 * lstAddedToppings.Items.Count)

        'Gather Cost for drinks
        Dim numDrinks As Integer
        If (Integer.TryParse(txtDrinks.Text, numDrinks)) Then
            dblTotal += (1.75 * numDrinks)
        End If

        'Display the total cost
        MessageBox.Show("Total: " + dblTotal.ToString("c"))
        clear()
    End Sub

    Private Sub clear()
        rbtnSmall.Checked = True
        rbtnSmall.Checked = True
        SetChecked(clbSideOrders, False)
        lstAddedToppings.Items.Clear()
        txtDrinks.Clear()
    End Sub

    'Borrowed this handy function from www.vb-helper.com for clearing
    'multiple checkboxes at once
    Private Sub SetChecked(ByVal clb As CheckedListBox, ByVal _
    check_items As Boolean)
        For i As Integer = 0 To clb.Items.Count - 1
            clb.SetItemChecked(i, check_items)
        Next i
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        MessageBox.Show("All ingredients are fresh when the pizza is delivered and if you " +
                        "have any questions about the amount of fat, salt, or calories in " +
                        "the pizza then you probably should not order one.")
    End Sub
End Class

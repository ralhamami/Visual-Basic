Public Class frmCookies
    Dim intCustomerNumber As Integer = 0
    Public lstName As New List(Of String)
    Public lstTelephone As New List(Of String)
    Public lstHomeAddress As New List(Of String)
    Public lstOrdered As New List(Of String)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' id lbl converted to integer and used as the subscript for lists
        Dim intIndex As Integer = CInt(lblCustomerNumberDisplay.Text)
        txtCustomerName.Text = txtCustomerName.Text.Trim()
        txtTelephone.Text = txtTelephone.Text.Trim()
        txtHomeAddress.Text = txtHomeAddress.Text.Trim()
        txtOrder.Text = txtOrder.Text.Trim()
        ' checks to see if data is present
        If txtCustomerName.Text = "" Then
            MessageBox.Show("Customer Name is missing!", "ERROR")
            txtCustomerName.Focus()
            Exit Sub
        ElseIf txtTelephone.Text = "" Then
            MessageBox.Show("Telephone Number is missing!", "ERROR")
            txtTelephone.Focus()
            Exit Sub
        End If

        ' The data in the textboxes are stored in their lists, using the subscript from the ID label
        lstName.Insert(intIndex, txtCustomerName.Text)
        lstTelephone.Insert(intIndex, txtTelephone.Text)
        lstHomeAddress.Insert(intIndex, txtHomeAddress.Text)
        lstOrdered.Insert(intIndex, txtOrder.Text)
        ' The other three buttons are enabled
        btnFindName.Enabled = True
        btnFindPhone.Enabled = True
        btnNew.Enabled = True
        ' The focus is set to the 'New' Button
        btnNew.Focus()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' lsts should be prepared to receive new values
        ' The value in the ID label is set to the subscrit to be used for the new st values that will be stored later, when save button is clicked
        intCustomerNumber += 1
        lblCustomerNumberDisplay.Text = intCustomerNumber.ToString()
        ' The contents of the textboxes should be cleared
        txtCustomerName.Clear()
        txtTelephone.Clear()
        txtHomeAddress.Clear()
        txtOrder.Clear()
        ' The New, Find Name, and Find Phone buttons should be disabled
        btnNew.Enabled = False
        btnFindName.Enabled = False
        btnFindPhone.Enabled = False
        ' The focus is set to the customer name textbox
        txtCustomerName.Focus()
    End Sub
    Private Sub btnFindPhone_Click(sender As Object, e As EventArgs) Handles btnFindPhone.Click
        txtTelephone.Text = txtTelephone.Text.Trim()
        find(lstTelephone, txtTelephone.Text, "telephone")
    End Sub
    Private Sub btnFindName_Click(sender As Object, e As EventArgs) Handles btnFindName.Click
        txtCustomerName.Text = txtCustomerName.Text.Trim()
        find(lstName, txtCustomerName.Text, "name")
    End Sub
    Private Sub frmCookies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustomerNumberDisplay.Text = intCustomerNumber.ToString()
    End Sub
    Private Sub find(ByRef lst As List(Of String), ByRef str As String, ByRef checker As String)
        Dim foundAt As Integer
        foundAt = lst.IndexOf(str)
        If foundAt <> -1 Then
            txtCustomerName.Text = lstName(foundAt)
            txtTelephone.Text = lstTelephone(foundAt)
            txtHomeAddress.Text = lstHomeAddress(foundAt)
            txtOrder.Text = lstOrdered(foundAt)
            lblCustomerNumberDisplay.Text = foundAt.ToString()
        Else
            MessageBox.Show("No match was found!", "ERROR")
            If checker = "telephone" Then
                txtTelephone.Focus()
                txtTelephone.SelectAll()
            ElseIf checker = "name" Then
                txtCustomerName.Focus()
                txtCustomerName.SelectAll()
            End If
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblCustomerNumber_Click(sender As Object, e As EventArgs) Handles lblCustomerNumber.Click

    End Sub

    Private Sub lblCustomerName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub

    Private Sub txtHomeAddress_TextChanged(sender As Object, e As EventArgs) Handles txtHomeAddress.TextChanged

    End Sub

    Private Sub lblHomeAddress_Click(sender As Object, e As EventArgs) Handles lblHomeAddress.Click

    End Sub

    Private Sub lblOrder_Click(sender As Object, e As EventArgs) Handles lblOrder.Click

    End Sub

    Private Sub lblCustomerNumberDisplay_Click(sender As Object, e As EventArgs) Handles lblCustomerNumberDisplay.Click

    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged

    End Sub

    Private Sub txtOrder_TextChanged(sender As Object, e As EventArgs) Handles txtOrder.TextChanged

    End Sub

    Private Sub lblTelephone_Click(sender As Object, e As EventArgs) Handles lblTelephone.Click

    End Sub
End Class

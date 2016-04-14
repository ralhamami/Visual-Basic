<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCookies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerNumberDisplay = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFindPhone = New System.Windows.Forms.Button()
        Me.btnFindName = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblHomeAddress = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerNumber = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(259, 339)
        Me.txtOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(296, 22)
        Me.txtOrder.TabIndex = 40
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Location = New System.Drawing.Point(259, 259)
        Me.txtHomeAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHomeAddress.Multiline = True
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(296, 72)
        Me.txtHomeAddress.TabIndex = 39
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(259, 227)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(296, 22)
        Me.txtTelephone.TabIndex = 38
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(259, 195)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(296, 22)
        Me.txtCustomerName.TabIndex = 37
        '
        'lblCustomerNumberDisplay
        '
        Me.lblCustomerNumberDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.lblCustomerNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomerNumberDisplay.Location = New System.Drawing.Point(259, 167)
        Me.lblCustomerNumberDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerNumberDisplay.Name = "lblCustomerNumberDisplay"
        Me.lblCustomerNumberDisplay.Size = New System.Drawing.Size(297, 25)
        Me.lblCustomerNumberDisplay.TabIndex = 36
        Me.lblCustomerNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(471, 388)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFindPhone
        '
        Me.btnFindPhone.Enabled = False
        Me.btnFindPhone.Location = New System.Drawing.Point(343, 388)
        Me.btnFindPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindPhone.Name = "btnFindPhone"
        Me.btnFindPhone.Size = New System.Drawing.Size(100, 28)
        Me.btnFindPhone.TabIndex = 44
        Me.btnFindPhone.Text = "Find &Phone"
        Me.btnFindPhone.UseVisualStyleBackColor = True
        '
        'btnFindName
        '
        Me.btnFindName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnFindName.Enabled = False
        Me.btnFindName.Location = New System.Drawing.Point(220, 388)
        Me.btnFindName.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindName.Name = "btnFindName"
        Me.btnFindName.Size = New System.Drawing.Size(100, 28)
        Me.btnFindName.TabIndex = 43
        Me.btnFindName.Text = "Find N&ame"
        Me.btnFindName.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Enabled = False
        Me.btnNew.Location = New System.Drawing.Point(95, 388)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 28)
        Me.btnNew.TabIndex = 42
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(96, 343)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(45, 17)
        Me.lblOrder.TabIndex = 50
        Me.lblOrder.Text = "&Order"
        '
        'lblHomeAddress
        '
        Me.lblHomeAddress.AutoSize = True
        Me.lblHomeAddress.Location = New System.Drawing.Point(96, 263)
        Me.lblHomeAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHomeAddress.Name = "lblHomeAddress"
        Me.lblHomeAddress.Size = New System.Drawing.Size(101, 17)
        Me.lblHomeAddress.TabIndex = 49
        Me.lblHomeAddress.Text = "&Home Address"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(96, 231)
        Me.lblTelephone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(76, 17)
        Me.lblTelephone.TabIndex = 48
        Me.lblTelephone.Text = "&Telephone"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(96, 199)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(109, 17)
        Me.lblCustomerName.TabIndex = 47
        Me.lblCustomerName.Text = "&Customer Name"
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.Location = New System.Drawing.Point(96, 172)
        Me.lblCustomerNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(122, 17)
        Me.lblCustomerNumber.TabIndex = 46
        Me.lblCustomerNumber.Text = "Customer Number"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(83, 121)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 31)
        Me.lblTitle.TabIndex = 45
        Me.lblTitle.Text = "Girl Scout Thin Mint Cookies"
        '
        'frmCookies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 537)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.txtHomeAddress)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerNumberDisplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFindPhone)
        Me.Controls.Add(Me.btnFindName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblHomeAddress)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCookies"
        Me.Text = "Cookies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtOrder As System.Windows.Forms.TextBox
    Private WithEvents txtHomeAddress As System.Windows.Forms.TextBox
    Private WithEvents txtTelephone As System.Windows.Forms.TextBox
    Private WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Private WithEvents lblCustomerNumberDisplay As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnFindPhone As System.Windows.Forms.Button
    Private WithEvents btnFindName As System.Windows.Forms.Button
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents lblOrder As System.Windows.Forms.Label
    Private WithEvents lblHomeAddress As System.Windows.Forms.Label
    Private WithEvents lblTelephone As System.Windows.Forms.Label
    Private WithEvents lblCustomerName As System.Windows.Forms.Label
    Private WithEvents lblCustomerNumber As System.Windows.Forms.Label
    Private WithEvents lblTitle As System.Windows.Forms.Label

End Class

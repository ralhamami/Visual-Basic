<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtListPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalListPrice = New System.Windows.Forms.Label()
        Me.lblTotalDiscAmount = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.lblTotalNetPrice = New System.Windows.Forms.Label()
        Me.btnAddToTotals = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount %"
        '
        'txtListPrice
        '
        Me.txtListPrice.Location = New System.Drawing.Point(68, 18)
        Me.txtListPrice.Name = "txtListPrice"
        Me.txtListPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtListPrice.TabIndex = 2
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(68, 52)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total List Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Discount Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Net Price:"
        '
        'lblTotalListPrice
        '
        Me.lblTotalListPrice.Location = New System.Drawing.Point(126, 130)
        Me.lblTotalListPrice.Name = "lblTotalListPrice"
        Me.lblTotalListPrice.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalListPrice.TabIndex = 8
        Me.lblTotalListPrice.Text = "$0.00"
        '
        'lblTotalDiscAmount
        '
        Me.lblTotalDiscAmount.Location = New System.Drawing.Point(126, 153)
        Me.lblTotalDiscAmount.Name = "lblTotalDiscAmount"
        Me.lblTotalDiscAmount.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalDiscAmount.TabIndex = 9
        Me.lblTotalDiscAmount.Text = "$0.00"
        '
        'lblTotalTax
        '
        Me.lblTotalTax.Location = New System.Drawing.Point(126, 176)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalTax.TabIndex = 10
        Me.lblTotalTax.Text = "$0.00"
        '
        'lblTotalNetPrice
        '
        Me.lblTotalNetPrice.Location = New System.Drawing.Point(126, 199)
        Me.lblTotalNetPrice.Name = "lblTotalNetPrice"
        Me.lblTotalNetPrice.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalNetPrice.TabIndex = 11
        Me.lblTotalNetPrice.Text = "$0.00"
        '
        'btnAddToTotals
        '
        Me.btnAddToTotals.Location = New System.Drawing.Point(174, 18)
        Me.btnAddToTotals.Name = "btnAddToTotals"
        Me.btnAddToTotals.Size = New System.Drawing.Size(97, 23)
        Me.btnAddToTotals.TabIndex = 12
        Me.btnAddToTotals.Text = "&Add to Totals"
        Me.btnAddToTotals.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(174, 47)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(174, 76)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAddToTotals
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddToTotals)
        Me.Controls.Add(Me.lblTotalNetPrice)
        Me.Controls.Add(Me.lblTotalTax)
        Me.Controls.Add(Me.lblTotalDiscAmount)
        Me.Controls.Add(Me.lblTotalListPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtListPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "$0.00"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtListPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalListPrice As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiscAmount As System.Windows.Forms.Label
    Friend WithEvents lblTotalTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalNetPrice As System.Windows.Forms.Label
    Friend WithEvents btnAddToTotals As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

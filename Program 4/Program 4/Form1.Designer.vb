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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rbtnLarge = New System.Windows.Forms.RadioButton()
        Me.rbtnMedium = New System.Windows.Forms.RadioButton()
        Me.rbtnSmall = New System.Windows.Forms.RadioButton()
        Me.grpCrust = New System.Windows.Forms.GroupBox()
        Me.rbtnPan = New System.Windows.Forms.RadioButton()
        Me.rbtnThick = New System.Windows.Forms.RadioButton()
        Me.rbtnThin = New System.Windows.Forms.RadioButton()
        Me.lstToppings = New System.Windows.Forms.ListBox()
        Me.lstAddedToppings = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.btnOrderIn = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clbSideOrders = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpSize.SuspendLayout()
        Me.grpCrust.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rbtnLarge)
        Me.grpSize.Controls.Add(Me.rbtnMedium)
        Me.grpSize.Controls.Add(Me.rbtnSmall)
        Me.grpSize.Location = New System.Drawing.Point(12, 12)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(200, 89)
        Me.grpSize.TabIndex = 0
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Select Size"
        '
        'rbtnLarge
        '
        Me.rbtnLarge.AutoSize = True
        Me.rbtnLarge.Location = New System.Drawing.Point(7, 66)
        Me.rbtnLarge.Name = "rbtnLarge"
        Me.rbtnLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbtnLarge.TabIndex = 2
        Me.rbtnLarge.TabStop = True
        Me.rbtnLarge.Text = "Large"
        Me.rbtnLarge.UseVisualStyleBackColor = True
        '
        'rbtnMedium
        '
        Me.rbtnMedium.AutoSize = True
        Me.rbtnMedium.Location = New System.Drawing.Point(7, 43)
        Me.rbtnMedium.Name = "rbtnMedium"
        Me.rbtnMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbtnMedium.TabIndex = 1
        Me.rbtnMedium.TabStop = True
        Me.rbtnMedium.Text = "Medium"
        Me.rbtnMedium.UseVisualStyleBackColor = True
        '
        'rbtnSmall
        '
        Me.rbtnSmall.AutoSize = True
        Me.rbtnSmall.Checked = True
        Me.rbtnSmall.Location = New System.Drawing.Point(7, 20)
        Me.rbtnSmall.Name = "rbtnSmall"
        Me.rbtnSmall.Size = New System.Drawing.Size(50, 17)
        Me.rbtnSmall.TabIndex = 0
        Me.rbtnSmall.TabStop = True
        Me.rbtnSmall.Text = "Small"
        Me.rbtnSmall.UseVisualStyleBackColor = True
        '
        'grpCrust
        '
        Me.grpCrust.Controls.Add(Me.rbtnPan)
        Me.grpCrust.Controls.Add(Me.rbtnThick)
        Me.grpCrust.Controls.Add(Me.rbtnThin)
        Me.grpCrust.Location = New System.Drawing.Point(12, 107)
        Me.grpCrust.Name = "grpCrust"
        Me.grpCrust.Size = New System.Drawing.Size(200, 89)
        Me.grpCrust.TabIndex = 3
        Me.grpCrust.TabStop = False
        Me.grpCrust.Text = "Select Crust"
        '
        'rbtnPan
        '
        Me.rbtnPan.AutoSize = True
        Me.rbtnPan.Location = New System.Drawing.Point(7, 66)
        Me.rbtnPan.Name = "rbtnPan"
        Me.rbtnPan.Size = New System.Drawing.Size(44, 17)
        Me.rbtnPan.TabIndex = 2
        Me.rbtnPan.TabStop = True
        Me.rbtnPan.Text = "Pan"
        Me.rbtnPan.UseVisualStyleBackColor = True
        '
        'rbtnThick
        '
        Me.rbtnThick.AutoSize = True
        Me.rbtnThick.Location = New System.Drawing.Point(7, 43)
        Me.rbtnThick.Name = "rbtnThick"
        Me.rbtnThick.Size = New System.Drawing.Size(52, 17)
        Me.rbtnThick.TabIndex = 1
        Me.rbtnThick.TabStop = True
        Me.rbtnThick.Text = "Thick"
        Me.rbtnThick.UseVisualStyleBackColor = True
        '
        'rbtnThin
        '
        Me.rbtnThin.AutoSize = True
        Me.rbtnThin.Checked = True
        Me.rbtnThin.Location = New System.Drawing.Point(7, 20)
        Me.rbtnThin.Name = "rbtnThin"
        Me.rbtnThin.Size = New System.Drawing.Size(46, 17)
        Me.rbtnThin.TabIndex = 0
        Me.rbtnThin.TabStop = True
        Me.rbtnThin.Text = "Thin"
        Me.rbtnThin.UseVisualStyleBackColor = True
        '
        'lstToppings
        '
        Me.lstToppings.FormattingEnabled = True
        Me.lstToppings.Items.AddRange(New Object() {"Bacon", "Black Olives", "Green Olives", "Green Peppers", "Hamburger", "Mushrooms", "Onions", "Sausage"})
        Me.lstToppings.Location = New System.Drawing.Point(218, 28)
        Me.lstToppings.Name = "lstToppings"
        Me.lstToppings.Size = New System.Drawing.Size(177, 95)
        Me.lstToppings.TabIndex = 5
        '
        'lstAddedToppings
        '
        Me.lstAddedToppings.FormattingEnabled = True
        Me.lstAddedToppings.Location = New System.Drawing.Point(219, 147)
        Me.lstAddedToppings.Name = "lstAddedToppings"
        Me.lstAddedToppings.Size = New System.Drawing.Size(177, 95)
        Me.lstAddedToppings.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Toppings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Toppings Added"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(402, 28)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 35)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "Add Topping"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(402, 147)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(75, 38)
        Me.btnRemoveItem.TabIndex = 10
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Drinks"
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(218, 265)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(100, 20)
        Me.txtDrinks.TabIndex = 12
        Me.txtDrinks.Text = "0"
        '
        'btnOrderIn
        '
        Me.btnOrderIn.Location = New System.Drawing.Point(158, 312)
        Me.btnOrderIn.Name = "btnOrderIn"
        Me.btnOrderIn.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderIn.TabIndex = 13
        Me.btnOrderIn.Text = "Order In"
        Me.btnOrderIn.UseVisualStyleBackColor = True
        '
        'btnAboutUs
        '
        Me.btnAboutUs.Location = New System.Drawing.Point(256, 312)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(75, 23)
        Me.btnAboutUs.TabIndex = 14
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Program_4.My.Resources.Resources.happy_pizza_slice_character_38182832__2_
        Me.PictureBox1.Location = New System.Drawing.Point(377, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'clbSideOrders
        '
        Me.clbSideOrders.BackColor = System.Drawing.SystemColors.Control
        Me.clbSideOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbSideOrders.FormattingEnabled = True
        Me.clbSideOrders.Items.AddRange(New Object() {"Cheese Bread", "Salad", "Fried Cheese Sticks"})
        Me.clbSideOrders.Location = New System.Drawing.Point(12, 212)
        Me.clbSideOrders.Name = "clbSideOrders"
        Me.clbSideOrders.Size = New System.Drawing.Size(200, 60)
        Me.clbSideOrders.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Side Orders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 347)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clbSideOrders)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAboutUs)
        Me.Controls.Add(Me.btnOrderIn)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAddedToppings)
        Me.Controls.Add(Me.lstToppings)
        Me.Controls.Add(Me.grpCrust)
        Me.Controls.Add(Me.grpSize)
        Me.Name = "Form1"
        Me.Text = "Happy's Pizza"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpCrust.ResumeLayout(False)
        Me.grpCrust.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSmall As System.Windows.Forms.RadioButton
    Friend WithEvents grpCrust As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPan As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnThick As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnThin As System.Windows.Forms.RadioButton
    Friend WithEvents grpSideOrders As System.Windows.Forms.GroupBox
    Friend WithEvents chkFriedCheeseSticks As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalad As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheeseBread As System.Windows.Forms.CheckBox
    Friend WithEvents lstToppings As System.Windows.Forms.ListBox
    Friend WithEvents lstAddedToppings As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDrinks As System.Windows.Forms.TextBox
    Friend WithEvents btnOrderIn As System.Windows.Forms.Button
    Friend WithEvents btnAboutUs As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents clbSideOrders As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

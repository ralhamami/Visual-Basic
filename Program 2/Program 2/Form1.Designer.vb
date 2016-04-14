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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtCoats = New System.Windows.Forms.TextBox()
        Me.txtPaintCap = New System.Windows.Forms.TextBox()
        Me.txtPaintCost = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblCoats = New System.Windows.Forms.Label()
        Me.lblPaintCap = New System.Windows.Forms.Label()
        Me.lblPaintCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGallonRequirement = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblGallonsNeeded = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(142, 13)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 1
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(142, 39)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 3
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCoats
        '
        Me.txtCoats.Location = New System.Drawing.Point(142, 65)
        Me.txtCoats.Name = "txtCoats"
        Me.txtCoats.Size = New System.Drawing.Size(100, 20)
        Me.txtCoats.TabIndex = 5
        Me.txtCoats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaintCap
        '
        Me.txtPaintCap.Location = New System.Drawing.Point(142, 91)
        Me.txtPaintCap.Name = "txtPaintCap"
        Me.txtPaintCap.Size = New System.Drawing.Size(100, 20)
        Me.txtPaintCap.TabIndex = 7
        Me.txtPaintCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaintCost
        '
        Me.txtPaintCost.Location = New System.Drawing.Point(142, 117)
        Me.txtPaintCost.Name = "txtPaintCost"
        Me.txtPaintCost.Size = New System.Drawing.Size(100, 20)
        Me.txtPaintCost.TabIndex = 9
        Me.txtPaintCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(99, 19)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "&Length"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(104, 46)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "&Width"
        '
        'lblCoats
        '
        Me.lblCoats.AutoSize = True
        Me.lblCoats.Location = New System.Drawing.Point(83, 72)
        Me.lblCoats.Name = "lblCoats"
        Me.lblCoats.Size = New System.Drawing.Size(56, 13)
        Me.lblCoats.TabIndex = 4
        Me.lblCoats.Text = "&# of Coats"
        '
        'lblPaintCap
        '
        Me.lblPaintCap.AutoSize = True
        Me.lblPaintCap.Location = New System.Drawing.Point(52, 98)
        Me.lblPaintCap.Name = "lblPaintCap"
        Me.lblPaintCap.Size = New System.Drawing.Size(87, 13)
        Me.lblPaintCap.TabIndex = 6
        Me.lblPaintCap.Text = "&Paint Sq. Ft. Cap"
        '
        'lblPaintCost
        '
        Me.lblPaintCost.AutoSize = True
        Me.lblPaintCost.Location = New System.Drawing.Point(43, 124)
        Me.lblPaintCost.Name = "lblPaintCost"
        Me.lblPaintCost.Size = New System.Drawing.Size(96, 13)
        Me.lblPaintCost.TabIndex = 8
        Me.lblPaintCost.Text = "Cost of One &Gallon"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 228)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(105, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGallonRequirement
        '
        Me.lblGallonRequirement.AutoSize = True
        Me.lblGallonRequirement.Location = New System.Drawing.Point(56, 159)
        Me.lblGallonRequirement.Name = "lblGallonRequirement"
        Me.lblGallonRequirement.Size = New System.Drawing.Size(83, 13)
        Me.lblGallonRequirement.TabIndex = 10
        Me.lblGallonRequirement.Text = "Gallons &Needed"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(84, 190)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(55, 13)
        Me.lblGrandTotal.TabIndex = 12
        Me.lblGrandTotal.Text = "&Total Cost"
        '
        'lblGallonsNeeded
        '
        Me.lblGallonsNeeded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGallonsNeeded.Location = New System.Drawing.Point(142, 155)
        Me.lblGallonsNeeded.Name = "lblGallonsNeeded"
        Me.lblGallonsNeeded.Size = New System.Drawing.Size(100, 20)
        Me.lblGallonsNeeded.TabIndex = 11
        Me.lblGallonsNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(142, 186)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalCost.TabIndex = 13
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(284, 260)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblGallonsNeeded)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblGallonRequirement)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPaintCost)
        Me.Controls.Add(Me.lblPaintCap)
        Me.Controls.Add(Me.lblCoats)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtPaintCost)
        Me.Controls.Add(Me.txtPaintCap)
        Me.Controls.Add(Me.txtCoats)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Name = "Form1"
        Me.Text = "Program 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtCoats As System.Windows.Forms.TextBox
    Friend WithEvents txtPaintCap As System.Windows.Forms.TextBox
    Friend WithEvents txtPaintCost As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblCoats As System.Windows.Forms.Label
    Friend WithEvents lblPaintCap As System.Windows.Forms.Label
    Friend WithEvents lblPaintCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblGallonRequirement As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblGallonsNeeded As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class

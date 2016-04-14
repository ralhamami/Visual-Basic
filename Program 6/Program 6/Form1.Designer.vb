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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtLength1 = New System.Windows.Forms.TextBox()
        Me.chkInstall1 = New System.Windows.Forms.CheckBox()
        Me.chkFinish1 = New System.Windows.Forms.CheckBox()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.chkFinish2 = New System.Windows.Forms.CheckBox()
        Me.chkInstall2 = New System.Windows.Forms.CheckBox()
        Me.txtLength2 = New System.Windows.Forms.TextBox()
        Me.lblTotal3 = New System.Windows.Forms.Label()
        Me.chkFinish3 = New System.Windows.Forms.CheckBox()
        Me.chkInstall3 = New System.Windows.Forms.CheckBox()
        Me.txtLength3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtWidth1 = New System.Windows.Forms.TextBox()
        Me.txtWidth2 = New System.Windows.Forms.TextBox()
        Me.txtWidth3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLength1
        '
        Me.txtLength1.Location = New System.Drawing.Point(70, 102)
        Me.txtLength1.Name = "txtLength1"
        Me.txtLength1.Size = New System.Drawing.Size(100, 20)
        Me.txtLength1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtLength1, "Enter length in feet")
        '
        'chkInstall1
        '
        Me.chkInstall1.AutoSize = True
        Me.chkInstall1.Location = New System.Drawing.Point(289, 104)
        Me.chkInstall1.Name = "chkInstall1"
        Me.chkInstall1.Size = New System.Drawing.Size(82, 17)
        Me.chkInstall1.TabIndex = 2
        Me.chkInstall1.Text = "Installation?"
        Me.ToolTip1.SetToolTip(Me.chkInstall1, "Check if installation is needed")
        Me.chkInstall1.UseVisualStyleBackColor = True
        '
        'chkFinish1
        '
        Me.chkFinish1.AutoSize = True
        Me.chkFinish1.Location = New System.Drawing.Point(376, 104)
        Me.chkFinish1.Name = "chkFinish1"
        Me.chkFinish1.Size = New System.Drawing.Size(59, 17)
        Me.chkFinish1.TabIndex = 3
        Me.chkFinish1.Text = "Finish?"
        Me.ToolTip1.SetToolTip(Me.chkFinish1, "Check if sanding and staining is needed")
        Me.chkFinish1.UseVisualStyleBackColor = True
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Location = New System.Drawing.Point(447, 106)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal1.TabIndex = 3
        Me.lblTotal1.Text = "$0.00"
        '
        'lblTotal2
        '
        Me.lblTotal2.AutoSize = True
        Me.lblTotal2.Location = New System.Drawing.Point(447, 144)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal2.TabIndex = 7
        Me.lblTotal2.Text = "$0.00"
        '
        'chkFinish2
        '
        Me.chkFinish2.AutoSize = True
        Me.chkFinish2.Location = New System.Drawing.Point(376, 142)
        Me.chkFinish2.Name = "chkFinish2"
        Me.chkFinish2.Size = New System.Drawing.Size(59, 17)
        Me.chkFinish2.TabIndex = 7
        Me.chkFinish2.Text = "Finish?"
        Me.ToolTip1.SetToolTip(Me.chkFinish2, "Check if sanding and staining is needed")
        Me.chkFinish2.UseVisualStyleBackColor = True
        '
        'chkInstall2
        '
        Me.chkInstall2.AutoSize = True
        Me.chkInstall2.Location = New System.Drawing.Point(289, 142)
        Me.chkInstall2.Name = "chkInstall2"
        Me.chkInstall2.Size = New System.Drawing.Size(82, 17)
        Me.chkInstall2.TabIndex = 6
        Me.chkInstall2.Text = "Installation?"
        Me.ToolTip1.SetToolTip(Me.chkInstall2, "Check if installation is needed")
        Me.chkInstall2.UseVisualStyleBackColor = True
        '
        'txtLength2
        '
        Me.txtLength2.Location = New System.Drawing.Point(70, 140)
        Me.txtLength2.Name = "txtLength2"
        Me.txtLength2.Size = New System.Drawing.Size(100, 20)
        Me.txtLength2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtLength2, "Enter length in feet")
        '
        'lblTotal3
        '
        Me.lblTotal3.AutoSize = True
        Me.lblTotal3.Location = New System.Drawing.Point(447, 180)
        Me.lblTotal3.Name = "lblTotal3"
        Me.lblTotal3.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal3.TabIndex = 11
        Me.lblTotal3.Text = "$0.00"
        '
        'chkFinish3
        '
        Me.chkFinish3.AutoSize = True
        Me.chkFinish3.Location = New System.Drawing.Point(376, 178)
        Me.chkFinish3.Name = "chkFinish3"
        Me.chkFinish3.Size = New System.Drawing.Size(59, 17)
        Me.chkFinish3.TabIndex = 11
        Me.chkFinish3.Text = "Finish?"
        Me.ToolTip1.SetToolTip(Me.chkFinish3, "Check if sanding and staining is needed")
        Me.chkFinish3.UseVisualStyleBackColor = True
        '
        'chkInstall3
        '
        Me.chkInstall3.AutoSize = True
        Me.chkInstall3.Location = New System.Drawing.Point(289, 178)
        Me.chkInstall3.Name = "chkInstall3"
        Me.chkInstall3.Size = New System.Drawing.Size(82, 17)
        Me.chkInstall3.TabIndex = 10
        Me.chkInstall3.Text = "Installation?"
        Me.ToolTip1.SetToolTip(Me.chkInstall3, "Check if installation is needed")
        Me.chkInstall3.UseVisualStyleBackColor = True
        '
        'txtLength3
        '
        Me.txtLength3.Location = New System.Drawing.Point(70, 176)
        Me.txtLength3.Name = "txtLength3"
        Me.txtLength3.Size = New System.Drawing.Size(100, 20)
        Me.txtLength3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtLength3, "Enter length in feet")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Room 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Room 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Room 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to calculate cost")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(277, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Grand Total: "
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(352, 226)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblGrandTotal.TabIndex = 17
        Me.lblGrandTotal.Text = "$0.00"
        '
        'txtWidth1
        '
        Me.txtWidth1.Location = New System.Drawing.Point(176, 101)
        Me.txtWidth1.Name = "txtWidth1"
        Me.txtWidth1.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtWidth1, "Enter width in feet")
        '
        'txtWidth2
        '
        Me.txtWidth2.Location = New System.Drawing.Point(176, 139)
        Me.txtWidth2.Name = "txtWidth2"
        Me.txtWidth2.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtWidth2, "Enter width in feet")
        '
        'txtWidth3
        '
        Me.txtWidth3.Location = New System.Drawing.Point(176, 175)
        Me.txtWidth3.Name = "txtWidth3"
        Me.txtWidth3.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth3.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtWidth3, "Enter width in feet")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Length"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Width"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Total"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(513, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtWidth3)
        Me.Controls.Add(Me.txtWidth2)
        Me.Controls.Add(Me.txtWidth1)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal3)
        Me.Controls.Add(Me.chkFinish3)
        Me.Controls.Add(Me.chkInstall3)
        Me.Controls.Add(Me.txtLength3)
        Me.Controls.Add(Me.lblTotal2)
        Me.Controls.Add(Me.chkFinish2)
        Me.Controls.Add(Me.chkInstall2)
        Me.Controls.Add(Me.txtLength2)
        Me.Controls.Add(Me.lblTotal1)
        Me.Controls.Add(Me.chkFinish1)
        Me.Controls.Add(Me.chkInstall1)
        Me.Controls.Add(Me.txtLength1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLength1 As System.Windows.Forms.TextBox
    Friend WithEvents chkInstall1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkFinish1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal2 As System.Windows.Forms.Label
    Friend WithEvents chkFinish2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkInstall2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLength2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal3 As System.Windows.Forms.Label
    Friend WithEvents chkFinish3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkInstall3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLength3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtWidth1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

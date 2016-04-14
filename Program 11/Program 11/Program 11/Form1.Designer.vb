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
        Me.lstStudent = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblTest3 = New System.Windows.Forms.Label()
        Me.lblTest2 = New System.Windows.Forms.Label()
        Me.lblTest1 = New System.Windows.Forms.Label()
        Me.txtPossible_T3 = New System.Windows.Forms.TextBox()
        Me.txtPossible_T2 = New System.Windows.Forms.TextBox()
        Me.txtPossible_T1 = New System.Windows.Forms.TextBox()
        Me.txtEarned_T3 = New System.Windows.Forms.TextBox()
        Me.txtEarned_T2 = New System.Windows.Forms.TextBox()
        Me.txtEarned_T1 = New System.Windows.Forms.TextBox()
        Me.lblPointsPossible = New System.Windows.Forms.Label()
        Me.lblPointsEarned = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstStudent
        '
        Me.lstStudent.FormattingEnabled = True
        Me.lstStudent.ItemHeight = 16
        Me.lstStudent.Location = New System.Drawing.Point(308, 312)
        Me.lstStudent.Name = "lstStudent"
        Me.lstStudent.Size = New System.Drawing.Size(150, 132)
        Me.lstStudent.TabIndex = 47
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(475, 269)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 27)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Enabled = False
        Me.btnFind.Location = New System.Drawing.Point(335, 269)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(96, 27)
        Me.btnFind.TabIndex = 42
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(195, 269)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 27)
        Me.btnNew.TabIndex = 43
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblTest3
        '
        Me.lblTest3.AutoSize = True
        Me.lblTest3.Location = New System.Drawing.Point(566, 128)
        Me.lblTest3.Name = "lblTest3"
        Me.lblTest3.Size = New System.Drawing.Size(48, 17)
        Me.lblTest3.TabIndex = 46
        Me.lblTest3.Text = "Test 3"
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.Location = New System.Drawing.Point(393, 128)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(48, 17)
        Me.lblTest2.TabIndex = 45
        Me.lblTest2.Text = "Test 2"
        '
        'lblTest1
        '
        Me.lblTest1.AutoSize = True
        Me.lblTest1.Location = New System.Drawing.Point(220, 128)
        Me.lblTest1.Name = "lblTest1"
        Me.lblTest1.Size = New System.Drawing.Size(48, 17)
        Me.lblTest1.TabIndex = 44
        Me.lblTest1.Text = "Test 1"
        '
        'txtPossible_T3
        '
        Me.txtPossible_T3.Enabled = False
        Me.txtPossible_T3.Location = New System.Drawing.Point(541, 209)
        Me.txtPossible_T3.Name = "txtPossible_T3"
        Me.txtPossible_T3.Size = New System.Drawing.Size(100, 22)
        Me.txtPossible_T3.TabIndex = 40
        Me.txtPossible_T3.Text = "0"
        Me.txtPossible_T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPossible_T2
        '
        Me.txtPossible_T2.Enabled = False
        Me.txtPossible_T2.Location = New System.Drawing.Point(369, 209)
        Me.txtPossible_T2.Name = "txtPossible_T2"
        Me.txtPossible_T2.Size = New System.Drawing.Size(100, 22)
        Me.txtPossible_T2.TabIndex = 38
        Me.txtPossible_T2.Text = "0"
        Me.txtPossible_T2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPossible_T1
        '
        Me.txtPossible_T1.Enabled = False
        Me.txtPossible_T1.Location = New System.Drawing.Point(197, 209)
        Me.txtPossible_T1.Name = "txtPossible_T1"
        Me.txtPossible_T1.Size = New System.Drawing.Size(100, 22)
        Me.txtPossible_T1.TabIndex = 35
        Me.txtPossible_T1.Text = "0"
        Me.txtPossible_T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEarned_T3
        '
        Me.txtEarned_T3.Enabled = False
        Me.txtEarned_T3.Location = New System.Drawing.Point(541, 160)
        Me.txtEarned_T3.Name = "txtEarned_T3"
        Me.txtEarned_T3.Size = New System.Drawing.Size(100, 22)
        Me.txtEarned_T3.TabIndex = 39
        Me.txtEarned_T3.Text = "0"
        Me.txtEarned_T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEarned_T2
        '
        Me.txtEarned_T2.Enabled = False
        Me.txtEarned_T2.Location = New System.Drawing.Point(369, 160)
        Me.txtEarned_T2.Name = "txtEarned_T2"
        Me.txtEarned_T2.Size = New System.Drawing.Size(100, 22)
        Me.txtEarned_T2.TabIndex = 37
        Me.txtEarned_T2.Text = "0"
        Me.txtEarned_T2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEarned_T1
        '
        Me.txtEarned_T1.Enabled = False
        Me.txtEarned_T1.Location = New System.Drawing.Point(197, 160)
        Me.txtEarned_T1.Name = "txtEarned_T1"
        Me.txtEarned_T1.Size = New System.Drawing.Size(100, 22)
        Me.txtEarned_T1.TabIndex = 33
        Me.txtEarned_T1.Text = "0"
        Me.txtEarned_T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPointsPossible
        '
        Me.lblPointsPossible.AutoSize = True
        Me.lblPointsPossible.Location = New System.Drawing.Point(36, 212)
        Me.lblPointsPossible.Name = "lblPointsPossible"
        Me.lblPointsPossible.Size = New System.Drawing.Size(104, 17)
        Me.lblPointsPossible.TabIndex = 36
        Me.lblPointsPossible.Text = "Points Possible"
        '
        'lblPointsEarned
        '
        Me.lblPointsEarned.AutoSize = True
        Me.lblPointsEarned.Location = New System.Drawing.Point(36, 163)
        Me.lblPointsEarned.Name = "lblPointsEarned"
        Me.lblPointsEarned.Size = New System.Drawing.Size(97, 17)
        Me.lblPointsEarned.TabIndex = 34
        Me.lblPointsEarned.Text = "Points Earned"
        '
        'txtStudentName
        '
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.Location = New System.Drawing.Point(245, 71)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(277, 22)
        Me.txtStudentName.TabIndex = 32
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(329, 47)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(98, 17)
        Me.lblStudentName.TabIndex = 31
        Me.lblStudentName.Text = "Student Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 499)
        Me.Controls.Add(Me.lstStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblTest3)
        Me.Controls.Add(Me.lblTest2)
        Me.Controls.Add(Me.lblTest1)
        Me.Controls.Add(Me.txtPossible_T3)
        Me.Controls.Add(Me.txtPossible_T2)
        Me.Controls.Add(Me.txtPossible_T1)
        Me.Controls.Add(Me.txtEarned_T3)
        Me.Controls.Add(Me.txtEarned_T2)
        Me.Controls.Add(Me.txtEarned_T1)
        Me.Controls.Add(Me.lblPointsPossible)
        Me.Controls.Add(Me.lblPointsEarned)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentName)
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstStudent As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblTest3 As System.Windows.Forms.Label
    Friend WithEvents lblTest2 As System.Windows.Forms.Label
    Friend WithEvents lblTest1 As System.Windows.Forms.Label
    Friend WithEvents txtPossible_T3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPossible_T2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPossible_T1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEarned_T3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEarned_T2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEarned_T1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPointsPossible As System.Windows.Forms.Label
    Friend WithEvents lblPointsEarned As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentName As System.Windows.Forms.Label

End Class

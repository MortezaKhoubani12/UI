<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox_Student = New System.Windows.Forms.GroupBox()
        Me.Combo_char = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_Instructor = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Employee = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox_Employee)
        Me.Panel1.Controls.Add(Me.GroupBox_Instructor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Combo_char)
        Me.Panel1.Controls.Add(Me.GroupBox_Student)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 448)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox_Student
        '
        Me.GroupBox_Student.Location = New System.Drawing.Point(294, 30)
        Me.GroupBox_Student.Name = "GroupBox_Student"
        Me.GroupBox_Student.Size = New System.Drawing.Size(208, 404)
        Me.GroupBox_Student.TabIndex = 0
        Me.GroupBox_Student.TabStop = False
        Me.GroupBox_Student.Text = "Student information"
        Me.GroupBox_Student.Visible = False
        '
        'Combo_char
        '
        Me.Combo_char.FormattingEnabled = True
        Me.Combo_char.Items.AddRange(New Object() {"Student", "Instructor", "Employee"})
        Me.Combo_char.Location = New System.Drawing.Point(145, 30)
        Me.Combo_char.Name = "Combo_char"
        Me.Combo_char.Size = New System.Drawing.Size(121, 21)
        Me.Combo_char.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose person:"
        '
        'GroupBox_Instructor
        '
        Me.GroupBox_Instructor.Location = New System.Drawing.Point(294, 30)
        Me.GroupBox_Instructor.Name = "GroupBox_Instructor"
        Me.GroupBox_Instructor.Size = New System.Drawing.Size(208, 404)
        Me.GroupBox_Instructor.TabIndex = 1
        Me.GroupBox_Instructor.TabStop = False
        Me.GroupBox_Instructor.Text = "Instructor information"
        Me.GroupBox_Instructor.Visible = False
        '
        'GroupBox_Employee
        '
        Me.GroupBox_Employee.Location = New System.Drawing.Point(294, 30)
        Me.GroupBox_Employee.Name = "GroupBox_Employee"
        Me.GroupBox_Employee.Size = New System.Drawing.Size(204, 363)
        Me.GroupBox_Employee.TabIndex = 2
        Me.GroupBox_Employee.TabStop = False
        Me.GroupBox_Employee.Text = "Employee information"
        Me.GroupBox_Employee.Visible = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox_Student As GroupBox
    Friend WithEvents Combo_char As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_Instructor As GroupBox
    Friend WithEvents GroupBox_Employee As GroupBox
End Class

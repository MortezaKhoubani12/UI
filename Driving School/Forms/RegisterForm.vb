Public Class RegisterForm
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_char.SelectedIndexChanged
        If Combo_char.Text = "Student" Then
            GroupBox_Student.Visible = True
            GroupBox_Instructor.Visible = False
            GroupBox_Employee.Visible = False
        End If
        If Combo_char.Text = "Instructor" Then
            GroupBox_Instructor.Visible = True
            GroupBox_Student.Visible = False
            GroupBox_Employee.Visible = False
        End If
        If Combo_char.Text = "Employee" Then
            GroupBox_Employee.Visible = True
            GroupBox_Instructor.Visible = False
            GroupBox_Student.Visible = False
        End If


    End Sub
End Class
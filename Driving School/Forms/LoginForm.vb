Imports FontAwesome.Sharp

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form1.PictureBox_user.Visible = True
        Form1.Label_signout.Visible = True
        Form1.IconPicBox_signout.Visible = True
        Form1.Label_Profile.Visible = True
        Form1.IconPicBox_Edit.Visible = True
        Form1.Label_Login.Visible = False
        Form1.IconPicBox_login.Visible = False
        Form1.Label_Register.Visible = False
        Form1.IconPicBox_reg.Visible = False
        Me.Close()
    End Sub
End Class
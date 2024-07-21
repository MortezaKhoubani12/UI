Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports FontAwesome.Sharp

Public Class Form1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constractor
    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)
        Menu_Panel.Controls.Add(leftBorderBtn)
        'Hide title bar Form 
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods
    Private Sub AvtivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Current Form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customcolor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            'currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.BackColor = Color.DarkSlateBlue
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'End
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.BackColor = Color.LightSteelBlue
        childForm.Show()
        LblFormTitle.Text = childForm.Text
    End Sub
    'Events
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AvtivateButton(sender, RGBcolor.color1)
        OpenChildForm(New DashboardForm)
    End Sub
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        AvtivateButton(sender, RGBcolor.color2)
        OpenChildForm(New BookingForm)
    End Sub
    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        AvtivateButton(sender, RGBcolor.color3)
        OpenChildForm(New TimetableForm)
    End Sub
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        AvtivateButton(sender, RGBcolor.color4)
        OpenChildForm(New RecordForm)
    End Sub
    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        AvtivateButton(sender, RGBcolor.color5)
        OpenChildForm(New ExamForm)
    End Sub
    Private Sub btnInstractor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        AvtivateButton(sender, RGBcolor.color6)
        OpenChildForm(New InstructorForm)
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        AvtivateButton(sender, RGBcolor.color7)
        OpenChildForm(New ReportForm)
    End Sub

    Private Sub ImgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        LblFormTitle.Text = "Home"
    End Sub

    Private Sub Label_Login_Click(sender As Object, e As EventArgs) Handles Label_Login.Click
        OpenChildForm(New LoginForm)
    End Sub

    Private Sub IconPicBox_login_Click(sender As Object, e As EventArgs) Handles IconPicBox_login.Click
        OpenChildForm(New LoginForm)
    End Sub

    Private Sub Label_Register_Click(sender As Object, e As EventArgs) Handles Label_Register.Click
        OpenChildForm(New RegisterForm)
    End Sub

    Private Sub IconPicBox_reg_Click(sender As Object, e As EventArgs) Handles IconPicBox_reg.Click
        OpenChildForm(New RegisterForm)
    End Sub

    Private Sub Label_signout_Click(sender As Object, e As EventArgs) Handles Label_signout.Click
        PictureBox_user.Visible = False
        Label_signout.Visible = False
        IconPicBox_signout.Visible = False
        Label_Profile.Visible = False
        IconPicBox_Edit.Visible = False
        Label_Login.Visible = True
        IconPicBox_login.Visible = True
        Label_Register.Visible = True
        IconPicBox_reg.Visible = True
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub IconPicBox_signout_Click(sender As Object, e As EventArgs) Handles IconPicBox_signout.Click
        PictureBox_user.Visible = False
        Label_signout.Visible = False
        IconPicBox_signout.Visible = False
        Label_Profile.Visible = False
        IconPicBox_Edit.Visible = False
        Label_Login.Visible = True
        IconPicBox_login.Visible = True
        Label_Register.Visible = True
        IconPicBox_reg.Visible = True
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    'Drag Form
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)

    End Sub

    Private Sub Panel_title_bar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_title_bar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconButton_close_Click(sender As Object, e As EventArgs) Handles IconButton_close.Click
        Application.Exit()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class

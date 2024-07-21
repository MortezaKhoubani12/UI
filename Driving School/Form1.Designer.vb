<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Menu_Panel = New System.Windows.Forms.Panel()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.btnInstructor = New FontAwesome.Sharp.IconButton()
        Me.btnExam = New FontAwesome.Sharp.IconButton()
        Me.btnRecord = New FontAwesome.Sharp.IconButton()
        Me.btnTimetable = New FontAwesome.Sharp.IconButton()
        Me.btnBooking = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.Logo_Panel = New System.Windows.Forms.Panel()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.Panel_title_bar = New System.Windows.Forms.Panel()
        Me.PictureBox_user = New System.Windows.Forms.PictureBox()
        Me.Label_Register = New System.Windows.Forms.Label()
        Me.Label_Login = New System.Windows.Forms.Label()
        Me.LblFormTitle = New System.Windows.Forms.Label()
        Me.IconPicBox_reg = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPicBox_login = New FontAwesome.Sharp.IconPictureBox()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Panel_About = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label_Code_Date = New System.Windows.Forms.Label()
        Me.Label_design = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconPicBox_signout = New FontAwesome.Sharp.IconPictureBox()
        Me.Label_signout = New System.Windows.Forms.Label()
        Me.Label_Profile = New System.Windows.Forms.Label()
        Me.IconPicBox_Edit = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton_close = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Menu_Panel.SuspendLayout()
        Me.Logo_Panel.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_title_bar.SuspendLayout()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicBox_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicBox_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.Panel_About.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicBox_signout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicBox_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu_Panel
        '
        Me.Menu_Panel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Menu_Panel.Controls.Add(Me.btnReport)
        Me.Menu_Panel.Controls.Add(Me.btnInstructor)
        Me.Menu_Panel.Controls.Add(Me.btnExam)
        Me.Menu_Panel.Controls.Add(Me.btnRecord)
        Me.Menu_Panel.Controls.Add(Me.btnTimetable)
        Me.Menu_Panel.Controls.Add(Me.btnBooking)
        Me.Menu_Panel.Controls.Add(Me.btnDashboard)
        Me.Menu_Panel.Controls.Add(Me.Logo_Panel)
        Me.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Panel.Name = "Menu_Panel"
        Me.Menu_Panel.Size = New System.Drawing.Size(220, 526)
        Me.Menu_Panel.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.SystemColors.Info
        Me.btnReport.IconChar = FontAwesome.Sharp.IconChar.TableList
        Me.btnReport.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReport.IconSize = 35
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 460)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(220, 60)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "Reports"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnInstructor
        '
        Me.btnInstructor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstructor.FlatAppearance.BorderSize = 0
        Me.btnInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructor.ForeColor = System.Drawing.SystemColors.Info
        Me.btnInstructor.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard
        Me.btnInstructor.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnInstructor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInstructor.IconSize = 35
        Me.btnInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstructor.Location = New System.Drawing.Point(0, 400)
        Me.btnInstructor.Name = "btnInstructor"
        Me.btnInstructor.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnInstructor.Size = New System.Drawing.Size(220, 60)
        Me.btnInstructor.TabIndex = 6
        Me.btnInstructor.Text = "Instructors"
        Me.btnInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInstructor.UseVisualStyleBackColor = True
        '
        'btnExam
        '
        Me.btnExam.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExam.FlatAppearance.BorderSize = 0
        Me.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam.ForeColor = System.Drawing.SystemColors.Info
        Me.btnExam.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnExam.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnExam.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExam.IconSize = 35
        Me.btnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExam.Location = New System.Drawing.Point(0, 340)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnExam.Size = New System.Drawing.Size(220, 60)
        Me.btnExam.TabIndex = 5
        Me.btnExam.Text = "Examination"
        Me.btnExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecord.FlatAppearance.BorderSize = 0
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.SystemColors.Info
        Me.btnRecord.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.btnRecord.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnRecord.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRecord.IconSize = 35
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.Location = New System.Drawing.Point(0, 280)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnRecord.Size = New System.Drawing.Size(220, 60)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record Card"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnTimetable
        '
        Me.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTimetable.FlatAppearance.BorderSize = 0
        Me.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimetable.ForeColor = System.Drawing.SystemColors.Info
        Me.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.CalendarDays
        Me.btnTimetable.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTimetable.IconSize = 35
        Me.btnTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimetable.Location = New System.Drawing.Point(0, 220)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnTimetable.Size = New System.Drawing.Size(220, 60)
        Me.btnTimetable.TabIndex = 3
        Me.btnTimetable.Text = "Timetable"
        Me.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimetable.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.ForeColor = System.Drawing.SystemColors.Info
        Me.btnBooking.IconChar = FontAwesome.Sharp.IconChar.TriangleCircleSquare
        Me.btnBooking.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnBooking.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBooking.IconSize = 35
        Me.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooking.Location = New System.Drawing.Point(0, 160)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnBooking.Size = New System.Drawing.Size(220, 60)
        Me.btnBooking.TabIndex = 2
        Me.btnBooking.Text = "Lesson Booking"
        Me.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.Info
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.btnDashboard.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 35
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Logo_Panel
        '
        Me.Logo_Panel.Controls.Add(Me.ImgHome)
        Me.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logo_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Logo_Panel.Name = "Logo_Panel"
        Me.Logo_Panel.Size = New System.Drawing.Size(220, 100)
        Me.Logo_Panel.TabIndex = 0
        '
        'ImgHome
        '
        Me.ImgHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgHome.Image = Global.Driving_School.My.Resources.Resources.logo1
        Me.ImgHome.Location = New System.Drawing.Point(34, 12)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(146, 72)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'Panel_title_bar
        '
        Me.Panel_title_bar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel_title_bar.Controls.Add(Me.IconButton2)
        Me.Panel_title_bar.Controls.Add(Me.IconButton1)
        Me.Panel_title_bar.Controls.Add(Me.IconButton_close)
        Me.Panel_title_bar.Controls.Add(Me.IconPicBox_Edit)
        Me.Panel_title_bar.Controls.Add(Me.Label_Profile)
        Me.Panel_title_bar.Controls.Add(Me.Label_signout)
        Me.Panel_title_bar.Controls.Add(Me.IconPicBox_signout)
        Me.Panel_title_bar.Controls.Add(Me.PictureBox_user)
        Me.Panel_title_bar.Controls.Add(Me.Label_Register)
        Me.Panel_title_bar.Controls.Add(Me.Label_Login)
        Me.Panel_title_bar.Controls.Add(Me.LblFormTitle)
        Me.Panel_title_bar.Controls.Add(Me.IconPicBox_reg)
        Me.Panel_title_bar.Controls.Add(Me.IconPicBox_login)
        Me.Panel_title_bar.Controls.Add(Me.IconCurrentForm)
        Me.Panel_title_bar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_title_bar.Location = New System.Drawing.Point(220, 0)
        Me.Panel_title_bar.Name = "Panel_title_bar"
        Me.Panel_title_bar.Size = New System.Drawing.Size(764, 70)
        Me.Panel_title_bar.TabIndex = 1
        '
        'PictureBox_user
        '
        Me.PictureBox_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_user.Image = Global.Driving_School.My.Resources.Resources.avatar
        Me.PictureBox_user.Location = New System.Drawing.Point(599, 12)
        Me.PictureBox_user.Name = "PictureBox_user"
        Me.PictureBox_user.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_user.TabIndex = 3
        Me.PictureBox_user.TabStop = False
        Me.PictureBox_user.Visible = False
        '
        'Label_Register
        '
        Me.Label_Register.AutoSize = True
        Me.Label_Register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Register.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label_Register.Location = New System.Drawing.Point(275, 30)
        Me.Label_Register.Name = "Label_Register"
        Me.Label_Register.Size = New System.Drawing.Size(46, 13)
        Me.Label_Register.TabIndex = 2
        Me.Label_Register.Text = "Register"
        '
        'Label_Login
        '
        Me.Label_Login.AutoSize = True
        Me.Label_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Login.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label_Login.Location = New System.Drawing.Point(167, 30)
        Me.Label_Login.Name = "Label_Login"
        Me.Label_Login.Size = New System.Drawing.Size(33, 13)
        Me.Label_Login.TabIndex = 2
        Me.Label_Login.Text = "Login"
        '
        'LblFormTitle
        '
        Me.LblFormTitle.AutoSize = True
        Me.LblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormTitle.ForeColor = System.Drawing.SystemColors.Info
        Me.LblFormTitle.Location = New System.Drawing.Point(45, 28)
        Me.LblFormTitle.Name = "LblFormTitle"
        Me.LblFormTitle.Size = New System.Drawing.Size(41, 15)
        Me.LblFormTitle.TabIndex = 1
        Me.LblFormTitle.Text = "Home"
        '
        'IconPicBox_reg
        '
        Me.IconPicBox_reg.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconPicBox_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPicBox_reg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPicBox_reg.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_reg.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.IconPicBox_reg.IconColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_reg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicBox_reg.IconSize = 25
        Me.IconPicBox_reg.Location = New System.Drawing.Point(253, 21)
        Me.IconPicBox_reg.Name = "IconPicBox_reg"
        Me.IconPicBox_reg.Size = New System.Drawing.Size(25, 25)
        Me.IconPicBox_reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPicBox_reg.TabIndex = 0
        Me.IconPicBox_reg.TabStop = False
        '
        'IconPicBox_login
        '
        Me.IconPicBox_login.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconPicBox_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPicBox_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPicBox_login.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_login.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.IconPicBox_login.IconColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicBox_login.IconSize = 25
        Me.IconPicBox_login.Location = New System.Drawing.Point(145, 21)
        Me.IconPicBox_login.Name = "IconPicBox_login"
        Me.IconPicBox_login.Size = New System.Drawing.Size(25, 25)
        Me.IconPicBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPicBox_login.TabIndex = 0
        Me.IconPicBox_login.TabStop = False
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconCurrentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 25
        Me.IconCurrentForm.Location = New System.Drawing.Point(23, 21)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(25, 25)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelDesktop.Controls.Add(Me.Panel_About)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 70)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(764, 456)
        Me.PanelDesktop.TabIndex = 2
        '
        'Panel_About
        '
        Me.Panel_About.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_About.Controls.Add(Me.PictureBox5)
        Me.Panel_About.Controls.Add(Me.PictureBox3)
        Me.Panel_About.Controls.Add(Me.PictureBox4)
        Me.Panel_About.Controls.Add(Me.PictureBox2)
        Me.Panel_About.Controls.Add(Me.RichTextBox1)
        Me.Panel_About.Controls.Add(Me.Label_Code_Date)
        Me.Panel_About.Controls.Add(Me.Label_design)
        Me.Panel_About.Controls.Add(Me.PictureBox1)
        Me.Panel_About.Location = New System.Drawing.Point(1, 1)
        Me.Panel_About.Name = "Panel_About"
        Me.Panel_About.Size = New System.Drawing.Size(760, 449)
        Me.Panel_About.TabIndex = 7
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(18, 164)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(166, 125)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(536, 164)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 125)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(43, 310)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(166, 125)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(596, 295)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(246, 221)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(302, 180)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label_Code_Date
        '
        Me.Label_Code_Date.AutoSize = True
        Me.Label_Code_Date.Location = New System.Drawing.Point(403, 433)
        Me.Label_Code_Date.Name = "Label_Code_Date"
        Me.Label_Code_Date.Size = New System.Drawing.Size(114, 13)
        Me.Label_Code_Date.TabIndex = 6
        Me.Label_Code_Date.Text = "KHO22193371_(2024)"
        '
        'Label_design
        '
        Me.Label_design.AutoSize = True
        Me.Label_design.Location = New System.Drawing.Point(243, 433)
        Me.Label_design.Name = "Label_design"
        Me.Label_design.Size = New System.Drawing.Size(146, 13)
        Me.Label_design.TabIndex = 7
        Me.Label_design.Text = "Design by: Morteza Khoubani"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(165, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'IconPicBox_signout
        '
        Me.IconPicBox_signout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPicBox_signout.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconPicBox_signout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPicBox_signout.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_signout.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare
        Me.IconPicBox_signout.IconColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_signout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicBox_signout.IconSize = 25
        Me.IconPicBox_signout.Location = New System.Drawing.Point(435, 21)
        Me.IconPicBox_signout.Name = "IconPicBox_signout"
        Me.IconPicBox_signout.Size = New System.Drawing.Size(25, 25)
        Me.IconPicBox_signout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPicBox_signout.TabIndex = 4
        Me.IconPicBox_signout.TabStop = False
        Me.IconPicBox_signout.Visible = False
        '
        'Label_signout
        '
        Me.Label_signout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_signout.AutoSize = True
        Me.Label_signout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_signout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label_signout.Location = New System.Drawing.Point(456, 30)
        Me.Label_signout.Name = "Label_signout"
        Me.Label_signout.Size = New System.Drawing.Size(46, 13)
        Me.Label_signout.TabIndex = 5
        Me.Label_signout.Text = "Sign out"
        Me.Label_signout.Visible = False
        '
        'Label_Profile
        '
        Me.Label_Profile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Profile.AutoSize = True
        Me.Label_Profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Profile.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label_Profile.Location = New System.Drawing.Point(544, 30)
        Me.Label_Profile.Name = "Label_Profile"
        Me.Label_Profile.Size = New System.Drawing.Size(36, 13)
        Me.Label_Profile.TabIndex = 6
        Me.Label_Profile.Text = "Profile"
        Me.Label_Profile.Visible = False
        '
        'IconPicBox_Edit
        '
        Me.IconPicBox_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPicBox_Edit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconPicBox_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPicBox_Edit.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_Edit.IconChar = FontAwesome.Sharp.IconChar.UserGear
        Me.IconPicBox_Edit.IconColor = System.Drawing.Color.MediumPurple
        Me.IconPicBox_Edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPicBox_Edit.IconSize = 25
        Me.IconPicBox_Edit.Location = New System.Drawing.Point(520, 18)
        Me.IconPicBox_Edit.Name = "IconPicBox_Edit"
        Me.IconPicBox_Edit.Size = New System.Drawing.Size(25, 25)
        Me.IconPicBox_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPicBox_Edit.TabIndex = 7
        Me.IconPicBox_Edit.TabStop = False
        Me.IconPicBox_Edit.Visible = False
        '
        'IconButton_close
        '
        Me.IconButton_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton_close.FlatAppearance.BorderSize = 0
        Me.IconButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton_close.IconChar = FontAwesome.Sharp.IconChar.X
        Me.IconButton_close.IconColor = System.Drawing.Color.White
        Me.IconButton_close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton_close.IconSize = 20
        Me.IconButton_close.Location = New System.Drawing.Point(742, 5)
        Me.IconButton_close.Name = "IconButton_close"
        Me.IconButton_close.Size = New System.Drawing.Size(17, 19)
        Me.IconButton_close.TabIndex = 8
        Me.IconButton_close.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Television
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(715, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(17, 19)
        Me.IconButton1.TabIndex = 8
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(688, 5)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(17, 19)
        Me.IconButton2.TabIndex = 8
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(984, 526)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel_title_bar)
        Me.Controls.Add(Me.Menu_Panel)
        Me.MinimumSize = New System.Drawing.Size(1000, 565)
        Me.Name = "Form1"
        Me.Text = "Pass IT Driving School"
        Me.Menu_Panel.ResumeLayout(False)
        Me.Logo_Panel.ResumeLayout(False)
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_title_bar.ResumeLayout(False)
        Me.Panel_title_bar.PerformLayout()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicBox_reg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicBox_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.Panel_About.ResumeLayout(False)
        Me.Panel_About.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicBox_signout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicBox_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu_Panel As Panel
    Friend WithEvents Logo_Panel As Panel
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInstructor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExam As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecord As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTimetable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBooking As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_title_bar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label_Register As Label
    Friend WithEvents Label_Login As Label
    Friend WithEvents IconPicBox_reg As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPicBox_login As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox_user As PictureBox
    Friend WithEvents Panel_About As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label_Code_Date As Label
    Friend WithEvents Label_design As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_signout As Label
    Friend WithEvents IconPicBox_signout As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPicBox_Edit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label_Profile As Label
    Friend WithEvents IconButton_close As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class

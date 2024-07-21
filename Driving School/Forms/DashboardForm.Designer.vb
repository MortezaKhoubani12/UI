<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item31ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item32ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Option2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(193, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.Option2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item1ToolStripMenuItem, Me.Item2ToolStripMenuItem, Me.Item3ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripMenuItem1.Text = "Option 1"
        '
        'Item1ToolStripMenuItem
        '
        Me.Item1ToolStripMenuItem.Name = "Item1ToolStripMenuItem"
        Me.Item1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item1ToolStripMenuItem.Text = "Item 1"
        '
        'Item2ToolStripMenuItem
        '
        Me.Item2ToolStripMenuItem.Name = "Item2ToolStripMenuItem"
        Me.Item2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item2ToolStripMenuItem.Text = "Item 2"
        '
        'Item3ToolStripMenuItem
        '
        Me.Item3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item31ToolStripMenuItem, Me.Item32ToolStripMenuItem})
        Me.Item3ToolStripMenuItem.Name = "Item3ToolStripMenuItem"
        Me.Item3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item3ToolStripMenuItem.Text = "Item 3"
        '
        'Item31ToolStripMenuItem
        '
        Me.Item31ToolStripMenuItem.Name = "Item31ToolStripMenuItem"
        Me.Item31ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item31ToolStripMenuItem.Text = "Item 3-1"
        '
        'Item32ToolStripMenuItem
        '
        Me.Item32ToolStripMenuItem.Name = "Item32ToolStripMenuItem"
        Me.Item32ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item32ToolStripMenuItem.Text = "Item 3-2"
        '
        'Option2ToolStripMenuItem
        '
        Me.Option2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item1ToolStripMenuItem1, Me.Item2ToolStripMenuItem1})
        Me.Option2ToolStripMenuItem.Name = "Option2ToolStripMenuItem"
        Me.Option2ToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.Option2ToolStripMenuItem.Text = "Option 2"
        '
        'Item1ToolStripMenuItem1
        '
        Me.Item1ToolStripMenuItem1.Name = "Item1ToolStripMenuItem1"
        Me.Item1ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.Item1ToolStripMenuItem1.Text = "Item 1"
        '
        'Item2ToolStripMenuItem1
        '
        Me.Item2ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item21ToolStripMenuItem})
        Me.Item2ToolStripMenuItem1.Name = "Item2ToolStripMenuItem1"
        Me.Item2ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.Item2ToolStripMenuItem1.Text = "Item 2"
        '
        'Item21ToolStripMenuItem
        '
        Me.Item21ToolStripMenuItem.Name = "Item21ToolStripMenuItem"
        Me.Item21ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Item21ToolStripMenuItem.Text = "Item 2-1"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Item1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Item2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Item3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Item31ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Item32ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Option2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Item1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Item2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Item21ToolStripMenuItem As ToolStripMenuItem
End Class

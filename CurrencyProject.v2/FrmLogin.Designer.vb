<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblPasswordMessage = New System.Windows.Forms.Label()
        Me.LblUserNameMessage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.LblPasswordMessage)
        Me.Panel2.Controls.Add(Me.LblUserNameMessage)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CmbUserName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtPassword)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(807, 191)
        Me.Panel2.TabIndex = 1
        '
        'LblPasswordMessage
        '
        Me.LblPasswordMessage.AutoSize = True
        Me.LblPasswordMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswordMessage.ForeColor = System.Drawing.Color.Red
        Me.LblPasswordMessage.Location = New System.Drawing.Point(184, 155)
        Me.LblPasswordMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPasswordMessage.Name = "LblPasswordMessage"
        Me.LblPasswordMessage.Size = New System.Drawing.Size(178, 20)
        Me.LblPasswordMessage.TabIndex = 19
        Me.LblPasswordMessage.Text = "الرجاء ادخال كلمة المرور"
        Me.LblPasswordMessage.Visible = False
        '
        'LblUserNameMessage
        '
        Me.LblUserNameMessage.AutoSize = True
        Me.LblUserNameMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserNameMessage.ForeColor = System.Drawing.Color.Red
        Me.LblUserNameMessage.Location = New System.Drawing.Point(556, 155)
        Me.LblUserNameMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUserNameMessage.Name = "LblUserNameMessage"
        Me.LblUserNameMessage.Size = New System.Drawing.Size(185, 20)
        Me.LblUserNameMessage.TabIndex = 13
        Me.LblUserNameMessage.Text = "الرجاء ادخال اسم المستخدم"
        Me.LblUserNameMessage.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(640, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 36)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "اسم المستخدم"
        '
        'CmbUserName
        '
        Me.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserName.BackColor = System.Drawing.Color.White
        Me.CmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbUserName.Font = New System.Drawing.Font("Hacen Saudi Arabia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmbUserName.FormattingEnabled = True
        Me.CmbUserName.Location = New System.Drawing.Point(430, 108)
        Me.CmbUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbUserName.Size = New System.Drawing.Size(360, 40)
        Me.CmbUserName.Sorted = True
        Me.CmbUserName.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(259, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 36)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "كلمة المرور"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.White
        Me.TxtPassword.Font = New System.Drawing.Font("Hacen Saudi Arabia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TxtPassword.Location = New System.Drawing.Point(28, 108)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPassword.Size = New System.Drawing.Size(372, 38)
        Me.TxtPassword.TabIndex = 15
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(153, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(149, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "كلمة المرور:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(500, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(179, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "اسم المستخدم:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(500, 28)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(308, 15)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 29)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 15)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(306, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تسجيل الدخول"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.LblTimer)
        Me.Panel1.Controls.Add(Me.BtnOk)
        Me.Panel1.Location = New System.Drawing.Point(3, 191)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 82)
        Me.Panel1.TabIndex = 1
        '
        'LblTimer
        '
        Me.LblTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblTimer.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(15, 13)
        Me.LblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(86, 51)
        Me.LblTimer.TabIndex = 12
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTimer.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.AccessibleDescription = ""
        Me.BtnOk.BackColor = System.Drawing.Color.Transparent
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOk.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.Aqua
        Me.BtnOk.Location = New System.Drawing.Point(153, 13)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(489, 51)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "دخول"
        Me.ToolTip1.SetToolTip(Me.BtnOk, "تسجيل الدخول")
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "منظومة العملات"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.NotifyIcon1.BalloonTipText = "تسجيل الدخول"
        Me.NotifyIcon1.BalloonTipTitle = "تسجيل الدخول"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "الدخول "
        Me.NotifyIcon1.Visible = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول للمنظومة"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbUserName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblPasswordMessage As Label
    Friend WithEvents LblUserNameMessage As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
End Class

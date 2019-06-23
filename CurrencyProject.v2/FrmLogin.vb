Public Class FrmLogin
    Private ErrorCount As Integer
    Private TimerCount As Integer
    Private WaitCount As Integer
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbUserName.Select()

        CmbUserName.Items.Clear()
        CmbUserName.Items.Add("يوسف محمد ميلاد")
        CmbUserName.Items.Add("ميلاد محمد ميلاد")

        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Left = Me.Left - 15
        If Me.Left <= (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Top = Me.Top + 15
        If Me.Top >= (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2 Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Password = TxtPassword.Text

        If CmbUserName.Text = "" Then
            Timer3.Enabled = True
            CmbUserName.Focus()
            Exit Sub
        End If

        If TxtPassword.Text = "" Then
            Timer3.Enabled = True
            TxtPassword.Focus()
            Exit Sub
        End If



        If CmbUserName.Text = "يوسف محمد ميلاد" Then

            If TxtPassword.Text = "111" Then
                Me.Hide()
                FrmMain.ShowDialog()
                Me.Close()
            Else
                ErrorCount = ErrorCount + 1
                If ErrorCount < 3 Then
                    MsgBox("كلمة المرور خطأ لقد استنفذت: " & ErrorCount & " محاولة من 3 محاولات", MsgBoxStyle.Exclamation, "خطــأ")
                    TxtPassword.Text = ""
                    TxtPassword.Focus()
                ElseIf ErrorCount = 3 Then
                    'MsgBox("كلمة المرور خطأ .. لقد استنفذت جميع المحاولات ، يجب الانتظار 30 ثانية")
                    NotifyIcon1.BalloonTipText = "كلمة المرور خطأ .. لقد استنفذت جميع المحاولات ، يجب الانتظار 30 ثانية"
                    NotifyIcon1.ShowBalloonTip(1)
                    Me.Enabled = False
                    LblTimer.Visible = True
                    WaitCount = 30
                    LblTimer.Text = WaitCount
                    Timer4.Enabled = True
                    TxtPassword.Text = ""

                End If

            End If

        ElseIf CmbUserName.Text = "ميلاد محمد ميلاد" Then

            If TxtPassword.Text = "222" Then
                Me.Hide()
                FrmMain.ShowDialog()
                Me.Close()

            Else
                ErrorCount = ErrorCount + 1
                If ErrorCount < 3 Then
                    MsgBox("كلمة المرور خطأ لقد استنفذت: " & ErrorCount & " محاولة من 3 محاولات", MsgBoxStyle.Exclamation, "خطــأ")
                    TxtPassword.Text = ""
                    TxtPassword.Focus()
                ElseIf ErrorCount = 3 Then
                    'MsgBox("كلمة المرور خطأ .. لقد استنفذت جميع المحاولات ، يجب الانتظار 30 ثانية")
                    NotifyIcon1.BalloonTipText = "كلمة المرور خطأ .. لقد استنفذت جميع المحاولات ، يجب الانتظار 30 ثانية"
                    NotifyIcon1.ShowBalloonTip(1)
                    Me.Enabled = False
                    LblTimer.Visible = True
                    WaitCount = 30
                    LblTimer.Text = WaitCount
                    Timer4.Enabled = True
                    TxtPassword.Text = ""


                End If



            End If

        Else
            MsgBox("اسم المستخدم غير موجود في المنظومة", MsgBoxStyle.Exclamation, "خطأ")
            CmbUserName.SelectAll()
            CmbUserName.Focus()



        End If
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        LblUserNameMessage.Visible = False
        UserName = CmbUserName.Text


        CmbUserName.SelectAll()
        TxtPassword.Text = ""
        TxtPassword.Focus()
    End Sub

    Private Sub CmbUserName_TextChanged(sender As Object, e As EventArgs) Handles CmbUserName.TextChanged
        If CmbUserName.Text = "" Then
            Label6.Visible = True
        Else
            Label6.Visible = False
        End If


    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        TxtPassword.Focus()

        If TxtPassword.Text = "" Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        TimerCount = TimerCount + 1
        If CmbUserName.Text = "" Then
            If LblUserNameMessage.Visible = True Then
                LblUserNameMessage.Visible = False
            Else
                LblUserNameMessage.Visible = True
            End If
            If TimerCount = 6 Then
                Timer3.Enabled = False
                LblUserNameMessage.Visible = False
                TimerCount = 0
            End If
        ElseIf TxtPassword.Text = "" Then
            If LblPasswordMessage.Visible = True Then
                LblPasswordMessage.Visible = False
            Else
                LblPasswordMessage.Visible = True
            End If
            If TimerCount = 6 Then
                Timer3.Enabled = False
                LblPasswordMessage.Visible = False
                TimerCount = 0
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        WaitCount -= 1
        LblTimer.Text = WaitCount
        If WaitCount = 0 Then
            Me.Enabled = True
            Timer4.Enabled = False
            LblTimer.Visible = False
            ErrorCount = 0
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        CmbUserName.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TxtPassword.Focus()
    End Sub
End Class

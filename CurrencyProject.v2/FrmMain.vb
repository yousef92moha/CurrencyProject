Imports System.ComponentModel

Public Class FrmMain
    Private Sub BtnSetting_MouseEnter(sender As Object, e As EventArgs) Handles BtnSetting.MouseEnter
        BtnSetting.BackColor = Color.FromArgb(128, 128, 255)
        BtnSetting.SetBounds(BtnSetting.Left - 5, BtnSetting.Top - 5, BtnSetting.Width + 10, BtnSetting.Height + 10)
        PanelSign2.Visible = False
        PanelSign3.Visible = False
        PanelSign4.Visible = False
        PanelSign5.Visible = True
    End Sub

    Private Sub BtnSetting_MouseLeave(sender As Object, e As EventArgs) Handles BtnSetting.MouseLeave
        BtnSetting.SetBounds(BtnSetting.Left + 5, BtnSetting.Top + 5, BtnSetting.Width - 10, BtnSetting.Height - 10)
        PanelSign5.Visible = False
        BtnSetting.BackColor = Color.FromArgb(100, 150, 255)
    End Sub


    Private Sub BtnShowCurrency_Click(sender As Object, e As EventArgs) Handles BtnShowCurrency.Click

        FrmShowCurrency.ShowDialog()
    End Sub



    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TSSLTimeOfDay.Text = TimeOfDay
        TSSLUserName.Text = UserName
        TSSLDate.Text = Now.Date
        Timer2.Enabled = True
        Timer7.Enabled = True

        CmbFromCurrency.Items.Add("الدولار الأمريكي")
        CmbFromCurrency.Items.Add("الدولارالكندي")
        CmbFromCurrency.Items.Add("الجنيه الاسترليني")
        CmbFromCurrency.Items.Add("الفرنك السويسري")
        CmbFromCurrency.Items.Add("الريال السعودي")
        CmbFromCurrency.Items.Add("الدرهم الاماراتي")
        CmbFromCurrency.Items.Add("الباوند")
        CmbFromCurrency.Items.Add("اليورو")

        TxtDolar.Text = Dollar
        TxtDolarCandan.Text = DolarCandan
        TxtEstrline.Text = Estrline
        TxtFrankSwis.Text = FrankSwis
        TxtSuadiReial.Text = SuadiReial
        TxtEmaratiDerham.Text = EmaratiDerham
        TxtPound.Text = Pound
        TxtEuro.Text = Euro
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSSLTimeOfDay.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity + 0.03
        If Me.Opacity >= 1 Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Opacity = Me.Opacity - 0.03
        If Me.Opacity <= 0 Then
            End
        End If
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("هل تريد الخروج", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbMsgBoxRight + MsgBoxStyle.DefaultButton2, "تأكيد الخروج") = MsgBoxResult.Yes Then
            e.Cancel = True
            Timer3.Enabled = True
        Else
            e.Cancel = True
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPassword.Text = "" Then
            MsgBox("الرجاء ادخال كلمة المرور", MsgBoxStyle.Exclamation, "خطـــأ")
            TxtPassword.Focus()
            Exit Sub
        End If


        If TxtPassword.Text = Password Then

            Timer5.Enabled = True
            Timer6.Enabled = False
            Timer7.Enabled = False
            BtnUpdate.Enabled = True

            TxtDolar.Enabled = True
            TxtDolarCandan.Enabled = True
            TxtEstrline.Enabled = True
            TxtFrankSwis.Enabled = True
            TxtSuadiReial.Enabled = True
            TxtEmaratiDerham.Enabled = True
            TxtEmaratiDerham.Enabled = True
            TxtPound.Enabled = True
            TxtEuro.Enabled = True


            GroupBox1.Left = -500



            'MsgBox("تم ضبط سعر العملات")

            TxtPassword.Focus()
            TxtPassword.Text = ""
            TxtPassword.Focus()
        Else
            MsgBox("كلمة المرور غير صحيحة", MsgBoxStyle.Exclamation, "خطــأ")
            TxtPassword.Text = ""
            TxtPassword.Focus()

        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If GroupBox1.Left = 64 Then
            GroupBox1.Left = -500
        End If
        TxtPassword.Text = ""
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        GroupBox1.Left = GroupBox1.Left + 3
        If GroupBox1.Left >= 76 Then
            GroupBox1.Left = 64
            Timer4.Enabled = False
        Else
            Timer4.Enabled = True

        End If
    End Sub

    Private Sub BtnResetCurrency_Click(sender As Object, e As EventArgs) Handles BtnResetCurrency.Click
        Timer4.Enabled = True
        TxtPassword.Focus()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Me.Width <= 977 Then
            Me.Width = Me.Width + 5
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Dollar = Val(TxtDolar.Text)
        DolarCandan = Val(TxtDolarCandan.Text)
        Estrline = Val(TxtEstrline.Text)
        FrankSwis = Val(TxtFrankSwis.Text)
        SuadiReial = Val(TxtSuadiReial.Text)
        EmaratiDerham = Val(TxtEmaratiDerham.Text)

        Pound = Val(TxtPound.Text)
        Euro = Val(TxtEuro.Text)


        Timer6.Enabled = True
        Timer5.Enabled = False
        Timer7.Enabled = True


        TxtDolar.Enabled = False
        TxtDolarCandan.Enabled = False
        TxtEstrline.Enabled = False
        TxtFrankSwis.Enabled = False
        TxtSuadiReial.Enabled = False
        TxtEmaratiDerham.Enabled = False
        TxtEmaratiDerham.Enabled = False
        TxtPound.Enabled = False
        TxtEuro.Enabled = False
        BtnUpdate.Enabled = False

        NotifyIcon1.BalloonTipText = "تم ضبط سعر العملات" & vbCrLf & Now
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub PicDolarInc_Click(sender As Object, e As EventArgs) Handles PicDolarInc.Click
        TxtDolar.Text = Format(Val(TxtDolar.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicDolarDec_Click(sender As Object, e As EventArgs) Handles PicDolarDec.Click
        TxtDolar.Text = Format(Val(TxtDolar.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicDolarCandanInc_Click(sender As Object, e As EventArgs) Handles PicDolarCandanInc.Click
        TxtDolarCandan.Text = Format(Val(TxtDolarCandan.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicDolarCandanDec_Click(sender As Object, e As EventArgs) Handles PicDolarCandanDec.Click
        TxtDolarCandan.Text = Format(Val(TxtDolarCandan.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicEstrlineInc_Click(sender As Object, e As EventArgs) Handles PicEstrlineInc.Click
        TxtEstrline.Text = Format(Val(TxtEstrline.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicEstrlineDec_Click(sender As Object, e As EventArgs) Handles PicEstrlineDec.Click
        TxtEstrline.Text = Format(Val(TxtEstrline.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicFrankSwisInc_Click(sender As Object, e As EventArgs) Handles PicFrankSwisInc.Click
        TxtFrankSwis.Text = Format(Val(TxtFrankSwis.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicFrankSwisDec_Click(sender As Object, e As EventArgs) Handles PicFrankSwisDec.Click
        TxtFrankSwis.Text = Format(Val(TxtFrankSwis.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicSuadiReialInc_Click(sender As Object, e As EventArgs) Handles PicSuadiReialInc.Click
        TxtSuadiReial.Text = Format(Val(TxtSuadiReial.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicSuadiReialDec_Click(sender As Object, e As EventArgs) Handles PicSuadiReialDec.Click
        TxtSuadiReial.Text = Format(Val(TxtSuadiReial.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicEmaratiDerhamInc_Click(sender As Object, e As EventArgs) Handles PicEmaratiDerhamInc.Click
        TxtEmaratiDerham.Text = Format(Val(TxtEmaratiDerham.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicEmaratiDerhamDec_Click(sender As Object, e As EventArgs) Handles PicEmaratiDerhamDec.Click
        TxtEmaratiDerham.Text = Format(Val(TxtEmaratiDerham.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicPoundInc_Click(sender As Object, e As EventArgs) Handles PicPoundInc.Click
        TxtPound.Text = Format(Val(TxtPound.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicPoundDec_Click(sender As Object, e As EventArgs) Handles PicPoundDec.Click
        TxtPound.Text = Format(Val(TxtPound.Text) - 0.01, "0.00")
    End Sub

    Private Sub PicEuroInc_Click(sender As Object, e As EventArgs) Handles PicEuroInc.Click
        TxtEuro.Text = Format(Val(TxtEuro.Text) + 0.01, "0.00")
    End Sub

    Private Sub PicEuroDec_Click(sender As Object, e As EventArgs) Handles PicEuroDec.Click
        TxtEuro.Text = Format(Val(TxtEuro.Text) - 0.01, "0.00")
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If Me.Width >= 794 Then
            Me.Width = Me.Width - 5
        End If
    End Sub
    Private Sub BtnShowCurrency_MouseEnter(sender As Object, e As EventArgs) Handles BtnShowCurrency.MouseEnter
        BtnShowCurrency.BackColor = Color.FromArgb(128, 128, 255)
        BtnShowCurrency.SetBounds(BtnShowCurrency.Left - 5, BtnShowCurrency.Top - 5, BtnShowCurrency.Width + 10, BtnShowCurrency.Height + 10)
        PanelSign2.Visible = True
        PanelSign3.Visible = False
        PanelSign4.Visible = False
        PanelSign5.Visible = False
    End Sub

    Private Sub BtnShowCurrency_MouseLeave(sender As Object, e As EventArgs) Handles BtnShowCurrency.MouseLeave
        BtnShowCurrency.BackColor = Color.FromArgb(100, 150, 255)
        BtnShowCurrency.SetBounds(BtnShowCurrency.Left + 5, BtnShowCurrency.Top + 5, BtnShowCurrency.Width - 10, BtnShowCurrency.Height - 10)
        PanelSign2.Visible = False
    End Sub

    Private Sub BtnResetCurrency_MouseEnter(sender As Object, e As EventArgs) Handles BtnResetCurrency.MouseEnter
        BtnResetCurrency.BackColor = Color.FromArgb(128, 128, 255)
        BtnResetCurrency.SetBounds(BtnResetCurrency.Left - 5, BtnResetCurrency.Top - 5, BtnResetCurrency.Width + 10, BtnResetCurrency.Height + 10)
        PanelSign2.Visible = False
        PanelSign3.Visible = True
        PanelSign4.Visible = False
        PanelSign5.Visible = False
    End Sub

    Private Sub BtnResetCurrency_MouseLeave(sender As Object, e As EventArgs) Handles BtnResetCurrency.MouseLeave
        BtnResetCurrency.BackColor = Color.FromArgb(100, 150, 255)
        BtnResetCurrency.SetBounds(BtnResetCurrency.Left + 5, BtnResetCurrency.Top + 5, BtnResetCurrency.Width - 10, BtnResetCurrency.Height - 10)
        PanelSign3.Visible = False
    End Sub

    Private Sub BtnBills_MouseEnter(sender As Object, e As EventArgs) Handles BtnBills.MouseEnter
        BtnBills.BackColor = Color.FromArgb(128, 128, 255)
        BtnBills.SetBounds(BtnBills.Left - 5, BtnBills.Top - 5, BtnBills.Width + 10, BtnBills.Height + 10)
        PanelSign2.Visible = False
        PanelSign3.Visible = False
        PanelSign4.Visible = True
        PanelSign5.Visible = False
    End Sub

    Private Sub BtnBills_MouseLeave(sender As Object, e As EventArgs) Handles BtnBills.MouseLeave
        BtnBills.BackColor = Color.FromArgb(100, 150, 255)
        BtnBills.SetBounds(BtnBills.Left + 5, BtnBills.Top + 5, BtnBills.Width - 10, BtnBills.Height - 10)
        PanelSign4.Visible = False
    End Sub

    Private Sub BtnBills_Click(sender As Object, e As EventArgs) Handles BtnBills.Click
        NotifyIcon2.BalloonTipText = "الفواتير"
        NotifyIcon2.ShowBalloonTip(1)
    End Sub
    Private Sub LblBtnColorChange_Click(sender As Object, e As EventArgs) Handles LblBtnColorChange.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            BtnShowCurrency.BackColor = ColorDialog1.Color
            BtnResetCurrency.BackColor = ColorDialog1.Color
            BtnBills.BackColor = ColorDialog1.Color
            BtnSetting.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub LblFontColorChange_Click(sender As Object, e As EventArgs) Handles LblFontColorChange.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            BtnShowCurrency.ForeColor = ColorDialog1.Color
            BtnResetCurrency.ForeColor = ColorDialog1.Color
            BtnBills.ForeColor = ColorDialog1.Color
            BtnSetting.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub LblMin_Click(sender As Object, e As EventArgs) Handles LblMin.Click
        GroupBox2.Visible = False

    End Sub

    Private Sub LblChangeLogo_Click(sender As Object, e As EventArgs) Handles LblChangeLogo.Click
        PictureBox10.Image = Nothing
        OpenFileDialog1.Filter = "صور  | *.jpg;*.png"

        OpenFileDialog1.Title = "تحميل صورة من ملف"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox10.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            PictureBox10.SizeMode = 1

        End If
    End Sub

    Private Sub CmbFromCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFromCurrency.SelectedIndexChanged
        CmbToCurrency.Items.Clear()



        If CmbFromCurrency.Text = "الدولار الأمريكي" Then
            TxtPrice.Text = Dollar
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الدولارالكندي" Then
            TxtPrice.Text = DolarCandan
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الجنيه الاسترليني" Then
            TxtPrice.Text = Estrline
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الفرنك السويسري" Then
            TxtPrice.Text = FrankSwis
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الريال السعودي" Then
            TxtPrice.Text = SuadiReial
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الدرهم الاماراتي" Then
            TxtPrice.Text = EmaratiDerham
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الباوند")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "الباوند" Then
            TxtPrice.Text = Pound
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("اليورو")
        ElseIf CmbFromCurrency.Text = "اليورو" Then
            TxtPrice.Text = Euro
            CmbToCurrency.Items.Add("الدولار الأمريكي")
            CmbToCurrency.Items.Add("الدولارالكندي")
            CmbToCurrency.Items.Add("الجنيه الاسترليني")
            CmbToCurrency.Items.Add("الفرنك السويسري")
            CmbToCurrency.Items.Add("الريال السعودي")
            CmbToCurrency.Items.Add("الدرهم الاماراتي")
            CmbToCurrency.Items.Add("الباوند")
        End If

    End Sub

    Private Sub CmbToCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbToCurrency.SelectedIndexChanged

        If CmbToCurrency.Text = "الدولار الأمريكي" Then
            TxtCompare.Text = Dollar
        ElseIf CmbToCurrency.Text = "الدولارالكندي" Then
            TxtCompare.Text = DolarCandan
        ElseIf CmbToCurrency.Text = "الجنيه الاسترليني" Then
            TxtCompare.Text = Estrline
        ElseIf CmbToCurrency.Text = "الفرنك السويسري" Then
            TxtCompare.Text = FrankSwis
        ElseIf CmbToCurrency.Text = "الريال السعودي" Then
            TxtCompare.Text = SuadiReial
        ElseIf CmbToCurrency.Text = "الدرهم الاماراتي" Then
            TxtCompare.Text = EmaratiDerham
        ElseIf CmbToCurrency.Text = "الباوند" Then
            TxtCompare.Text = Pound
        ElseIf CmbToCurrency.Text = "اليورو" Then
            TxtCompare.Text = Euro
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim change As String
        change = CmbFromCurrency.Text
        CmbFromCurrency.Text = CmbToCurrency.Text
        CmbToCurrency.Text = change


        BtnConvert.Text = "تحويل"
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click

        If BtnConvert.Text = "تحويل" Then
            If Val(TxtPrice.Text) >= Val(TxtCompare.Text) Then
                Dim Price, Denar, Value As Double
                Price = Val(TxtPrice.Text)
                Denar = Val(TxtDenar.Text)
                Value = Denar * Price
                TxtVal.Text = Math.Round(Value, 3)

                LblCurrency.Text = CmbToCurrency.Text

                BtnConvert.Text = "جديد"

                TxtPrice.Enabled = False
                TxtCompare.Enabled = False

                PicBtnInc1.Enabled = False
                PicBtnDec1.Enabled = False
                PicBtnInc2.Enabled = False
                PicBtnDec2.Enabled = False

            End If

            If Val(TxtPrice.Text) <= Val(TxtCompare.Text) Then
                Dim Price, Denar, Value As Double
                Price = Val(TxtPrice.Text)
                Denar = Val(TxtDenar.Text)
                Value = Denar / Price
                TxtVal.Text = Math.Round(Value, 3)
                LblCurrency.Text = CmbToCurrency.Text

                BtnConvert.Text = "جديد"

                TxtPrice.Enabled = False
                TxtCompare.Enabled = False
            End If
        Else

            TxtDenar.Text = ""
            TxtPrice.Text = ""
            TxtCompare.Text = ""
            TxtDenar.Text = ""
            TxtVal.Text = ""

            '------------------------------هده تمسح الي في كومبو بوكس ب -1 ----------------------------------------
            CmbFromCurrency.SelectedIndex = -1
            CmbToCurrency.Text = ""
            BtnConvert.Text = "تحويل"
            LblCurrency.Text = "العملة"
        End If
    End Sub

    Private Sub TxtDenar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDenar.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Or (Asc(e.KeyChar) = 46 And TxtDenar.Text.IndexOf(".") = -1) Then
            e.Handled = False
        End If
    End Sub

    Private Sub BtnLogof_Click(sender As Object, e As EventArgs) Handles BtnLogof.Click
        Application.Restart()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        PictureBox11.Left += 1
        If PictureBox11.Left >= Me.Width Then
            PictureBox11.Left = -(PictureBox11.Width)
        End If

        PictureBox12.Left += 1
        If PictureBox12.Left >= Me.Width Then
            PictureBox12.Left = -(PictureBox12.Width)
        End If

        PictureBox13.Left += 1
        If PictureBox13.Left >= Me.Width Then
            PictureBox13.Left = -(PictureBox13.Width)
        End If

        PictureBox14.Left += 1
        If PictureBox14.Left >= Me.Width Then
            PictureBox14.Left = -(PictureBox14.Width)
        End If

        PictureBox15.Left += 1
        If PictureBox15.Left >= Me.Width Then
            PictureBox15.Left = -(PictureBox15.Width)
        End If

        PictureBox16.Left += 1
        If PictureBox16.Left >= Me.Width Then
            PictureBox16.Left = -(PictureBox16.Width)
        End If

        PictureBox17.Left += 1
        If PictureBox17.Left >= Me.Width Then
            PictureBox17.Left = -(PictureBox17.Width)
        End If

        PictureBox18.Left += 1
        If PictureBox18.Left >= Me.Width Then
            PictureBox18.Left = -(PictureBox18.Width)
        End If
    End Sub

    Private Sub LblBtnColorChange_MouseDown(sender As Object, e As MouseEventArgs) Handles LblBtnColorChange.MouseDown
        LblBtnColorChange.ForeColor = Color.Red
    End Sub

    Private Sub LblBtnColorChange_MouseUp(sender As Object, e As MouseEventArgs) Handles LblBtnColorChange.MouseUp
        LblBtnColorChange.ForeColor = Color.Black
    End Sub

    Private Sub LblFontColorChange_MouseDown(sender As Object, e As MouseEventArgs) Handles LblFontColorChange.MouseDown
        LblFontColorChange.ForeColor = Color.Red
    End Sub

    Private Sub LblFontColorChange_MouseUp(sender As Object, e As MouseEventArgs) Handles LblFontColorChange.MouseUp
        LblFontColorChange.ForeColor = Color.Black
    End Sub

    Private Sub LblChangeLogo_MouseDown(sender As Object, e As MouseEventArgs) Handles LblChangeLogo.MouseDown
        LblChangeLogo.ForeColor = Color.Red
    End Sub

    Private Sub LblChangeLogo_MouseUp(sender As Object, e As MouseEventArgs) Handles LblChangeLogo.MouseUp
        LblChangeLogo.ForeColor = Color.Black
    End Sub

    Private Sub LblUpdate_Click(sender As Object, e As EventArgs) Handles LblUpdate.Click
        TxtPrice.Enabled = True
        TxtCompare.Enabled = True
        PicBtnInc1.Enabled = True
        PicBtnDec1.Enabled = True
        PicBtnInc2.Enabled = True
        PicBtnDec2.Enabled = True
        BtnConvert.Text = "تحويل"
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PicBtnInc1.Click
        TxtPrice.Text = Format(Val(TxtPrice.Text) + 0.01, "0.00")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PicBtnDec1.Click
        TxtPrice.Text = Format(Val(TxtPrice.Text) - 0.01, "0.00")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PicBtnInc2.Click
        TxtCompare.Text = Format(Val(TxtCompare.Text) + 0.01, "0.00")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PicBtnDec2.Click
        TxtCompare.Text = Format(Val(TxtCompare.Text) - 0.01, "0.00")
    End Sub
End Class
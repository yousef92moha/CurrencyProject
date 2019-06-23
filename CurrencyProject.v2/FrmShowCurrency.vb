Public Class FrmShowCurrency
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = Screen.PrimaryScreen.WorkingArea.Top - Me.Height
        Timer1.Enabled = True
        Timer2.Enabled = True

        TxtDolar.Text = Dollar
        TxtDolarCandan.Text = DolarCandan
        TxtEstrline.Text = Estrline
        TxtFrankSwis.Text = FrankSwis
        TxtSuadiReial.Text = SuadiReial
        TxtEmaratiDerham.Text = EmaratiDerham
        TxtPound.Text = Pound
        TxtEuro.Text = Euro
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmMain.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dollar = Val(TxtDolar.Text)
        DolarCandan = Val(TxtDolarCandan.Text)
        Estrline = Val(TxtEstrline.Text)
        FrankSwis = Val(TxtFrankSwis.Text)
        SuadiReial = Val(TxtSuadiReial.Text)
        EmaratiDerham = Val(TxtEmaratiDerham.Text)

        Pound = Val(TxtPound.Text)
        Euro = Val(TxtEuro.Text)
        Me.Close()
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
End Class
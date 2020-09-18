Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        With ComboBox1
            .Items.Add("Hitam")
            .Items.Add("Silver")
            .Items.Add("Merah")
            .Items.Add("Biru")
            .Items.Add("Putih")
        End With
        With ComboBox2
            .Items.Add(36)
            .Items.Add(24)
            .Items.Add(12)
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
        Form4.TextBox4.Text = Me.TextBox4.Text
        Form4.TextBox5.Text = Me.TextBox6.Text
        Form4.TextBox7.Text = Me.TextBox1.Text
        Form4.TextBox8.Text = Me.ComboBox3.Text
        Form4.TextBox9.Text = Me.ComboBox1.Text
        Form4.TextBox10.Text = Me.TextBox3.Text
        Form4.TextBox11.Text = Me.ComboBox2.Text
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Toyota" Then
            TextBox3.Text = 170000000
        End If
        If ComboBox3.Text = "GrandNeo" Then
            TextBox3.Text = 190000000
        End If
        If ComboBox3.Text = "Ninja" Then
            TextBox3.Text = 70000000
        End If
        If ComboBox3.Text = "RX King" Then
            TextBox3.Text = 45000000
        End If
        If ComboBox3.Text = "Yamaha" Then
            TextBox3.Text = 34000000
        End If
        If ComboBox3.Text = "Honda" Then
            TextBox3.Text = 30000000
        End If
        If ComboBox3.Text = "Zupiter" Then
            TextBox3.Text = 17000000
        End If
        If ComboBox3.Text = "Sabre" Then
            TextBox3.Text = 15000000
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            Dim a As Long
            a = TextBox3.Text
            TextBox3.Text = Format(a, "##,##0")
            TextBox3.SelectionStart = Len(TextBox3.Text)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> "" Then
            Dim a As Long
            a = TextBox4.Text
            TextBox4.Text = Format(a, "##,##0")
            TextBox5.Text = Format(Val(Str(TextBox3.Text)) - Val(Str(TextBox4.Text)), "##,##0")
            TextBox4.SelectionStart = Len(TextBox4.Text)
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <> "" Then
            Dim a As Long
            a = ComboBox2.Text
            ComboBox2.Text = Format(a, "##,##0")
            TextBox6.Text = "Rp." & Format(Val(Str(TextBox5.Text)) / Val(Str(ComboBox2.Text)), "##,##0")
            ComboBox2.SelectionStart = Len(ComboBox2.Text)
        End If
    End Sub
End Class
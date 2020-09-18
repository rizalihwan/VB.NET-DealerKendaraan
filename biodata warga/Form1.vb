Public Class Form1
    Dim b As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "" Then
            MsgBox("Harus Memakai Angka")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) And TextBox2.Text <> "" Then
            MsgBox("Harus Memakai Huruf")
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Not IsNumeric(TextBox5.Text) And TextBox5.Text <> "" Then
            MsgBox("Harus Memakai Angka")
            TextBox5.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Kawin")
        ComboBox1.Items.Add("Belum Kawin")
        ComboBox2.Items.Add("A")
        ComboBox2.Items.Add("B")
        ComboBox2.Items.Add("C")
        ComboBox2.Items.Add("AB")
        For a As Integer = 1 To 10
            If a < 10 Then
                ComboBox3.Items.Add("0" & a)
            Else
                ComboBox3.Items.Add(a)

            End If
        Next
        ComboBox4.Items.Add("Buruh")
        ComboBox4.Items.Add("Dokter")
        ComboBox4.Items.Add("Guru")
        ComboBox4.Items.Add("K.Swasta")
        ComboBox4.Items.Add("Wiraswata")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Not IsNumeric(TextBox6.Text) And TextBox6.Text <> "" Then
            MsgBox("Harus Memakai Angka")
            TextBox6.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = InputBox("Masukan Tambahan : ")
        ComboBox4.Items.Add(b)
        ComboBox4.Text = b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Then
            MsgBox("Harus Diisi Lengkap! Silakan Coba Kembali")
            End
        End If
        If TextBox5.Text >= 7000000 Then
            MsgBox("Boleh Membeli Semua Kendaraan!")
            Form2.Show()
            Form2.Button1.Enabled = True
            Form2.Button2.Enabled = True
            Form2.Button3.Enabled = True
            Form2.Button4.Enabled = True
            Me.Hide()
        ElseIf TextBox5.Text >= 5000000 Then
            MsgBox("Boleh Membeli Semua Kendaraan Kecuali Mobil!")
            Form2.Show()
            Form2.Button1.Enabled = False
            Form2.Button2.Enabled = True
            Form2.Button3.Enabled = True
            Form2.Button4.Enabled = True
            Me.Hide()
        ElseIf TextBox5.Text >= 3000000 Then
            MsgBox("Boleh Membeli Semua Kendaraan Kecuali Mobil Dan Motor Sport!")
            Form2.Show()
            Form2.Button1.Enabled = False
            Form2.Button2.Enabled = False
            Form2.Button3.Enabled = True
            Form2.Button4.Enabled = True
            Me.Hide()
        ElseIf TextBox5.Text >= 1500000 Then
            MsgBox("Hanya Boleh Membeli Motor Bebek!")
            Form2.Show()
            Form2.Button1.Enabled = False
            Form2.Button2.Enabled = False
            Form2.Button3.Enabled = False
            Form2.Button4.Enabled = True
            Me.Hide()
        ElseIf TextBox5.Text <= 1500000 Then
            MsgBox("Uang Anda Tidak Mencukupi!")
            TextBox5.Clear()
        End If
        Form4.TextBox1.Text = Me.TextBox1.Text
        Form4.TextBox2.Text = Me.TextBox2.Text
        Form4.TextBox3.Text = Me.TextBox3.Text
        Form4.TextBox6.Text = Me.TextBox6.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Val(Label1.Text + 1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer1.Enabled = True
    End Sub
End Class

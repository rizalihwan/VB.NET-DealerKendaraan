Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
        Form3.TextBox1.Text = "MOBIL"
        Form3.ComboBox3.Items.Add("Toyota")
        Form3.ComboBox3.Items.Add("GrandNeo")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
        Form3.TextBox1.Text = "MOTOR SPORT"
        Form3.ComboBox3.Items.Add("Ninja")
        Form3.ComboBox3.Items.Add("RX King")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
        Form3.TextBox1.Text = "MOTOR MATIC"
        Form3.ComboBox3.Items.Add("Yamaha")
        Form3.ComboBox3.Items.Add("Honda")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
        Form3.TextBox1.Text = "MOTOR BEBEK"
        Form3.ComboBox3.Items.Add("Zupiter")
        Form3.ComboBox3.Items.Add("Sabre")
    End Sub
End Class
Public Class Tugas2

    Private Sub Tugas2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("°C")
        ComboBox1.Items.Add("°R")
        ComboBox1.Items.Add("°F")
        ComboBox1.Items.Add("°K")

        ComboBox2.Items.Add("°C")
        ComboBox2.Items.Add("°R")
        ComboBox2.Items.Add("°F")
        ComboBox2.Items.Add("°K")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "°C" Then
            MessageBox.Show("Hais", "broo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If ComboBox2.SelectedItem = "°R" Then
                TextBox2.Text = TextBox1.Text * 0.8
            ElseIf ComboBox2.SelectedItem = "°F" Then
                TextBox2.Text = TextBox1.Text * 1.8 + 32
            ElseIf ComboBox2.Text = "°K" Then
                TextBox2.Text = TextBox1.Text + 273.15
            Else
                TextBox2.Text = TextBox1.Text
            End If
        ElseIf ComboBox1.SelectedItem = "°R" Then
            If ComboBox2.SelectedItem = "°C" Then
                TextBox2.Text = TextBox1.Text / 0.8
            ElseIf ComboBox2.SelectedItem = "°F" Then
                TextBox2.Text = TextBox1.Text * 2.25 + 32
            ElseIf ComboBox2.Text = "°K" Then
                TextBox2.Text = TextBox1.Text / 0.8 + 273.15
            Else
                TextBox2.Text = TextBox1.Text
            End If
        ElseIf ComboBox1.SelectedItem = "°F" Then
            If ComboBox2.SelectedItem = "°C" Then
                TextBox2.Text = (TextBox1.Text - 32) / 1.8
            ElseIf ComboBox2.SelectedItem = "°R" Then
                TextBox2.Text = (TextBox1.Text - 32) * 0.44
            ElseIf ComboBox2.Text = "°K" Then
                TextBox2.Text = (TextBox1.Text + 459.67) / 1.8
            Else
                TextBox2.Text = TextBox1.Text
            End If
        ElseIf ComboBox1.SelectedItem = "°K" Then
            If ComboBox2.SelectedItem = "°C" Then
                TextBox2.Text = TextBox1.Text - 273.15
            ElseIf ComboBox2.SelectedItem = "°F" Then
                TextBox2.Text = TextBox1.Text * 1.8 - 459.67
            ElseIf ComboBox2.Text = "°R" Then
                TextBox2.Text = (TextBox1.Text - 273.15) * 0.8
            Else
                TextBox2.Text = TextBox1.Text
            End If
        End If
    End Sub
End Class
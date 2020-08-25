Public Class Tugas1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text * TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label1.Text = TextBox1.Text / TextBox2.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label1.Text = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label1.Text = TextBox1.Text + 0 + TextBox2.Text
    End Sub
End Class

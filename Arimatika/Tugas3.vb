Public Class Tugas3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        If Not TextBox1.Text = "" Then
            TextBox1.Text = TextBox1.Text - (TextBox1.Text * 2)
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & ","
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Label1.Text = TextBox1.Text * TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        If Not TextBox1.Text = "" Then
            Label2.Text = ":"
            Label1.Text = TextBox1.Text
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Not TextBox1.Text = "" Then
            Label2.Text = "X"
            Label1.Text = TextBox1.Text
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Not TextBox1.Text = "" Then
            Label2.Text = "-"
            Label1.Text = TextBox1.Text
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Not Label2.Text = "" Then
            If Label2.Text = "X" Then
                Label1.Text = Label1.Text * TextBox1.Text
                'MessageBox.Show("Hais", "broo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label2.Text = ":" Then
                Label1.Text = Label1.Text / TextBox1.Text
            ElseIf Label2.Text = "-" Then
                Label1.Text = Label1.Text - TextBox1.Text
            ElseIf Label2.Text = "+" Then
                Label1.Text = Label1.Text + 0 + TextBox1.Text
            End If
            Label2.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        TextBox1.Text = ""
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        If Not TextBox1.Text = "" Then
            Label2.Text = "%"
            Label1.Text = TextBox1.Text
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Label1.Text = 1 / TextBox1.Text
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Not TextBox1.Text = "" Then
            Label2.Text = "+"
            Label1.Text = TextBox1.Text
            TextBox1.Text = ""
        End If
    End Sub
End Class
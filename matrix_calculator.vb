Public Class matrix_calculator
    'fade in...
    Public Sub fade_In()
        For fadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadeIn
            'Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    '... fade out...
    Public Sub fade_out()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            'Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Private Sub clear2()
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox9.Text = Val(TextBox1.Text) + Val(TextBox5.Text)
        TextBox10.Text = Val(TextBox2.Text) + Val(TextBox6.Text)
        TextBox11.Text = Val(TextBox3.Text) + Val(TextBox7.Text)
        TextBox12.Text = Val(TextBox4.Text) + Val(TextBox8.Text)
    End Sub

    Private Sub e(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Numbers Only,Alphabets Is Not Allowed", MsgBoxStyle.Information, "ALERT")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox9.Text = Val(TextBox1.Text) - Val(TextBox5.Text)
        TextBox10.Text = Val(TextBox2.Text) - Val(TextBox6.Text)
        TextBox11.Text = Val(TextBox3.Text) - Val(TextBox7.Text)
        TextBox12.Text = Val(TextBox4.Text) - Val(TextBox8.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox9.Text = Val(TextBox1.Text) * Val(TextBox5.Text) + Val(TextBox2.Text) * Val(TextBox7.Text)
        TextBox10.Text = Val(TextBox1.Text) * Val(TextBox6.Text) + Val(TextBox2.Text) * Val(TextBox8.Text)
        TextBox11.Text = Val(TextBox3.Text) * Val(TextBox5.Text) + Val(TextBox4.Text) * Val(TextBox7.Text)
        TextBox12.Text = Val(TextBox3.Text) * Val(TextBox6.Text) + Val(TextBox4.Text) * Val(TextBox8.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TextBox9.Text = Val(TextBox5.Text)
            TextBox10.Text = Val(TextBox7.Text)
            TextBox11.Text = Val(TextBox6.Text)
            TextBox12.Text = Val(TextBox8.Text)

            TextBox9.Text = Val(TextBox1.Text)
            TextBox10.Text = Val(TextBox3.Text)
            TextBox11.Text = Val(TextBox2.Text)
            TextBox12.Text = Val(TextBox4.Text)
        Catch ex As Exception
        End Try
        MsgBox("Please Use Matrix A For Transpose")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clear2()
        TextBox5.Focus()
    End Sub

    Private Sub matrix_calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

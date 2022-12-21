Public Class permutation
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
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, n, r, d, c As Long
        n = Val(TextBox1.Text)
        r = Val(TextBox2.Text)
        Try
            a = 1
            For i = 1 To Val(TextBox1.Text)
                a = a * i
            Next i

            c = 1
            For i = 1 To Val(TextBox1.Text) - Val(TextBox2.Text)
                c = c * i
            Next i

            d = a / c
            MsgBox(n & "permutation" & r & "is" & d)
        Catch ex As Exception
            MsgBox("an error occured")
        End Try
        clear()
    End Sub

    Private Sub permutation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
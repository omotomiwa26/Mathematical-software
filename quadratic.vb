Public Class quadratic
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        Dim D, x1, x2 As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        D = (b ^ 2) - (4 * a * c)
        If D >= 0 Then
            x1 = (-b + Math.Sqrt(D)) / (2 * a)
            x2 = (-b - Math.Sqrt(D)) / (2 * a)
            MsgBox("x1 is " & x1 & " and " & "x2 is " & x2)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Focus()
        Else
            MsgBox("complex roots")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub quadratic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

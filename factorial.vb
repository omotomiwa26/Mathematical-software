Public Class factorial

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
        Dim result As Integer
        result = 1
        For i = 1 To Val(TextBox1.Text)
            result = result * i
        Next i
        MsgBox("factorial of is" & result)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub factorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class formulae_page

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
        matrix_calculator.Show()
        matrix_calculator.fade_in()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        combination.Show()
        combination.fade_in()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        permutation.Show()
        permutation.fade_in()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        factorial.Show()
        factorial.fade_in()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        quadratic.Show()
        quadratic.fade_in()
    End Sub

    Private Sub formulae_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        home_page.Show()
        fade_In()
    End Sub
End Class
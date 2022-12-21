Public Class home_page
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

    Private Sub home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fade_In()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        formulae_page.Show()
        formulae_page.fade_In()
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        LinkLabel1.LinkColor = Color.YellowGreen
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        LinkLabel1.LinkColor = Color.SandyBrown
    End Sub
    Private Sub begin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Are you sure you want to quit?", vbYesNo + MsgBoxStyle.Information) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
            fade_out()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are you sure you want to quit?", vbYesNo + MsgBoxStyle.Information) = Windows.Forms.DialogResult.Yes Then
            End
            fade_out()
        End If
    End Sub
End Class
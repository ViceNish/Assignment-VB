Public Class frm_splashscreen_a174088
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 10
        If (Panel2.Width >= 700) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub frm_splashscreen_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/b5.jpg")
        Timer1.Start()


    End Sub

End Class
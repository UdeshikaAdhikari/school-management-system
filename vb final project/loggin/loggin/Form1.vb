Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoardingBar.Increment(1)
        If LoardingBar.Value = 100 Then
            Me.Hide()
            Dim log = New logging
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class

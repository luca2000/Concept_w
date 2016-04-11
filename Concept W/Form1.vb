Public Class Avvio
    Private Sub Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Home.Show()
            ProgressBar1.Value = 0
            Me.Hide()
        End If
    End Sub
End Class

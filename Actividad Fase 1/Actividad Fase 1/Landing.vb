Public Class Landing
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 20
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Login.Show()
        End If
    End Sub
End Class
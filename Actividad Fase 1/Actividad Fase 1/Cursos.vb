Public Class Cursos
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Tem3.LinkClicked

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Dim salir As Byte

        salir = MsgBox("Desea salir de la aplicación?", 32 + 4, "SALIR...")
        If salir = 6 Then
            End
        End If

    End Sub
End Class
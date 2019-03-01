Public Class Registrate
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        If nombres.Text = vbNullString Or apellidos.Text = vbNullString Or telefonos.Text = vbNullString Or correo.Text = vbNullString Or User.Text = vbNullString Or Pass.Text = vbNullString Or Rpass.Text = vbNullString Then
            MsgBox("Por favor rellene todos los campos")
            nombres.Focus()
        ElseIf Rpass.Text <> Pass.Text Then
            MsgBox("Las contraseñas no coinciden")
            Pass.Focus()
        Else
            MsgBox("Felicitaciones ya estas registrado, por favor inicia con tu usuario y contraseña")
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class
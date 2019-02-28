Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Landing.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If User.Text = vbNullString Or Pass.Text = vbNullString Then
            MsgBox("Ingresa tu usuario y/o contraseña")
            User.Focus()
        End If
    End Sub
End Class
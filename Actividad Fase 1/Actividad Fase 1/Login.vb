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
        Else
            Cursos.Show()
            Me.Close()

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registrate.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Dim salir As Byte

        salir = MsgBox("Desea salir de la aplicación?", 32 + 4, "SALIR...")
        If salir = 6 Then
            End
        End If
    End Sub
End Class
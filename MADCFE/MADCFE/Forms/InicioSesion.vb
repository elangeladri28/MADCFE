Public Class InicioSesion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonInicioSesion_Iniciar_Click(sender As Object, e As EventArgs) Handles ButtonInicioSesion_Iniciar.Click
        Dim Menu As New MenuPrincipalEmpleado()
        Me.Hide()
        Menu.ShowDialog()
        Me.Close()
    End Sub
End Class

Public Class InicioSesion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonInicioSesion_Iniciar_Click(sender As Object, e As EventArgs) Handles ButtonInicioSesion_Iniciar.Click
        If ComboBoxInicioSesion_Tipo.Text = "Empleado" Then
            Dim Menu As New MenuPrincipalEmpleado()
            Me.Hide()
            Menu.ShowDialog()
            Me.Close()
        End If

        If ComboBoxInicioSesion_Tipo.Text = "Cliente" Then
            Dim MenuUser As New ConsultarRecibo()
            Me.Hide()
            MenuUser.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class

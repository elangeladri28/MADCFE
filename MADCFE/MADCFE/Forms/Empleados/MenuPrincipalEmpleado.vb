Public Class MenuPrincipalEmpleado
    Private Sub MenuPrincipalEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdministrarClientesToolStripMenuItem_MenuEmpleado_Click(sender As Object, e As EventArgs) Handles AdministrarClientesToolStripMenuItem_MenuEmpleado.Click
        Dim AdminClientes As New AdministrarClientes()

        AdminClientes.ShowDialog()

    End Sub
End Class
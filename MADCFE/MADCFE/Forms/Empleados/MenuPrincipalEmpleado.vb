Public Class MenuPrincipalEmpleado
    Private Sub MenuPrincipalEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdministrarClientesToolStripMenuItem_MenuEmpleado_Click(sender As Object, e As EventArgs) Handles AdministrarClientesToolStripMenuItem_MenuEmpleado.Click
        Dim AdminClientes As New Usuarios()

        AdminClientes.ShowDialog()

    End Sub

    Private Sub AdministrarUsuarios_MenuEmpleado_Click(sender As Object, e As EventArgs) Handles AdministrarUsuarios_MenuEmpleado.Click

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
    End Sub

    Private Sub Tarifas_Cargas_MenuEmpleado_Click(sender As Object, e As EventArgs) Handles Tarifas_Cargas_MenuEmpleado.Click
        Dim Tarifas As New Tarifas()

        Tarifas.ShowDialog()

    End Sub

    Private Sub DomiciliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomiciliosToolStripMenuItem.Click
        Dim domicilios As New Domicilios()
        domicilios.ShowDialog()
    End Sub

    Private Sub MedidoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedidoresToolStripMenuItem.Click
        Dim Medidores As New Medidores()
        Medidores.ShowDialog()
    End Sub

    Private Sub Consumos_Cargas_MenuPrincipal_Click(sender As Object, e As EventArgs) Handles Consumos_Cargas_MenuPrincipal.Click
        Dim consumos As New Consumos()
        consumos.ShowDialog()
    End Sub
End Class
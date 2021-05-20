Public Class Consumos
    Private Sub Consumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvConsumos_Clientes.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvConsumos_Clientes.DataMember = "users"
    End Sub
End Class
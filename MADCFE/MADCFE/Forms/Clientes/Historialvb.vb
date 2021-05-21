Public Class Historial
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvHistorial_Usuarios.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvHistorial_Usuarios.DataMember = "users"
    End Sub
End Class
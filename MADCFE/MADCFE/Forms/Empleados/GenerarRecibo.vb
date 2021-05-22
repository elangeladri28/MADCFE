Public Class GenerarRecibo
    Private Sub dgvRecibo_Usuarios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecibo_Usuarios.RowHeaderMouseClick
        Dim qry As New Usuarios_Querys()
        dgvRecibo_Usuarios.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvRecibo_Usuarios.DataMember = "users"
    End Sub

    Private Sub dgvRecibo_Medidor_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecibo_Medidor.RowHeaderMouseClick
        Dim qry As New Medidores_Querys()
        dgvRecibo_Medidor.DataSource = qry.SelectElectricityMetersByClient(Globals.username)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblRecibos_idPeriodo.Click

    End Sub

    Private Sub dgvRecibo_Medidor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecibo_Medidor.CellContentClick

    End Sub
End Class
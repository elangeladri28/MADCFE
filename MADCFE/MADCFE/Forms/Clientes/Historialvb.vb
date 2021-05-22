Public Class Historial
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim qry As New Usuarios_Querys()
        dgvHistorial_Usuarios.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvHistorial_Usuarios.DataMember = "users"

    End Sub

    Private Sub dgvHistorial_Usuarios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHistorial_Usuarios.RowHeaderMouseClick

        lblIDHistorial_Cliente.Text = dgvHistorial_Usuarios.CurrentRow.Cells(0).Value
        Dim id As String = lblIDHistorial_Cliente.Text

        If id <> "" Then
            Dim qry As New Medidores_Querys()
            dgvHistorial_Medidores.DataSource = qry.SelectElectricityMetersByClient(id)
            dgvHistorial_Medidores.DataMember = "electricityMeters"
        End If

    End Sub

    Private Sub dgvHistorial_Medidores_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHistorial_Medidores.RowHeaderMouseClick
        lblIDHistorial_Medidor.Text = dgvHistorial_Medidores.CurrentRow.Cells(0).Value
        Dim id As String = lblIDHistorial_Medidor.Text
        Dim idcliente As String = lblIDHistorial_Cliente.Text
        If id <> "" Then
            Dim qry As New Historial_Querys()
            dgvHistorial_Historial.DataSource = qry.SelectAllFromHistorial(idcliente, id)
            dgvHistorial_Historial.DataMember = "historial"
        End If
    End Sub
End Class
Public Class Domicilios
    Private Sub Domicilios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvDomicilios_Clientes.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvDomicilios_Clientes.DataMember = "users"
    End Sub

    Private Sub dgvDomicilios_Clientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDomicilios_Clientes.RowHeaderMouseClick
        lblDomicilios_idClient.Text = dgvDomicilios_Clientes.CurrentRow.Cells(0).Value
        Dim id As String = lblDomicilios_idClient.Text
        If id <> "" Then
            Dim qry As New Domicilios_Querys()
            dgvDomicilios_Domicilios.DataSource = qry.SelectAllClientLocations(id)
            dgvDomicilios_Domicilios.DataMember = "locations"
        End If

    End Sub

    Private Sub dgvDomicilios_Domicilios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDomicilios_Domicilios.RowHeaderMouseClick
        lblDomicilios_idDomicilio.Text = dgvDomicilios_Domicilios.CurrentRow.Cells(0).Value
        txtDomicilios_Direccion.Text = dgvDomicilios_Domicilios.CurrentRow.Cells(3).Value
        txtDomicilios_Ciudad.Text = dgvDomicilios_Domicilios.CurrentRow.Cells(4).Value
        txtDomicilios_Estado.Text = dgvDomicilios_Domicilios.CurrentRow.Cells(5).Value
        txtDomicilios_CodigoPostal.Text = dgvDomicilios_Domicilios.CurrentRow.Cells(6).Value
        chbDomicilios_Activo.Checked = dgvDomicilios_Domicilios.CurrentRow.Cells(7).Value
    End Sub

    Private Sub btnDomicilios_Insertar_Click(sender As Object, e As EventArgs) Handles btnDomicilios_Insertar.Click
        Dim address As String = txtDomicilios_Direccion.Text
        Dim city As String = txtDomicilios_Ciudad.Text
        Dim state As String = txtDomicilios_Estado.Text
        Dim pc As String = txtDomicilios_CodigoPostal.Text

        lblDomicilios_idClient.Text = dgvDomicilios_Clientes.CurrentRow.Cells(0).Value
        Dim id As String = lblDomicilios_idClient.Text
        Dim qry As New Domicilios_Querys()
        qry.InsertLocation(id, address, city, state, pc, Globals.username)
        dgvDomicilios_Domicilios.DataSource = qry.SelectAllClientLocations(id)
        dgvDomicilios_Domicilios.DataMember = "locations"
    End Sub

    Private Sub btnDomicilios_Editar_Click(sender As Object, e As EventArgs) Handles btnDomicilios_Editar.Click
        Dim idClient = lblDomicilios_idClient.Text
        Dim id As String = lblDomicilios_idDomicilio.Text
        Dim address As String = txtDomicilios_Direccion.Text
        Dim city As String = txtDomicilios_Ciudad.Text
        Dim state As String = txtDomicilios_Estado.Text
        Dim pc As String = txtDomicilios_CodigoPostal.Text
        Dim active As Boolean = chbDomicilios_Activo.Checked

        Dim qry As New Domicilios_Querys()
        qry.UpdateLocation(id, address, city, state, pc, active, Globals.username)
        dgvDomicilios_Domicilios.DataSource = qry.SelectAllClientLocations(idClient)
        dgvDomicilios_Domicilios.DataMember = "locations"
    End Sub

    Private Sub btnDomicilios_Eliminar_Click(sender As Object, e As EventArgs) Handles btnDomicilios_Eliminar.Click
        Dim id As String = lblDomicilios_idDomicilio.Text
        Dim idClient = lblDomicilios_idClient.Text

        Dim qry As New Domicilios_Querys()
        qry.DeleteLocation(id)
        dgvDomicilios_Domicilios.DataSource = qry.SelectAllClientLocations(idClient)
        dgvDomicilios_Domicilios.DataMember = "locations"
    End Sub
End Class
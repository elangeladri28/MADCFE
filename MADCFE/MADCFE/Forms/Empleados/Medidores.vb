Public Class Medidores
    Private Sub Medidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvMedidores_Clientes.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvMedidores_Clientes.DataMember = "users"

        Dim cargarComboRegimen As New Tarifas_Querys()
        cbMedidores_Regimen.DataSource = cargarComboRegimen.SelectAllRatesNames()
        cbMedidores_Regimen.DisplayMember = "rateName"
        cbMedidores_Regimen.SelectedItem = Nothing
    End Sub

    Private Sub dgvMedidores_Clientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMedidores_Clientes.RowHeaderMouseClick
        lblMedidores_idCliente.Text = dgvMedidores_Clientes.CurrentRow.Cells(0).Value
        Dim id As String = lblMedidores_idCliente.Text
        If id <> "" Then
            Dim qry As New Domicilios_Querys()
            dgvMedidores_Domicilio.DataSource = qry.SelectAllClientLocations(id)
            dgvMedidores_Domicilio.DataMember = "locations"
        End If
    End Sub

    Private Sub dgvMedidores_Domicilio_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMedidores_Domicilio.RowHeaderMouseClick
        lblMedidores_idDomicilio.Text = dgvMedidores_Domicilio.CurrentRow.Cells(0).Value
        Dim id As String = lblMedidores_idDomicilio.Text
        txtMedidores_NombreCliente.Text = dgvMedidores_Domicilio.CurrentRow.Cells(1).Value
        txtMedidores_Calle.Text = dgvMedidores_Domicilio.CurrentRow.Cells(3).Value
        Dim client As String = lblMedidores_idCliente.Text

        Dim qry As New Medidores_Querys()
        dgvMedidores_Medidores.DataSource = qry.SelectElectricityMetersByClient(client)
        dgvMedidores_Medidores.DataMember = "electricityMeters"
    End Sub

    Private Sub cbMedidores_Regimen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMedidores_Regimen.SelectedIndexChanged
        Try
            Dim dgv As New Tarifas_Querys()
            Dim price As String = cbMedidores_Regimen.Text
            dgv_invi.DataSource = dgv.SelectRatesPricesByName(price)
            dgv_invi.DataMember = "rates"

            'If (dgv_invi.Columns.Count <> 0) Then
            '    dgv_invi.Columns.Item(0).HeaderText = "Precio Base"
            '    dgv_invi.Columns.Item(1).HeaderText = "Precio Intermedio"
            '    dgv_invi.Columns.Item(2).HeaderText = "Precio Excedente"
            'End If

            txtMedidores_PrecioBase.Text = ""
            txtMedidores_PrecioIntermedio.Text = ""
            txtMedidores_PrecioExcedente.Text = ""

            txtMedidores_PrecioBase.Text = dgv_invi.Rows(0).Cells(0).Value
            txtMedidores_PrecioIntermedio.Text = dgv_invi.Rows(0).Cells(1).Value
            txtMedidores_PrecioExcedente.Text = dgv_invi.Rows(0).Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMedidores_Insertar_Click(sender As Object, e As EventArgs) Handles btnMedidores_Insertar.Click
        Dim client As String = lblMedidores_idCliente.Text
        Dim address As String = lblMedidores_idDomicilio.Text
        Dim regimen As String = cbMedidores_Regimen.Text
        Dim cobro As String = cbMedidores_PeriodoCobro.SelectedItem.ToString()

        Dim qry As New Medidores_Querys()
        qry.InsertElectricityMeter(regimen, client, address, cobro, Globals.username)
        dgvMedidores_Medidores.DataSource = qry.SelectElectricityMetersByClient(client)
        dgvMedidores_Medidores.DataMember = "electricityMeters"

    End Sub

    Private Sub btnMedidores_Editar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
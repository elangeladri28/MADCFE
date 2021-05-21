﻿Public Class Consumos
    Private Sub Consumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Consumption_Querys()
        dgvConsumos_Clientes.DataSource = qry.SelectClientsConsumption()
        dgvConsumos_Clientes.DataMember = "comsumption"
    End Sub

    Private Sub txtConsumos_NombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsumos_NombreCliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtConsumos_Kw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsumos_Kw.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgvConsumos_Clientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvConsumos_Clientes.RowHeaderMouseClick
        txtboxConsumos_NombreCliente.Text = dgvConsumos_Clientes.CurrentRow.Cells(1).Value
        txtboxConsumos_Domicilio.Text = dgvConsumos_Clientes.CurrentRow.Cells(2).Value
        txtConsumos_Medidor.Text = dgvConsumos_Clientes.CurrentRow.Cells(4).Value
        txtboxConsumos_Regimen.Text = dgvConsumos_Clientes.CurrentRow.Cells(5).Value
        lblConsumos_Username.Text = dgvConsumos_Clientes.CurrentRow.Cells(0).Value

        Try
            Dim dgv As New Tarifas_Querys()
            Dim price As String = txtboxConsumos_Regimen.Text
            dgv_invi_consumos.DataSource = dgv.SelectRatesPricesByName(price)
            dgv_invi_consumos.DataMember = "rates"

            txtConsumos_PrecioBase.Text = ""
            txtConsumos_PrecioIntermedio.Text = ""
            txtConsumos_PrecioExcedente.Text = ""

            txtConsumos_PrecioBase.Text = dgv_invi_consumos.Rows(0).Cells(0).Value
            txtConsumos_PrecioIntermedio.Text = dgv_invi_consumos.Rows(0).Cells(1).Value
            txtConsumos_PrecioExcedente.Text = dgv_invi_consumos.Rows(0).Cells(2).Value

            Dim qry As New Consumption_Querys()
            dgvConsumos_Consumos.DataSource = qry.SelectClientsConsumption()
            dgvConsumos_Consumos.DataMember = "comsumption"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsumos_Insertar_Click(sender As Object, e As EventArgs) Handles btnConsumos_Insertar.Click
        Dim Client As String = txtboxConsumos_NombreCliente.Text
        Dim Regimen As String = txtboxConsumos_Regimen.Text
        Dim electricityMeter As String = txtConsumos_Medidor.Text
        Dim kw As String = txtConsumos_Kw.Text
        Dim fecha As String = dtpConsumos_Date.Value

        Dim qry As New Consumption_Querys()
        qry.InsertComsumption(Client, Regimen, electricityMeter, kw, fecha, Globals.username)
        dgvConsumos_Consumos.DataSource = qry.SelectClientsConsumption()
        dgvConsumos_Consumos.DataMember = "comsumption"

    End Sub
End Class
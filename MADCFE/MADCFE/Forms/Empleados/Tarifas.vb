Public Class Tarifas
    Private Sub Tarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Tarifas_Querys()
        dgvTarifas.DataSource = qry.SelectAllFromRates()
        dgvTarifas.DataMember = "rates"
    End Sub

    Private Sub btnTarifas_Insertar_Click(sender As Object, e As EventArgs) Handles btnTarifas_Insertar.Click
        Dim RateName As String = txtTarifas_Nombre.Text
        Dim RateType As String = cbTarifas_Tipo.SelectedItem.ToString()
        Dim BaseRate As String = txtTarifas_Base.Text
        Dim IntermediateRate As String = txtTarifas_Intermedia.Text
        Dim ExcedentRate As String = txtTarifas_Excedente.Text
        Dim Check As Boolean = chbTarifas_Activo.Checked
        Dim Fecha As Date = dtpTarifas_Fecha.Value

        Dim qry As New Tarifas_Querys()
        qry.InsertRate(RateName, RateType, BaseRate, IntermediateRate, ExcedentRate, Check, Fecha, Globals.username)
        dgvTarifas.DataSource = qry.SelectAllFromRates()
        dgvTarifas.DataMember = "rates"

    End Sub

    Private Sub dgvTarifas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTarifas.RowHeaderMouseClick
        lblTarifa_id.Text = dgvTarifas.CurrentRow.Cells(0).Value
        txtTarifas_Nombre.Text = dgvTarifas.CurrentRow.Cells(1).Value
        cbTarifas_Tipo.SelectedItem = dgvTarifas.CurrentRow.Cells(2).Value
        txtTarifas_Base.Text = dgvTarifas.CurrentRow.Cells(3).Value
        txtTarifas_Intermedia.Text = dgvTarifas.CurrentRow.Cells(4).Value
        txtTarifas_Excedente.Text = dgvTarifas.CurrentRow.Cells(5).Value
        chbTarifas_Activo.Checked = dgvTarifas.CurrentRow.Cells(6).Value
        dtpTarifas_Fecha.Value = dgvTarifas.CurrentRow.Cells(7).Value
    End Sub

    Private Sub btnTarifas_Editar_Click(sender As Object, e As EventArgs) Handles btnTarifas_Editar.Click
        Dim id As Integer = lblTarifa_id.Text
        Dim RateName As String = txtTarifas_Nombre.Text
        Dim RateType As String = cbTarifas_Tipo.Text
        Dim BaseRate As String = txtTarifas_Base.Text
        Dim IntermediateRate As String = txtTarifas_Intermedia.Text
        Dim ExcedentRate As String = txtTarifas_Excedente.Text
        Dim Check As Boolean = chbTarifas_Activo.Checked
        Dim Fecha As Date = dtpTarifas_Fecha.Value

        Dim qry As New Tarifas_Querys()
        qry.UpdateRate(id, RateName, RateType, BaseRate, IntermediateRate, ExcedentRate, Check, Fecha, Globals.username)
        dgvTarifas.DataSource = qry.SelectAllFromRates()
        dgvTarifas.DataMember = "rates"
    End Sub

    Private Sub btnTaifas_Eliminar_Click(sender As Object, e As EventArgs) Handles btnTaifas_Eliminar.Click
        Dim id As String = lblTarifa_id.Text
        Dim qry As New Tarifas_Querys()
        qry.DeleteRate(id)
        dgvTarifas.DataSource = qry.SelectAllFromRates()
        dgvTarifas.DataMember = "rates"
    End Sub
End Class
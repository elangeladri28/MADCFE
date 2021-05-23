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


        If txtTarifas_Nombre.Text <> "" And cbTarifas_Tipo.Text <> "" And txtTarifas_Base.Text And txtTarifas_Intermedia.Text And
            txtTarifas_Excedente.Text <> "" Then

            Dim qry As New Tarifas_Querys()
            qry.InsertRate(RateName, RateType, BaseRate, IntermediateRate, ExcedentRate, Check, Fecha, Globals.username)
            dgvTarifas.DataSource = qry.SelectAllFromRates()
            dgvTarifas.DataMember = "rates"

        Else
            MessageBox.Show("Faltan Datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If





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

        If txtTarifas_Nombre.Text <> "" And cbTarifas_Tipo.Text <> "" And txtTarifas_Base.Text And txtTarifas_Intermedia.Text And
            txtTarifas_Excedente.Text <> "" Then

            Dim qry As New Tarifas_Querys()
            qry.UpdateRate(id, RateName, RateType, BaseRate, IntermediateRate, ExcedentRate, Check, Fecha, Globals.username)
            dgvTarifas.DataSource = qry.SelectAllFromRates()
            dgvTarifas.DataMember = "rates"

        Else

            MessageBox.Show("Faltan Datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub

    Private Sub btnTaifas_Eliminar_Click(sender As Object, e As EventArgs) Handles btnTaifas_Eliminar.Click

        Dim Respuesta As String = MessageBox.Show("¿Estas seguro de que quieres borrar a este usuario?", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If Respuesta = vbYes Then

            Dim id As String = lblTarifa_id.Text
            Dim qry As New Tarifas_Querys()
            qry.DeleteRate(id)
            dgvTarifas.DataSource = qry.SelectAllFromRates()
            dgvTarifas.DataMember = "rates"

        End If

    End Sub

    Private Sub txtTarifas_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifas_Nombre.KeyPress
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

    Private Sub txtTarifas_Base_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifas_Base.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTarifas_Intermedia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifas_Intermedia.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTarifas_Excedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifas_Excedente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTarifas_FiltroYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTarifas_FiltroYear.KeyPress
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

    Private Sub btnTarifas_Filtrar_Click(sender As Object, e As EventArgs) Handles btnTarifas_Filtrar.Click

    End Sub
End Class
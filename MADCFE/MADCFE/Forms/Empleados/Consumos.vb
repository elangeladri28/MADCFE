Public Class Consumos
    Private Sub Consumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvConsumos_Clientes.DataSource = qry.SelectAllClientsFromUsuarios()
        dgvConsumos_Clientes.DataMember = "users"
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
End Class
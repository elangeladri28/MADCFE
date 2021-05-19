Imports MADCFE.Globals

Public Class Usuarios
    Private Sub AdministrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As New Usuarios_Querys()
        dgvUsuarios.DataSource = qry.SelectAllFromUsuarios()
        dgvUsuarios.DataMember = "users"
    End Sub

    Private Sub btnUsuarios_Insertar_Click(sender As Object, e As EventArgs) Handles btnUsuarios_Insertar.Click
        Dim username As String = txtUsuarios_Username.Text
        Dim password As String = txtUsuarios_Password.Text
        Dim userType As String = cbUsuarios_TipoUsuario.SelectedItem.ToString()
        Dim fullname As String = txtUsuarios_Nombre.Text
        Dim curp As String = txtUsuarios_Curp.Text
        Dim rfc As String = txtUsuarios_Rfc.Text
        Dim fecha As Date = dtpUsuarios_FechaNacimiento.Value
        Dim gender As String = cbUsuarios_Genero.SelectedItem.ToString()


        Dim qry As New Usuarios_Querys()
        qry.InsertUsuario(username, password, userType, fullname, curp, rfc, fecha, gender, Globals.username)
        dgvUsuarios.DataSource = qry.SelectAllFromUsuarios()
        dgvUsuarios.DataMember = "users"
    End Sub

    Private Sub dgvUsuarios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.RowHeaderMouseClick

        lblUsuarios_id.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        txtUsuarios_Username.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        txtUsuarios_Password.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        cbUsuarios_TipoUsuario.SelectedItem = dgvUsuarios.CurrentRow.Cells(3).Value
        txtUsuarios_Nombre.Text = dgvUsuarios.CurrentRow.Cells(4).Value
        txtUsuarios_Curp.Text = dgvUsuarios.CurrentRow.Cells(5).Value
        txtUsuarios_Rfc.Text = dgvUsuarios.CurrentRow.Cells(6).Value
        dtpUsuarios_FechaNacimiento.Value = dgvUsuarios.CurrentRow.Cells(7).Value
        cbUsuarios_Genero.SelectedItem = dgvUsuarios.CurrentRow.Cells(8).Value
        lblUsuarios_Tried.Text = dgvUsuarios.CurrentRow.Cells(9).Value
        txtUsuarios_Modificado.Text = dgvUsuarios.CurrentRow.Cells(10).Value
        chbUsuarios_Bloqueado.Checked = dgvUsuarios.CurrentRow.Cells(12).Value
        chbUsuarios_Activo.Checked = dgvUsuarios.CurrentRow.Cells(13).Value

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbUsuarios_Bloqueado.CheckedChanged

    End Sub

    Private Sub btnUsuarios_Editar_Click(sender As Object, e As EventArgs) Handles btnUsuarios_Editar.Click
        Dim id As Integer = lblUsuarios_id.Text
        Dim username As String = txtUsuarios_Username.Text
        Dim password As String = txtUsuarios_Password.Text
        Dim userType As String = cbUsuarios_TipoUsuario.SelectedItem.ToString()
        Dim fullname As String = txtUsuarios_Nombre.Text
        Dim curp As String = txtUsuarios_Curp.Text
        Dim rfc As String = txtUsuarios_Rfc.Text
        Dim fecha As Date = dtpUsuarios_FechaNacimiento.Value
        Dim gender As String = cbUsuarios_Genero.SelectedItem.ToString()
        Dim tried As String = lblUsuarios_Tried.Text
        Dim blocked As Boolean = chbUsuarios_Bloqueado.Checked
        Dim active As Boolean = chbUsuarios_Activo.Checked

        Dim qry As New Usuarios_Querys()
        qry.UpdateUsuario(id, username, password, userType, fullname, curp, rfc, fecha, gender, tried, Globals.username, blocked, active)
        dgvUsuarios.DataSource = qry.SelectAllFromUsuarios()
        dgvUsuarios.DataMember = "users"
    End Sub

    Private Sub btnUsuarios_Eliminar_Click(sender As Object, e As EventArgs) Handles btnUsuarios_Eliminar.Click
        Dim id As String = lblUsuarios_id.Text
        Dim qry As New Usuarios_Querys()
        qry.DeleteUsuario(id)
        dgvUsuarios.DataSource = qry.SelectAllFromUsuarios()
        dgvUsuarios.DataMember = "users"
    End Sub
End Class
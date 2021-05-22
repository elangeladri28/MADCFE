Imports MADCFE.Globals

Public Class InicioSesion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MAD_CFEDataSet.rememberMe' table. You can move, or remove it, as needed.
        Dim qry As New Usuarios_Querys()
        Dim lista As New AutoCompleteStringCollection
        dgvLogin_Users.DataSource = qry.SelectAllUsernames()
        dgvLogin_Users.DataMember = "users"
        For Each dr As DataGridViewRow In dgvLogin_Users.Rows
            lista.Add(dr.Cells(0).Value)
        Next
        Dim numero As Integer = lista.Count
        lista.RemoveAt(numero - 1)
        'TextBoxInicioSesion_Usuario.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBoxInicioSesion_Usuario.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBoxInicioSesion_Usuario.AutoCompleteCustomSource = lista
    End Sub

    Private Sub ButtonInicioSesion_Iniciar_Click(sender As Object, e As EventArgs) Handles ButtonInicioSesion_Iniciar.Click
        Dim username As String = TextBoxInicioSesion_Usuario.Text
        Dim password As String = TextBoxInicioSesion_Contraseña.Text
        Globals.username = username
        Globals.TipoUsuario = ComboBoxInicioSesion_Tipo.Text
        Dim qry As New Usuarios_Querys()
        dgvLogin_Users.DataSource = qry.IniciarSesion(username, password)
        dgvLogin_Users.DataMember = "users"


        If ComboBoxInicioSesion_Tipo.Text <> "" And TextBoxInicioSesion_Usuario.Text <> "" And TextBoxInicioSesion_Contraseña.Text <> "" Then
            If dgvLogin_Users.Rows.Count >= 1 Then
                If ComboBoxInicioSesion_Tipo.Text = "Empleado" Then
                    Dim Menu As New MenuPrincipalEmpleado()
                    Me.Hide()
                    Menu.ShowDialog()
                    Me.Close()
                End If

                If ComboBoxInicioSesion_Tipo.Text = "Cliente" Then
                    Dim MenuUser As New ConsultarRecibo()
                    Me.Hide()
                    MenuUser.ShowDialog()
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("Faltan Datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If chbIniciarSesion_RememberMe.Checked Then

        End If
    End Sub

    Private Sub TextBoxInicioSesion_Usuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInicioSesion_Usuario.TextChanged

    End Sub

    Private Sub TextBoxInicioSesion_Contraseña_Enter(sender As Object, e As EventArgs) Handles TextBoxInicioSesion_Contraseña.Enter
        Dim username As String = TextBoxInicioSesion_Usuario.Text
        Dim qry As New Usuarios_Querys()
        dgvLogin_password.DataSource = qry.SearchPassword(username)
        dgvLogin_password.DataMember = "users"

        If dgvLogin_password.Rows.Count > 0 Then
            TextBoxInicioSesion_Contraseña.Text = dgvLogin_password.Rows(0).Cells(0).Value
        End If

    End Sub
End Class

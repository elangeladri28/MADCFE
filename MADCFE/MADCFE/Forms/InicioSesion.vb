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
        Dim Tipo As String = ComboBoxInicioSesion_Tipo.Text
        Dim Bloqueado As Boolean

        Globals.username = username
     
        Globals.password = password

        If ComboBoxInicioSesion_Tipo.Text <> "" And TextBoxInicioSesion_Usuario.Text <> "" And TextBoxInicioSesion_Contraseña.Text <> "" Then

            Dim qry As New Usuarios_Querys()
            dgviniciosesion.DataSource = qry.InicioCheto(username, password, Tipo)
            dgviniciosesion.DataMember = "users"

            Try

                username = dgviniciosesion.CurrentRow.Cells(0).Value.ToString()
                Bloqueado = dgviniciosesion.Rows(0).Cells(1).Value

                If Bloqueado = True Then

                    MessageBox.Show("Cuenta Bloqueada, contacta a el administrador", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

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




            Catch ex As Exception

                Try

                    dgvnopassword.DataSource = qry.InicioSinPassword(username, Tipo)
                    dgvnopassword.DataMember = "users"

                    username = dgvnopassword.CurrentRow.Cells(0).Value.ToString()
                    Bloqueado = dgviniciosesion.Rows(0).Cells(1).Value


                    If Bloqueado = True Then

                        MessageBox.Show("Cuenta Bloqueada, contacta a el administrador", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else


                        MessageBox.Show("Contraseña incorrecta", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Globals.Attempts = Globals.Attempts + 1

                        If Globals.Attempts > 3 Then

                            MessageBox.Show("Cuenta Bloqueada, contacta a el administrador", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Globals.Attempts = 0
                            dgvnopassword.DataSource = qry.BloqueoUsuario(username, Tipo)
                            dgvnopassword.DataMember = "users"
                        End If

                    End If

                Catch exe As Exception

                    MessageBox.Show("No existe o Faltan Datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try


            End Try



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

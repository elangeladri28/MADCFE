Imports System.Data.SqlClient

Public Class Usuarios_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()
    Dim dt As New DataTable()

    Public Function SelectAllFromUsuarios()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllFromUsers;"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InicioCheto(username As String, password As String, Tipo As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC InicioSesion '" + username + "','" + password + "','" + Tipo + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()

            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InicioSinPassword(username As String, Tipo As String)

        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC InicioSinPassword '" + username + "','" + Tipo + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()

            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function BloqueoUsuario(username As String, Tipo As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()
            Dim var() As String = {username, Tipo}
            Dim query As String = String.Format("EXEC BloqueoUsuario '{0}', '{1}';", var)
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Public Function InsertUsuario(username As String, userPassword As String, userType As String, fullname As String, curp As String, rfc As String, birthday As Date, gender As String, user As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()
            Dim query As String = "EXEC InsertUser '" + username + "', '" + userPassword + "', '" + userType + "', '" + fullname + "', '" +
                curp + "', '" + rfc + "', '" + birthday.ToString() + "', '" + gender + "', 0, '" + user + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function UpdateUsuario(id As String, username As String, userPassword As String, userType As String, fullname As String, curp As String, rfc As String, birthday As Date, gender As String,
                                  tried As Integer, modifiedBy As String, blocked As Boolean, active As Boolean)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()
            Dim var() As String = {id, username, userPassword, userType, fullname, curp, rfc, birthday, gender, tried, modifiedBy, blocked, active}
            Dim query As String = String.Format("EXEC UpdateUser {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, '{10}', {11}, {12};", var)
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function DeleteUsuario(id As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()
            Dim query As String = "EXEC DeleteUser " + id + ";"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SelectAllClientsFromUsuarios()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllClientsFromUsers;"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SearchUsername(username As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "SELECT username FROM users WHERE username LIKE %" + username + "%;"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception

        End Try
    End Function

    Public Function SelectAllUsernames()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "SELECT username FROM users WHERE active = 1"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SearchPassword(username As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "
DECLARE @id int;
SET @id = (SELECT id from users WHERE username = '" + username + "');
SELECT userPassword FROM rememberMe WHERE idUser = @id;"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function






    Public Function IniciarSesion(username As String, password As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "SELECT username, userPassword FROM users WHERE username = '" + username + "' AND userPassword = '" + password + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetIdByUsername(username As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "SELECT id, fullname, username, birthday FROM users WHERE username = '" + username + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "users")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class

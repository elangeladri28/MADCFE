Imports System.Data.SqlClient
Public Class Historial_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromHistorial(client As String, electricityMeter As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllFromHistorial " + client + "," + electricityMeter + ";"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "historial")
            conn.DisconnectSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


End Class

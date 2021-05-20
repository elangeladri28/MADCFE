Imports System.Data.SqlClient
Public Class Medidores_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromElectricityMeters()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllFromElectricityMeters"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "electricityMeters")
            conn.DisconnectSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Public Function InsertElectricityMeter(regimen As String, client As String, location As String, billingPeriod As String, modifiedBy As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim var() = {regimen, client, location, billingPeriod, modifiedBy}
            Dim query As String = String.Format("EXEC InsertElectricityMeter '{0}', {1}, {2}, '{3}', '{4}';", var)
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "electricityMeters")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function




End Class

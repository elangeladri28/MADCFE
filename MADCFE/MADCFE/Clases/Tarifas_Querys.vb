Imports System.Data.SqlClient

Public Class Tarifas_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromRates()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllFromRates;"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "rates")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InsertRate(rateName As String, rateType As String, baseRate As String, intermediateRate As String, excedentRate As String, active As Boolean, fecha As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC InsertRate '" + rateName + "','" + rateType + "'," + baseRate + "," + intermediateRate + "," + excedentRate + ",'" + active + "','" + fecha + "';"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "rates")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function UpdateRate(id As String, rateName As String, rateType As String, baseRate As Decimal,
                               intermediateRate As Decimal, excedentRate As Decimal, active As Boolean, fecha As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim var() As String = {id, rateName, rateType, baseRate, intermediateRate, excedentRate, active, fecha}
            Dim query As String = String.Format("EXEC UpdateRate {0}, '{1}', '{2}', {3}, {4}, {5}, {6}, '{7}';", var)
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "rates")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function DeleteRate(id As String)
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC DeleteRate " + id + ";"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "rates")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class

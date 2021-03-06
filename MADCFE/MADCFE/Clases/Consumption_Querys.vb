Imports System.Data.SqlClient

Public Class Consumption_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectClientsConsumption()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectClientsConsumption"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "comsumption")
            conn.DisconnectSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SelectAllConsumptions()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectAllConsumptions"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "comsumption")
            conn.DisconnectSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InsertComsumption(client As String, regimen As String, electricityMeter As String, kwBase As String,
                                      kwIntermediate As String, kwExcedent As String, fecha As Date, modifiedBy As String)

        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim var() = {client, regimen, electricityMeter, kwBase, kwIntermediate, kwExcedent, fecha, modifiedBy}
            Dim query As String = String.Format("EXEC InsertComsumptionNew '{0}', '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}';", var)
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "comsumption")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


End Class

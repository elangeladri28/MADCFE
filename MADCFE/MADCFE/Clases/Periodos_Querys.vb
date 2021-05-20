Imports System.Data.SqlClient
Public Class Periodos_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()
    Public Function SelectBillingPeriodText()
        Try
            Dim conn As New SQL_Connection()
            conn.ConnectSQL()

            Dim query As String = "EXEC SelectBillingPeriodText"
            Dim sqlCom As New SqlCommand(query, conn.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "electricityMeters")
            conn.DisconnectSQL()
            Return ds
        Catch ex As Exception

        End Try
    End Function
End Class

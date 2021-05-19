Imports System.Data.SqlClient

Public Class SQL_Connection

    Public connectionString As String = Configuration.ConfigurationManager.AppSettings("ConnectionDB").ToString()
    Public connection As New SqlConnection(connectionString)
    Public dataadapter As New SqlDataAdapter()
    Public ds As New DataSet()

    Public Sub ConnectSQL()
        connection.Open()
    End Sub

    Public Sub DisconnectSQL()
        connection.Close()
    End Sub
End Class

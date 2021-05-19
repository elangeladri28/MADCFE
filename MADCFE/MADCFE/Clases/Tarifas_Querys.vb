Imports System.Data.SqlClient

Public Class Tarifas_Querys
    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromRates()
        Try

        Catch ex As Exception

        End Try
    End Function
End Class

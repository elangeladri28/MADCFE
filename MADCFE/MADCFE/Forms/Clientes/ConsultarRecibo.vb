Public Class ConsultarRecibo
    Private Sub ConsultarRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonConsultarRecibos_Pagar_Click(sender As Object, e As EventArgs) Handles ButtonConsultarRecibos_Pagar.Click
        Dim Pagar As New PagarRecibo()

        Pagar.ShowDialog()

    End Sub
End Class
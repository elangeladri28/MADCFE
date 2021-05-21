Public Class ConsultarRecibo
    Private Sub ConsultarRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonConsultarRecibos_Pagar_Click(sender As Object, e As EventArgs) Handles ButtonConsultarRecibos_Pagar.Click
        Dim Pagar As New PagarRecibo()

        Pagar.ShowDialog()



    End Sub

    Private Sub txtboxConsultarRecibo_NumMedidor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxConsultarRecibo_NumMedidor.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
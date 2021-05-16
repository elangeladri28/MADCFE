Public Class PagarRecibo
    Private Sub PagarRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxPagarRecibo_TipoTarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPagarRecibo_TipoTarjeta.SelectedIndexChanged
        If ComboBoxPagarRecibo_TipoTarjeta.Text <> "" Then
            TextBoxPagarRecibo_Numeracion.Enabled = True
            TextBoxPagarRecibo_Mes.Enabled = True
            TextBoxPagarRecibo_Year.Enabled = True
            TextBoxPagarRecibo_CVV.Enabled = True
            ButtonPagarRecibo_Pagar.Enabled = True
        End If
    End Sub
End Class
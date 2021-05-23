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

    Private Sub TextBoxPagarRecibo_Numeracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagarRecibo_Numeracion.KeyPress
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

    Private Sub TextBoxPagarRecibo_Mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagarRecibo_Mes.KeyPress
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

    Private Sub TextBoxPagarRecibo_Year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagarRecibo_Year.KeyPress
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

    Private Sub TextBoxPagarRecibo_CVV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagarRecibo_CVV.KeyPress
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

    Private Sub ButtonPagarRecibo_Generar_Click(sender As Object, e As EventArgs) Handles ButtonPagarRecibo_Generar.Click
        Dim Referencia As New Random(CInt(Date.Now.Ticks And Integer.MaxValue))



        Dim ValorFinal As String = System.Convert.ToString(Referencia.Next)

        MessageBox.Show("Referencia creada con exito tu referencia es: " + ValorFinal, "¡Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ButtonPagarRecibo_Pagar_Click(sender As Object, e As EventArgs) Handles ButtonPagarRecibo_Pagar.Click
        If TextBoxPagarRecibo_Numeracion.Text <> "" And TextBoxPagarRecibo_Mes.Text <> "" And TextBoxPagarRecibo_Year.Text <> "" And TextBoxPagarRecibo_CVV.Text <> "" Then

            MessageBox.Show("Pago Realizado", "¡Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else

            MessageBox.Show("Datos incompletos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class
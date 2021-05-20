Public Class Recibos
    Private Sub txtboxRecibos_NumeroServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxRecibos_NumeroServicio.KeyPress
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
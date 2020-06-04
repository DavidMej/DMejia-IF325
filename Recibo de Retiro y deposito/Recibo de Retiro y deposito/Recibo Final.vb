Public Class Recibo_Final


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            txtCliente2.Text = Module1.Date_begin
            txtSaldos2.Text = Module1.Date_total
        End If
    End Sub
    Private Sub btnSalir2_Click(sender As Object, e As EventArgs) Handles btnSalir2.Click

        End

    End Sub
End Class
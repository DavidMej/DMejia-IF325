Public Class Form1
    Private Sub btnSolicitar_Pedido_Click(sender As Object, e As EventArgs) Handles btnSolicitar_Pedido.Click

        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = mtbNoOrden.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                totalPagar += precio

            Next

            total = totalPagar / orden
            txtTotalPagar.Text = totalPagar
            txtPagoIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mtbNoOrden_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbNoOrden.MaskInputRejected

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        mtbNoOrden.Clear()
        txtTotalPagar.Clear()
        txtPagoIndividual.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        MsgBox("¿Esta seguro que desea salir?", vbInformation)
        End

    End Sub

End Class

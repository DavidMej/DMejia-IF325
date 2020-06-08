Public Class Numeros_Pares_e_Impares
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Pares, Impares, Positivos, Negativos As Integer
        Dim Datos, TotalNums, SumaTotal, residuo As Double

        Try
            If Val(txtDatos.Text) - Int(Val(txtDatos.Text)) = 0 And Val(txtDatos.Text) >= 0 Then
                TotalNums = Val(txtDatos.Text)

                For i = 1 To TotalNums Step 1
                    Datos = InputBox("Ingrese el valor x" & i, "Ingresar Datos")

                    residuo = Datos Mod 2
                    cmbValores.Items.Add(Datos)

                    If residuo = 0 Then
                        Pares += 1
                    Else
                        Impares += 1
                    End If
                    SumaTotal += Datos

                    If Datos > 0 Then
                        Positivos += 1
                    Else
                        Negativos += 1
                    End If
                Next
                txtPares.Text = Pares
                txtImpares.Text = Impares
                txtPositivos.Text = Positivos
                txtNegativos.Text = Negativos
                txtSuma.Text = SumaTotal
                txtTotalNums.Text = TotalNums
            Else
                MessageBox.Show("Es necesario que ingrese un valor entero positivo", "Error en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDatos.Clear()
        txtPares.Clear()
        txtImpares.Clear()
        txtPositivos.Clear()
        txtNegativos.Clear()
        txtTotalNums.Clear()
        txtSuma.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class
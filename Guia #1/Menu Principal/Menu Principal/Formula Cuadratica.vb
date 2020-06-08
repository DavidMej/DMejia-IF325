Public Class Formula_Cuadratica
    Private Sub Formula_Cuadratica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c As Integer
        Dim x1, x2 As Double

        a = CInt(txtXcuadrado.Text)
        b = CInt(txtXlineal.Text)
        c = CInt(txtTermIndependiente.Text)


        If txtXcuadrado.Text = "" Then
            MessageBox.Show("Debe ingresar un valor mayor a 0 en ´x2´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtXcuadrado.Focus()
            Return
        End If
        Try
            a = Convert.ToDouble(txtXcuadrado.Text)
        Catch ex As Exception
            MessageBox.Show("Debe ingresar un valor numerico mayor a 0 en ´x2´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtXcuadrado.Text = ""
            txtXcuadrado.Focus()
            Return
        End Try

        If txtXlineal.Text = "" Then
            MessageBox.Show("Debe ingresar un valor en ´x1´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtXlineal.Focus()
            Return
        End If
        Try
            b = Convert.ToDouble(txtXlineal.Text)
        Catch ex As Exception
            MessageBox.Show("Debe ingresar un valor numerico en ´x1´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtXlineal.Text = ""
            txtXlineal.Focus()
            Return
        End Try

        If txtTermIndependiente.Text = "" Then
            MessageBox.Show("Debe ingresar un valor en ´c´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTermIndependiente.Focus()
            Return
        End If
        Try
            c = Convert.ToDouble(txtTermIndependiente.Text)
        Catch ex As Exception
            MessageBox.Show("Debe ingresar un valor numerico en ´c´", "Error de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTermIndependiente.Text = ""
            txtTermIndependiente.Focus()
            Return
        End Try

        x1 = ((-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a))
        x2 = ((-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a))

        txtX1.Text = x1.ToString
        txtX2.Text = x2.ToString
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtXcuadrado.Clear()
        txtXlineal.Clear()
        txtTermIndependiente.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        MenuPrincipal.Show()
        Me.Hide()

    End Sub
End Class
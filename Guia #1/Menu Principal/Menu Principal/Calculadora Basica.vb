Public Class Calculadora_Basica

    Dim Operacion As String
    Dim valorResultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim total As Nullable(Of Double) = Nothing
    Dim Operador As Boolean

    Private Sub Calculadora_Basica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "0"
    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "1"
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "2"
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "3"
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "4"
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "5"
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "6"
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "7"
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "8"
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        Evaluar_Concatenar()
        txtPantalla.Text &= "9"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Evaluar_Operar()
        Operacion = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Evaluar_Operar()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Evaluar_Operar()
        Operacion = "x"
    End Sub

    Private Sub btnDivicion_Click(sender As Object, e As EventArgs) Handles btnDivicion.Click
        Evaluar_Operar()
        Operacion = "÷"
    End Sub

    Private Sub btnCleanPantalla_Click(sender As Object, e As EventArgs) Handles btnCleanPantalla.Click
        txtPantalla.Clear()
        valorResultado = Nothing
        valor2 = Nothing
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Evaluar_Operar()
        Operacion = ""
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Evaluar_Concatenar()
        If InStr(txtPantalla.Text, ".", CompareMethod.Text) = 0 Then
            txtPantalla.Text &= "."
        End If
    End Sub

    Private Sub txtPantalla_TextChanged(sender As Object, e As EventArgs) Handles txtPantalla.TextChanged

    End Sub

    Private Sub lstHistorial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistorial.SelectedIndexChanged

    End Sub

    Private Sub btnCleanHistorial_Click(sender As Object, e As EventArgs) Handles btnCleanHistorial.Click
        lstHistorial.Items.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        MenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub Evaluar_Operar()
        Operador = True
        valor2 = Val(txtPantalla.Text)
        If valorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    total = valorResultado + valor2
                    lstHistorial.Items.Add(valorResultado & "+" & valor2 & "=" & total)
                Case "-"
                    total = valorResultado - valor2
                    lstHistorial.Items.Add(valorResultado & "-" & valor2 & "=" & total)
                Case "x"
                    total = valorResultado * valor2
                    lstHistorial.Items.Add(valorResultado & "x" & valor2 & "=" & total)
                Case "÷"
                    total = valorResultado / valor2
                    lstHistorial.Items.Add(valorResultado & "÷" & valor2 & "=" & total)
            End Select
            txtPantalla.Text = total

        End If
        valorResultado = valor2
    End Sub

    Private Sub Evaluar_Concatenar()
        If Operador = True Then
            txtPantalla.Text = ""
            Operador = False
        ElseIf txtPantalla.Text = "0" Then
            txtPantalla.Text = ""
        End If
    End Sub

End Class
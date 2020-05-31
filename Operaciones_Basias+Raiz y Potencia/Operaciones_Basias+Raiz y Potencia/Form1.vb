Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Titulo.Click

    End Sub

    Private Sub valor1_Click(sender As Object, e As EventArgs) Handles valor1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub valor2_Click(sender As Object, e As EventArgs) Handles valor2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtValor2.TextChanged

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        'Inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim Suma As Integer
        Dim Resta As Integer
        Dim Multiplicacion As Integer
        Dim Divicion As String
        Dim Raiz1 As Double
        Dim Raiz2 As Double
        Dim Potencia As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'Proceso
        If chkSuma.Checked = True Then
            Suma = valor1 + valor2
            txtSuma.Text = Suma
        End If

        If chkResta.Checked = True Then
            Resta = valor1 - valor2
            txtResta.Text = Resta
        End If

        If chkMultiplicacion.Checked = True Then
            Multiplicacion = valor1 * valor2
            txtMultiplicacion.Text = Multiplicacion
        End If

        If chkDivicion.Checked = True Then
            Divicion = valor1 / valor2
            txtDivicion.Text = Divicion
            If valor2 = 0 Then
                Divicion = "Math error"
                MsgBox("Error!" & vbNewLine & "El valor 1 no puede ser dividido / 0", vbInformation)
            Else
                Divicion = valor1 / valor2
            End If
        End If
        If chkRaiz.Checked = True Then
            Raiz1 = valor1 * (1 / 2)
            Raiz2 = valor2 * (1 / 2)
            txtRaiz1.Text = Raiz1
            txtRaiz2.Text = Raiz2
        End If
        If chkPotencia.Checked = True Then
            Potencia = valor1 ^ valor2
            txtPotencia.Text = Potencia
        End If

        'Salidas
        txtSuma.Text = Suma
        txtResta.Text = Resta
        txtMultiplicacion.Text = Multiplicacion
        txtDivicion.Text = Divicion
        txtRaiz1.Text = Raiz1
        txtRaiz2.Text = Raiz2
        txtPotencia.Text = Potencia


    End Sub

    Private Sub Resutados_Click(sender As Object, e As EventArgs) Handles Resutados.Click

    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click

    End Sub

    Private Sub txtSuma_TextChanged(sender As Object, e As EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click

    End Sub

    Private Sub txtResta_TextChanged(sender As Object, e As EventArgs) Handles txtResta.TextChanged

    End Sub

    Private Sub Multiplicacion_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click

    End Sub

    Private Sub txtMultiplicacion_TextChanged(sender As Object, e As EventArgs) Handles txtMultiplicacion.TextChanged

    End Sub

    Private Sub Divicion_Click(sender As Object, e As EventArgs) Handles Divicion.Click

    End Sub

    Private Sub txtDivicion_TextChanged(sender As Object, e As EventArgs) Handles txtDivicion.TextChanged

    End Sub

    Private Sub Raiz1_Click(sender As Object, e As EventArgs) Handles Raiz1.Click

    End Sub

    Private Sub txtRaiz1_TextChanged(sender As Object, e As EventArgs) Handles txtRaiz1.TextChanged

    End Sub

    Private Sub Raiz2_Click(sender As Object, e As EventArgs) Handles Raiz2.Click

    End Sub

    Private Sub txtRaiz2_TextChanged(sender As Object, e As EventArgs) Handles txtRaiz2.TextChanged

    End Sub

    Private Sub Potencia_Click(sender As Object, e As EventArgs) Handles Potencia.Click

    End Sub

    Private Sub txtPotencia_TextChanged(sender As Object, e As EventArgs) Handles txtPotencia.TextChanged

    End Sub

    Private Sub BtnReintentar_Click(sender As Object, e As EventArgs) Handles BtnReintentar.Click

        txtValor1.Clear()
        txtValor2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivicion.Clear()
        txtRaiz1.Clear()
        txtRaiz2.Clear()
        txtPotencia.Clear()

        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivicion.Checked = False
        chkRaiz.Checked = False
        chkPotencia.Checked = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("¿Esta seguro que desea salir?", vbInformation)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click

        Dim valor1 As Int16

        If txtValor1.Text = "" Then
            MsgBox("Po favor escriva un numero en las casillas", vbAbortRetryIgnore)

        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico", vbAbortRetryIgnore)
            txtValor1.Text = ""
        ElseIf IsNumeric(valor1) Then
            valor1 = Val(txtValor1.Text)
            If valor1 = 0 Then
                MsgBox("Bien...El nuero es 0")
            ElseIf valor1 > 0 Then
                MsgBox("Bien...El numero es Positivo")
            ElseIf valor1 < 0 Then
                MsgBox("Bien...El numero es Negaivo")
            End If
        End If

        Dim valor2 As Int16

        If txtValor2.Text = "" Then
            MsgBox("Po favor escriva un numero en las casillas", vbAbortRetryIgnore)

        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico", vbAbortRetryIgnore)
            txtValor2.Text = ""
        ElseIf IsNumeric(valor2) Then
            valor2 = Val(txtValor2.Text)
            If valor2 = 0 Then
                MsgBox("Bien...El nuero es 0")
            ElseIf valor2 > 0 Then
                MsgBox("Bien...El numero es Positivo")
            ElseIf valor2 < 0 Then
                MsgBox("Bien...El numero es Negaivo")
            End If
        End If


    End Sub

    Private Sub chkSuma_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuma.CheckedChanged

    End Sub

    Private Sub chkResta_CheckedChanged(sender As Object, e As EventArgs) Handles chkResta.CheckedChanged

    End Sub

    Private Sub chkMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiplicacion.CheckedChanged

    End Sub

    Private Sub chkDivicion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDivicion.CheckedChanged

    End Sub

    Private Sub chkRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles chkRaiz.CheckedChanged

    End Sub

    Private Sub chkPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkPotencia.CheckedChanged

    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub valor1_Click(sender As Object, e As EventArgs) Handles valor1.Click

    End Sub

    Private Sub txtValor1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub valor2_Click(sender As Object, e As EventArgs) Handles valor2.Click

    End Sub

    Private Sub txtValor2_TextChanged(sender As Object, e As EventArgs) Handles txtValor2.TextChanged

    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click

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

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim Suma As Integer
        Dim Resta As Integer
        Dim Multiplicacion As Integer
        Dim Divicion As String

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'Proceso

        Suma = valor1 + valor2
        Resta = valor1 - valor2
        Multiplicacion = valor1 * valor2
        If valor2 = 0 Then
            Divicion = "Math error"
            MsgBox("Error!" & vbNewLine & "El valor 1 no puede ser dividido / 0", vbInformation)
        Else
            Divicion = valor1 / valor2
        End If

        'Salida

        txtSuma.Text = Suma
        txtResta.Text = Resta
        txtMultiplicacion.Text = Multiplicacion
        txtDivicion.Text = Divicion

    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click

    End Sub

    Private Sub txtSuma_TextChanged(sender As Object, e As EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click

    End Sub

    Private Sub txtResta_TextChanged(sender As Object, e As EventArgs) Handles txtResta.TextChanged

    End Sub

    Private Sub Divicion_Click(sender As Object, e As EventArgs) Handles Divicion.Click

    End Sub

    Private Sub txtDivicion_TextChanged(sender As Object, e As EventArgs) Handles txtDivicion.TextChanged

    End Sub

    Private Sub Multiplicacion_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click

    End Sub

    Private Sub txtMultiplicacion_TextChanged(sender As Object, e As EventArgs) Handles txtMultiplicacion.TextChanged

    End Sub

    Private Sub BtnReintentar_Click(sender As Object, e As EventArgs) Handles BtnReintentar.Click

        txtValor1.Clear()
        txtValor2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivicion.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        MsgBox("¿Esta seguro que desea salir?", vbInformation)
        End

    End Sub
End Class

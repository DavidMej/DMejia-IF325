Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles PrecioUnitario.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecioU.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Cantidad.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkApliDescuento.CheckedChanged

    End Sub

    Private Sub CmbDescuentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDescuentos.SelectedIndexChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkApliIVS.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbImpuestos.SelectedIndexChanged

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim PUnitario As Int16

        If TxtPrecioU.Text = "" Then
            MsgBox("Por favor escriva un numero en las casillas", vbAbortRetryIgnore)

        ElseIf Not IsNumeric(TxtPrecioU.Text) Then
            MsgBox("Ingrese un valor numerico", vbAbortRetryIgnore)
            TxtPrecioU.Text = ""
        ElseIf IsNumeric(PUnitario) Then
            PUnitario = Val(TxtPrecioU.Text)
            If PUnitario > 0 Then
                MsgBox("El valor numerico es correcto")
            ElseIf PUnitario < 0 Then
                MsgBox("Ingrese un valor numerico positivo", vbAbortRetryIgnore)
            End If
        End If

        Dim cantidad As Int16

        If TxtCantidad.Text = "" Then
            MsgBox("Por favor escriva un numero en las casillas", vbAbortRetryIgnore)

        ElseIf Not IsNumeric(TxtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbAbortRetryIgnore)
            TxtCantidad.Text = ""
        ElseIf IsNumeric(cantidad) Then
            cantidad = Val(TxtCantidad.Text)
            If cantidad > 0 Then
                MsgBox("El valor numerico es correcto")
            ElseIf cantidad < 0 Then
                MsgBox("Ingrese un valor numerico positivo", vbAbortRetryIgnore)
            End If
        End If

        Dim PrecioU, Cantidad1 As Integer
        Dim descuento, IVS, total, subtotal As Double
        Dim AplicDescuento, AplicarIVS As String


        PrecioU = Val(TxtPrecioU.Text)
        Cantidad1 = Val(TxtCantidad.Text)


        'chkApliDescuento.Checked = False
        AplicDescuento = CmbDescuentos.SelectedItem
        AplicarIVS = CmbImpuestos.SelectedItem
        descuento = 0
        IVS = 0
        subtotal = PrecioU * Cantidad1

        If chkApliDescuento.Checked = True Then

            If AplicDescuento = "Tercera Edad" Then
                descuento = subtotal * 0.5
            End If

            If AplicDescuento = "Todo Publico" Then
                descuento = subtotal * 0.3
            End If

            If AplicDescuento = "Mujeres Embarazadas" Then
                descuento = subtotal * 0.25
            End If

            If AplicDescuento = "Estudiantes " Then
                descuento = subtotal * 0.2
            End If

            If AplicDescuento = "Discapacitados " Then
                descuento = subtotal * 0.05
            End If

        End If

        If chkApliIVS.Checked = True Then

            If AplicarIVS = "15%" Then
                IVS = subtotal * 0.15
            End If

            If AplicarIVS = "17% " Then
                IVS = subtotal * 0.17
            End If

        End If

        total = subtotal - descuento + IVS

        TxtDescuento.Text = descuento
        TxtIVS.Text = IVS
        TxtSubtotal.Text = subtotal
        TxtTotalPagar.Text = total



    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        TxtPrecioU.Clear()
        TxtCantidad.Clear()

        chkApliDescuento.Checked = False
        chkApliIVS.Checked = False

        TxtDescuento.Clear()
        TxtIVS.Clear()
        TxtSubtotal.Clear()
        TxtTotalPagar.Clear()

        chkApliDescuento.Enabled = True
        chkApliIVS.Enabled = True
        CmbDescuentos.SelectedItem = Nothing
        CmbImpuestos.SelectedItem = Nothing
        chkApliDescuento.Enabled = True
        chkApliIVS.Enabled = True

        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        MsgBox("¿Seguro que desea salir?", vbInformation)
        End

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Subtotal.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtSubtotal.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Descuento.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TxtDescuento.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles IVS.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TxtIVS.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles TotalPagar.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalPagar.TextChanged

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

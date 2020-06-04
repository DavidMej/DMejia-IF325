Public Class Form1

    Private Sub activarControles()
        txtCliente.Enabled = False
        txtMonto.Enabled = False
        btnAbrirCuenta.Enabled = False
        txtSaldos.Enabled = True
        lstDepositos.Enabled = True
        lstRetiros.Enabled = True
        btnDeposito.Enabled = True
        btnRetiro.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtCliente.Enabled = True
        txtMonto.Enabled = True
        btnAbrirCuenta.Enabled = True
        txtSaldos.Enabled = False
        lstDepositos.Enabled = False
        lstRetiros.Enabled = False
        btnDeposito.Enabled = False
        btnRetiro.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private monto As Double

    Private Sub btnAbrirCuenta_Click(sender As Object, e As EventArgs) Handles btnAbrirCuenta.Click
        Dim cliente As String
        cliente = txtCliente.Text

        If txtCliente.Text = "" Then
            MessageBox.Show("Para abrir una cuenta debe de ingresar un nombre de Usuario", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            desactivarControles()
        ElseIf IsNumeric(txtCliente.Text) Then
            MessageBox.Show("No puede ingresar un valor ´Numerico´ en su nombre de Usuario", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            desactivarControles()
        End If


        monto = Val(txtMonto.Text)

        If monto >= 0 Then
            activarControles()
        End If

        If txtMonto.Text = "" Then
            MessageBox.Show("Para abrir una cuenta debe de ingresar un monto", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            desactivarControles()
        ElseIf Not IsNumeric(txtMonto.Text) Then
            MessageBox.Show("Ingrese un valor Numerico", "Error en monto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            desactivarControles()
        ElseIf IsNumeric(txtMonto.Text) Then
            If txtMonto.Text < 0 Then
                MessageBox.Show("El monto ingresado no puede ser menor que 0", "Gestion de Ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                desactivarControles()
            End If

        End If

    End Sub

    Private Function leer(pregunta As String) As Double
        Dim cantidad As Double
        cantidad = InputBox("Ingrese el monto a " + pregunta, "Gestion de Transaccion", "0")
        Return cantidad
    End Function

    Private Sub Mostrar()
        txtSaldos.Text = monto
    End Sub

    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        Dim deposito As Double
        deposito = leer("Depositar:")
        monto = monto + deposito
        lstDepositos.Items.Add(deposito)
        Mostrar()
    End Sub

    Private Sub btnRetiro_Click(sender As Object, e As EventArgs) Handles btnRetiro.Click
        Dim retiro As Double

        retiro = leer("Retirar:")

        If retiro <= monto Then
            monto = monto - retiro
            lstRetiros.Items.Add(retiro)
            Mostrar()
        Else
            MessageBox.Show("No se puede retirar una cantitad mayor al monto actual", "Gestion de Trasaccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivarControles()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
        txtCliente.Clear()
        txtMonto.Clear()
        txtSaldos.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Try
            If btnSalir.Enabled = True Then
                MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End
            Else btnSalir.DialogResult = DialogResult.Cancel

                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ImprimirRecibo.Click

        If CheckBox1.Checked = True Then
            Module1.Date_begin = txtCliente.Text
            Module1.Date_total = txtSaldos.Text
            Recibo_Final.Show()
            Me.Hide()
        Else
            MessageBox.Show("Debe selecionar ´Si´ para imprimir el recibo", "Error al Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

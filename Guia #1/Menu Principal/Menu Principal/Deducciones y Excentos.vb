Public Class Deducciones_y_Excentos
    Private Sub Deducciones_y_Excentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim sueldo, Deduccion, sueldoRecibido As Double
        Dim ISR1, ISR2, ISR3 As Double
        ISR1 = 0.15
        ISR2 = 0.2
        ISR3 = 0.25
        sueldo = Val(txtSueldo.Text)

        If sueldo < 16582.92 Then
            txtDeduccion.Text = 0
            txtExcento.Text = 0
            txtSueldoRecibido.Text = sueldo
        End If

        If sueldo >= 16582.92 And sueldo < 23536.61 Then
            Deduccion = sueldo * ISR1
            sueldoRecibido = sueldo - Deduccion

            txtDeduccion.Text = Deduccion
            txtExcento.Text = "15%"
            txtSueldoRecibido.Text = sueldoRecibido
        End If

        If sueldo >= 23536.61 And sueldo < 50317.69 Then
            Deduccion = sueldo * ISR1
            sueldoRecibido = sueldo - Deduccion

            txtDeduccion.Text = Deduccion
            txtExcento.Text = "20%"
            txtSueldoRecibido.Text = sueldoRecibido
        End If

        If sueldo >= 50317.69 Then
            Deduccion = sueldo * ISR1
            sueldoRecibido = sueldo - Deduccion

            txtDeduccion.Text = Deduccion
            txtExcento.Text = "25%"
            txtSueldoRecibido.Text = sueldoRecibido
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtSueldo.Clear()
        txtDeduccion.Clear()
        txtExcento.Clear()
        txtSueldoRecibido.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class
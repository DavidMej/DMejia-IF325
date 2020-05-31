Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NombreProducto_Click(sender As Object, e As EventArgs) Handles NombreProducto.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub Precio_Click(sender As Object, e As EventArgs) Handles Precio.Click

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub Cantidad_Click(sender As Object, e As EventArgs) Handles Cantidad.Click

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub Descripcion_Click(sender As Object, e As EventArgs) Handles Descripcion.Click

    End Sub

    Private Sub RhtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles RhtDescripcion.TextChanged

    End Sub

    Private Sub BtnRegistar_Click(sender As Object, e As EventArgs) Handles BtnRegistar.Click

        'Try Catch
        'ValidateChildren Button
        'Validating Cajas de Texto

        Try
            'Si las casillas estan sin ningun valor
            'Aplique a todos los elementos -> Producto sea diferente de vacio, Precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Igresado correctamente", "Formulario del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Rectifique los datos ingresdos", "Erros en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        txtNombre.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        RhtDescripcion.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        End

    End Sub
End Class

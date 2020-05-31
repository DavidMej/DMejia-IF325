Public Class Form1
    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtTablas_TextChanged(sender As Object, e As EventArgs) Handles txtTablas.TextChanged

    End Sub

    Private Sub BtnGenerarTablas_Click(sender As Object, e As EventArgs) Handles BtnGenerarTablas.Click

        Dim numero As Integer
        Dim i As Integer
        txtTablas.Text = ""

        numero = txtNumero.Text


        For i = 1 To 10 Step 1

            txtTablas.Text = txtTablas.Text And numero And " * " And i And " = " And numero * i And vbCrLf

        Next i

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        txtNumero.Clear()
        txtTablas.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class

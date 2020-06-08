Public Class Calcular_Media_de_Ventas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim almacenes As Integer
        Dim media, suma, venta1, venta2, venta3, venta4, venta5, venta6, venta7, venta8, venta9, venta10 As Double

        Try
            almacenes = 10

            venta1 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #1 Dorado", "Ingresar")
            venta2 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #2 Blanco", "Ingresar")
            venta3 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #3 Verde", "Ingresar")
            venta4 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #4 Amarilla", "Ingresar")
            venta5 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #5 Rosada", "Ingresar")
            venta6 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #6 Rojo", "Ingresar")
            venta7 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #7 Azul", "Ingresar")
            venta8 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #8 Gris", "Ingresar")
            venta9 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #9 Negra", "Ingresar")
            venta10 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #10 Cafe", "Ingresar")

            suma = venta1 + venta2 + venta3 + venta4 + venta5 + venta6 + venta7 + venta8 + venta9 + venta10
            media = suma / almacenes

            If venta1 > media Then
                lbListaEmpresas.Items.Add("Empresa #1 Dorado" & " = " & venta1)
            End If
            If venta2 > media Then
                lbListaEmpresas.Items.Add("Empresa #2 Blanco" & " = " & venta2)
            End If
            If venta3 > media Then
                lbListaEmpresas.Items.Add("Empresa #3 Verde" & " = " & venta3)
            End If
            If venta4 > media Then
                lbListaEmpresas.Items.Add("Empresa #4 Amarilla" & " = " & venta4)
            End If
            If venta5 > media Then
                lbListaEmpresas.Items.Add("Empresa #5 Rosada" & " = " & venta5)
            End If
            If venta6 > media Then
                lbListaEmpresas.Items.Add("Empresa #6 Rojo" & " = " & venta6)
            End If
            If venta7 > media Then
                lbListaEmpresas.Items.Add("Empresa #7 Azul" & " = " & venta7)
            End If
            If venta8 > media Then
                lbListaEmpresas.Items.Add("Empresa #8 Gris" & " = " & venta8)
            End If
            If venta9 > media Then
                lbListaEmpresas.Items.Add("Empresa #9 Negra" & " = " & venta9)
            End If
            If venta10 > media Then
                lbListaEmpresas.Items.Add("Empresa #10 Café" & " = " & venta10)
            End If
            txtMedia.Text = media

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtMedia.Clear()
        lbListaEmpresas.Items.Clear()
    End Sub

End Class
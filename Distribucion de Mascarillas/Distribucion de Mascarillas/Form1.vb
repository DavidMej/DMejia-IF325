Public Class Entrega_Mascarillas

    Private Sub txtNoDeptos_TextChanged(sender As Object, e As EventArgs) Handles txtNoDeptos.TextChanged

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        If txtNoDeptos.Text = "" Then
            MessageBox.Show("Escriba un numero en la casilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtNoDeptos.Text) Then
            MessageBox.Show("Escriba un valor numero en la casilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNoDeptos.Text = ""
        ElseIf txtNoDeptos.Text < 0 Then
            MessageBox.Show("Escriba un numero que sea positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNoDeptos.Text = ""
        End If

        Dim departamentos, mascarillas As Integer

        departamentos = Val(txtNoDeptos.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, "Ingresar", MessageBoxButtons.AbortRetryIgnore)

            Loop While (mascarillas < 0 Or mascarillas > 10000)

            cmbCantDepto.Items.Add(mascarillas)
        Next

    End Sub

    Private Sub cmbCantDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantDepto.SelectedIndexChanged

    End Sub

    Private Sub txtcantMunicipios_TextChanged(sender As Object, e As EventArgs) Handles txtcantMunicipios.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCantDepto.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Dim IDdepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        IDdepartamento = cmbCantDepto.SelectedIndex
        itemDepartamento = cmbCantDepto.SelectedItem.ToString
        municipios = Val(txtcantMunicipios.Text)

        Select Case IDdepartamento
            Case 0
                If municipios > 8 Then
                    MsgBox("Hay un maximo de 8 municipios en Atlantida", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 1
                If municipios > 16 Then
                    MsgBox("Hay un maximo de 16 municipios en Cholutecaa", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 2
                If municipios > 10 Then
                    MsgBox("Hay un maximo de 10 municipios en Colón", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 3
                If municipios > 21 Then
                    MsgBox("Hay un maximo de 21 municipios en Comayagua", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 4
                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Copán", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 5
                If municipios > 12 Then
                    MsgBox("Hay un maximo de 12 municipios en Cortes", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 6
                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en El Paraiso", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 7
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Francisco Morazán", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
            Case 8
                If municipios > 6 Then
                    MsgBox("Hay un maximo de 6 municipios en Gracias a Dios", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 9
                If municipios > 17 Then
                    MsgBox("Hay un máximo de 17 municipios en Intibuca", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 10
                If municipios > 4 Then
                    MsgBox("Hay un maximo de 4 municipios en Islas de la Bahia", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 11
                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en La Paz", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 12
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Lempira", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 13
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Francisco Morazán", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 14
                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Olancho", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 15
                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Santa Bárbara", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 16
                If municipios > 9 Then
                    MsgBox("Hay un maximo de 9 municipios en Valle", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 17
                If municipios > 11 Then
                    MsgBox("Hay un maximo de 11 municipios en Yoro", vbOK + vbExclamation, "Error en Cantidad de Municipios")
                    txtcantMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtCantDisponible.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If


        End Select

    End Sub

    Private Sub txtCantDisponible_TextChanged(sender As Object, e As EventArgs) Handles txtCantDisponible.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub
End Class

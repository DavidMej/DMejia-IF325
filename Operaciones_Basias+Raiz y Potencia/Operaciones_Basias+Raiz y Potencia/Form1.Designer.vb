<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Nota2 = New System.Windows.Forms.Label()
        Me.chkPotencia = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.chkDivicion = New System.Windows.Forms.CheckBox()
        Me.chkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.BtnReintentar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.txtRaiz2 = New System.Windows.Forms.TextBox()
        Me.txtRaiz1 = New System.Windows.Forms.TextBox()
        Me.txtDivicion = New System.Windows.Forms.TextBox()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Potencia = New System.Windows.Forms.Label()
        Me.Raiz2 = New System.Windows.Forms.Label()
        Me.Raiz1 = New System.Windows.Forms.Label()
        Me.Divicion = New System.Windows.Forms.Label()
        Me.Multiplicacion = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Label()
        Me.Resutados = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.valor2 = New System.Windows.Forms.Label()
        Me.valor1 = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nota2
        '
        Me.Nota2.AutoSize = True
        Me.Nota2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nota2.Location = New System.Drawing.Point(663, 414)
        Me.Nota2.Name = "Nota2"
        Me.Nota2.Size = New System.Drawing.Size(300, 20)
        Me.Nota2.TabIndex = 65
        Me.Nota2.Text = "Nota: El Valor 2 es la potencia a elevar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkPotencia
        '
        Me.chkPotencia.AutoSize = True
        Me.chkPotencia.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPotencia.Location = New System.Drawing.Point(856, 348)
        Me.chkPotencia.Name = "chkPotencia"
        Me.chkPotencia.Size = New System.Drawing.Size(107, 27)
        Me.chkPotencia.TabIndex = 64
        Me.chkPotencia.Text = "Potencia"
        Me.chkPotencia.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRaiz.Location = New System.Drawing.Point(856, 280)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(74, 27)
        Me.chkRaiz.TabIndex = 63
        Me.chkRaiz.Text = "Raíz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'chkDivicion
        '
        Me.chkDivicion.AutoSize = True
        Me.chkDivicion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDivicion.Location = New System.Drawing.Point(856, 220)
        Me.chkDivicion.Name = "chkDivicion"
        Me.chkDivicion.Size = New System.Drawing.Size(114, 27)
        Me.chkDivicion.TabIndex = 62
        Me.chkDivicion.Text = "Divición "
        Me.chkDivicion.UseVisualStyleBackColor = True
        '
        'chkMultiplicacion
        '
        Me.chkMultiplicacion.AutoSize = True
        Me.chkMultiplicacion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultiplicacion.Location = New System.Drawing.Point(673, 348)
        Me.chkMultiplicacion.Name = "chkMultiplicacion"
        Me.chkMultiplicacion.Size = New System.Drawing.Size(158, 27)
        Me.chkMultiplicacion.TabIndex = 61
        Me.chkMultiplicacion.Text = "Multiplicación"
        Me.chkMultiplicacion.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResta.Location = New System.Drawing.Point(670, 280)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(83, 27)
        Me.chkResta.TabIndex = 60
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuma.Location = New System.Drawing.Point(670, 220)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(84, 27)
        Me.chkSuma.TabIndex = 59
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 50)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Seleccione las Operaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     que desea realizar: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nota: Validar los valores antes de Calcular"
        '
        'BtnValidar
        '
        Me.BtnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnValidar.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.Location = New System.Drawing.Point(359, 130)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(119, 42)
        Me.BtnValidar.TabIndex = 56
        Me.BtnValidar.Text = "Validar..."
        Me.BtnValidar.UseVisualStyleBackColor = False
        '
        'BtnReintentar
        '
        Me.BtnReintentar.BackColor = System.Drawing.Color.Gold
        Me.BtnReintentar.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReintentar.Location = New System.Drawing.Point(667, 526)
        Me.BtnReintentar.Name = "BtnReintentar"
        Me.BtnReintentar.Size = New System.Drawing.Size(126, 39)
        Me.BtnReintentar.TabIndex = 55
        Me.BtnReintentar.Text = "Reintentar"
        Me.BtnReintentar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(856, 526)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 39)
        Me.BtnSalir.TabIndex = 54
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'txtRaiz2
        '
        Me.txtRaiz2.Location = New System.Drawing.Point(466, 490)
        Me.txtRaiz2.Name = "txtRaiz2"
        Me.txtRaiz2.Size = New System.Drawing.Size(100, 26)
        Me.txtRaiz2.TabIndex = 53
        '
        'txtRaiz1
        '
        Me.txtRaiz1.Location = New System.Drawing.Point(466, 414)
        Me.txtRaiz1.Name = "txtRaiz1"
        Me.txtRaiz1.Size = New System.Drawing.Size(100, 26)
        Me.txtRaiz1.TabIndex = 52
        '
        'txtDivicion
        '
        Me.txtDivicion.Location = New System.Drawing.Point(494, 341)
        Me.txtDivicion.Name = "txtDivicion"
        Me.txtDivicion.Size = New System.Drawing.Size(100, 26)
        Me.txtDivicion.TabIndex = 51
        '
        'txtPotencia
        '
        Me.txtPotencia.Location = New System.Drawing.Point(359, 552)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.Size = New System.Drawing.Size(100, 26)
        Me.txtPotencia.TabIndex = 50
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.Location = New System.Drawing.Point(276, 485)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(100, 26)
        Me.txtMultiplicacion.TabIndex = 49
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(201, 414)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 26)
        Me.txtResta.TabIndex = 48
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(209, 338)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 26)
        Me.txtSuma.TabIndex = 47
        '
        'Potencia
        '
        Me.Potencia.AutoSize = True
        Me.Potencia.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Potencia.Location = New System.Drawing.Point(269, 553)
        Me.Potencia.Name = "Potencia"
        Me.Potencia.Size = New System.Drawing.Size(87, 23)
        Me.Potencia.TabIndex = 46
        Me.Potencia.Text = "Potencia:"
        '
        'Raiz2
        '
        Me.Raiz2.AutoSize = True
        Me.Raiz2.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Raiz2.Location = New System.Drawing.Point(392, 491)
        Me.Raiz2.Name = "Raiz2"
        Me.Raiz2.Size = New System.Drawing.Size(75, 23)
        Me.Raiz2.TabIndex = 45
        Me.Raiz2.Text = "Raíz 2: "
        '
        'Raiz1
        '
        Me.Raiz1.AutoSize = True
        Me.Raiz1.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Raiz1.Location = New System.Drawing.Point(392, 417)
        Me.Raiz1.Name = "Raiz1"
        Me.Raiz1.Size = New System.Drawing.Size(67, 23)
        Me.Raiz1.TabIndex = 44
        Me.Raiz1.Text = "Raíz 1:"
        '
        'Divicion
        '
        Me.Divicion.AutoSize = True
        Me.Divicion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divicion.Location = New System.Drawing.Point(392, 342)
        Me.Divicion.Name = "Divicion"
        Me.Divicion.Size = New System.Drawing.Size(88, 23)
        Me.Divicion.TabIndex = 43
        Me.Divicion.Text = "Divición:"
        '
        'Multiplicacion
        '
        Me.Multiplicacion.AutoSize = True
        Me.Multiplicacion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicacion.Location = New System.Drawing.Point(132, 486)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(138, 23)
        Me.Multiplicacion.TabIndex = 42
        Me.Multiplicacion.Text = "Multiplicación:"
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(132, 414)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(63, 23)
        Me.Resta.TabIndex = 41
        Me.Resta.Text = "Resta:"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma.Location = New System.Drawing.Point(132, 339)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(64, 23)
        Me.Suma.TabIndex = 40
        Me.Suma.Text = "Suma:"
        '
        'Resutados
        '
        Me.Resutados.AutoSize = True
        Me.Resutados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Resutados.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resutados.Location = New System.Drawing.Point(278, 266)
        Me.Resutados.Name = "Resutados"
        Me.Resutados.Size = New System.Drawing.Size(118, 25)
        Me.Resutados.TabIndex = 39
        Me.Resutados.Text = "Resultados:"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCalcular.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(525, 130)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(119, 42)
        Me.BtnCalcular.TabIndex = 38
        Me.BtnCalcular.Text = "Calcular..."
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(180, 160)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 26)
        Me.txtValor2.TabIndex = 37
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(180, 111)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 26)
        Me.txtValor1.TabIndex = 36
        '
        'valor2
        '
        Me.valor2.AutoSize = True
        Me.valor2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor2.Location = New System.Drawing.Point(84, 160)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(90, 22)
        Me.valor2.TabIndex = 35
        Me.valor2.Text = "Valor 2:"
        '
        'valor1
        '
        Me.valor1.AutoSize = True
        Me.valor1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor1.Location = New System.Drawing.Point(84, 113)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(90, 22)
        Me.valor1.TabIndex = 34
        Me.valor1.Text = "Valor 1:"
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Titulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(238, 46)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(588, 28)
        Me.Titulo.TabIndex = 33
        Me.Titulo.Text = "Ingrese 2 numeros para calcular las Operaciones Basicas:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1010, 607)
        Me.Controls.Add(Me.Nota2)
        Me.Controls.Add(Me.chkPotencia)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkDivicion)
        Me.Controls.Add(Me.chkMultiplicacion)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnValidar)
        Me.Controls.Add(Me.BtnReintentar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.txtRaiz2)
        Me.Controls.Add(Me.txtRaiz1)
        Me.Controls.Add(Me.txtDivicion)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.Potencia)
        Me.Controls.Add(Me.Raiz2)
        Me.Controls.Add(Me.Raiz1)
        Me.Controls.Add(Me.Divicion)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.Resutados)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nota2 As Label
    Friend WithEvents chkPotencia As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents chkDivicion As CheckBox
    Friend WithEvents chkMultiplicacion As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnValidar As Button
    Friend WithEvents BtnReintentar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents txtRaiz2 As TextBox
    Friend WithEvents txtRaiz1 As TextBox
    Friend WithEvents txtDivicion As TextBox
    Friend WithEvents txtPotencia As TextBox
    Friend WithEvents txtMultiplicacion As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents Potencia As Label
    Friend WithEvents Raiz2 As Label
    Friend WithEvents Raiz1 As Label
    Friend WithEvents Divicion As Label
    Friend WithEvents Multiplicacion As Label
    Friend WithEvents Resta As Label
    Friend WithEvents Suma As Label
    Friend WithEvents Resutados As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents valor2 As Label
    Friend WithEvents valor1 As Label
    Friend WithEvents Titulo As Label
End Class

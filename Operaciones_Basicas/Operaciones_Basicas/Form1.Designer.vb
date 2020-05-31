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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.txtDivicion = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Divicion = New System.Windows.Forms.Label()
        Me.Multiplicacion = New System.Windows.Forms.Label()
        Me.Resutados = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.valor2 = New System.Windows.Forms.Label()
        Me.valor1 = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Label()
        Me.BtnReintentar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nota: Validar los valores antes de Calcular"
        '
        'BtnValidar
        '
        Me.BtnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnValidar.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.Location = New System.Drawing.Point(353, 138)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(119, 42)
        Me.BtnValidar.TabIndex = 40
        Me.BtnValidar.Text = "Validar..."
        Me.BtnValidar.UseVisualStyleBackColor = False
        '
        'txtDivicion
        '
        Me.txtDivicion.Location = New System.Drawing.Point(484, 318)
        Me.txtDivicion.Name = "txtDivicion"
        Me.txtDivicion.Size = New System.Drawing.Size(100, 26)
        Me.txtDivicion.TabIndex = 37
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.Location = New System.Drawing.Point(484, 409)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(100, 26)
        Me.txtMultiplicacion.TabIndex = 36
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(156, 409)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 26)
        Me.txtResta.TabIndex = 35
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(156, 321)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 26)
        Me.txtSuma.TabIndex = 34
        '
        'Divicion
        '
        Me.Divicion.AutoSize = True
        Me.Divicion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divicion.Location = New System.Drawing.Point(369, 321)
        Me.Divicion.Name = "Divicion"
        Me.Divicion.Size = New System.Drawing.Size(88, 23)
        Me.Divicion.TabIndex = 31
        Me.Divicion.Text = "Divición:"
        '
        'Multiplicacion
        '
        Me.Multiplicacion.AutoSize = True
        Me.Multiplicacion.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicacion.Location = New System.Drawing.Point(313, 412)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(138, 23)
        Me.Multiplicacion.TabIndex = 30
        Me.Multiplicacion.Text = "Multiplicación:"
        '
        'Resutados
        '
        Me.Resutados.AutoSize = True
        Me.Resutados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Resutados.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resutados.Location = New System.Drawing.Point(283, 237)
        Me.Resutados.Name = "Resutados"
        Me.Resutados.Size = New System.Drawing.Size(118, 25)
        Me.Resutados.TabIndex = 29
        Me.Resutados.Text = "Resultados:"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCalcular.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(520, 138)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(119, 42)
        Me.BtnCalcular.TabIndex = 28
        Me.BtnCalcular.Text = "Calcular..."
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(156, 169)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 26)
        Me.txtValor2.TabIndex = 27
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(156, 122)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 26)
        Me.txtValor1.TabIndex = 26
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Titulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(106, 27)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(588, 28)
        Me.Titulo.TabIndex = 25
        Me.Titulo.Text = "Ingrese 2 numeros para calcular las Operaciones Basicas:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'valor2
        '
        Me.valor2.AutoSize = True
        Me.valor2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor2.Location = New System.Drawing.Point(31, 171)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(90, 22)
        Me.valor2.TabIndex = 43
        Me.valor2.Text = "Valor 2:"
        '
        'valor1
        '
        Me.valor1.AutoSize = True
        Me.valor1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor1.Location = New System.Drawing.Point(31, 124)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(90, 22)
        Me.valor1.TabIndex = 42
        Me.valor1.Text = "Valor 1:"
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(83, 410)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(63, 23)
        Me.Resta.TabIndex = 45
        Me.Resta.Text = "Resta:"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Font = New System.Drawing.Font("High Tower Text", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma.Location = New System.Drawing.Point(83, 321)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(64, 23)
        Me.Suma.TabIndex = 44
        Me.Suma.Text = "Suma:"
        '
        'BtnReintentar
        '
        Me.BtnReintentar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnReintentar.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReintentar.Location = New System.Drawing.Point(484, 493)
        Me.BtnReintentar.Name = "BtnReintentar"
        Me.BtnReintentar.Size = New System.Drawing.Size(126, 39)
        Me.BtnReintentar.TabIndex = 47
        Me.BtnReintentar.Text = "Reintentar"
        Me.BtnReintentar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(666, 493)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 39)
        Me.BtnSalir.TabIndex = 46
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 563)
        Me.Controls.Add(Me.BtnReintentar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnValidar)
        Me.Controls.Add(Me.txtDivicion)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.Divicion)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.Resutados)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnValidar As Button
    Friend WithEvents txtDivicion As TextBox
    Friend WithEvents txtMultiplicacion As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents Divicion As Label
    Friend WithEvents Multiplicacion As Label
    Friend WithEvents Resutados As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Titulo As Label
    Friend WithEvents valor2 As Label
    Friend WithEvents valor1 As Label
    Friend WithEvents Resta As Label
    Friend WithEvents Suma As Label
    Friend WithEvents BtnReintentar As Button
    Friend WithEvents BtnSalir As Button
End Class

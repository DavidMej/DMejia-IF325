<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora_Basica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora_Basica))
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnSiete = New System.Windows.Forms.Button()
        Me.btnOcho = New System.Windows.Forms.Button()
        Me.btnNueve = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnCleanPantalla = New System.Windows.Forms.Button()
        Me.btnDivicion = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstHistorial = New System.Windows.Forms.ListBox()
        Me.btnCleanHistorial = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUno
        '
        Me.btnUno.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUno.Location = New System.Drawing.Point(30, 262)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(67, 49)
        Me.btnUno.TabIndex = 0
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(121, 262)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(67, 49)
        Me.btnDos.TabIndex = 1
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(213, 262)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(67, 49)
        Me.btnTres.TabIndex = 2
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnCuatro
        '
        Me.btnCuatro.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuatro.Location = New System.Drawing.Point(30, 186)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(67, 49)
        Me.btnCuatro.TabIndex = 3
        Me.btnCuatro.Text = "4"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(121, 186)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(67, 49)
        Me.btnCinco.TabIndex = 4
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(213, 186)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(67, 49)
        Me.btnSeis.TabIndex = 5
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnSiete
        '
        Me.btnSiete.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiete.Location = New System.Drawing.Point(30, 107)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(67, 49)
        Me.btnSiete.TabIndex = 6
        Me.btnSiete.Text = "7"
        Me.btnSiete.UseVisualStyleBackColor = True
        '
        'btnOcho
        '
        Me.btnOcho.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcho.Location = New System.Drawing.Point(121, 107)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(67, 49)
        Me.btnOcho.TabIndex = 7
        Me.btnOcho.Text = "8"
        Me.btnOcho.UseVisualStyleBackColor = True
        '
        'btnNueve
        '
        Me.btnNueve.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueve.Location = New System.Drawing.Point(213, 107)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(67, 49)
        Me.btnNueve.TabIndex = 8
        Me.btnNueve.Text = "9"
        Me.btnNueve.UseVisualStyleBackColor = True
        '
        'btnCero
        '
        Me.btnCero.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCero.Location = New System.Drawing.Point(30, 344)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(67, 49)
        Me.btnCero.TabIndex = 9
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.Location = New System.Drawing.Point(121, 344)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(67, 49)
        Me.btnPunto.TabIndex = 10
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(213, 344)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(67, 49)
        Me.btnIgual.TabIndex = 11
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnCleanPantalla
        '
        Me.btnCleanPantalla.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanPantalla.Location = New System.Drawing.Point(307, 344)
        Me.btnCleanPantalla.Name = "btnCleanPantalla"
        Me.btnCleanPantalla.Size = New System.Drawing.Size(67, 49)
        Me.btnCleanPantalla.TabIndex = 12
        Me.btnCleanPantalla.Text = "CE"
        Me.btnCleanPantalla.UseVisualStyleBackColor = True
        '
        'btnDivicion
        '
        Me.btnDivicion.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivicion.Location = New System.Drawing.Point(307, 262)
        Me.btnDivicion.Name = "btnDivicion"
        Me.btnDivicion.Size = New System.Drawing.Size(67, 49)
        Me.btnDivicion.TabIndex = 13
        Me.btnDivicion.Text = "÷"
        Me.btnDivicion.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(307, 186)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(67, 49)
        Me.btnMultiplicacion.TabIndex = 14
        Me.btnMultiplicacion.Text = "x"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(307, 107)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(67, 49)
        Me.btnResta.TabIndex = 15
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(307, 33)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(67, 49)
        Me.btnSuma.TabIndex = 16
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'txtPantalla
        '
        Me.txtPantalla.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPantalla.Location = New System.Drawing.Point(63, 44)
        Me.txtPantalla.Multiline = True
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.Size = New System.Drawing.Size(187, 38)
        Me.txtPantalla.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstHistorial)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(413, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 390)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial"
        '
        'lstHistorial
        '
        Me.lstHistorial.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistorial.FormattingEnabled = True
        Me.lstHistorial.ItemHeight = 23
        Me.lstHistorial.Location = New System.Drawing.Point(20, 57)
        Me.lstHistorial.Name = "lstHistorial"
        Me.lstHistorial.Size = New System.Drawing.Size(159, 303)
        Me.lstHistorial.TabIndex = 0
        '
        'btnCleanHistorial
        '
        Me.btnCleanHistorial.Font = New System.Drawing.Font("Segoe Print", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanHistorial.Location = New System.Drawing.Point(433, 399)
        Me.btnCleanHistorial.Name = "btnCleanHistorial"
        Me.btnCleanHistorial.Size = New System.Drawing.Size(159, 80)
        Me.btnCleanHistorial.TabIndex = 19
        Me.btnCleanHistorial.Text = " Limpiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Historial "
        Me.btnCleanHistorial.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(30, 415)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(137, 45)
        Me.btnRegresar.TabIndex = 20
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Calculadora_Basica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(630, 491)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnCleanHistorial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPantalla)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnDivicion)
        Me.Controls.Add(Me.btnCleanPantalla)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btnCero)
        Me.Controls.Add(Me.btnNueve)
        Me.Controls.Add(Me.btnOcho)
        Me.Controls.Add(Me.btnSiete)
        Me.Controls.Add(Me.btnSeis)
        Me.Controls.Add(Me.btnCinco)
        Me.Controls.Add(Me.btnCuatro)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnUno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora_Basica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora_Basica"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUno As Button
    Friend WithEvents btnDos As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents btnCuatro As Button
    Friend WithEvents btnCinco As Button
    Friend WithEvents btnSeis As Button
    Friend WithEvents btnSiete As Button
    Friend WithEvents btnOcho As Button
    Friend WithEvents btnNueve As Button
    Friend WithEvents btnCero As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnCleanPantalla As Button
    Friend WithEvents btnDivicion As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstHistorial As ListBox
    Friend WithEvents btnCleanHistorial As Button
    Friend WithEvents btnRegresar As Button
End Class

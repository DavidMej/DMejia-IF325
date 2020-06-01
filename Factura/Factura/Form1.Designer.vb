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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtIVS = New System.Windows.Forms.TextBox()
        Me.TxtTotalPagar = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TotalPagar = New System.Windows.Forms.Label()
        Me.IVS = New System.Windows.Forms.Label()
        Me.Descuento = New System.Windows.Forms.Label()
        Me.Subtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbImpuestos = New System.Windows.Forms.ComboBox()
        Me.chkApliIVS = New System.Windows.Forms.CheckBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.CmbDescuentos = New System.Windows.Forms.ComboBox()
        Me.chkApliDescuento = New System.Windows.Forms.CheckBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecioU = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.PrecioUnitario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 31)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "¡Gracias por su Preferencia!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 632)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 22)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "LPS."
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(282, 495)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(100, 26)
        Me.TxtDescuento.TabIndex = 43
        '
        'TxtIVS
        '
        Me.TxtIVS.Location = New System.Drawing.Point(282, 563)
        Me.TxtIVS.Name = "TxtIVS"
        Me.TxtIVS.Size = New System.Drawing.Size(100, 26)
        Me.TxtIVS.TabIndex = 42
        '
        'TxtTotalPagar
        '
        Me.TxtTotalPagar.Location = New System.Drawing.Point(282, 628)
        Me.TxtTotalPagar.Name = "TxtTotalPagar"
        Me.TxtTotalPagar.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPagar.TabIndex = 41
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(282, 432)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 26)
        Me.TxtSubtotal.TabIndex = 40
        '
        'TotalPagar
        '
        Me.TotalPagar.AutoSize = True
        Me.TotalPagar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPagar.Location = New System.Drawing.Point(111, 630)
        Me.TotalPagar.Name = "TotalPagar"
        Me.TotalPagar.Size = New System.Drawing.Size(128, 22)
        Me.TotalPagar.TabIndex = 39
        Me.TotalPagar.Text = "Total a Pagar:"
        '
        'IVS
        '
        Me.IVS.AutoSize = True
        Me.IVS.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVS.Location = New System.Drawing.Point(111, 563)
        Me.IVS.Name = "IVS"
        Me.IVS.Size = New System.Drawing.Size(51, 22)
        Me.IVS.TabIndex = 38
        Me.IVS.Text = "IVS: "
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(111, 497)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(107, 22)
        Me.Descuento.TabIndex = 37
        Me.Descuento.Text = "Descuento: "
        '
        'Subtotal
        '
        Me.Subtotal.AutoSize = True
        Me.Subtotal.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.Location = New System.Drawing.Point(111, 436)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(90, 22)
        Me.Subtotal.TabIndex = 36
        Me.Subtotal.Text = "Subtotal: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 25)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Datos de la Factura:  "
        '
        'CmbImpuestos
        '
        Me.CmbImpuestos.FormattingEnabled = True
        Me.CmbImpuestos.Items.AddRange(New Object() {"15%", "17% "})
        Me.CmbImpuestos.Location = New System.Drawing.Point(17, 265)
        Me.CmbImpuestos.Name = "CmbImpuestos"
        Me.CmbImpuestos.Size = New System.Drawing.Size(169, 28)
        Me.CmbImpuestos.TabIndex = 34
        Me.CmbImpuestos.Text = "  IMPUESTOS"
        '
        'chkApliIVS
        '
        Me.chkApliIVS.AutoSize = True
        Me.chkApliIVS.Location = New System.Drawing.Point(17, 235)
        Me.chkApliIVS.Name = "chkApliIVS"
        Me.chkApliIVS.Size = New System.Drawing.Size(122, 24)
        Me.chkApliIVS.TabIndex = 33
        Me.chkApliIVS.Text = " Aplicar ISV:"
        Me.chkApliIVS.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(310, 244)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(126, 40)
        Me.BtnSalir.TabIndex = 32
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Turquoise
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(310, 161)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(126, 40)
        Me.BtnNuevo.TabIndex = 31
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnCalcular.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(310, 81)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(126, 40)
        Me.BtnCalcular.TabIndex = 30
        Me.BtnCalcular.Text = "Calcular..."
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'CmbDescuentos
        '
        Me.CmbDescuentos.FormattingEnabled = True
        Me.CmbDescuentos.Items.AddRange(New Object() {"Tercera Edad", "Todo Publico", "Mujeres Embarazadas", "Estudiantes ", "Discapacitados "})
        Me.CmbDescuentos.Location = New System.Drawing.Point(17, 191)
        Me.CmbDescuentos.Name = "CmbDescuentos"
        Me.CmbDescuentos.Size = New System.Drawing.Size(184, 28)
        Me.CmbDescuentos.TabIndex = 29
        Me.CmbDescuentos.Text = "  DESCUENTOS"
        '
        'chkApliDescuento
        '
        Me.chkApliDescuento.AutoSize = True
        Me.chkApliDescuento.Location = New System.Drawing.Point(17, 161)
        Me.chkApliDescuento.Name = "chkApliDescuento"
        Me.chkApliDescuento.Size = New System.Drawing.Size(169, 24)
        Me.chkApliDescuento.TabIndex = 28
        Me.chkApliDescuento.Text = "Aplicar Descuento:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkApliDescuento.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(115, 118)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 26)
        Me.TxtCantidad.TabIndex = 27
        '
        'TxtPrecioU
        '
        Me.TxtPrecioU.Location = New System.Drawing.Point(115, 70)
        Me.TxtPrecioU.Name = "TxtPrecioU"
        Me.TxtPrecioU.Size = New System.Drawing.Size(100, 26)
        Me.TxtPrecioU.TabIndex = 26
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(13, 122)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(92, 22)
        Me.Cantidad.TabIndex = 25
        Me.Cantidad.Text = "Cantidad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.AutoSize = True
        Me.PrecioUnitario.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioUnitario.Location = New System.Drawing.Point(13, 52)
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.Size = New System.Drawing.Size(87, 44)
        Me.PrecioUnitario.TabIndex = 24
        Me.PrecioUnitario.Text = "  Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unitario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Datos Requeridos:  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(466, 670)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.TxtIVS)
        Me.Controls.Add(Me.TxtTotalPagar)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.TotalPagar)
        Me.Controls.Add(Me.IVS)
        Me.Controls.Add(Me.Descuento)
        Me.Controls.Add(Me.Subtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbImpuestos)
        Me.Controls.Add(Me.chkApliIVS)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.CmbDescuentos)
        Me.Controls.Add(Me.chkApliDescuento)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtPrecioU)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.PrecioUnitario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Inversiones DLS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents TxtIVS As TextBox
    Friend WithEvents TxtTotalPagar As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents TotalPagar As Label
    Friend WithEvents IVS As Label
    Friend WithEvents Descuento As Label
    Friend WithEvents Subtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbImpuestos As ComboBox
    Friend WithEvents chkApliIVS As CheckBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents CmbDescuentos As ComboBox
    Friend WithEvents chkApliDescuento As CheckBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtPrecioU As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents PrecioUnitario As Label
    Friend WithEvents Label1 As Label
End Class

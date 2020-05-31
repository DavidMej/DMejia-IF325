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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.RhtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnRegistar = New System.Windows.Forms.Button()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.Label()
        Me.NombreProducto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(424, 478)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(134, 43)
        Me.BtnSalir.TabIndex = 23
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(462, 226)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(134, 43)
        Me.BtnNuevo.TabIndex = 22
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'RhtDescripcion
        '
        Me.RhtDescripcion.Location = New System.Drawing.Point(250, 338)
        Me.RhtDescripcion.Name = "RhtDescripcion"
        Me.RhtDescripcion.Size = New System.Drawing.Size(249, 96)
        Me.RhtDescripcion.TabIndex = 21
        Me.RhtDescripcion.Text = ""
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(221, 270)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidad.TabIndex = 20
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(221, 190)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 26)
        Me.txtPrecio.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(221, 113)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(139, 26)
        Me.txtNombre.TabIndex = 18
        '
        'BtnRegistar
        '
        Me.BtnRegistar.BackColor = System.Drawing.Color.Gold
        Me.BtnRegistar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistar.Location = New System.Drawing.Point(462, 133)
        Me.BtnRegistar.Name = "BtnRegistar"
        Me.BtnRegistar.Size = New System.Drawing.Size(134, 43)
        Me.BtnRegistar.TabIndex = 17
        Me.BtnRegistar.Text = "Registrar..."
        Me.BtnRegistar.UseVisualStyleBackColor = False
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(103, 340)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(121, 22)
        Me.Descripcion.TabIndex = 16
        Me.Descripcion.Text = "Descripcion: "
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(102, 272)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(92, 22)
        Me.Cantidad.TabIndex = 15
        Me.Cantidad.Text = "Cantidad:"
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(103, 194)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(70, 22)
        Me.Precio.TabIndex = 14
        Me.Precio.Text = "Precio:"
        '
        'NombreProducto
        '
        Me.NombreProducto.AutoSize = True
        Me.NombreProducto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProducto.Location = New System.Drawing.Point(97, 115)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(80, 22)
        Me.NombreProducto.TabIndex = 13
        Me.NombreProducto.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Regisro de Poductos: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 557)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.RhtDescripcion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.BtnRegistar)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.NombreProducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents RhtDescripcion As RichTextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents BtnRegistar As Button
    Friend WithEvents Descripcion As Label
    Friend WithEvents Cantidad As Label
    Friend WithEvents Precio As Label
    Friend WithEvents NombreProducto As Label
    Friend WithEvents Label1 As Label
End Class

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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTablas = New System.Windows.Forms.TextBox()
        Me.BtnGenerarTablas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(174, 22)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(471, 32)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Generador de Tablas de Multiplicacion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese un  numero para conocer la tabla de muliplicacion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(118, 129)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(167, 26)
        Me.txtNumero.TabIndex = 2
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(638, 248)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(103, 41)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(638, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtTablas
        '
        Me.txtTablas.Location = New System.Drawing.Point(74, 169)
        Me.txtTablas.Multiline = True
        Me.txtTablas.Name = "txtTablas"
        Me.txtTablas.Size = New System.Drawing.Size(469, 269)
        Me.txtTablas.TabIndex = 2
        '
        'BtnGenerarTablas
        '
        Me.BtnGenerarTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGenerarTablas.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarTablas.Location = New System.Drawing.Point(582, 169)
        Me.BtnGenerarTablas.Name = "BtnGenerarTablas"
        Me.BtnGenerarTablas.Size = New System.Drawing.Size(201, 41)
        Me.BtnGenerarTablas.TabIndex = 6
        Me.BtnGenerarTablas.Text = "Generar Tablas "
        Me.BtnGenerarTablas.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 492)
        Me.Controls.Add(Me.BtnGenerarTablas)
        Me.Controls.Add(Me.txtTablas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTablas As TextBox
    Friend WithEvents BtnGenerarTablas As Button
End Class

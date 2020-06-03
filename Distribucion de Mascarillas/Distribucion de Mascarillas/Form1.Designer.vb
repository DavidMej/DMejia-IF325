<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrega_Mascarillas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.cmbCantDepto = New System.Windows.Forms.ComboBox()
        Me.cantDepto = New System.Windows.Forms.Label()
        Me.txtNoDeptos = New System.Windows.Forms.TextBox()
        Me.NoDepto = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCantDisponible = New System.Windows.Forms.TextBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.CantiDisponible = New System.Windows.Forms.Label()
        Me.txtcantMunicipios = New System.Windows.Forms.TextBox()
        Me.cantMunicipios = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.cmbCantDepto)
        Me.GroupBox1.Controls.Add(Me.cantDepto)
        Me.GroupBox1.Controls.Add(Me.txtNoDeptos)
        Me.GroupBox1.Controls.Add(Me.NoDepto)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(52, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por Departamento:"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSolicitar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.Location = New System.Drawing.Point(229, 108)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(117, 46)
        Me.btnSolicitar.TabIndex = 4
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'cmbCantDepto
        '
        Me.cmbCantDepto.FormattingEnabled = True
        Me.cmbCantDepto.Location = New System.Drawing.Point(276, 185)
        Me.cmbCantDepto.Name = "cmbCantDepto"
        Me.cmbCantDepto.Size = New System.Drawing.Size(121, 31)
        Me.cmbCantDepto.TabIndex = 3
        '
        'cantDepto
        '
        Me.cantDepto.AutoSize = True
        Me.cantDepto.Location = New System.Drawing.Point(22, 188)
        Me.cantDepto.Name = "cantDepto"
        Me.cantDepto.Size = New System.Drawing.Size(219, 23)
        Me.cantDepto.TabIndex = 2
        Me.cantDepto.Text = "Cant. por Departamento:"
        '
        'txtNoDeptos
        '
        Me.txtNoDeptos.Location = New System.Drawing.Point(231, 55)
        Me.txtNoDeptos.Name = "txtNoDeptos"
        Me.txtNoDeptos.Size = New System.Drawing.Size(115, 30)
        Me.txtNoDeptos.TabIndex = 1
        '
        'NoDepto
        '
        Me.NoDepto.AutoSize = True
        Me.NoDepto.Location = New System.Drawing.Point(22, 58)
        Me.NoDepto.Name = "NoDepto"
        Me.NoDepto.Size = New System.Drawing.Size(178, 23)
        Me.NoDepto.TabIndex = 0
        Me.NoDepto.Text = "No. Departamentos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCantDisponible)
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.CantiDisponible)
        Me.GroupBox2.Controls.Add(Me.txtcantMunicipios)
        Me.GroupBox2.Controls.Add(Me.cantMunicipios)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(52, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidad por Departamento:"
        '
        'txtCantDisponible
        '
        Me.txtCantDisponible.Location = New System.Drawing.Point(213, 185)
        Me.txtCantDisponible.Name = "txtCantDisponible"
        Me.txtCantDisponible.Size = New System.Drawing.Size(115, 30)
        Me.txtCantDisponible.TabIndex = 5
        '
        'btnEntregar
        '
        Me.btnEntregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnEntregar.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.Location = New System.Drawing.Point(213, 109)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(133, 45)
        Me.btnEntregar.TabIndex = 4
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = False
        '
        'CantiDisponible
        '
        Me.CantiDisponible.AutoSize = True
        Me.CantiDisponible.Location = New System.Drawing.Point(22, 188)
        Me.CantiDisponible.Name = "CantiDisponible"
        Me.CantiDisponible.Size = New System.Drawing.Size(157, 23)
        Me.CantiDisponible.TabIndex = 2
        Me.CantiDisponible.Text = "Cant. Disponible:"
        '
        'txtcantMunicipios
        '
        Me.txtcantMunicipios.Location = New System.Drawing.Point(213, 55)
        Me.txtcantMunicipios.Name = "txtcantMunicipios"
        Me.txtcantMunicipios.Size = New System.Drawing.Size(115, 30)
        Me.txtcantMunicipios.TabIndex = 1
        '
        'cantMunicipios
        '
        Me.cantMunicipios.AutoSize = True
        Me.cantMunicipios.Location = New System.Drawing.Point(22, 58)
        Me.cantMunicipios.Name = "cantMunicipios"
        Me.cantMunicipios.Size = New System.Drawing.Size(162, 23)
        Me.cantMunicipios.TabIndex = 0
        Me.cantMunicipios.Text = "Cant. Municipios:"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(708, 622)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 43)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir..."
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SeaShell
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"1)Atlántida (8 municipios)", "2)Choluteca (16 municipios)", "3)Colón (10 municipios)", "4)Comayagua (21 municipios)", "5)Copán (23 municipios)", "6)Cortes (12 municipios)", "7)El Paraíso (19 municipios)", "8)Francisco Morazán (28 municipios)", "9)Gracias a Dios (6 municipios)", "10)Intibucá (17 municipios)", "11)Islas de la Bahía (4 municipios)", "12)La Paz (19 municipios)", "13)Lempira (28 municipios)", "14)Ocotepeque (16 municipios)", "15)Olancho (23 municipios)", "16)Santa Bárbara (28 municipios)", "17)Valle (9 municipios)", "18)Yoro (11 municipios)"})
        Me.ListBox1.Location = New System.Drawing.Point(555, 141)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(293, 364)
        Me.ListBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Departamentos:"
        '
        'Entrega_Mascarillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 693)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entrega_Mascarillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SINAGER "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCantDepto As ComboBox
    Friend WithEvents cantDepto As Label
    Friend WithEvents txtNoDeptos As TextBox
    Friend WithEvents NoDepto As Label
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCantDisponible As TextBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents CantiDisponible As Label
    Friend WithEvents txtcantMunicipios As TextBox
    Friend WithEvents cantMunicipios As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
End Class

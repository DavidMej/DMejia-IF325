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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbNoOrden = New System.Windows.Forms.MaskedTextBox()
        Me.NoOrden = New System.Windows.Forms.Label()
        Me.TotalPagar = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPagoIndividual = New System.Windows.Forms.TextBox()
        Me.P_Individual = New System.Windows.Forms.Label()
        Me.BtnSolicitar_Pedido = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedir Orden "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtbNoOrden)
        Me.GroupBox1.Controls.Add(Me.NoOrden)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(26, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden:"
        '
        'mtbNoOrden
        '
        Me.mtbNoOrden.Location = New System.Drawing.Point(132, 40)
        Me.mtbNoOrden.Mask = "999"
        Me.mtbNoOrden.Name = "mtbNoOrden"
        Me.mtbNoOrden.Size = New System.Drawing.Size(100, 30)
        Me.mtbNoOrden.TabIndex = 1
        Me.mtbNoOrden.ValidatingType = GetType(Integer)
        '
        'NoOrden
        '
        Me.NoOrden.AutoSize = True
        Me.NoOrden.Location = New System.Drawing.Point(16, 43)
        Me.NoOrden.Name = "NoOrden"
        Me.NoOrden.Size = New System.Drawing.Size(100, 22)
        Me.NoOrden.TabIndex = 0
        Me.NoOrden.Text = "No. Orden:"
        '
        'TotalPagar
        '
        Me.TotalPagar.AutoSize = True
        Me.TotalPagar.Location = New System.Drawing.Point(7, 62)
        Me.TotalPagar.Name = "TotalPagar"
        Me.TotalPagar.Size = New System.Drawing.Size(133, 22)
        Me.TotalPagar.TabIndex = 2
        Me.TotalPagar.Text = "Total a Pagar: "
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(151, 59)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(100, 30)
        Me.txtTotalPagar.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPagoIndividual)
        Me.GroupBox2.Controls.Add(Me.P_Individual)
        Me.GroupBox2.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox2.Controls.Add(Me.TotalPagar)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 169)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago:"
        '
        'txtPagoIndividual
        '
        Me.txtPagoIndividual.Location = New System.Drawing.Point(171, 122)
        Me.txtPagoIndividual.Name = "txtPagoIndividual"
        Me.txtPagoIndividual.Size = New System.Drawing.Size(100, 30)
        Me.txtPagoIndividual.TabIndex = 5
        '
        'P_Individual
        '
        Me.P_Individual.AutoSize = True
        Me.P_Individual.Location = New System.Drawing.Point(7, 125)
        Me.P_Individual.Name = "P_Individual"
        Me.P_Individual.Size = New System.Drawing.Size(148, 22)
        Me.P_Individual.TabIndex = 4
        Me.P_Individual.Text = "Pago Individual:"
        '
        'BtnSolicitar_Pedido
        '
        Me.BtnSolicitar_Pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSolicitar_Pedido.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSolicitar_Pedido.Location = New System.Drawing.Point(321, 107)
        Me.BtnSolicitar_Pedido.Name = "BtnSolicitar_Pedido"
        Me.BtnSolicitar_Pedido.Size = New System.Drawing.Size(181, 43)
        Me.BtnSolicitar_Pedido.TabIndex = 5
        Me.BtnSolicitar_Pedido.Text = "Solicitar Pedido"
        Me.BtnSolicitar_Pedido.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(348, 493)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 46)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir..."
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(188, 493)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 46)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 564)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnSolicitar_Pedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtbNoOrden As MaskedTextBox
    Friend WithEvents NoOrden As Label
    Friend WithEvents TotalPagar As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPagoIndividual As TextBox
    Friend WithEvents P_Individual As Label
    Friend WithEvents BtnSolicitar_Pedido As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents btnNuevo As Button
End Class

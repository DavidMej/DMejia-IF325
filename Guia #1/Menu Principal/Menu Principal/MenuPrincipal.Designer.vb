<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulaCuadraticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosPrimosParesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularMediaDeCentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadorasToolStripMenuItem, Me.CalcularMediaDeCentasToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 468)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadorasToolStripMenuItem
        '
        Me.CalculadorasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicaToolStripMenuItem, Me.FormulaCuadraticaToolStripMenuItem, Me.NumerosPrimosParesToolStripMenuItem})
        Me.CalculadorasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculadorasToolStripMenuItem.Name = "CalculadorasToolStripMenuItem"
        Me.CalculadorasToolStripMenuItem.Size = New System.Drawing.Size(157, 464)
        Me.CalculadorasToolStripMenuItem.Text = "Calculadoras"
        '
        'BasicaToolStripMenuItem
        '
        Me.BasicaToolStripMenuItem.Name = "BasicaToolStripMenuItem"
        Me.BasicaToolStripMenuItem.Size = New System.Drawing.Size(390, 44)
        Me.BasicaToolStripMenuItem.Text = "Basica "
        '
        'FormulaCuadraticaToolStripMenuItem
        '
        Me.FormulaCuadraticaToolStripMenuItem.Name = "FormulaCuadraticaToolStripMenuItem"
        Me.FormulaCuadraticaToolStripMenuItem.Size = New System.Drawing.Size(390, 44)
        Me.FormulaCuadraticaToolStripMenuItem.Text = "Formula Cuadratica"
        '
        'NumerosPrimosParesToolStripMenuItem
        '
        Me.NumerosPrimosParesToolStripMenuItem.Name = "NumerosPrimosParesToolStripMenuItem"
        Me.NumerosPrimosParesToolStripMenuItem.Size = New System.Drawing.Size(390, 44)
        Me.NumerosPrimosParesToolStripMenuItem.Text = "Numeros Pares e Impares  "
        '
        'CalcularMediaDeCentasToolStripMenuItem
        '
        Me.CalcularMediaDeCentasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CalcularMediaDeCentasToolStripMenuItem.Name = "CalcularMediaDeCentasToolStripMenuItem"
        Me.CalcularMediaDeCentasToolStripMenuItem.Size = New System.Drawing.Size(204, 464)
        Me.CalcularMediaDeCentasToolStripMenuItem.Text = "Media de Ventas "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(16, 464)
        '
        'DeduccuionOExtensoDeUnSueldoToolStripMenuItem
        '
        Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem.Name = "DeduccuionOExtensoDeUnSueldoToolStripMenuItem"
        Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem.Size = New System.Drawing.Size(359, 464)
        Me.DeduccuionOExtensoDeUnSueldoToolStripMenuItem.Text = "Deduccion o Exento de un sueldo"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(761, 392)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 47)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir "
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.BackgroundImage = Global.Menu_Principal.My.Resources.Resources.FondoMenu2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(914, 468)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulaCuadraticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumerosPrimosParesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularMediaDeCentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeduccuionOExtensoDeUnSueldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
End Class

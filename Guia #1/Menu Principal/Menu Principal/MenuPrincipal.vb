Public Class MenuPrincipal
    Private Sub BasicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicaToolStripMenuItem.Click
        Calculadora_Basica.Show()
        Me.Hide()
    End Sub

    Private Sub FormulaCuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaCuadraticaToolStripMenuItem.Click
        Formula_Cuadratica.Show()
        Me.Hide()
    End Sub

    Private Sub NumerosPrimosParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumerosPrimosParesToolStripMenuItem.Click
        Numeros_Pares_e_Impares.Show()
        Me.Hide()
    End Sub

    Private Sub DeduccuionOExtensoDeUnSueldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeduccuionOExtensoDeUnSueldoToolStripMenuItem.Click
        Deducciones_y_Excentos.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub CalcularMediaDeCentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularMediaDeCentasToolStripMenuItem.Click
        Calcular_Media_de_Ventas.Show()
        Me.Hide()
    End Sub
End Class

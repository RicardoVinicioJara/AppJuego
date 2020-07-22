Public Class resultados
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
        inicio.Show()

    End Sub

    Private Sub resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuadro.Series("3R").Points.AddXY("Apodo", 10)
        cuadro.Series("Trivia").Points.AddXY("Apodo", 10)

    End Sub
End Class
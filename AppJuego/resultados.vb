Public Class resultados
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
        inicio.Show()
        Me.Dispose()

    End Sub

    Private Sub resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim List = ListarPuntaje()
        For i As Integer = 0 To List.Count - 1 Step 1
            If List(i)(2) = "1" Then
                cuadro.Series("Trivia").Points.AddXY(List(i)(1), Convert.ToInt32(List(i)(0)))
            End If
            If List(i)(2) = "2" Then
                cuadro.Series("PPT").Points.AddXY(List(i)(1), Convert.ToInt32(List(i)(0)))
            End If

        Next


    End Sub
End Class
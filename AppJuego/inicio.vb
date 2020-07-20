Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resConection As String = Abrirconexion()
        lblConexion.Text = resConection


    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub
End Class

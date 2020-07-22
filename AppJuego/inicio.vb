Imports System.Globalization

Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resConection As String = Abrirconexion()
        lblConexion.Text = resConection
        boxJuego.Visible = False
        'Dim List = ListarPuntaje()'
        'MsgBox(List(0)(0).ToString, MsgBoxStyle.Critical, "1111111")'

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If Login(txtApodoL.Text, txtContraL.Text) = True Then
            boxJuego.Visible = True
            txtContraL.Text = ""
            txtApodoL.Text = ""
        Else
            boxJuego.Visible = False
            MsgBox("Datos Incorrectos", MsgBoxStyle.Exclamation, "Informacion")
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If exitApodo(txtApodo.Text) = False Then
            Dim resConection2 As String = insertarJugador(txtNombre.Text, CDate(txtFecha.Text), txtApodo.Text, txtContra.Text)
            If resConection2 = True Then
                MsgBox("Jugaor Insetado Correctamente", MsgBoxStyle.Information, "Informacion")
                txtApodo.Text = ""
                txtNombre.Text = ""
                txtFecha.Text = ""
                txtContra.Text = ""
            Else
                MsgBox("Jugaor No Ingresado", MsgBoxStyle.Information, "Informacion")
            End If
        Else
            MsgBox("Apodo Existente", MsgBoxStyle.Information, "Informacion")
        End If


    End Sub

    Private Sub btnJuego1_Click(sender As Object, e As EventArgs) Handles btnJuego1.Click
        boxJuego.Visible = False
        trivia.Show()
        Me.Hide()
    End Sub

    Private Sub btnJuego2_Click(sender As Object, e As EventArgs) Handles btnJuego2.Click
        boxJuego.Visible = False
        piedra.Show()
        Me.Hide()
    End Sub
End Class

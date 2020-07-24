Imports System.Globalization

Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inicia la conexion 
        Dim resConection As String = Abrirconexion()
        'mostramos el estado de la conexion 
        lblConexion.Text = resConection
        boxJuego.Visible = False

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'llama la funcio login y pasa el valor de la contraseña y apodo
        If Login(txtApodoL.Text, txtContraL.Text) = True Then
            'SI el login es exitoso se muetra la bontones para escojer los juegos
            boxJuego.Visible = True
            txtContraL.Text = ""
            txtApodoL.Text = ""
        Else
            'En que que login retorne falso > oculta botones de juego
            boxJuego.Visible = False
            MsgBox("Datos Incorrectos", MsgBoxStyle.Exclamation, "Informacion")
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Llama a la funcion que insertar jugador y crea al jugador
        If exitApodo(txtApodo.Text) = False Then
            Dim resConection2 As String = insertarJugador(txtNombre.Text, CDate(txtFecha.Text), txtApodo.Text, txtContra.Text)
            If resConection2 = True Then
                MsgBox("Jugaor Insetado Correctamente", MsgBoxStyle.Information, "Informacion")
                txtApodo.Text = ""
                txtNombre.Text = ""
                txtFecha.Text = ""
                txtContra.Text = ""
                'el cliente se crea correctamente
            Else
                'Erro al ingresar jugador
                MsgBox("Jugaor No Ingresado", MsgBoxStyle.Information, "Informacion")
            End If
        Else
            'No se ingresa en caso de que exista el apodo
            MsgBox("Apodo Existente", MsgBoxStyle.Information, "Informacion")
        End If
    End Sub

    Private Sub btnJuego1_Click(sender As Object, e As EventArgs) Handles btnJuego1.Click
        'abra el form de juego de trivia
        'Desaparce los botones del juego
        boxJuego.Visible = False
        'Aparecer el form del primer juego
        trivia.Show()
        'Desaparece el incico
        Me.Hide()
    End Sub

    Private Sub btnJuego2_Click(sender As Object, e As EventArgs) Handles btnJuego2.Click
        'Abre el juego piedra papel y tijera
        boxJuego.Visible = False
        piedra.Show()
        'Desaparece el inicio
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'abre el forma de rustados
        'desaparce el form de incio
        Me.Hide()
        resultados.Show()
    End Sub
End Class

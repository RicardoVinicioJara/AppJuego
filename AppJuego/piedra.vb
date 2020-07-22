Imports System.Threading

Public Class piedra
    Public Shared sistema As Integer = 0
    Public Shared jugador As Integer = 0
    Public Shared puntaje As Integer = 0
    ' 1 = Piedra
    ' 2 = Papel
    ' 3 = Tijera
    Private Sub btnPiedra_Click(sender As Object, e As EventArgs) Handles btnPiedra.Click
        calcularGanador(1)
    End Sub

    Function calcularGanador(ByVal opc As Integer) As String
        Dim numSistema As Integer = Int((3 - 1 + 1) * Rnd() + 1)
        opcionSistema(numSistema)
        If numSistema = opc Then
            lblResultado.Text = "Empate"
            sistema = sistema + 1
            jugador = jugador + 1
            puntaje = puntaje + 5
        ElseIf opc = 1 And numSistema = 2 Then
            lblResultado.Text = "Gana sistema"
            sistema = sistema + 1
        ElseIf opc = 1 And numSistema = 3 Then
            lblResultado.Text = "Gana jugador"
            jugador = jugador + 1
            puntaje = puntaje + 10
        ElseIf opc = 2 And numSistema = 1 Then
            lblResultado.Text = "Gana jugador"
            jugador = jugador + 1
            puntaje = puntaje + 10
        ElseIf opc = 2 And numSistema = 3 Then
            lblResultado.Text = "Gana Sistema"
            sistema = sistema + 1
        ElseIf opc = 3 And numSistema = 1 Then
            lblResultado.Text = "Gana jugador"
            jugador = jugador + 1
            puntaje = puntaje + 10
        ElseIf opc = 3 And numSistema = 2 Then
            lblResultado.Text = "Gana Sistema"
            sistema = sistema + 1
        End If
        escribirResultados()
        'Cambiar el numero de veces que debe ganar
        If sistema > (jugador + 1) Then
            lblResultado.Text = "El sistema tiene 2 de ventaga... GANA"
            insertarPuntaje(puntaje, 2)
            ocultar()
        End If
        If jugador > (sistema + 1) Then
            lblResultado.Text = "El jugador tiene 2 de ventaga... GANA"
            insertarPuntaje(puntaje, 2)
            ocultar()
        End If
        Return ""
    End Function

    Function opcionSistema(ByVal opc As Integer) As String
        Select Case opc
            Case 1
                btnSistema.Image = My.Resources.piedra

            Case 2
                btnSistema.Image = My.Resources.papel
            Case 3
                btnSistema.Image = My.Resources.tijera
            Case 4
                btnSistema.Image = My.Resources.load
        End Select

    End Function

    Function escribirResultados()
        lblJugador.Text = jugador & ""
        lblSistema.Text = sistema & ""
    End Function

    Function ocultar()
        btnAceptar.Visible = True
        btnPiedra.Enabled = False
        btnPapel.Enabled = False
        btnTijera.Enabled = False

    End Function


    Private Sub btnPapel_Click(sender As Object, e As EventArgs) Handles btnPapel.Click
        calcularGanador(2)
    End Sub

    Private Sub btnTijera_Click(sender As Object, e As EventArgs) Handles btnTijera.Click
        calcularGanador(3)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        resultados.Show()
        puntaje = 0
        sistema = 0
        jugador = 0
        Me.Hide()
        Me.Dispose()
    End Sub
End Class
﻿Public Class trivia
    'datos para el inicio de datos
    Public Shared contador As Integer = 0
    Public Shared puntaje As Integer = 0
    Public Shared respuesta As Integer = -100
    'arreglo de preguntas
    Public Shared preguntas = New String(5, 4) {{"¿Cómo se llama la capital de Ecuador?", "Cuenca", "Lima", "Quito", "3"},
                                         {"¿Cuántas provincias tiene el Ecuador?", "24", "22", "21", "1"},
                                         {"¿En qué fecha se independizó de España?", "14 de enero de 1809", "10 de agosto de 1809", "6 de mayo de 1809", "2"},
                                         {"¿Cuál es la ciudad más poblada?", "Quito", "Ibarra", "Guayaquil", "3"},
                                         {"¿Ecuador fue parte de la Gran Colombia?", "SI", "NO", "Aun lo es", "1"},
                                         {"¿Dónde nació Antonio José de Sucre?", "Colombia", "Venezuela", "Peru", "2"}}
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If opcbox.SelectedIndex = -1 Then
            MsgBox("Selecione una opcion ", MsgBoxStyle.Exclamation, "Informacion")
        Else
            If respuesta = opcbox.SelectedIndex Then
                puntaje = puntaje + 10
            End If
            PasarPregunta()
        End If
    End Sub

    Private Sub trivia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inicia con un cotador en cero para psara las preguntas
        contador = 0
        PasarPregunta()
    End Sub

    Function PasarPregunta() As String
        'funcion que rrecorre el arreglo de preguntas
        If contador < 6 Then
            lblPreguntas.Text = preguntas(contador, 0)
            opcbox.Items.Clear()
            opcbox.Items.Add(preguntas(contador, 1))
            opcbox.Items.Add(preguntas(contador, 2))
            opcbox.Items.Add(preguntas(contador, 3))
            respuesta = Convert.ToInt32(preguntas(contador, 4)) - 1
            contador = contador + 1
            opcbox.SelectedIndex = -1
            opcbox.Text = ""
        Else
            'en caso de que ya se haya recorrido las 6 preguntas muestra el resultado
            lblPreguntas.Text = "Tu puntaje obtenido es: " & puntaje
            Dim resConection2 As String = insertarPuntaje(puntaje, 1)
            btnNext.Visible = False
            opcbox.Visible = False
            btnAceptar.Visible = True
        End If
        Return ""
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'muestra el cuadro de resultados
        puntaje = 0
        resultados.Show()
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub
End Class
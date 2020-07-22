Public Class trivia

    Public Shared contador As Integer = 0
    Public Shared puntaje As Integer = 0
    Public Shared respuesta As Integer = -100
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
        PasarPregunta()
    End Sub

    Function PasarPregunta() As String
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
            lblPreguntas.Text = "Tu puntaje obtenido es: " & puntaje
            Dim resConection2 As String = insertarPuntaje(puntaje, 1)
            btnNext.Visible = False
            opcbox.Visible = False
        End If
        Return ""
    End Function

End Class
'Clase que ayuda con el control y manejo de datos con la base de datos
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections

Module metodos
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public jugador As Integer = 0
    Public dr As SqlDataReader
    Public cmd As SqlCommand

    'Conexión  la bace de daatoas
    'Retorna un mensaje con el estado de la conexión  
    Function Abrirconexion() As String
        Try
            conexiones = New SqlConnection("Data Source=LAPTOP-A3DS3D8A\SQLEXPRESS;Initial Catalog=Juego;Integrated Security=True")
            conexiones.Open()
            'MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
            conexiones.Close()
            Return "Conexion exitosa"
        Catch ex As Exception
            'MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")'
            conexiones.Close() 'Cierra la conexion'
            Return "Error al realizar la conexion"
        End Try
    End Function

    'Busca el ultimo ID de jugador 
    'le suma uno al resultado para ingresar el nuevo id
    'retorna un integer siendo el nuevo ID

    Function MaxID() As Integer
        Dim resultado As Integer = -1
        Try
            conexiones.Open()
            enunciado = New SqlCommand("SELECT MAX(id) FROM Jugador", conexiones)
            resultado = enunciado.ExecuteScalar()
            conexiones.Close()
            Return resultado

        Catch ex As Exception
            resultado = -1
            conexiones.Close()

        End Try
        Return resultado
    End Function

    'Busca el ultimo ID de puntaje 
    'le suma uno al resultado para ingresar el nuevo id de puntaje
    'retorna un integer siendo el nuevo ID
    Function MaxIDPutaje() As Integer
        Dim resultado As Integer = -1
        Try
            conexiones.Open()
            enunciado = New SqlCommand("SELECT MAX(id) FROM puntaje", conexiones)
            resultado = enunciado.ExecuteScalar()
            conexiones.Close()
            Return resultado

        Catch ex As Exception
            resultado = -1
            conexiones.Close()

        End Try
        Return resultado
    End Function

    'Función que busca si el apodo ingresado ya existe 
    'En caso de que ya existe retorna un FALSE
    'En caso de que no existe retorna un TRUE
    Function exitApodo(ByVal apodo As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexiones.Open()
            enunciado = New SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM Jugador WHERE apodo = '" & apodo & "')  THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", conexiones)
            resultado = enunciado.ExecuteScalar()
            conexiones.Close()
            Return resultado

        Catch ex As Exception
            resultado = False
            conexiones.Close()

        End Try
        Return resultado
    End Function

    'Función que cónsula en la base de datos si existe una jugador ingresado con el apodo y la contraseña 
    'Retorna  un TRUE si existe
    'Retorna un FALSE si no existe
    'recibe como parámetro un String de apodo y String de contraseña 
    Function Login(ByVal apodo As String, ByVal contra As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexiones.Open()
            enunciado = New SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM Jugador WHERE apodo = '" & apodo & "' and Contracenia = '" & contra & "' ) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", conexiones)
            resultado = enunciado.ExecuteScalar()
            conexiones.Close()

            If resultado = True Then
                'En caso de que el login sea exitoso se buscar el id de jugador
                'El id del jugador se lo ultilizara en cuado se ingrese un puntaje
                conexiones.Open()
                enunciado = New SqlCommand("select id from Jugador where apodo = '" & apodo & "'", conexiones)
                jugador = enunciado.ExecuteScalar()
                conexiones.Close()
            End If
            Return resultado

        Catch ex As Exception
            Console.Write(ex.ToString)
            resultado = False
            conexiones.Close()

        End Try
        Return resultado
    End Function

    'Funcion que ingresa el nuevo jugador 
    ''recibe como parámetro un String de nombre, Date fechaNac y String de contraseña y un apodo
    Function insertarJugador(ByVal nombre As String, ByVal fechaNac As Date, ByVal apodo As String, ByVal contrasenia As String) As Boolean
        Dim id As Integer = MaxID() + 1
        Dim resultado As Boolean = False
        If id >= 0 Then
            Try
                conexiones.Open()
                enunciado = New SqlCommand("insert into Jugador(id,nombre,fechaNac,apodo,Contracenia) values(" & id & ",'" & nombre & "','" & Format(fechaNac, "yyyy/MM/dd") & "','" & apodo & "','" & contrasenia & "')", conexiones)
                enunciado.ExecuteNonQuery()
                resultado = True
                conexiones.Close()
            Catch ex As Exception
                Console.Write("No se pudo realizar la Reservacion" + ex.ToString)
                conexiones.Close()
                resultado = False

            End Try
        End If
        Return resultado
    End Function

    'Funcion que ingresa el puntaje del un jugador con un juego 
    'Recibe como parametor un int de cantidad, y el juego | 1 = trivia | 2 = piedra papel o tijera
    Function insertarPuntaje(ByVal puntaje As Integer, ByVal juego As Integer) As Boolean
        Dim id As Integer = MaxIDPutaje() + 1
        Dim resultado As Boolean = False
        If id >= 0 Then
            Try
                conexiones.Open()
                enunciado = New SqlCommand("insert into puntaje(id, puntaje, jugador_id, juego_id) values(" & id & "," & puntaje & "," & jugador & "," & juego & ")", conexiones)
                enunciado.ExecuteNonQuery()
                resultado = True
                conexiones.Close()
            Catch ex As Exception
                Console.Write("No se pudo realizar la Reservacion" + ex.ToString)
                conexiones.Close()
                resultado = False

            End Try
        End If
        Return resultado
    End Function
    'Funcion que retorna una matriz con la suma de los puntajes obtenidos de cada jugaro en cada juego
    Function ListarPuntaje() As ArrayList
        Dim List As New ArrayList
        Try
            conexiones.Open()
            enunciado = New SqlCommand("Select SUM(p.puntaje) as Puntaje, j.apodo as Apodo, p.juego_id as Juego from puntaje p, jugador j where j.id = p.jugador_id GROUP BY p.juego_id, j.apodo", conexiones)
            dr = enunciado.ExecuteReader()
            Do While dr.Read
                'Se llena la matriz que nos ayudara a generar el grafico de los puntajes
                List.Add({dr.GetValue(0), dr.GetString(1), dr.GetValue(2)})
                'MsgBox(dr.GetValue(0) & " <> " & dr.GetString(1) & " <> " & dr.GetValue(2), MsgBoxStyle.Critical, "1111111")'
            Loop
            If dr.IsClosed = False Then
                dr.Close()
            End If
            conexiones.Close()
        Catch ex As Exception
            MsgBox(ex.ToString & ex.Message, MsgBoxStyle.Critical, "weeee")
            Console.Write("n" + ex.ToString)
            conexiones.Close()
        End Try
        Return List
    End Function

End Module
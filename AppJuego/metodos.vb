﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Module metodos
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter


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

    Function Login(ByVal apodo As String, ByVal contra As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexiones.Open()
            enunciado = New SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM Jugador WHERE apodo = '" & apodo & "' and Contracenia = '" & contra & "' ) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", conexiones)
            resultado = enunciado.ExecuteScalar()
            conexiones.Close()
            Return resultado

        Catch ex As Exception
            resultado = False
            conexiones.Close()

        End Try
        Return resultado
    End Function

    Function insertarJugador(ByVal nombre As String, ByVal fechaNac As Date, ByVal apodo As String, ByVal contrasenia As String) As Boolean
        Dim id As Integer = MaxID() + 1
        Dim resultado As Boolean = False
        If id > 0 Then
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
    '******************************************************************************************************************************************************'


    'FUNCION DE ELIMINACION'
    '***************************************************************************************************************************************************'
    Function eliminarReservacion(ByVal identificacion As String) As String
        Dim resultado As String
        Try
            enunciado = New SqlCommand("Delete Reservacion from Reservacion where Id_Cliente='" & identificacion & "'", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se elimino la reservacion Correctamente"
        Catch ex As Exception
            resultado = "No se elimino elimino la reservacion correctamente" + ex.ToString

        End Try
        Return resultado

    End Function
    '***************************************************************************************************************************************************'

End Module
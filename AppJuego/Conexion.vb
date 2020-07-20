Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'

    Function Abrirconexion() As String
        Try
            conexiones = New SqlConnection("Data Source=LAPTOP-A3DS3D8A\SQLEXPRESS;Initial Catalog=Juego;Integrated Security=True")
            conexiones.Open()
            'MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
            Return "Conexion exitosa"

        Catch ex As Exception
            'MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")'
            conexiones.Close() 'Cierra la conexion'
            Return "Error al realizar la conexion"
        End Try
    End Function

    '***********************************************************************************************************************************************'


    'FUNCION DE INSERCION '
    '***************************************************************************************************************************************************'
    Function insercionReservacion(ByVal identificacion As String, ByVal nombre As String, ByVal telefono As String, ByVal hora As String, ByVal fecha As Date, ByVal horaIngreso As String, ByVal horaSalida As String, ByVal numeroHabitacion As Integer, ByVal nacionalidad As Integer) As String

        Dim resultado As String = ""

        Try
            enunciado = New SqlCommand("insert into Reservacion(Id_Cliente,Nombre_Cliente,Telefono_Cliente,Hora_Reservacion,Fecha_Reservacion,Hora_Ingreso,Hora_Salida,Numero_Habitacion,Nacionalidad) values('" & identificacion & "','" & nombre & "','" & telefono & "','" & hora & "','" & fecha & "','" & horaIngreso & "','" & horaSalida & "'," & numeroHabitacion & "," & nacionalidad & ")", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha reservado correctamente"
            conexiones.Close()

        Catch ex As Exception
            resultado = "No se pudo realizar la Reservacion"
            conexiones.Close()

        End Try
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
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Module Conexion
    Public conexion As SqlConnection
    Public adaptador As SqlDataAdapter
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Sub Abrir()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub
    'Funcion para mostrar datos en el DataGridView'
    Sub DataEmpleados(ByVal tabla As DataGridView)
        adaptador = New SqlDataAdapter("select Id_Identidad, Nombres, Apellidos, Sexo, Telefono, Direccion, Correo, Fecha_de_Ingreso, Cargo_Nominal, Cargo_Funcional, Modalidad_de_Contratación, Tipo from Registro_de_Empleados inner join Tipo_Vacaciones on Registro_de_Empleados.Id_Tipo_Vacacion = Tipo_Vacaciones.Id_Tipo_Vacacion", conexion)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Registro_de_Empleados")
        tabla.DataSource = dataS.Tables("Registro_de_Empleados")
    End Sub

    'Funcion para mostrar datos en el DataGridView'
    Sub DataUsuarios(ByVal tabla As DataGridView)
        adaptador = New SqlDataAdapter("select * From Registrar_Usuarios", conexion)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Registrar_Usuarios")
        tabla.DataSource = dataS.Tables("Registrar_Usuarios")
    End Sub

    Sub DataVacaciones(ByVal tabla As DataGridView)
        adaptador = New SqlDataAdapter("select * From Vacaciones", conexion)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Vacaciones")
        tabla.DataSource = dataS.Tables("Vacaciones")
    End Sub

    Sub DataPermisos(ByVal tabla As DataGridView)
        adaptador = New SqlDataAdapter("select * From Permisos", conexion)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Permisos")
        tabla.DataSource = dataS.Tables("Permisos")
    End Sub

    'Usar para inicio de Sesion con verificacion desde la base de datos

    Function UsuarioRegistrado(ByVal Identificador As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Registrar_Usuarios where Nombre_De_Usuario ='" & Identificador & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function ContrasenaUsuario(ByVal Identificador As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contrasena from Registrar_Usuarios where Nombre_De_Usuario='" & Identificador & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasena")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function



End Module

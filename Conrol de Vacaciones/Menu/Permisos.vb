Imports System.Runtime.InteropServices
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class Permisos
    Public conexion As SqlConnection
    Public consulta As SqlCommand
    Public datos As DataSet

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataPermisos(DGPermisos)
        Abrir()
    End Sub
    Sub BuscarCuenta()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub


    ' Buscar Permiso
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)

        Try

            If txtIdentidad.Text <> "" And txtIdentidad.Text <> 0 Then
                consulta = New SqlCommand("select  id_Identidad, Tipo_de_Permiso, Fecha_de_Permiso, Descripcion, Id_Identidad from Registro_de_Empleados where id_Identidad='" & txtIdentidad.Text & "'", conexion)
                adaptador = New SqlDataAdapter(consulta)
                datos = New DataSet
                adaptador.Fill(datos, "Permisos")
                DGPermisos.DataSource = datos

                Dim resultado As Boolean = False
                respuesta = consulta.ExecuteReader
                If respuesta.Read Then
                    resultado = True
                    DGPermisos.DataMember = "Permisos"
                    respuesta.Close()

                Else
                    MsgBox("Identidad no encontrada", MsgBoxStyle.Critical)
                    txtIdentidad.SelectAll()
                    respuesta.Close()
                End If

            Else
                MsgBox("Ingrese un número de identidad", MsgBoxStyle.Critical)
                txtIdentidad.Focus()
                txtIdentidad.Clear()
            End If
        Catch ex As Exception
            MsgBox("Ingrese un valor correcto", MsgBoxStyle.Critical)
            txtIdentidad.Clear()

        End Try
    End Sub

    'Guardar Permiso
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim permisos As Integer
        Dim conexion As String
        conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("insert into Permisos values('" & Id_Identidad.Text & "', '" & Tipo_de_PermisoTextBox.Text & "','" & Fecha_de_PermisoDateTimePicker.Value & "','" & DesccripcionTextBox.Text & "','" & permisos.ToString & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Permiso Guardado")
        Abrir()
        DataPermisos(DGPermisos)

    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

End Class
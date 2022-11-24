Imports System.Runtime.InteropServices
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class Registro_de_Personal
    Public conexion As SqlConnection
    Public consulta As SqlCommand
    Public datos As DataSet

    Private Sub Registro_de_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bloquear()
        BuscarCuenta()
        Abrir()
        DataEmpleados(dgEmpleados)

    End Sub
    Sub BuscarCuenta()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    'Bloquear los Textbox'
    Private Sub Bloquear()
        Id_IdentidadTextBox.Enabled = False
        NombresTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        ApellidosTextBox.Enabled = False
        CbxSexo.Enabled = False
        DireccionTextBox.Enabled = False
        CorreoTextBox.Enabled = False
        Fecha_de_IngresoDateTimePicker.Enabled = False
        Cargo_NominalTextBox.Enabled = False
        Cargo_FuncionalTextBox.Enabled = False
        Modalidad_de_ContrataciónTextBox.Enabled = False
    End Sub
    'Desbloquear los TextBox'
    Private Sub Desblooquear()
        Id_IdentidadTextBox.Enabled = True
        NombresTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        ApellidosTextBox.Enabled = True
        CbxSexo.Enabled = True
        DireccionTextBox.Enabled = True
        CorreoTextBox.Enabled = True
        Fecha_de_IngresoDateTimePicker.Enabled = True
        Cargo_NominalTextBox.Enabled = True
        Cargo_FuncionalTextBox.Enabled = True
        Modalidad_de_ContrataciónTextBox.Enabled = True
    End Sub

    Private Sub AlBuscarBloquear()
        NombresTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        ApellidosTextBox.Enabled = False
        CbxSexo.Enabled = False
        DireccionTextBox.Enabled = False
        CorreoTextBox.Enabled = False
        Fecha_de_IngresoDateTimePicker.Enabled = False
        Cargo_FuncionalTextBox.Enabled = False
        Cargo_NominalTextBox.Enabled = False
        Modalidad_de_ContrataciónTextBox.Enabled = False
    End Sub

    Private Sub AlBuscarLimpiar()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        CbxSexo.Text = ""
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        Fecha_de_IngresoDateTimePicker.CustomFormat = " "
        Cargo_FuncionalTextBox.Clear()
        Cargo_NominalTextBox.Clear()
        Modalidad_de_ContrataciónTextBox.Clear()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Guardad registros
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim vacaciones As Integer

        If chkbOrdinaria.Checked = True Then
            vacaciones = "1"
        End If
        If chkbProfilactica.Checked = True Then
            vacaciones = "2"
        End If
        If chkbAmbas.Checked = True Then
            vacaciones = "3"
        End If

        If chkbOrdinaria.Checked = False And chkbProfilactica.Checked = False And chkbAmbas.Checked = False Then
            MsgBox("No selecciono ninguna opcion del tipo de Vacaciones", MsgBoxStyle.Critical)
            chkbOrdinaria.Select()
        Else
            Dim conexion As String
            conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("insert into Registro_de_Empleados values('" & Id_IdentidadTextBox.Text & "','" & NombresTextBox.Text & "','" & ApellidosTextBox.Text & "' , '" & CbxSexo.Text & "','" & TelefonoTextBox.Text & "', '" & DireccionTextBox.Text & "', '" & CorreoTextBox.Text & "', '" & Fecha_de_IngresoDateTimePicker.Value & "' , '" & Cargo_NominalTextBox.Text & "', '" & Cargo_FuncionalTextBox.Text & "','" & Modalidad_de_ContrataciónTextBox.Text & "', '" & vacaciones.ToString & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Registro Guardado")
            Abrir()
            DataEmpleados(dgEmpleados)
        End If
    End Sub


    'Nuevo Registro'
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Desblooquear()
        Id_IdentidadTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        Cargo_FuncionalTextBox.Clear()
        Cargo_NominalTextBox.Clear()
        Modalidad_de_ContrataciónTextBox.Clear()
    End Sub


    'Buscar un Registró

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Bloquear()
        AlBuscarLimpiar()
        AlBuscarBloquear()
        Try

            If Id_IdentidadTextBox.Text <> "" And Id_IdentidadTextBox.Text <> 0 Then
                consulta = New SqlCommand("select Id_Identidad, Nombres, Apellidos, Sexo, Telefono, Direccion, Correo, Fecha_de_Ingreso, Cargo_Nominal, Cargo_Funcional, Modalidad_de_Contratación, Tipo from Registro_de_Empleados inner join Tipo_Vacaciones on Registro_de_Empleados.Id_Tipo_Vacacion = Tipo_Vacaciones.Id_Tipo_Vacacion where Id_Identidad='" & Id_IdentidadTextBox.Text & "'", conexion)
                adaptador = New SqlDataAdapter(consulta)
                datos = New DataSet
                adaptador.Fill(datos, "Registro_de_Empleados")
                dgEmpleados.DataSource = datos

                Dim resultado As Boolean = False
                respuesta = consulta.ExecuteReader
                If respuesta.Read Then
                    resultado = True
                    dgEmpleados.DataMember = "Registro_de_Empleados"
                    respuesta.Close()

                Else
                    MsgBox("Identidad no encontrada", MsgBoxStyle.Critical)
                    Id_IdentidadTextBox.SelectAll()
                    respuesta.Close()
                End If

            Else
                MsgBox("Ingrese un número de identidad", MsgBoxStyle.Critical)
                Id_IdentidadTextBox.Focus()
                Id_IdentidadTextBox.Clear()
            End If
        Catch ex As Exception
            MsgBox("Ingrese un valor correcto", MsgBoxStyle.Critical)
            Id_IdentidadTextBox.Clear()

        End Try
    End Sub

    'E;iminar un Registro' 
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Bloquear()
        Dim conexion As String
        conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Dim comando As New SqlCommand("delete from Registro_de_Empleados where Id_Identidad='" & Id_IdentidadTextBox.Text & "'", cn)
        comando.ExecuteNonQuery()
        MsgBox("Registro Eliminado")
        cn.Close()
        DataEmpleados(dgEmpleados)

    End Sub

    'Mostar informacion de DTG en los texbox
    Private Sub dgEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellContentClick

        Id_IdentidadTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(0).Value.ToString
        NombresTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(1).Value.ToString

        ApellidosTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(2).Value.ToString
        CbxSexo.Text = dgEmpleados.CurrentRow.Cells.Item(3).Value.ToString
        TelefonoTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(4).Value.ToString
        DireccionTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(5).Value.ToString
        CorreoTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(6).Value.ToString
        'Fecha_de_IngresoDateTimePicker.Text = dgEmpleados.CurrentRow.Cells.Item(8).Value.ToString
        Cargo_NominalTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(8).Value.ToString
        Cargo_FuncionalTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(9).Value.ToString
        Modalidad_de_ContrataciónTextBox.Text = dgEmpleados.CurrentRow.Cells.Item(10).Value.ToString
        'chkbOrdinaria.Text = dgEmpleados.CurrentRow.Cells.Item(12).Value.ToString
        'chkbProfilactica.Text = dgEmpleados.CurrentRow.Cells.Item(1).Value.ToString
        'chkbAmbas.Text = dgEmpleados.CurrentRow.Cells.Item(12).Value.ToString
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Desblooquear()
        Abrir()
        Dim conexion As String
        conexion = "Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("update Registro_de_Empleados set Id_Identidad ='" & Id_IdentidadTextBox.Text & "',Nombres='" & NombresTextBox.Text & "', Apellidos='" & ApellidosTextBox.Text & "', Sexo='" & CbxSexo.Text & "', Telefono='" & TelefonoTextBox.Text & "', Direccion='" & DireccionTextBox.Text & "', Correo='" & CorreoTextBox.Text & "', Fecha_de_Ingreso='" & Fecha_de_IngresoDateTimePicker.Text & "', Cargo_Nominal='" & Cargo_NominalTextBox.Text & "', Cargo_Funcional='" & Cargo_FuncionalTextBox.Text & "', Modalidad_de_Contratación='" & Modalidad_de_ContrataciónTextBox.Text & "', from Registro_de_Empleados='", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Registro Actualizado")
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Close()
    End Sub


End Class






Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Registrar_Usuarios
    Public conexion As SqlConnection
    Sub BuscarCuenta()
        Try
            Conexion = New SqlConnection("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            Conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub
    'Funciones
    Private Sub Bloquear()
        Correo_ElectronicoTextBox.Enabled = False
        Nombre_De_UsuarioTextBox.Enabled = False
        ContraseñaTextBox.Enabled = False
        ComparadorTextBox.Enabled = False
    End Sub
    Private Sub Desbloquear()
        Correo_ElectronicoTextBox.Enabled = True
        Nombre_De_UsuarioTextBox.Enabled = True
        ContraseñaTextBox.Enabled = True
        ComparadorTextBox.Enabled = True
    End Sub

    Private Sub Limpiar()
        Nombre_De_UsuarioTextBox.Clear()
        Correo_ElectronicoTextBox.Clear()
        ContraseñaTextBox.Clear()
        ComparadorTextBox.Clear()
    End Sub
    'Cambiar el texto de los texbox a ***
    Private Sub Registrar_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bloquear()
        DataUsuarios(DGUsuarios)
        Abrir()
        BuscarCuenta()
        ContraseñaTextBox.PasswordChar = "*"
        ComparadorTextBox.PasswordChar = "*"

    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Guardar un usuario

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim conexion As String

        conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        If ContraseñaTextBox.Text = ComparadorTextBox.Text Then
            Dim adaptador As New SqlCommand("insert into Registrar_Usuarios values('" & Correo_ElectronicoTextBox.Text & "','" & Nombre_De_UsuarioTextBox.Text & "' , '" & ContraseñaTextBox.Text & "', '" & ComparadorTextBox.Text & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Nuevo Usuario Registrado")
            Abrir()
        Else
            MsgBox("La Contraseña ingresada no es igual", MsgBoxStyle.Information)
            ContraseñaTextBox.Focus()
            Abrir()
            DataUsuarios(DGUsuarios)


        End If

      
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Desbloquear()
        Limpiar()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Bloquear()
        Dim conexion As String
        conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()
        Dim comando As New SqlCommand("delete from Registrar_Usuarios where Nombre_de_Usuario='" & Nombre_De_UsuarioTextBox.Text & "'", cn)
        comando.ExecuteNonQuery()
        MsgBox("Registro Eliminado")
        cn.Close()
        DataUsuarios(DGUsuarios)
    End Sub

    Private Sub DGUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentClick
        Correo_ElectronicoTextBox.Text = DGUsuarios.CurrentRow.Cells.Item(0).Value.ToString
        Nombre_De_UsuarioTextBox.Text = DGUsuarios.CurrentRow.Cells.Item(1).Value.ToString
        ContraseñaTextBox.Text = DGUsuarios.CurrentRow.Cells.Item(2).Value.ToString
        ComparadorTextBox.Text = DGUsuarios.CurrentRow.Cells.Item(2).Value.ToString
    End Sub

    'Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
    '    Desbloquear()
    '    Dim conexion As String
    '    conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
    '    Dim cn As New SqlConnection
    '    cn.ConnectionString = conexion
    '    If ContraseñaTextBox.Text = ComparadorTextBox.Text Then
    '        Dim adaptador As New SqlCommand("edit into Registrar_Usuarios values('" & Correo_ElectronicoTextBox.Text & "','" & Nombre_De_UsuarioTextBox.Text & "' , '" & ContraseñaTextBox.Text & "', '" & ComparadorTextBox.Text & "')", cn)
    '        cn.Open()
    '        adaptador.ExecuteNonQuery()
    '        MsgBox("Nuevo Usuario Registrado")
    '        Abrir()

    '    Else
    '        MsgBox("La Contraseña ingresada no es igual", MsgBoxStyle.Information)
    '        ContraseñaTextBox.Focus()
    '        DataUsuarios(DGUsuarios)
    '    End If
    'End Sub
End Class
'Limpiar()
'Dim conexion As String
'conexion = ("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
'Dim cn As New SqlConnection
'cn.ConnectionString = conexion
'cn.Open()
'Dim comando As New SqlCommand("Update Registrar_Usuarios set Correo_Electronico='" & Correo_ElectronicoTextBox.Text & "', Nombre_de_Usuario ='" & Nombre_De_UsuarioTextBox.Text & "', Contrasena='" & ContraseñaTextBox.Text & "',Comparador='" & ComparadorTextBox.Text & "' where Correo_Electronico='" & Correo_ElectronicoTextBox.Text & "'", cn)
'If ContraseñaTextBox.Text = ComparadorTextBox.Text Then
'MsgBox("Usuario Editado")
'Else
'MsgBox("Ingrese Datos Correctos")
'End If
'comando.ExecuteNonQuery()
'DataUsuarios(DgUsuarios)
'cn.Close()
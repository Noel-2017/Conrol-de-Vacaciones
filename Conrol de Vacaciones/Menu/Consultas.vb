Imports System.Data.SqlClient
Imports System.Data.OleDb

Module Consultas
    Public conexion As SqlConnection
    Public adaptadorEmpleado As SqlDataAdapter
    Sub AbrirEmpleado()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Sub TablaEmpleado(ByVal Combo As ComboBox)
        adaptadorEmpleado = New SqlDataAdapter("Select * from Registro_de_Empleados", conexion)
        Dim datase As New DataSet
        adaptadorEmpleado.Fill(datase)
        Combo.DataSource = datase.Tables(0)
    End Sub






End Module

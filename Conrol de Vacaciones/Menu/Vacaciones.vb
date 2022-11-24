Imports System.Data.SqlClient
Public Class Vacaciones

    Public Dias_de_Vacaciones
    Dim fecha As DateTime
    Dim dias, diasdisponibles, diasvacaciones, diassolicitados As Integer

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If btnNombre.Visible = False And btnIdentidad.Visible = False And txtBuscar.Visible = False Then

            btnNombre.Visible = True
            btnIdentidad.Visible = True
            txtBuscar.Visible = True
        Else
            btnNombre.Visible = False
            btnIdentidad.Visible = False
            txtBuscar.Visible = False
        End If
    End Sub

    Private Sub Fecha_InicioDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Fecha_InicioDateTimePicker.ValueChanged

        Dim Fechainicio As Date = Fecha_InicioDateTimePicker.Value.ToShortDateString
        Dim sabado, domingofin, sabadofin As Integer
        sabado = 1 + Cantidad_de_Dias_SolicitadosTXT.Text
        sabadofin = 2 + Cantidad_de_Dias_SolicitadosTXT.Text
        domingofin = 1 + Cantidad_de_Dias_SolicitadosTXT.Text

        If (Weekday(Fechainicio) = vbSunday) Then
            Fecha_InicioDateTimePicker.Value = Fechainicio.AddDays(1)
            Fecha_FinalDateTimePicker.Value = Fechainicio.AddDays(Cantidad_de_Dias_SolicitadosTXT.Text)
        ElseIf (Weekday(Fechainicio) = vbSaturday) Then
            Fecha_InicioDateTimePicker.Value = Fechainicio.AddDays(2)
            Fecha_FinalDateTimePicker.Value = Fechainicio.AddDays(sabado)
        ElseIf Cantidad_de_Dias_SolicitadosTXT.Text = 1 Then
            Fecha_FinalDateTimePicker.Value = Fechainicio
        Else
            Fecha_FinalDateTimePicker.Value = Fechainicio.AddDays(Cantidad_de_Dias_SolicitadosTXT.Text - 1)
        End If


        If (Weekday(Fecha_FinalDateTimePicker.Value.ToShortDateString) = vbSaturday) Then
            Fecha_FinalDateTimePicker.Value = Fechainicio.AddDays(sabadofin)
        End If
        If (Weekday(Fecha_FinalDateTimePicker.Value.ToShortDateString) = vbSunday) Then
            Fecha_FinalDateTimePicker.Value = Fechainicio.AddDays(domingofin)
        End If
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'Nuevo Registro'
        IdentidadTXT.Clear()
        ApellidosTextBox.Clear()
        NombresTextBox.Text = ""
        Cantidad_de_Dias_SolicitadosTXT.Clear()
        Cantidad_de_Días_DisponiblesTextBox.Clear()
        Cantidad_de_días_de_vacacionesTextBox.Clear()
        Tarjeta_de_AsistenciaTextBox.Clear()
        txtPeriodo_Vacaciones.Clear()
    End Sub

    Private Sub Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirEmpleado()
        Abrir()
        TablaEmpleado(NombresTextBox)
        DataVacaciones(DGvacaciones)
        NombresTextBox.DisplayMember = "Nombres"
        NombresTextBox.ValueMember = "Nombres"
    End Sub

    Private Sub NombresTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombresTextBox.SelectedIndexChanged
        Dim coneccion, tipo_vacacion As String
        coneccion = "Data Source=DESKTOP-1JPQNQC\SQLEXPRESS;Initial Catalog=Control de Vacaciones;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = coneccion
        Dim Query As String
        Query = "Select Id_Identidad, Apellidos, Fecha_de_Ingreso, Id_Tipo_Vacacion from Registro_de_Empleados where Nombres='" & NombresTextBox.Text & "'"
        adaptador = New SqlDataAdapter(Query, coneccion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        For Each row As DataRow In dt.Rows
            IdentidadTXT.Text = row("Id_Identidad").ToString
            ApellidosTextBox.Text = row("Apellidos").ToString
            FechaIngreso.Text = row("Fecha_de_Ingreso")
            tipo_vacacion = row("Id_Tipo_Vacacion").ToString
            If tipo_vacacion = 1 Then
                chkOrdinaria.Checked = True
            ElseIf tipo_vacacion = 2 Then
                chkProfilactica.Checked = True
            ElseIf tipo_vacacion = 3 Then
                chkAmbas.Checked = True
            End If
        Next
        fecha = DateTime.Now
        dias = DateDiff(DateInterval.Year, CDate(FechaIngreso.Text), CDate(fecha))

        If dias >= 1 And dias < 2 Then
            diasvacaciones = 12
            Cantidad_de_días_de_vacacionesTextBox.Text = diasvacaciones
        ElseIf dias >= 2 And dias < 3 Then
            diasvacaciones = 15
            Cantidad_de_días_de_vacacionesTextBox.Text = diasvacaciones
        ElseIf dias >= 3 And dias < 4 Then
            diasvacaciones = 18
            Cantidad_de_días_de_vacacionesTextBox.Text = diasvacaciones
        ElseIf dias >= 4 Then
            diasvacaciones = 30
            Cantidad_de_días_de_vacacionesTextBox.Text = diasvacaciones
        Else
            Cantidad_de_días_de_vacacionesTextBox.Text = 0
        End If
        diassolicitados = Cantidad_de_Dias_SolicitadosTXT.Text
        diasdisponibles = diasvacaciones - diassolicitados
        Cantidad_de_Días_DisponiblesTextBox.Text = diasdisponibles

    End Sub

End Class
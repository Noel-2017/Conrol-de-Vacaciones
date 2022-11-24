Imports System.Runtime.InteropServices 'Libreria para mover el formulario'
Public Class Menu_Principal

    'Mover Formularios'

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessege(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    ' Mover el formulario desde el panel cabecera o si se desea aplicar a otro panel'
    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessege(Me.Handle, &H112&, &HF012, 0)
    End Sub

    'FUNCIONALIDAD DE LOS BOTONES CERAR, MINIMIZAR, MAXIMIZAR Y RESTAURAR'

    Private Sub btncerrar_Click_1(sender As Object, e As EventArgs) Handles Btncerrar.Click
        End
    End Sub
    Private Sub Btnmaximizar_Click_1(sender As Object, e As EventArgs) Handles Btnmaximizar.Click
        Btnmaximizar.Visible = False
        Btnrestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Btnrestaurar_Click(sender As Object, e As EventArgs) Handles Btnrestaurar.Click
        Btnrestaurar.Visible = False
        Btnmaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Ocultar PanelMenu'
    Private Sub Tmocultarmenu_Tick(sender As Object, e As EventArgs) Handles Tmocultarmenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.Tmocultarmenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub Tmmostrarmenu_Tick(sender As Object, e As EventArgs) Handles Tmmostrarmenu.Tick
        If PanelMenu.Width >= 280 Then
            Me.Tmmostrarmenu.Enabled = True
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        If PanelMenu.Width = 280 Then
            Tmocultarmenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            Tmmostrarmenu.Enabled = True
        End If
    End Sub


    'Abrir Formularios dentro del Panel'
    Private Sub AbrirFormenPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        Else
            Dim fh As Form = TryCast(Formhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = FontHeight
            fh.Show()
        End If
    End Sub

    'Abrir Formulario'
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnRegistrarPersonal.Click
        AbrirFormenPanel(New Registro_de_Personal)
    End Sub
    Private Sub BtnAusencias_Click(sender As Object, e As EventArgs) Handles BtnAusencias.Click
        AbrirFormenPanel(New Permisos)
    End Sub



    Private Sub BtnVacaciones_Click(sender As Object, e As EventArgs) Handles BtnVacaciones.Click
        AbrirFormenPanel(New Vacaciones)
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        AbrirFormenPanel(New Registrar_Usuarios)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim Msg, Style, Title, Help, Ctxt, Response
        Msg = "Seguro que desea salir del sistema ?"
        Style = vbYesNo Or vbExclamation Or vbDefaultButton2
        Title = "SALIR DEL SISTEMA DE VACACIONES"
        Help = "DEMO.HLP"
        Ctxt = 1000

        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' 
            End
        End If
    End Sub
End Class
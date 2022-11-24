Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class Login
    'Mover Formularios'

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contraseña.PasswordChar.ToString()
        Abrir()
        AcceptButton = IconButton2
    End Sub

    Private Sub Usuario_MouseEnter_1(sender As Object, e As EventArgs) Handles Usuario.MouseEnter
        If (Usuario.Text = "USUARIO") Then
            Usuario.Text = ""
            Usuario.ForeColor = Color.White
        End If
    End Sub

    Private Sub Usuario_MouseLeave_1(sender As Object, e As EventArgs) Handles Usuario.MouseLeave
        If (Usuario.Text = "") Then
            Usuario.Text = "USUARIO"
            Usuario.ForeColor = Color.White
        End If
    End Sub

    Private Sub Contraseña_MouseEnter_1(sender As Object, e As EventArgs) Handles Contraseña.MouseEnter
        If (Contraseña.Text = "CONTRASEÑA") Then
            Contraseña.Text = ""
            Contraseña.ForeColor = Color.White
            Contraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Contraseña_MouseLeave_1(sender As Object, e As EventArgs) Handles Contraseña.MouseLeave
        If (Contraseña.Text = "") Then
            Contraseña.Text = "CONTRASEÑA"
            Contraseña.ForeColor = Color.White
            Contraseña.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub IconButton2_Click_1(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try

            Dim contra As String = ContrasenaUsuario(Usuario.Text)
            If contra.Equals(Contraseña.Text) = True Then
                Menu_Principal.Show()
                Me.Hide()
            ElseIf MsgBox("Contraseña Invalida", MsgBoxStyle.Critical) Then
                Contraseña.Clear()
                Contraseña.Focus()
            Else MsgBox("El Usuario " + Usuario.Text + " no se encuentra ", MsgBoxStyle.Critical)
                Usuario.Focus()
                Usuario.Select()
                Usuario.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        End
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Registrar_Usuarios.Show()
    End Sub

End Class
Imports System.Windows.Forms

Public Class Login

    Public Property Usuario() As String
        Get
            Return txtUsuario.Text
        End Get
        Set(value As String)
            txtUsuario.Text = value
        End Set
    End Property

    Public Property Contraseña() As String
        Get
            Return txtContraseña.Text
        End Get
        Set(value As String)
            txtContraseña.Text = value
        End Set
    End Property

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuarioIngresado As String = txtUsuario.Text
        Dim contraseñaIngresada As String = txtContraseña.Text

        If EsCredencialValida(usuarioIngresado, contraseñaIngresada) Then
            MessageBox.Show("Inicio de sesión exitoso.")
        Else
            MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.")
        End If
    End Sub

    Private Function EsCredencialValida(usuario As String, contraseña As String) As Boolean
        Return usuario = "admin" AndAlso contraseña = "admin"
    End Function
End Class

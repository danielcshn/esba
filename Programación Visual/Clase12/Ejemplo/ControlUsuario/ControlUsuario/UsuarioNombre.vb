Public Class UsuarioNombre

    Property primerNombreText() As String
        Get
            Return primerNombre.Text
        End Get
        Set(ByVal value As String)
            primerNombre.Text = value
        End Set
    End Property
    Property segundoNombreText() As String
        Get
            Return segundoNombre.Text
        End Get
        Set(ByVal value As String)
            segundoNombre.Text = value
        End Set
    End Property
    Property apellidoText() As String
        Get
            Return apellido.Text
        End Get
        Set(ByVal value As String)
            apellido.Text = value
        End Set
    End Property

    ReadOnly Property Apellido_NombresText() As String
        Get
            Return Apellido_Nombres.Text
        End Get
    End Property

    Private Sub primerNombre_TextChanged(sender As Object, e As EventArgs) Handles primerNombre.TextChanged, segundoNombre.TextChanged, apellido.TextChanged
        ' Muestra el contenido de las cajas de textos en la etiqueta.
        Apellido_Nombres.Text = primerNombre.Text & " " & segundoNombre.Text & " " & apellido.Text
    End Sub


End Class

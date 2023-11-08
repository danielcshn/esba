Public Class UsuarioNombre

    Private ListaMostrarEstilo As Mostrar
    Property MostrarEstilo() As Mostrar
        Get
            Return ListaMostrarEstilo
        End Get
        Set(ByVal valor As Mostrar)
            ListaMostrarEstilo = valor
        End Set
    End Property

    Public Enum Mostrar
        primerNombresegundoNombreapellido
        primeraNombreapellido
        apellidoprimerNombresegundoNombre
        apellidoprimerNombre
    End Enum

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
        ' Apellido_Nombres.Text = primerNombre.Text & " " & segundoNombre.Text & " " & apellido.Text

        Select Case ListaMostrarEstilo
            Case Mostrar.primeraNombreapellido
                Apellido_Nombres.Text = primerNombre.Text & " " &
               apellido.Text
            Case Mostrar.primerNombresegundoNombreapellido
                Apellido_Nombres.Text = primerNombre.Text & " " &
               segundoNombre.Text & " " & apellido.Text
            Case Mostrar.apellidoprimerNombre
                Apellido_Nombres.Text = apellido.Text & ", " &
               primerNombre.Text
            Case Mostrar.apellidoprimerNombresegundoNombre
                Apellido_Nombres.Text = apellido.Text & ", " &
               primerNombre.Text & " " & segundoNombre.Text
        End Select

    End Sub


End Class

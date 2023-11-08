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

    Private text1 As String = "Apellido"

    Property Label1Text() As String
        Get
            Return text1
        End Get
        Set(ByVal value As String)
            text1 = value
            Label1.Text = text1
        End Set
    End Property

    Private text2 As String = "Primer Nombre"

    Property Label2Text() As String
        Get
            Return text2
        End Get
        Set(ByVal value As String)
            text2 = value
            Label2.Text = text2
        End Set
    End Property

    Private text3 As String = "Segundo Nombre"

    Property Label3Text() As String
        Get
            Return text3
        End Get
        Set(ByVal value As String)
            text3 = value
            Label3.Text = text3
        End Set
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

    Private Sub UsuarioNombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = Label1Text
        Me.Label2.Text = Label2Text
        Me.Label3.Text = Label3Text
    End Sub

End Class

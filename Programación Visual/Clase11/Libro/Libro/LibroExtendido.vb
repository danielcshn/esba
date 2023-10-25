Public Class LibroExtendido
    Inherits Libro ' Hereda de la clase base Libro

    Private _comentario As String

    Public Sub New(ByVal titulo As String, ByVal autor As String, ByVal isbn As String, ByVal paginas As Integer, ByVal edicion As String, ByVal editorial As String, ByVal ciudad As String, ByVal pais As String, ByVal fechaEdicion As DateTime, ByVal comentario As String)
        ' Llama al constructor de la clase base para inicializar los atributos heredados
        MyBase.New(titulo, autor, isbn, paginas, edicion, editorial, ciudad, pais, fechaEdicion)

        ' Inicializa el atributo adicional de la clase derivada
        _comentario = comentario
    End Sub

    Public Sub AgregarComentario(comentario As String)
        _comentario = comentario
    End Sub

    Public Sub MostrarInformacionExtendida()
        ' Llama al método de la clase base para mostrar la información básica del libro
        LeerInformacion()

        ' Muestra el comentario adicional
        Console.WriteLine("Comentario: " & _comentario)
    End Sub
End Class

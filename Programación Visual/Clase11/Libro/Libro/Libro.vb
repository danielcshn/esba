Public Class Libro

    Private _titulo As String
    Private _autor As String
    Private _isbn As String
    Private _paginas As Integer
    Private _edicion As String
    Private _editorial As String
    Private _ciudad As String
    Private _pais As String
    Private _fechaEdicion As DateTime

    Public Sub New(ByVal titulo As String, ByVal autor As String, ByVal isbn As String, ByVal paginas As Integer, ByVal edicion As String, ByVal editorial As String, ByVal ciudad As String, ByVal pais As String, ByVal fechaEdicion As DateTime)
        _titulo = titulo
        _autor = autor
        _isbn = isbn
        _paginas = paginas
        _edicion = edicion
        _editorial = editorial
        _ciudad = ciudad
        _pais = pais
        _fechaEdicion = fechaEdicion
    End Sub

    Public Sub LeerInformacion()
        Console.WriteLine("Título: " & _titulo)
        Console.WriteLine(_edicion & " edición")
        Console.WriteLine("Autor: " & _autor)
        Console.WriteLine("ISBN: " & _isbn)
        Console.WriteLine(_editorial & ", " & _ciudad & " (" & _pais & ") " & _fechaEdicion.ToString("dddd d 'de' MMMM 'de' yyyy"))
        Console.WriteLine(_paginas & " páginas")
    End Sub

End Class

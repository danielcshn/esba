Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ejemplo de cómo utilizar la clase Libro
        Dim miLibro As New LibroExtendido("Introduction to Programming", "Liang, Y. Daniel", "0-13-031997-X", 784, "3a", "Prentice-Hall", "Nueva Jersey", "USA", New DateTime(2001, 11, 16), "Un libro muy informativo y útil.")
        miLibro.LeerInformacion()

        ' Ejemplo de cómo utilizar la clase LibroExtendido
        miLibro.MostrarInformacionExtendida()
    End Sub

End Class

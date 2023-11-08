Public Class UsuarioNombre
    Private Sub primerNombre_TextChanged(sender As Object, e As EventArgs) Handles primerNombre.TextChanged, segundoNombre.TextChanged, apellido.TextChanged
        ' Muestra el contenido de las cajas de textos en la etiqueta.
        Apellido_Nombres.Text = primerNombre.Text & " " & segundoNombre.Text & " " & apellido.Text
    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim B As Integer = -10

        If B >= 0 Then
            Console.WriteLine("El valor de B es positivo o cero.")
        Else
            Console.WriteLine("El valor de B es negativo.")
        End If

    End Sub
End Class

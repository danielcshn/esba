Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim A As Integer = 15

        If A Mod 2 = 0 Then
            Console.WriteLine("El valor de A (" & A & ") es par.")
        Else
            Console.WriteLine("El valor de A (" & A & ") es impar.")
        End If

    End Sub
End Class

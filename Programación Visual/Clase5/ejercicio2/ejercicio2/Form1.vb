Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim var1 As Integer = 10
        Dim var2 As Integer = 20

        If var1 > var2 Then
            Console.WriteLine("El primer número (" & var1 & ") es mayor que el segundo número (" & var2 & ").")
        ElseIf var1 < var2 Then
            Console.WriteLine("El primer número (" & var1 & ") es menor que el segundo número (" & var2 & ").")
        Else
            Console.WriteLine("Ambos números son iguales.")
        End If

    End Sub
End Class

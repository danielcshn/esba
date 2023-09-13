Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim N As Integer = 10
        Console.WriteLine("N: " & N)
        N += 77
        Console.WriteLine("Resultado es +77: " & N)
        N -= 3
        Console.WriteLine("Resultado es -3: " & N)
        N *= 2
        Console.WriteLine("Resultado es X2: " & N)

    End Sub
End Class

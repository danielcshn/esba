Public Class Form1

    ' Crear una cafetera con una capacidad máxima de 1000 ml
    Public Dim miCafetera As New Cafetera(1000)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        miCafetera.LlenarCafetera()
        Console.WriteLine("Cantidad actual en la cafetera: " & miCafetera.ObtenerCantidadActual())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        miCafetera.VaciarCafetera()
        Console.WriteLine("Cantidad actual en la cafetera: " & miCafetera.ObtenerCantidadActual())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        miCafetera.AgregarCafe(300)
        Console.WriteLine("Cantidad actual en la cafetera: " & miCafetera.ObtenerCantidadActual())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        miCafetera.ServirTaza(250)
        Console.WriteLine("Cantidad actual en la cafetera: " & miCafetera.ObtenerCantidadActual())
    End Sub
End Class

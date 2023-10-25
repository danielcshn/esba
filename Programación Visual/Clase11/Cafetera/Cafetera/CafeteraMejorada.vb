Public Class CafeteraMejorada
    Inherits Cafetera

    Public Sub New(capacidadMaxima As Integer)
        MyBase.New(capacidadMaxima)
    End Sub

    ' Nuevo método para calentar el café
    Public Sub CalentarCafe()
        If ObtenerCantidadActual() > 0 Then
            Console.WriteLine("El café se ha calentado.")
        Else
            Console.WriteLine("No hay café para calentar.")
        End If
    End Sub
End Class

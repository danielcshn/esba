Public Class Cafetera
    Private capacidadMaxima As Integer
    Private cantidadActual As Integer

    ' Constructor
    Public Sub New(capacidadMaxima As Integer)
        Me.capacidadMaxima = capacidadMaxima
        Me.cantidadActual = 0
    End Sub

    ' Método para llenar la cafetera
    Public Sub LlenarCafetera()
        cantidadActual = capacidadMaxima
    End Sub

    ' Método para servir una taza
    Public Sub ServirTaza(cantidad As Integer)
        If cantidadActual >= cantidad Then
            cantidadActual -= cantidad
            Console.WriteLine("Se ha servido una taza de " & cantidad & " ml de café.")
        Else
            Console.WriteLine("No hay suficiente café para llenar la taza. Se ha servido lo que quedaba.")
            cantidadActual = 0
        End If
    End Sub

    ' Método para vaciar la cafetera
    Public Sub VaciarCafetera()
        cantidadActual = 0
        Console.WriteLine("La cafetera ha sido vaciada.")
    End Sub

    ' Método para agregar café a la cafetera
    Public Sub AgregarCafe(cantidad As Integer)
        If cantidadActual + cantidad <= capacidadMaxima Then
            cantidadActual += cantidad
            Console.WriteLine("Se ha agregado " & cantidad & " ml de café a la cafetera.")
        Else
            cantidadActual = capacidadMaxima
            Console.WriteLine("La cafetera está llena. No se puede agregar más café.")
        End If
    End Sub

    ' Método para obtener la cantidad actual de café en la cafetera
    Public Function ObtenerCantidadActual() As Integer
        Return cantidadActual
    End Function

    ' Método para obtener la capacidad máxima de la cafetera
    Public Function ObtenerCapacidadMaxima() As Integer
        Return capacidadMaxima
    End Function
End Class

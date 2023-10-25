Public Class Jugadores

    Inherits Empleado
    Private numeroValor As Integer
    Private posicionValor As String

    Public Property Numero() As Integer
        Get
            Numero = numeroValor
        End Get
        Set(ByVal valor As Integer)
            numeroValor = valor
        End Set
    End Property

    Public Property Posicion() As String
        Get
            Posicion = posicionValor
        End Get
        Set(ByVal Valor As String)
            posicionValor = Valor
        End Set
    End Property

    Public Overloads Function apellido_nombre() As String
        If (nombre <> "") And (apellido <> "") Then
            apellido_nombre = nombre & " " & apellido
        Else
            MsgBox("Debe cargar nombre y apellido del empleado")
            apellido_nombre = ""
        End If
    End Function

End Class

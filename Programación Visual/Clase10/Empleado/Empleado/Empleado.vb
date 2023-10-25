Public Class Empleado

    Private nombreEmpleado As String
    Private apellidoEmpleado As String
    Public activo As Boolean

    Public Property nombre() As String
        Get
            nombre = nombreEmpleado
        End Get
        Set(nom As String)
            nombreEmpleado = nom
        End Set
    End Property

    Public Property apellido() As String
        Get
            Return apellidoEmpleado
        End Get
        Set(ByVal apell As String)
            apellidoEmpleado = apell
        End Set
    End Property

    Private numeroLegajo As Integer

    ReadOnly Property legajo() As Integer
        Get
            legajo = numeroLegajo
        End Get
    End Property

    Private valorContraseña As String
    WriteOnly Property contraseña() As String
        Set(ByVal value As String)
            valorContraseña = value
        End Set
    End Property

    Private añoIngresoEmpleado As Integer

    WriteOnly Property añoIngreso() As Integer
        Set(ByVal año As Integer)
            añoIngresoEmpleado = año
        End Set
    End Property

    ReadOnly Property antiguedad() As String
        Get
            antiguedad = CalcAntiguedad(añoIngresoEmpleado)
        End Get
    End Property

    Public Function apellido_nombre() As String
        If (nombreEmpleado <> "") And (apellidoEmpleado <> "") Then
            apellido_nombre = nombreEmpleado & " " & apellidoEmpleado
        Else
            MsgBox("Debe cargar nombre y apellido del empleado")
            apellido_nombre = ""
        End If
    End Function

    Private Function CalcAntiguedad(ByVal año As Integer) As Integer
        CalcAntiguedad = My.Computer.Clock.LocalTime.Year - año
    End Function

    Public Function inicialApellido() As String
        inicialApellido = Left$(apellidoEmpleado, 1)
    End Function

    Public Function inicialApellido(ByVal punto As Boolean) As String
        inicialApellido = Left$(apellidoEmpleado, 1) & "."
    End Function

End Class

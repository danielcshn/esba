Public Class Form2

    Dim jugador1 As New Jugadores
    Dim jugador2 As New Jugadores

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With jugador1
            .nombre = "Diego"
            .apellido = "Maradona"
            .Numero = 10
            .Posicion = "mediocampista ofensivo"
        End With
        With jugador2
            .nombre = "Lionel"
            .apellido = "Messi"
            .Numero = 9
            .Posicion = "Delantero"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("El " & jugador1.Posicion & " " & jugador1.nombre & ", #" & CStr(jugador1.Numero) & " esta en la cancha.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("El " & jugador2.Posicion & " " & jugador2.nombre & ", #" & CStr(jugador2.Numero) & " esta en banco.")
    End Sub
End Class
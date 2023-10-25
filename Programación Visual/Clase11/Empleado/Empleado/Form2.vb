Public Class Form2

    Dim jugador1 As New Jugadores
    Dim jugador2 As New Jugadores
    Dim jugador3 As New Jugadores
    Dim jugador4 As New Jugadores
    Dim equipoFutbol As New Collection

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

        With jugador3
            .nombre = "Sergio"
            .apellido = "Goycochea"
            .Numero = 1
            .Posicion = "Arquero"
        End With
        With jugador4
            .nombre = "Oscar"
            .apellido = "Ruggeri"
            .Numero = 6
            .Posicion = "Defensor"
        End With

        equipoFutbol.Add(jugador1, jugador1.Posicion)
        equipoFutbol.Add(jugador2, jugador2.Posicion)
        equipoFutbol.Add(jugador3, jugador3.Posicion)
        equipoFutbol.Add(jugador4, jugador4.Posicion)

        Dim jugador As Jugadores
        For Each jugador In equipoFutbol
            ComboBox1.Items.Add(jugador.Posicion)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("El " & jugador1.Posicion & " " & jugador1.nombre & ", #" & CStr(jugador1.Numero) & " esta en la cancha.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("El " & jugador2.Posicion & " " & jugador2.nombre & ", #" & CStr(jugador2.Numero) & " esta en banco.")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleccionarJugador As Jugadores
        seleccionarJugador = equipoFutbol(ComboBox1.SelectedItem)
        MsgBox("Jugando como " & ComboBox1.SelectedItem & " está " & seleccionarJugador.apellido_nombre & "!")
    End Sub
End Class
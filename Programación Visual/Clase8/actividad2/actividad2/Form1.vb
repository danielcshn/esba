Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try

            ' Declaración de variables
            Dim nombre As String
            Dim calificaciones(3) As Double
            Dim promedio As Double

            ' Solicitar nombre y apellido del estudiante
            nombre = txtNombre.Text

            ' Ccuatro calificaciones
            calificaciones(0) = Convert.ToDouble(txtNota1.Text)
            calificaciones(1) = Convert.ToDouble(txtNota2.Text)
            calificaciones(2) = Convert.ToDouble(txtNota3.Text)
            calificaciones(3) = Convert.ToDouble(txtNota4.Text)

            ' Calcular el promedio
            promedio = (calificaciones(0) + calificaciones(1) + calificaciones(2) + calificaciones(3)) / 4.0

            ' Determinar la puntuación
            Dim puntuacion As String
            If promedio >= 19 AndAlso promedio <= 20 Then
                puntuacion = "A"
            ElseIf promedio >= 16 AndAlso promedio <= 18 Then
                puntuacion = "B"
            ElseIf promedio >= 11 AndAlso promedio <= 15 Then
                puntuacion = "C"
            ElseIf promedio >= 6 AndAlso promedio <= 10 Then
                puntuacion = "D"
            Else
                puntuacion = "E"
            End If

            ' Mostrar resultados usando MessageBox
            Dim mensaje As String = $"Nombre del estudiante: {nombre}" & vbCrLf &
                                    $"Promedio de calificaciones: {promedio}" & vbCrLf &
                                    $"Puntuación: {puntuacion}"
            MessageBox.Show(mensaje, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

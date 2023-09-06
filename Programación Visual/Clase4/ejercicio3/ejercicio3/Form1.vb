' Programa que permite ingresar el nombre de un alumno y tres notas, deberá mostrar el
' promedio.Si este aprobado, su promedio se muestra en azul, de lo contrario en rojo. 

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text
        Dim nota1 As Integer
        Dim nota2 As Integer
        Dim nota3 As Integer

        If Integer.TryParse(txtNota1.Text, nota1) AndAlso
            Integer.TryParse(txtNota2.Text, nota2) AndAlso
            Integer.TryParse(txtNota3.Text, nota3) Then

            ' Calcular el promedio
            Dim promedio As Double = (nota1 + nota2 + nota3) / 3.0

            ' Cambiar el color del texto según si aprobó o no
            If promedio >= 4.0 Then
                lblResultado.Text = promedio.ToString("F2")
                lblResultado.ForeColor = Color.Blue
            Else
                lblResultado.Text = promedio.ToString("F2")
                lblResultado.ForeColor = Color.Red
            End If
        Else
            MessageBox.Show("Por favor, ingrese notas válidas.")
        End If

    End Sub
End Class

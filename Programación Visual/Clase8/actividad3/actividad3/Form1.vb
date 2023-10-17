Public Class Form1

    ' Declarar variables para la suma y el producto
    Private suma As Integer = 0
    Private producto As Long = 1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try
            ' Reiniciar las variables
            suma = 0
            producto = 1

            ' Calcular la suma y el producto
            For i As Integer = 2 To 100 Step 2
                ' Sumar números pares
                suma += i

                ' Multiplicar los 10 primeros números pares
                If i <= 20 Then
                    producto *= i
                End If
            Next

            ' Mostrar resultados en TextBoxes
            txtSuma.Text = suma.ToString()
            txtPares.Text = producto.ToString()

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPares.Text = ""
        txtSuma.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

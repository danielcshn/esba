Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        ' Verificar si ambos TextBox tienen valores ingresados
        If String.IsNullOrWhiteSpace(txtNum1.Text) Or String.IsNullOrWhiteSpace(txtNum2.Text) Then
            MessageBox.Show("Por favor, ingrese ambos números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convertir los valores de los TextBox a números
        Dim numero1 As Double
        Dim numero2 As Double

        If Not Double.TryParse(txtNum1.Text, numero1) Or Not Double.TryParse(txtNum2.Text, numero2) Then
            MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Comparar los números
        If numero1 > numero2 Then
            MessageBox.Show("El número " & numero1.ToString() & " es mayor que " & numero2.ToString(), "Resultado")
        ElseIf numero1 < numero2 Then
            MessageBox.Show("El número " & numero2.ToString() & " es mayor que " & numero1.ToString(), "Resultado")
        Else
            MessageBox.Show("Ambos números son iguales: " & numero1.ToString(), "Resultado")
        End If
    End Sub
End Class

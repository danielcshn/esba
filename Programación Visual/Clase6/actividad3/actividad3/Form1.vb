Public Class Form1
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim nombre As String = txtNombre.Text
        Dim edad As Integer
        Dim sexo As Char

        ' Verificar el nombre
        If nombre.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("El nombre no debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar la edad
        If Not Integer.TryParse(txtEdad.Text, edad) Then
            MessageBox.Show("La edad debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar el sexo
        sexo = Char.ToUpper(txtSexo.Text.Trim())
        If sexo <> "F"c AndAlso sexo <> "M"c Then
            MessageBox.Show("El sexo debe ser 'F' o 'M'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Mostrar los datos ingresados
        MessageBox.Show("Datos ingresados:" & vbCrLf &
                        "Nombre: " & nombre & vbCrLf &
                        "Edad: " & edad & vbCrLf &
                        "Sexo: " & sexo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

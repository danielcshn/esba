' Programa que permite ingresar el nombre de un cliente y el monto total de su factura y
' calcula y muestra por separado importe e impuesto (19%). La suma del importe y del
' impuesto debe dar el monto de la factura. 

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = txtNombre.Text
        Dim monto As Double

        If Double.TryParse(txtMonto.Text, monto) Then
            ' Calcular el importe (81% del monto total) y el impuesto (19% del monto total)
            Dim importe As Double = monto * 0.81
            Dim impuesto As Double = monto * 0.19
            Dim total As Double = importe + impuesto

            ' Mostrar el importe y el impuesto en los Labels
            lblResultado.Text = "Resultado: " & vbCrLf &
                "Nombre: " & nombre & vbCrLf &
                "Importe: " & importe.ToString("C2") & vbCrLf &
                "Impuesto (19%): " & impuesto.ToString("C2") & vbCrLf &
                "TOTAL: " & total
        Else
            MessageBox.Show("Por favor, ingrese un monto total válido.")
        End If
    End Sub
End Class

Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fecha1 As Date = Date.Parse(txtDate1.Text)
        Dim fecha2 As Date = Date.Parse(txtDate2.Text)

        ' Calcular la diferencia en días
        Dim diferenciaDias As Integer = (fecha2 - fecha1).Days

        ' Calcular la diferencia en semanas
        Dim diferenciaSemanas As Integer = diferenciaDias \ 7

        ' Calcular la diferencia en meses
        Dim diferenciaMeses As Integer = Math.Abs((fecha2.Year - fecha1.Year) * 12 + fecha2.Month - fecha1.Month)

        ' Calcular la diferencia en años
        Dim diferenciaAnios As Integer = Math.Abs(fecha2.Year - fecha1.Year)

        lbResultado.Text = "Diferencia en días: " & diferenciaDias & " días" & vbCrLf &
            "Diferencia en semanas: " & diferenciaSemanas & " semanas" & vbCrLf &
            "Diferencia en meses: " & diferenciaMeses & " meses" & vbCrLf &
            "Diferencia en años: " & diferenciaAnios & " años"

    End Sub
End Class

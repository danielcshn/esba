Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            ' Declaración de variables
            Dim apellidosNombres As String = txtTrabajador.Text
            Dim sueldoBasico As Decimal = Decimal.Parse(txtSueldoBase.Text)
            Dim horasExtras As Integer = Integer.Parse(txtHorasExtras.Text)
            Dim turnoDiurno As Boolean = rbDiurno.Checked
            Dim pagoHoraExtra As Decimal = If(turnoDiurno, 10D, 15D)

            ' Variables para las deducciones
            Dim renta As Decimal = 0
            Dim aportes As Decimal = 0
            Dim contribuciones As Decimal = 0

            ' Aplicar deducciones según CheckBoxes
            If cbRenta.Checked Then
                renta = sueldoBasico * 0.1D
            End If

            If cbAportes.Checked Then
                aportes = sueldoBasico * 0.07D
            End If

            If cbContribuciones.Checked Then
                contribuciones = sueldoBasico * 0.03D
            End If

            ' Calcular ingresos y egresos
            Dim ingresos As Decimal = sueldoBasico + horasExtras * pagoHoraExtra
            Dim egresos As Decimal = renta + aportes + contribuciones

            ' Calcular sueldo neto
            Dim sueldoNeto As Decimal = ingresos - egresos

            ' Mostrar resultados
            txtSueldoNeto.Text = sueldoNeto.ToString("0.00")

            Dim msgResultado As String = "Apellidos y Nombres: " & apellidosNombres & vbCrLf &
                            "Sueldo Básico: $" & sueldoBasico.ToString("0.00") & vbCrLf &
                            "Horas Extras: " & horasExtras & " horas" & vbCrLf &
                            "Turno Diurno: " & If(turnoDiurno, "Sí", "No") & vbCrLf &
                            "Ingresos: $" & ingresos.ToString("0.00") & vbCrLf &
                            "Egresos: $" & egresos.ToString("0.00") & vbCrLf &
                            "Sueldo Neto: $" & sueldoNeto.ToString("0.00")

            MsgBox(msgResultado)


        Catch ex As Exception
            ' Manejo de excepciones generales
            MsgBox("Ocurrió una excepción: " & ex.Message)

        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtHorasExtras.Text = ""
        txtPagoHoras.Text = ""
        txtSueldoBase.Text = ""
        txtSueldoNeto.Text = ""
        txtTrabajador.Text = ""
        cbAportes.Checked = False
        cbContribuciones.Checked = False
        cbRenta.Checked = False
        rbDiurno.Checked = True
    End Sub
End Class

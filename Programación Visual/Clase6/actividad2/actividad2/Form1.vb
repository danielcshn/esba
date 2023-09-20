Public Class Form1

    Dim resultadoFinal As String = ""

    Private Sub btnRepresenta_Click(sender As Object, e As EventArgs) Handles btnRepresenta.Click

        Dim codigoAlumno As String = txtCodigo.Text

        ' Verificar si el código tiene 10 caracteres
        If codigoAlumno.Length = 10 Then
            ' Obtener los componentes del código
            Dim anioMatricula As String = codigoAlumno.Substring(0, 4)
            Dim semestre As Char = codigoAlumno(4)
            Dim especialidad As String = codigoAlumno.Substring(5, 2)
            Dim ciclo As Char = codigoAlumno(7)
            Dim turno As Char = codigoAlumno(8)
            Dim grupo As Char = codigoAlumno(9)

            resultadoFinal = "Año de matrícula: " & anioMatricula & vbCrLf

            If semestre = "1" Then
                resultadoFinal &= "Semestre Académico: 1" & vbCrLf
            ElseIf semestre = "2" Then
                resultadoFinal &= "Semestre Académico: 2" & vbCrLf
            Else
                resultadoFinal &= "Semestre Académico: Error" & vbCrLf
            End If

            Select Case especialidad
                Case "CI"
                    resultadoFinal &= "Especialidad: Computación" & vbCrLf
                Case "CO"
                    resultadoFinal &= "Especialidad: Contabilidad" & vbCrLf
                Case "SE"
                    resultadoFinal &= "Especialidad: Secretariado" & vbCrLf
                Case "ET"
                    resultadoFinal &= "Especialidad: Enfermería" & vbCrLf
                Case Else
                    resultadoFinal &= "Especialidad: Error" & vbCrLf
            End Select

            If Char.IsDigit(ciclo) Then
                resultadoFinal &= "Ciclo: " & ciclo & vbCrLf
            Else
                resultadoFinal &= "Ciclo: Error" & vbCrLf
            End If

            If Char.IsLetter(turno) Then
                resultadoFinal &= "Turno: " & turno & vbCrLf
            Else
                resultadoFinal &= "Turno: Error" & vbCrLf
            End If

            resultadoFinal &= "Grupo: " & grupo & vbCrLf

            lbResultado.Text = resultadoFinal

        Else
            lbResultado.Text = "Error: El código debe tener 10 caracteres."
        End If

    End Sub

End Class

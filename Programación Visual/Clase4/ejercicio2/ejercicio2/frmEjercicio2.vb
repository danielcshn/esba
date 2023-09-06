' Aplicación que permite mostrar el nombre, edad y País de una persona. Se utiliza un control
' Label llamado LblDato y cuatro botones de comandos llamados: BtnNombre, BtnEdad,
' BtnPais y BtnFinalizar.

Public Class frmEjercicio2

    Public nombre As String
    Public edad As String
    Public pais As String

    Private Sub BtnNombre_Click(sender As Object, e As EventArgs) Handles BtnNombre.Click
        nombre = InputBox("Por favor, ingrese su nombre:", "Ingresar Nombre")
    End Sub

    Private Sub BtnEdad_Click(sender As Object, e As EventArgs) Handles BtnEdad.Click
        edad = InputBox("Por favor, ingrese su edad:", "Ingresar Edad")
    End Sub

    Private Sub BtnPais_Click(sender As Object, e As EventArgs) Handles BtnPais.Click
        pais = InputBox("Por favor, ingrese su pais:", "Ingresar Pais")
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        lblDato.Text = "Resultado:" & vbCrLf &
            "Nombre: " & nombre & vbCrLf &
            "Edad: " & edad & vbCrLf &
            "Pais: " & pais
    End Sub
End Class

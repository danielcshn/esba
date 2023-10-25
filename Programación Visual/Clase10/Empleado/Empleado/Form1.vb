Public Class Form1

    Dim Empleado1 As New Empleado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Empleado1
            .nombre = TextBox2.Text
            .apellido = TextBox3.Text
            .añoIngreso = TextBox4.Text
            .activo = CheckBox1.Checked
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(Empleado1.apellido_nombre)

        MsgBox(CStr(Empleado1.antiguedad) & " años ")

        If Empleado1.activo = True Then
            MsgBox(Empleado1.apellido & " esta activo")
        Else
            MsgBox(Empleado1.apellido & " fue dado de baja")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(Empleado1.nombre & Empleado1.inicialApellido(True))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox(Empleado1.nombre & UCase(Empleado1.inicialApellido))
    End Sub
End Class

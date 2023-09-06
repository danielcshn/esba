
' Programa que permite llamar a 3 formularios desde un formulario principal. El formulario
' principal se llamará FrmPrincipal y los otros: FrmPaises, FrmEmpleados y FrmProductos. 

Public Class FrmPrincipal
    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        FrmPaises.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        FrmEmpleados.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmProductos.Show()
    End Sub
End Class

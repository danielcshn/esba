Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Manejar el evento ItemCheck para actualizar el ListBox con elementos seleccionados
        ListBox1.Items.Clear()
        For Each item As Object In CheckedListBox1.CheckedItems
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Agregar números al CheckedListBox usando un bucle For
        For i As Integer = 0 To 9
            CheckedListBox1.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Agregar letras mayúsculas al CheckedListBox
        For i As Integer = Asc("A") To Asc("Z")
            CheckedListBox1.Items.Add(Chr(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Agregar letras minúsculas al CheckedListBox
        For i As Integer = Asc("a") To Asc("z")
            CheckedListBox1.Items.Add(Chr(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Agregar caracteres especiales al CheckedListBox
        Dim caracteresEspeciales As String = "áéíóúñÑ"
        For Each c As Char In caracteresEspeciales
            CheckedListBox1.Items.Add(c)
        Next
    End Sub
End Class

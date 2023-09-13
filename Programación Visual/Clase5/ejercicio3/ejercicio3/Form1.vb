Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


		Dim A As Integer = 10
		Dim B As Integer = 15
		Dim C As Integer = 20
		Dim D As Integer = 25

		Console.WriteLine("Valor A: " & A & ".")
		Console.WriteLine("Valor B: " & B & ".")
		Console.WriteLine("Valor C: " & C & ".")
		Console.WriteLine("Valor D: " & D & ".")

		Dim tmpB As Integer = B
		B = C
		C = A
		A = D
		D = tmpB

		Console.WriteLine("Valor A: " & A & ".")
		Console.WriteLine("Valor B: " & B & ".")
		Console.WriteLine("Valor C: " & C & ".")
		Console.WriteLine("Valor D: " & D & ".")

	End Sub
End Class

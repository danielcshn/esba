Algoritmo Actividad_2
	
	// Tragamonedas
	
	Repetir
		
		num1 = azar(100)+1
		num2 = azar(100)+1
		num3 = azar(100)+1
		
		Escribir "num1 = ", num1, " num2= ", num2, " num3= ", num3
		
		Si num1 = num2 y num2 = num3 Entonces
			Escribir "GANO!"
		SiNo
			Escribir "PERDIO!"
		Fin Si
		
		Escribir "Quiere volver a Jugar? (S/N)"
		Leer resp
		
	Hasta Que resp ="N" O resp="n"
	
FinAlgoritmo

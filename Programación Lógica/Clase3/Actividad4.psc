// Actividad 4

// Dado un grupo de 3 números determinar si la suma de cualquier pareja de ellos es igual al tercer número. 
// Si se cumple esta condición mostrar por pantalla "iguales", en caso contrario mostrar "distintos".

Algoritmo Actividad4
	
	Escribir "Ingresar 3 numeros:"
	Leer num1, num2, num3
	
	sub1 = num1 + num2
	sub2 = num1 + num3
	sub3 = num2 + num3
	
	Si (sub1 = num3) o (sub2 = num3) o (sub3 = num3) Entonces
		Escribir "iguales"
	SiNo
		Escribir "distintos"
	Fin Si
	
FinAlgoritmo

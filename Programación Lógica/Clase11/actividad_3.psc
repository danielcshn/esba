Algoritmo actividad_3
	
	// En una matriz de 4x4 almacenar números aleatorios entre 0 y 9. 
	// Posteriormente, suma todos los números que componen la matriz.
	
	Dimension Matriz[4,4]
	
	Definir sumar Como Entero
	sumar = 0
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 4 Hacer
			Matriz[f,c]= azar(9)
			sumar = sumar + Matriz[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 4 Hacer
			Escribir Matriz[f,c] Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
	Escribir "La suma de todos los numeros enteros es: ", sumar
	
FinAlgoritmo

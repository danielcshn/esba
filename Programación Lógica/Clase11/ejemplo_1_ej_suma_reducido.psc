Algoritmo ejemplo_1_ej_suma
	
	// Ejemplo 1: En una matriz de 4x4 almacenar números aleatorios entre 0 y 9. 
	// Posteriormente, suma todos los números que componen la matriz.
	// Reduccion de codigo: 
	
	suma = 0
	Dimension M[4,4]
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 4 Hacer
			M[f,c] = azar(10)
			suma = suma + M[f,c]
		FinPara
	FinPara
	
	Escribir "la suma de los numeros ingresados es: ", suma
	
FinAlgoritmo

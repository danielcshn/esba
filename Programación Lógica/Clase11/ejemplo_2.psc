Algoritmo ejemplo_2
	
	// Ejemplo 2: En una matriz de 4x4 almacenar números aleatorios entre 0 y 9. 
	// Posteriormente mostrar la matriz y sumar todos los números que componen 
	// la columna 1
	
	Dimension M[4,4]
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 4 Hacer
			M[f,c] = azar(10)
		FinPara
	FinPara
	
	Para f=1 Hasta 4 Hacer
		PAra c=1 Hasta 4 Hacer
			Escribir M[f,c] Sin Saltar
		FinPara
		Escribir " "
	FinPara
	
	Para f=1 Hasta 4 Hacer
		suma = suma + M[f,1]
	FinPara
	
	Escribir "la suma de los numeros ingresados en la columna 1: ", suma
	
FinAlgoritmo

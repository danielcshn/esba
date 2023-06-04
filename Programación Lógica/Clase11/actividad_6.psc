Algoritmo actividad_6
	
	// Realizar un algoritmo que permita calcular la suma de los elementos de la diagonal 
	// principal de una matriz (5x5). (Diagonal principal los índices de la fila y columna son iguales.
	
	Dimension Matriz[5,5]
	Definir sumar Como Entero
	sumar = 0
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Escribir "Ingrese un numero entero para Matriz: ", f, " ", c
			Leer Matriz[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Si f=c Entonces
				sumar = sumar + Matriz[f,c]
			Fin Si
		FinPara
	FinPara
	
	Escribir "La suma de los elementos en aldiagonal principal de la matriz (5x5) es: ", sumar
	
FinAlgoritmo

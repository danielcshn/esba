Algoritmo actividad_1
	
	// En una matriz de 3x3 almacenar 9 números enteros ingresados por el usuario. 
	// Luego mostrar el contenido de la matriz
	
	Dimension Matriz[3,3]
	
	Para f=1 Hasta 3 Hacer
		Para c=1 Hasta 3 Hacer
			Escribir "Ingresar numero entero: "
			Leer Matriz[f,c]
		FinPara
	FinPara
	
	Escribir " "
	
	Para f=1 Hasta 3 Hacer
		Para c=1 Hasta 3 Hacer
			Escribir Matriz[f,c] Sin Saltar
		FinPara
		Escribir "" 
	FinPara
	
FinAlgoritmo

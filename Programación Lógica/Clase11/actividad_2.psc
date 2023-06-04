Algoritmo actividad_2
	
	// Crear una matriz de NxN y llenarla con los números que el usuario desee. 
	// Luego mostrar el contenido de la matriz
	
	Escribir "Ingrese el numero de filas"
	Leer nf
	Escribir "Ingrese el numero de columnas"
	Leer nc
	
	Dimension Matriz[nf,nc]
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir "Ingresar un numero: ", nf, " - ", nc 
			Leer Matriz[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir Matriz[f,c] Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
FinAlgoritmo

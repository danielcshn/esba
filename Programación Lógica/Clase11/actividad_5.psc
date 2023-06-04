Algoritmo actividad_5
	
	// Realizar una algoritmo para obtener una matriz S, como resultado 
	// de la suma de dos matrices, A y B de orden MxN
	
	Escribir "Ingrese el numero de filas"
	Leer nf
	Escribir "Ingrese el numero de columnas"
	Leer nc
	
	Dimension MatrizA[nf,nc]
	Dimension MatrizB[nf,nc]
	Dimension MatrizS[nf,nc]
	
	Escribir " "
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir "Ingrese un numero entero para MatrizA: ", nf, " - ", nc
			Leer MatrizA[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir "Ingrese un numero entero para MatrizB: ", nf, " - ", nc
			Leer MatrizB[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			MatrizS[f,c] = MatrizA[f,c] + MatrizB[f,c]
		FinPara
	FinPara
	
	Escribir " "
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir MatrizS[f,c] Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
FinAlgoritmo

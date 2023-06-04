Algoritmo cargar_matriz_columna_fila
	
	Dimension M[3,4]
	
	Para c=1 Hasta 4 Hacer
		Para f=1 Hasta 3 Hacer
			Escribir "Ingrese un numero para la columna ", c, " fila ", f
			Leer M[f,c]
		FinPara
	FinPara
	
	Para c=1 Hasta 4 Hacer
		Para f=1 Hasta 3 Hacer
			Escribir M[f,c] , " " Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
FinAlgoritmo

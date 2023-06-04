Algoritmo ejemplo_3_suma_filas_y_columnas
	
	// Ejemplo 3: Realizar un algoritmo que lea una matriz de n filas y x columnas. 
	// Luego calcule la suma de las filas y de las columnas, dejando los resultados 
	// en dos vectores, uno con la suma de las filas y otro con la suma de las columnas. 
	// Posteriormente muestre los dos vectores.
	
	Escribir "Ingrese el numero de filas"
	Leer nf
	Escribir "Ingrese el numero de columnas"
	Leer nc
	
	Dimension Matriz[nf,nc]
	Dimension vector_columna[nc]
	Dimension vector_fila[nf]
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir "Ingrese el valor de la: ", f, " - ", c
			Leer Matriz[f,c]
		FinPara
	FinPara
	
	Para f=1 Hasta nf Hacer
		sumaf=0
		Para c=1 Hasta nc Hacer
			sumaf = sumaf + Matriz[f,c]
		FinPara
		vector_fila[f]=sumaf
	FinPara
	
	Para c=1 Hasta nc Hacer
		sumac=0
		Para f=1 Hasta nf Hacer
			sumac = sumac + Matriz[f,c]
		FinPara
		vector_columna[c]=sumac
	FinPara
	
	Escribir "Vector resultante de la suma de las filas"
	Para f=1 Hasta nf Hacer
		Escribir vector_fila[f]
	FinPara
	
	Escribir ""
	
	Escribir "Vector resultante de la suma de las columnas"
	Para c=1 Hasta nc Hacer
		Escribir vector_columna[c]
	FinPara
	
FinAlgoritmo

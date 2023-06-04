Algoritmo actividad_4
	
	// Crear un algoritmo que rellene automáticamente una matriz MxN con la suma de sus índices. 
	// (Es decir, el elemento A[1,1] = 1+1?. A[3,2] = 3+2). 
	// El algoritmo mostrará la matriz resultante por pantalla.
	
	Escribir "Ingrese el numero de filas"
	Leer nf
	Escribir "Ingrese el numero de columnas"
	Leer nc
	
	Dimension Matriz[nf,nc]
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Matriz[f,c] = f + c
		FinPara
	FinPara
	
	Escribir ""
	
	Para f=1 Hasta nf Hacer
		Para c=1 Hasta nc Hacer
			Escribir Matriz[f,c] Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
FinAlgoritmo

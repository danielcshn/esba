Algoritmo actividad_8
	
	// Hacer un algoritmo que llene una matriz de 10x10 y determine la posición [fila,columna] 
	// del número mayor almacenado en la matriz. Los números son diferentes.
	
	Definir fMayor Como Entero
	Definir cMayor Como Entero
	Definir fcvalor Como Entero
	
	fMayor = 0
	cMayor = 0
	fcvalor = 0
	
	Dimension Matriz[10,10]
	
	Para f=1 Hasta 10 Hacer
		Para c=1 Hasta 10 Hacer
			Matriz[f,c] = azar(100)
		FinPara
	FinPara
	
	Para f=1 Hasta 10 Hacer
		Para c=1 Hasta 10 Hacer
			Si Matriz[f,c] > fcvalor Entonces
				fcvalor = Matriz[f,c]
				fMayor = f
				cMayor = c
			Fin Si
		FinPara
	FinPara
	
	Escribir "La posicion [f,c] del numero mayor almacenado es: ", fMayor, "-", cMayor," = ", fcvalor 
	
FinAlgoritmo

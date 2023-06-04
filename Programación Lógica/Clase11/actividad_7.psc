Algoritmo actividad_7
	
	// En una matriz de 4x4 almacenar números aleatorios entre 0 y 20. 
	// Posteriormente, mostrar los elementos de la columna 3.
	
	Dimension Matriz[4,4]
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 4 Hacer
			Matriz[f,c] = azar(20)
			
			Si c = 3 Entonces
				Escribir "Valor Elemento ", f, "-",c, " = ", Matriz[f,c] 
			Fin Si
		FinPara
	FinPara
	
FinAlgoritmo

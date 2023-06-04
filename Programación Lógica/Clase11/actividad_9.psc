Algoritmo actividad_9
	
	// Hacer un algoritmo que llene una matriz de 5x5 y que almacene la diagonal principal en un vector. 
	// Mostrar el vector resultante.
	
	Dimension Matriz[5,5]
	Dimension Vector[5]
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Matriz[f,c] = azar(9)
			
			Si f=c Entonces
				Vector[f] = Matriz[f,c]
			Fin Si
		FinPara
	FinPara
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Escribir Matriz[f,c], " " Sin Saltar
		FinPara
		Escribir ""
	FinPara
	
	Escribir " "
	
	Para i = 1 Hasta 5 Hacer
		Escribir Vector[i] Sin Saltar
	FinPara
	
	Escribir " "
	
FinAlgoritmo

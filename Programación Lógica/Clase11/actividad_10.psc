Algoritmo actividad_10
	
	// Hacer un algoritmo que llene una matriz de 5x6 y muestre cu�ntos de los n�meros 
	// almacenados son cero, cu�ntos son positivos y cu�ntos son negativos.
	
	Dimension Matriz[5,6]
	
	Definir ceros Como Entero
	Definir positivos Como Entero
	Definir negativos Como Entero
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 6 Hacer
			Matriz[f,c] = azar(9)
		FinPara
	FinPara
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 6 Hacer
			// si es igual a 0
			Si Matriz[f,c] = 0 Entonces
				ceros = ceros+1
			Fin Si
			// si es positivos
			Si Matriz[f,c] >= 0 Entonces
				positivos = positivos+1
			SiNo
				negativos = negativos+1				
			FinSi
		FinPara
	FinPara
	
	Escribir "Numeros que son Cero: ", ceros
	Escribir "Numeros que son positivos: ", positivos
	Escribir "Numeros que son negativos: ", negativos
	
FinAlgoritmo

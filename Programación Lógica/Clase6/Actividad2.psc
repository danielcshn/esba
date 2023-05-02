Algoritmo Actividad2
	
	// 2) Contar y mostrar la cantidad de 0 de una serie de 50 números.
	
	nums = 0
	ceros = 0
	
	Repetir
		Escribir "Ingrese el numero: "
		Leer n
		
		Si n = 0 Entonces
			ceros = ceros + 1
		Fin Si
		
		nums = nums+1
	Hasta Que nums = 50
	
	Escribir "Cantidad de ceros: ", ceros 
	
FinAlgoritmo

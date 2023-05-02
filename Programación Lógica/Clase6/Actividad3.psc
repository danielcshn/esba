Algoritmo Actividad3
	
	// 3) Determinar de 500 números cuántos de ellos son positivos.
	
	nums = 0
	positivos = 0
	
	Repetir
		Escribir "Ingrese el numero: "
		Leer n
		
		Si n >= 0 Entonces
			// positivo
			positivos = positivos + 1
		Fin Si
		
		nums = nums+1
	Hasta Que nums = 500
	
	Escribir "Cantidad de numeros positivos: ", positivos 
	
FinAlgoritmo

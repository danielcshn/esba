Algoritmo Actividad1
	
	i = 0
	positivos = 0
	negativos = 0
	neutros = 0

	Para i=1 Hasta 20 Hacer
		Escribir "Ingrese un numero:"
		Leer N
		
		Si N = 0 Entonces
			neutros = neutros+1
		SiNo
			Si N > 0 Entonces
				positivos = positivos+1
			SiNo
				negativos = negativos+1
			Fin Si
		Fin Si
	Fin Para
	
	Escribir "Cantidad de Numeros positivos: ", positivos
	Escribir "Cantidad de Numeros negativos: ", negativos
	Escribir "Cantidad de Numeros neutros: ", neutros
	
FinAlgoritmo

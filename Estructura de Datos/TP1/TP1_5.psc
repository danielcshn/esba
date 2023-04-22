Algoritmo TP1_5
	
	// Usted observó que en la cola del banco se coló una persona de saco
	// azul y que de los n clientes del banco que hacen la cola es el único
	// que tiene un saco de ese color. Desarrolle un algoritmo que muestre
	//	la posición del intruso en la cola.
	//	a. Por búsqueda secuencial.
	//	b. Por búsqueda binaria. Considere que la cola se representa
	//	como un arreglo unidimensional ordenado cuyos elementos
	//	contienen el color del saco de cada cliente.
	
	Dimension cola(5)
	cola(1) = "rojo"
	cola(2) = "negro"
	cola(3) = "azul"
	cola(4) = "verde"
	cola(5) = "gris"
	
	busco = "azul"
	
	// Busqueda secuencial
	Para i=1 Hasta 5 Con Paso 1 Hacer
		Si busco=cola(i) Entonces
			Escribir "El saco azul se encuentra en la posición: ", i
		Fin Si
	Fin Para
	
	// Busqueda Binaria
	Definir encontro Como Logico
	encontro = Falso
	
	Definir p_inicial, p_final, p_medio Como Entero
	p_inicial = 1
	p_final = 5
	pos = -1
	
	Mientras encontro=Falso Y (p_inicial < p_final) Hacer
		p_medio = trunc(p_inicial+p_final / 2)
		
		Si cola(p_medio) = busco Entonces
			encontro = Verdadero
			pos = p_medio
			Escribir "El saco azul se encuentra en la posición: ", pos
		SiNo
			Si cola(p_medio)<busco Entonces
				p_inicial = p_medio + 1
			SiNo
				p_final = p_medio - 1
			Fin Si
		Fin Si
	Fin Mientras
	
FinAlgoritmo

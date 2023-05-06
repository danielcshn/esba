Algoritmo Actividad2
	
	Definir num, valorAnt, valorMax, valorMin, ordenMax, ordenMin Como Entero
	
	Escribir "Ingresar valor: (1/150)"
	Leer num
	
	valorAnt = 0
	valorMax = num
	valorMin = num
	ordenMax = 1
	ordenMin = 1
	
	Para i = 2 Hasta 5 Con Paso 1 Hacer
		Escribir "Ingresar valor: (", i, "/150)"
		Leer num
		
		Si num < valorMin Entonces
			valorMin = num
			ordenMin = i
		SiNo
			Si num > valorMax Entonces
				valorMax = num
				ordenMax = i
			Fin Si
		Fin Si
	Fin Para
	
	Escribir "El valor mas alto ", valorMax ", orden ", ordenMax
	Escribir "El valor mas bajo ", valorMin ", orden ", ordenMin
	
FinAlgoritmo

Algoritmo Actividad9
	
	Escribir "---------------------------"
	Escribir "1: "
	Escribir "---------------------------"
	
	total = 0
	Para i = 1 Hasta 10
		Escribir "Ingresar numero:"
		Leer num
		total = total + num
	Fin Para
	
	Escribir "Suma: ", total
	
	Escribir "---------------------------"
	Escribir "2: "
	Escribir "---------------------------"
	
	x = 1
	total = 0
	Repetir
		Escribir "Ingresar numero:"
		Leer num
		total = total + num
		x = x + 1
	Hasta Que x > 10
	
	Escribir "Suma: ", total
	
	Escribir "---------------------------"
	Escribir "3: "
	Escribir "---------------------------"
	
	x = 1
	total = 0
	Mientras (x >= 1) Y (x <= 10) Hacer
		Escribir "Ingresar numero:"
		Leer num
		total = total + num
		x = x + 1
	Fin Mientras
	
	Escribir "Suma: ", total
	
FinAlgoritmo

Algoritmo Actividad7
	
	Escribir "Ingresar cantidad de materias: "
	Leer x
	
	z = 1
	total = 0
	Repetir
		Escribir "Ingresar valor de la nota: "
		Leer num1
		total = total + num1
		z = z + 1
	Hasta Que z > x
	
	Escribir "Promedio es: ", total / x
	
FinAlgoritmo

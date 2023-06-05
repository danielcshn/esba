Algoritmo actividad_8
	
	// Dado los 30 nombres y notas de un conjunto de alumnos, informar:
	// a) La nota más alta
	// b) Los nombres de los alumnos que tienen esa nota.
	// (Ayuda: usar un vector para los nombres y otro vector para las notas)
	
	Dimension alumnos[30]
	Dimension notas[30]
	
	Para i=1 Hasta 30 Con Paso 1 Hacer
		alumnos[i] = Concatenar("Alumno",ConvertirATexto(i))
		notas[i] = azar(10)
	Fin Para
	
	max = notas[1]
	pos = 1
	Para i=1 Hasta 30 Con Paso 1 Hacer
		Si notas[i] > max Entonces
			max = notas[i]
			pos = i
		Fin Si
	Fin Para
	
	Escribir "Notas mas altas: ", notas[pos], " Alumno: ", alumnos[pos]
	
FinAlgoritmo

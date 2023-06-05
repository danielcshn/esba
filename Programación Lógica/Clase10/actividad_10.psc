Algoritmo actividad_10
	
	// Realizar un algoritmo que cargue en vector de N datos y asigne a sus elementos los
	// valores 1, 4, 9, 16 ?. Etc. (12, 22, 32, ?)
	
	Escribir "Ingrese el tamaño del vector: "
	Leer n
	
	Dimension vector[n]
	
	Para i = 1 hasta n Hacer 
		vector[i] = i ^ 2
	FinPara
	
	Para i = 1 hasta n Hacer 
		Escribir vector[i]
	FinPara
	
FinAlgoritmo

Algoritmo actividad_5
	
	// Llenar el vector A con 10 elementos.
	// Generar el vector B, cuyos elementos sean el duplo del vector A. 
	// Luego mostrar por pantalla ambos vectores.
	
	Dimension vectorA[10]
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		vectorA[i] = azar(10)
	Fin Para
	
	Dimension vectorB[10]
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		vectorB[i] = vectorA[i] * 2
	Fin Para
	
	Para i=1 Hasta 10 Hacer
		Escribir "vectorA ", i, " = ", vectorA[i]
	FinPara
	
	Para i=1 Hasta 10 Hacer
		Escribir "vectorB ", i, " = ", vectorB[i]
	FinPara
FinAlgoritmo

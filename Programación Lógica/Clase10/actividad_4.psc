Algoritmo actividad_4
	
	// Se requiere de un algoritmo para obtener un vector (C) de n elementos que contenga la 
	// suma de los elementos correspondientes a otros dos vectores (A, B). 
	// (Los vectores A y B Se deben cargar previamente con números enteros ingresados por el usuario)
	
	Escribir "Ingresar valor para vector:"
	Leer va
	
	Dimension vectorA[va]
	
	Para i=1 Hasta va Con Paso 1 Hacer
		Escribir "Ingresar un numero entero: vectorA ", i, "/", va
		Leer vectorA[i]
	Fin Para
	
	Dimension vectorB[va]
	
	Para i=1 Hasta va Con Paso 1 Hacer
		Escribir "Ingresar un numero entero: vectorB ", i, "/", va
		Leer vectorB[i]
	Fin Para
	
	Dimension vectorC[va]
	
	Para i = 1 hasta va Hacer
		vectorC[i] = vectorA[i] + vectorB[i]
	FinPara
	
	Para i = 1 hasta va Hacer
		Escribir vectorA[i] " + " vectorB[i] " = " vectorC[i]
	FinPara
	
FinAlgoritmo

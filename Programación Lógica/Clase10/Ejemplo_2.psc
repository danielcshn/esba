Algoritmo Ejemplo_2
	// Almacenar en un vector de tama�o 5 n�meros enteros ingresados por el usuario 
	// y luego mostrarlo en orden inverso.
	
	// Declaro el vector
	Dimension vec[10]
	//Cargo el vector
	
	Para i = 1 Hasta 5 Hacer
		Escribir "Ingrese un n�mero real: "
		Leer n 
		vec[i]=n
	FinPara
	
	// Muestro el contenido del vector en orden inverso
	Para i = 5 Hasta 1 Hacer 
		Escribir vec[i] Sin Saltar " "
	FinPara
FinAlgoritmo

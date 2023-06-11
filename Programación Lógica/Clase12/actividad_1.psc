Algoritmo actividad_1
	
	// Realizar un algoritmo que permita el ingreso por teclado de 30 elementos 
	// de un vector numérico, los ordene en forma ascendente y a continuación
	// muestre la lista ordenada.
	
	Definir N Como Entero
	N = 30
	Dimension V[N]
	
	// Cargo un vector con N elementos.
	
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir "Ingresar un numero para vector ", i, "/30";
		Leer V[i];
	FinPara
	
	Escribir " "
	
	Escribir "Vector Desornado"
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir V[i];
	FinPara
	
	Escribir " "
	
	Para j = 2 Hasta 5 Hacer
		aux = V[j]
		i = j-1
		Mientras i>0 y V[i] > aux Hacer
			V[i+1] = V[i]
			i = i-1
		FinMientras
		V[i+1]=aux
	FinPara
	
	Escribir " "
	
	// Muestro vector ordenado
	
	Escribir "Vector Ordenado"
	Para x=1 Hasta 5 Hacer
		Escribir V[x]
	FinPara
	
FinAlgoritmo

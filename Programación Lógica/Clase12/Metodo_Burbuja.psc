Algoritmo Metodo_Burbuja
	
	Escribir "Numero de elemento para el vector: "
	Leer N
	Dimension V[N]
	
	// Cargo un vector con N elementos.
	
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir "Elemento en la pos ", i;
		Leer V[i];
	FinPara
	
	Escribir "Vector Original"
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir V[i];
	FinPara
	
	// Ordenamiento
	
	Para i<-1 Hasta N-1 Con Paso 1 Hacer
		Para j<-1 Hasta N-1 Con Paso 1 Hacer
			Si V[j] > V[j+1] Entonces
				aux <- V[j+1]
				V[j+1] <- V[j]
				V[j]<-aux;
			FinSi
		FinPara
	FinPara
	
	Escribir "Vector Ordenado"
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir V[i];
	FinPara
	
FinAlgoritmo

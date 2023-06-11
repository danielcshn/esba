Algoritmo Metodo_Insercion
	
	// Cargo un vector con 5 numeros
	
	Dimension V[5]
	V[1]=2
	V[2]=1
	V[3]=3
	V[4]=4
	V[5]=5
	
	// Proceso Mostrar el vector
	
	Escribir "Vector Desornado"
	Para i=1 Hasta 5 Hacer
		Escribir V[i] Sin Saltar
	FinPara
	Escribir ""
	
	Para j = 2 Hasta 5 Hacer
		aux = V[j]
		i = j-1
		Mientras i>0 y V[i] > aux Hacer
			V[i+1] = V[i]
			i = i-1
		FinMientras
		V[i+1]=aux
	FinPara
	
	// Muestro vector ordenado
	
	Escribir "Vector Ordenado"
	Para x=1 Hasta 5 Hacer
		Escribir V[x] Sin Saltar
	FinPara
	
FinAlgoritmo

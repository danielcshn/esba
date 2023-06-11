Algoritmo actividad_4
	
	// Se ingresan 100 números al azar del 1 al 10 para luego ordenarlos 
	// de menor a mayor.
	
	Definir N Como Entero
	N = 100
	Dimension V[N]
	
	// Cargo un vector con N elementos.
	
	Para i<-1 Hasta N Con Paso 1 Hacer
		V[i] = azar(100)
	FinPara
	
	Escribir " "
	
	Escribir "Vector Desornado"
	Para i<-1 Hasta N Con Paso 1 Hacer
		Escribir V[i];
	FinPara
	
	Escribir " "
	
	Para j = 2 Hasta N Hacer
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
	Para x=1 Hasta N Hacer
		Escribir V[x]
	FinPara
	
FinAlgoritmo

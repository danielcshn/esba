Algoritmo Burbuja_Mejorado
	
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
	
	// Proceso de ordenamiento
	
	Repetir
		intercambiado=Verdadero
		Para j=1 Hasta 4 Hacer
			Si V[j] > V[j+1] Entonces
				aux = V[j]
				V[j] = V[j+1]
				V[j+1] = aux
				intercambiado = Falso
			FinSi
		FinPara
	Hasta Que intercambiado = Verdadero
	
	// Muestro vector ordenado
	
	Escribir "Vector Ordenado"
	Para x=1 Hasta 5 Hacer
		Escribir V[x] Sin Saltar
	FinPara
	
FinAlgoritmo

// Se tiene una matriz M de 36 columnas por 54 filas, y un vector V de 36 elementos. 
// Se pide dividir los elementos de cada columna de la matriz por el elemento correspondiente del vector, 
// guardando los resultados en otra matriz de 36 por 54.

Algoritmo actividad_5
	
	Dimension M[36, 54]
    Dimension V[36]
    Dimension resultado[36, 54]
    Definir c, f Como Entero
	
	// Cargo Matriz
	Para c <- 1 Hasta 36 Hacer
        Para f <- 1 Hasta 54 Hacer
            M[c, f] = azar(250)
        Fin Para
    Fin Para
	
	// Cargo Vector
	Para i <- 1 Hasta 36 Hacer
        V[i] = azar(250)
    Fin Para
	
	// Dividir
    Para c <- 1 Hasta 36 Hacer
        Para f <- 1 Hasta 54 Hacer
            resultado[c, f] <- M[c, f] / V[c]
        Fin Para
    Fin Para
	
    // Imprimir la matriz resultado
    Para f <- 1 Hasta 54 Hacer
        Para c <- 1 Hasta 36 Hacer
            Escribir resultado[c, f]
        Fin Para
        Escribir ""
    Fin Para

FinAlgoritmo

Algoritmo TP1_3
	
	// En una empresa se maneja una lista de precios de los n artículos que
	// comercializan. De cada artículo se tiene la siguiente información:
		//- Código de artículo
		//- Precio
	// Escriba un algoritmo para ordenar el arreglo en forma ascendente
	// por el campo Código.
		//a. Por el método de la burbuja.
		//b. Por el método Shell.
	
	Definir columna, fila, i, x, random, temp1, temp2, final, temp3, temp4 Como Entero
	columna = 2
	fila = 5
	
	// x | Codigo Articulo | Precio | 
	// 1 | 3645            | 3000   | 
	// 2 | 5876            | 5000   | 
	// 3 | 1231            | 1000   | 
	// 4 | 7453            | 7000   | 
	// 5 | 2323            | 5500   | 
	
	Dimension arreglo(columna,fila)
	// Le cargo los valores al arreglo
	arreglo(1,1) = 3645
	arreglo(2,1) = 3000
	arreglo(1,2) = 5876
	arreglo(2,2) = 5000
	arreglo(1,3) = 1231
	arreglo(2,3) = 1000
	arreglo(1,4) = 7453
	arreglo(2,4) = 7000
	arreglo(1,5) = 2323
	arreglo(2,5) = 5500
	
	// Debug: Muestra todos los numeros asignados al arreglo completo
	// Descomentar las siguientes lineas:
	
	Escribir "| Tabla Original"
	Escribir "| Codigo | Precio | "
	Para i=0 Hasta 5-1 Hacer
		Escribir "|  ", arreglo(1,i+1), "  |  ",  arreglo(2,i+1), "  |"
	Fin Para
	
	Escribir "---"
	
	// Ordena por Metodo Burbuja
	// determina la cantidad de pasadas
	pasadas = 3
	final = 0
	
	Repetir
		Para i=1 Hasta fila-1 Hacer
			
			Si arreglo(1,i) > arreglo(1,i+1) Entonces
				temp1 = arreglo(1,i)
				temp2 = arreglo(2,i)
				arreglo(1,i) = arreglo(1,i+1)
				arreglo(2,i) = arreglo(2,i+1)
				arreglo(1,i+1) = temp1
				arreglo(2,i+1) = temp2
			FinSi
			
		Fin Para
		final = final + 1
	Hasta Que final = pasadas
	
	Escribir "| Tabla Ordenada por Burbuja"
	Escribir "| Codigo | Precio | "
	Para i=0 Hasta 5-1 Hacer
		Escribir "|  ", arreglo(1,i+1), "  |  ",  arreglo(2,i+1), "  |"
	Fin Para
	
	Escribir "---"
	
	
	// x | Codigo Articulo | Precio | 
	// 1 | 3645            | 3000   | 
	// 2 | 5876            | 5000   | 
	// 3 | 1231            | 1000   | 
	// 4 | 7453            | 7000   | 
	// 5 | 2323            | 5500   | 

	// Le cargo los valores al arreglo
	arreglo(1,1) = 3645
	arreglo(2,1) = 3000
	arreglo(1,2) = 5876
	arreglo(2,2) = 5000
	arreglo(1,3) = 1231
	arreglo(2,3) = 1000
	arreglo(1,4) = 7453
	arreglo(2,4) = 7000
	arreglo(1,5) = 2323
	arreglo(2,5) = 5500
	
	Escribir "| Tabla Original"
	Escribir "| Codigo | Precio | "
	Para i=0 Hasta 5-1 Hacer
		Escribir "|  ", arreglo(1,i+1), "  |  ",  arreglo(2,i+1), "  |"
	Fin Para
	
	
	// Ordenar por Metodo Shell
	interno = trunc(fila/2)
	temp3 = 0
	temp4 = 0
	
	Mientras interno<>0 Hacer
		Para i=interno Hasta fila Con Paso 1 Hacer
			j=i-interno
			Mientras j>=1 Hacer
				k=j+interno
				Si arreglo(1,j)<=arreglo(1,k) Entonces
					j=j-1
				SiNo
					temp3 = arreglo(1,j)
					temp4 = arreglo(2,j)
					arreglo(1,j) = arreglo(1,k)
					arreglo(2,j) = arreglo(2,k)
					arreglo(1,k) = temp3
					arreglo(2,k) = temp4
					j=j-interno
				Fin Si
			Fin Mientras
		Fin Para
		interno=trunc(interno/2)
	Fin Mientras
	
	
	Escribir "---"
	Escribir "| Tabla Ordenada Shell"
	Escribir "| Codigo | Precio | "
	Para i=0 Hasta 5-1 Hacer
		Escribir "|  ", arreglo(1,i+1), "  |  ",  arreglo(2,i+1), "  |"
	Fin Para
	
FinAlgoritmo

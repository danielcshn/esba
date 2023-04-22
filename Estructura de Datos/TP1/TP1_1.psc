Algoritmo TP1_1
	
	// Escribir un algoritmo que lea 10 números por teclado, los almacene
	// en un arreglo y muestre la suma de todos.
	
	Dimension arreglo(10)
	suma = 0
	
	i = 0
	Para i = 1 Hasta 10 Hacer
		Escribir "Ingresar un numero: "
		Leer num
		arreglo(i) = num
		suma = suma + arreglo(i)
	Fin Para
	
	Escribir "La suma es: ", suma
	
	
FinAlgoritmo

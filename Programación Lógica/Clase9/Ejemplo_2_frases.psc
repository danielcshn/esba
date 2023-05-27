Algoritmo Ejemplo_2_frases
	
	// Ingresar una frase, convertir la frase a mayúscula, indicar la longitud de la frase e indicar la 
	// cantidad de vocales que tiene.
	
	Escribir "Ingresar una frase" 
	Leer frase 
	largo = Longitud(frase) 
	Escribir "Su longitud de la frase es:", largo 
	Escribir "la frase en mayúscula es: ", Mayusculas(frase) 
	Para i = 1 hasta largo Hacer 
		l = Subcadena(frase, i, i) 
		Si l = "a" o l = "e" o l = "i" o l = "o" o l = "u" o l = "á" o l = "é" o l = "í" o l = "ó" o l = "ú" 
			c = c + 1 
		FinSi 
	FinPara 
	Escribir "Tiene : ", c, " vocales"

FinAlgoritmo

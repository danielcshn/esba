Funcion area <- farea (base,altura)
	area = (base*altura)
FinFuncion

Algoritmo actividad_1
	
	// Crear una función que devuelva el área de un rectángulo dada su base y su altura. 
	// Luego invocarla desde el programa principal.
	
	Escribir "Calcular area de un rectangulo"
	Escribir "Ingrese la base: "
	Leer base
	Escribir "Ingrese la altura: "
	Leer altura
	
	Escribir "Area del rectangulo es: ", farea(base,altura)
	
FinAlgoritmo

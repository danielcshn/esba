Algoritmo actividad_2
	
	// Obtener el tama�o del vector y llenarlo con nombres. 
	// Visualizar los elementos del vector en may�scula.

	Escribir "Ingrese un tama�o para el vector: "
	Leer n
	
	Dimension vector[n]
	
	Para i = 1 Hasta n Con Paso 1 Hacer
		Escribir "Ingrese un nombre: ", i, "/", n
		Leer vector[i]
	Fin Para
	
	Para i = 1 Hasta n Con Paso 1 Hacer
		Si vector[i] = Mayusculas(vector[i]) Entonces
			Escribir "Nombre con mayuscula: ", vector[i]
		Fin Si
	Fin Para
	
FinAlgoritmo

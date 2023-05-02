Algoritmo promedio
	i=0
	suma=0
	Escribir "Ingrese un número (-999 para terminar): "
	Leer n
	Mientras n <> -999 Hacer
		i = i + 1
		suma = suma + n
		Escribir "Ingrese otro número (-999 para terminar): "
		Leer n
	Fin Mientras
	prom = suma/i
	Escribir "El promedio de los números ingresados es: ", prom	
FinAlgoritmo
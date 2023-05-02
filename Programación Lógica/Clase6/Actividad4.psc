Algoritmo Actividad4
	
	// 4) Hacer un algoritmo para obtener la estatura promedio de un 
	// grupo de personas, cuyo número de miembros se desconoce, el 
	// ciclo debe efectuarse siempre y cuando se tenga una estatura 
	// registrada (distinta de cero).

	cantidad=0 
	suma=0 
	
	Escribir "Ingrese la estatura (cero para terminar): "
	leer estatura	
	
	Mientras estatura<>0 Hacer
		
		suma = suma + estatura
		cantidad = cantidad + 1 
		
		Escribir "Ingrese la estatura: "
		leer estatura
		
	Fin Mientras
	
	Si cantidad <> 0 Entonces 
		promedio = suma/cantidad  
		Escribir "Suma total de las estaturas: ",suma, " mts."
		Escribir "Cantidad de personas: ", cantidad
		Escribir "El promedio de las estaturas ingresadas es de: ", promedio, " mts."
	SiNo
		Escribir "No se registraron estaturas"
	FinSi
	
FinAlgoritmo

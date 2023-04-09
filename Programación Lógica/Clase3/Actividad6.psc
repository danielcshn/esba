// Actividad 6

// Los surtidores de una estación de servicio registran lo que "surten" en galones, pero el precio de 
// la nafta está fijado en litros. Calcular y mostrar por pantalla lo que hay que cobrarle al cliente. 
// Consideraciones:
//	Cada galón tiene 3.785 litros
//	El precio del litro es $ 11.25

Algoritmo Actividad6
	
	Escribir "Ingresar valor cargado al cliente:"
	Leer valor1
	
	// valor de 1 galon:
	galon = 3785 * 11.25
	Escribir "1 galon > ", galon

	final = valor1 * galon
	
	Escribir "Valor a cobrar: ", final 
	
FinAlgoritmo

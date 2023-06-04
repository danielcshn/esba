Algoritmo ejemplo_3_mayor_venta
	
	// Ejemplo 3: En una matriz se registran las ventas de cinco vendedores 
	// durante cinco días de la semana. Se requiere determinar cuál fue la 
	// venta mayor realizada.
	
	// Para resolver este problema, vamos a utilizar una matriz de 5x5, donde 
	// las filas representan a los vendedores y las columnas los días de la semana.
	
	// Para poder saber cual es la mayor venta, vamos a asignar al vendedor 1 del 
	// día 1 como la venta máxima antes del proceso de determinar cual de las 
	// ventas es la mayor,
	
	Dimension ventas[5,5]
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Escribir "Ingrese el monto de la venta del vendedor ", f, " : "
			Leer ventas[f,c]
		FinPara
	FinPara
	
	max_venta = ventas[1,1]
	
	Para f=1 Hasta 5 Hacer
		Para c=1 Hasta 5 Hacer
			Si ventas[f,c] > max Entonces
				max=ventas[f,c]
			FinSi
		FinPara
	FinPara
	
	Escribir "La venta mayor fue: ", max
FinAlgoritmo

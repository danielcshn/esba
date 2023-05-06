Algoritmo Actividad6
	
	totalCat1 = 0
	totalCats = 0
	totalFacturas = 0
	
	Para i = 1 Hasta 50 Con Paso 1 Hacer
		Escribir "Ingresar importe: "
		Leer importe
		
		Escribir "Categoria cliente: "
		Leer categoria
		
		Si categoria = 1 Entonces
			// -15%
			final = importe - (importe*15/100)
			totalCat1 = totalCat1 + final
		SiNo
			// -18%
			final = importe - (importe*18/100)
			totalCats = totalCats + final
		Fin Si
		
		totalFacturas = totalFacturas + final
		
	Fin Para
	
	Escribir "Importe total de las 50 facturas: ", totalFacturas
	Escribir "Importe total de las facturas clientes categoria 1: ", totalCat1
	Escribir "Importe total de las facturas clientes otras categorias: ", totalCats
	
FinAlgoritmo

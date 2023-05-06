Algoritmo Actividad3
	
	Repetir
		Escribir "Ingrese el numero de cliente: "
		Leer cli
		Escribir "Ingrese el domicilio del cliente: "
		Leer dom
		Escribir "Ingrese los m2 contratados: "
		
		leer m2		
		si m2 <= 5 Entonces
			importe = m2 * 20 
		SiNo
			Si m2 <= 20 Entonces
				importe = m2 * 18.50
			Sino 
				importe = m2 * 15
				
				clientes = clientes + 1 
			FinSi
		FinSi
		total = total + importe
		
		Escribir "--------------------------------------------------------------------------"
		Escribir ""
		Escribir "El cliente N°", cli " Tiene que pagar un total de ", importe "$"
		Escribir ""
		
		Escribir "¿Ingresa otra venta? S/N"
		Leer resp
		resp = Mayusculas(resp)
		
	Hasta Que resp = "N"

	Escribir "--------------------------------------------------------------------------"
	Escribir ""
	Escribir "La recaudacion de la empresa es de ", total "$"
	Escribir "Un total de ", clientes " clientes contrataron más de 20 m2"
	Escribir ""
	
FinAlgoritmo

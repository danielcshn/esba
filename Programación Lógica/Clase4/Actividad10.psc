Algoritmo Actividad10
	
	// En una fábrica de computadoras se planea ofrecer a los clientes un descuento que dependerá del número de computadoras que compre. 
	// Si son menos de 5 se le realizará un 10% de descuento sobre el total de la compra; si esta entre 5 y 10 se le otorga un 20% de 
	// descuento y si son más de 10 un 40% de descuento. Mostrar lo que debe abonar el cliente por la compra realizada. 
	// Ud. deberá determinar cuáles son los datos que tendrá que ingresar para poder realizar lo que se pide.
	
	Escribir "Ingresar cantidad de computadoras: "
	Leer countPC
	
	Escribir "Ingresar el valor de cada PC: "
	Leer valorPC
	
	Segun countPC Hacer
		1,2,3,4:
			// -10%
			total = countPC * valorPC
			total = total-(total*0.10)
			Escribir "Valor de compra: $", total
		5,6,7,8,9,10:
			// -20%
			total = countPC * valorPC
			total = total-(total*0.20)
			Escribir "Valor de compra: $", total
		De Otro Modo:
			// +10 -40%
			total = countPC * valorPC
			total = total-(total*0.40)
			Escribir "Valor de compra: $", total
	Fin Segun
	
FinAlgoritmo

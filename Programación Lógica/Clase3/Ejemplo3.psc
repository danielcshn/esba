// En un comercio se hace un 20% de descuento a los clientes cuya compra supere los $1000
// ¿Cuál será la cantidad que pagará una persona por su compra?

// Entrada: 
// Valor de la compra 

// Salida: 
// Total a pagar por la compra 

// Proceso
// Si el valor de la compra es mayor a $1000 entonces se le descuenta un 20%, caso contrario, no
// se le realiza descuento.

Algoritmo EJEMPLO3
	
	Escribir "Ingrese el valor de la compra:"
	Leer ValorCompra
	
	Si ValorCompra > 1000 Entonces
		Escribir "-> El valor de la compra es superior a 1000, descuento de 20%"
		
		Descuento = ValorCompra * 20/100
		TotalPagar = ValorCompra - Descuento
		
		Escribir "Valor Pago: ", TotalPagar
	SiNo
		Escribir "Valor Pago: ", ValorCompra
	Fin Si
	
FinAlgoritmo

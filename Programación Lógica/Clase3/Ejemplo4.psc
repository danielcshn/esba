// Ingresar los lados de un rectángulo y el radio de un circulo. Determinar si las áreas de
// ambas figuras son o no iguales, mostrando un mensaje por pantalla.

// Entrada: 
// base, altura del rectángulo y el radio del círculo.

// Salida: 
// mensaje

// Proceso
// Área del rectángulo = base * altura
// Area del circulo = 3,1415 * radio ^ 2

Algoritmo EJEMPLO4
	
	Escribir "Ingresar la base y altura de un rectangulo: "
	Leer base, altura
	Escribir "Ingresar el radio de un circulo: "
	Leer radio
	
	Escribir "Area del rectangulo: "
	area_rec = base * altura
	Escribir area_rec
	
	Escribir "Area del circulo: "
	area_cir <- 3.1415 * radio ^ 2
	Escribir area_cir
	
	Si area_cir = area_rec Entonces
		Escribir "Las áreas son iguales"
	SiNo
		Escribir "Las áreas son distintas"
	Fin Si
	
FinAlgoritmo

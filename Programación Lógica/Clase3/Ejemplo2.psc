// Conocidas las medidas de un terreno de forma rectangular, se desea saber la superficie del 
// terreno, el perímetro del terreno y la diagonal del terreno.

// Entrada:
// - Largo del terreo 
// - Ancho del terreno

// Salida:
// - Superficie del terreno 
// - Perímetro del terreno 
// - Diagonal del terreno 

// Proceso:
// - La superficie del rectángulo es igual a base por altura
// - El perímetro del rectángulo es igual a la suma de las longitudes de sus cuatro lados 
// - La diagonal del rectángulo la podemos calcular empleando el teorema de Pitágoras


Algoritmo EJEMPLO2
	
	Escribir "Ingresar el Largo y Ancho del terreno:"
	Leer LARGO, ANCHO
	
	Escribir "Superficie es:"
	superficie<-ANCHO*LARGO
	Escribir superficie
	
	Escribir "Perimetro es:"
	perimetro<- (LARGO*2)+(ANCHO*2)
	Escribir perimetro
	
	Escribir "Diagonal es:"
	diagonal<- raiz((LARGO^2 + ANCHO^2))  
	Escribir diagonal
	
FinAlgoritmo

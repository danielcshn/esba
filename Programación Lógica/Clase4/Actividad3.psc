Algoritmo Actividad3
	
	Escribir "Elegir una operación:"
	Escribir "1.- SUMA"
	Escribir "2.- RESTA"
	Escribir "3.- MULTIPLICACIÓN"
	Escribir "4.- DIVICIÓN"
	Leer operacion
	
	Escribir "Ingresar primer numero:"
	Leer num1
	Escribir "Ingresar segundo numero:"
	Leer num2
	
	Segun operacion Hacer
		1:
			// SUMA
			Escribir (num1+num2)
		2:
			// RESTA
			Escribir (num1-num2)
		3:
			// MULTIPLICACION
			Escribir (num1*num2)
		4:
			// DIVICION
			Escribir (num1/num2)
		De Otro Modo:
			Escribir "Error"
	Fin Segun
	
FinAlgoritmo

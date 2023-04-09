// Actividad 5 

// Se ingresa el sueldo de un trabajador. Si el sueldo es menor a 5000 se le aplicará un incremento del 15%. 
// Mostrar por pantalla el nuevo sueldo del trabajador.

Algoritmo Actividad5
	
	Escribir "Ingresar sueldo del trabajador:"
	Leer sueldo
	
	Si sueldo < 5000 Entonces
		Escribir "Sueldo inferior, se aplica +15%"
		incremento = sueldo * 15 / 100
		final = sueldo + incremento
		Escribir "Se incremento el sueldo a : ", final
	SiNo
		Escribir "Sueldo superior a 5000, sin incremento."
	Fin Si
	
FinAlgoritmo

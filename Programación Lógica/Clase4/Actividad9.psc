Algoritmo Actividad9
	
	// Un obrero necesita calcular su sueldo semanal, el cual se obtiene de la siguiente manera:
	// a. Si trabaja 40 horas o menos se le paga $ 16 la hora
	// b. Si trabaja más de 40 horas se le paga $ 16 por cada una de las primeras 40 horas y $ 20 por cada hora extra.
	// Obtener el sueldo semanal del obrero mostrando el resultado por pantalla.
	
	Escribir "Ingresar las horas semanales trabajadas: "
	Leer horas
	
	monto = 0
	
	Si horas <= 40 Entonces
		monto = horas * 16
		Escribir "Sueldo semanal: ", monto
	SiNo
		monto = 40 * 16
		hextra = horas - 40
		
		Escribir "Sueldo semanal: ", monto + (hextra*20)
	Fin Si
	
FinAlgoritmo

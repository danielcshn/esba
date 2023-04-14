Algoritmo Actividad4
	
	Escribir "Ingresar mes (numerico)"
	Leer mes
	Escribir "Ingresar dia (numerico)"
	Leer dia
	
	// Primavera: 21 de septiembre
	// Verano: 21 de diciembre
	// Otoño: 20 de marzo
	// Invierno: 21 de junio
	
	Segun mes Hacer
		1: // Enero
			Escribir "Verano"
		2:
			Escribir "Verano"
		3: // Marzo
			Si dia >= 20 Entonces
				Escribir "Otoño"
			SiNo
				Escribir "Verano"
			Fin Si
		4: 
			Escribir "Otoño"
		5:
			Escribir "Otoño"
		6: // Junio
			Si dia >= 21 Entonces
				Escribir "Invierno"
			SiNo
				Escribir "Otoño"
			Fin Si
			
		7: // Julio
			Escribir "Invierno"
		8:
			Escribir "Invierno"
		9:
			Si dia >= 21 Entonces
				Escribir "Primavera"
			SiNo
				Escribir "Invierno"
			Fin Si
		10:
			Escribir "Primavera"
		11:
			Escribir "Primavera"
		12: // Diciembre
			Si dia >= 21 Entonces
				Escribir "Verano"
			SiNo
				Escribir "Primavera"
			Fin Si
		De Otro Modo:
			Escribir "Error"
	Fin Segun
FinAlgoritmo
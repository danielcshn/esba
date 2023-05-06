Algoritmo Actividad5
	
	tenis = 0
	edad_tenis = 0
	rugby = 0
	edad_rugby = 0
	voley = 0
	edad_voley = 0
	hockey = 0
	edad_hockey = 0
	futbol = 0
	edad_futbol = 0
	
	Repetir
		Escribir "Ingrese el número de socio que quiere registrar: "
		leer num_soc
		Escribir "Ingrese Nombre y Apellido:"
		Leer nombre
		Escribir "Ingrese la edad del socio: "
		leer edad
		
		Escribir "Ingrese una opción del tipo de deporte que practica"
		Escribir "1) Tenis | 2) Rugby | 3) Voley | 4) Hockey | 5) Futbol"
		
		leer deporte
		
		Segun deporte Hacer
			1:
				tenis = tenis + 1  
				edad_tenis = edad_tenis + edad
			2:
				rugby = rugby + 1
				edad_rugby = edad_rugby + edad
			3:
				voley = voley + 1
				edad_voley = edad_voley + edad
			4:
				hockey = hockey + 1
				edad_hockey = edad_hockey + edad
			5:
				futbol = futbol + 1
				edad_futbol = edad_futbol + edad
		Fin Segun
		
		Escribir "Quiere ingresar otro socio? S/N: "
		Leer resp
		resp = Mayusculas(resp) 
	Hasta Que resp = "N"

	Escribir "Total de socios que practican tenis: ", tenis
	Escribir "Con un promedio de edad de ", edad_tenis/tenis " años"
	Escribir "Total de socios que practican rugby: ", rugby
	Escribir "Con un promedio de edad de ", edad_tenis/rugby " años"
	
FinAlgoritmo

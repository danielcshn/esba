// Actividad 3

// Determinar si un alumno aprueba o reprueba un año sabiendo que aprueba si el promedio de 3 
// calificaciones es mayor o igual a 70; en caso contrario reprueba. Mostrar por pantalla
// los mensajes según corresponda.


Algoritmo Actividad3
	
	Escribir "Ingresar las 3 calificaciones: "
	Leer cali1, cali2, cali3
	
	promedio = (cali1+cali2+cali3) / 3
	
	Si promedio >= 70 Entonces
		Escribir "Alumno Aprobado! :)"
	SiNo
		Escribir "Alumno Reprobado! ;("
	Fin Si
	
FinAlgoritmo

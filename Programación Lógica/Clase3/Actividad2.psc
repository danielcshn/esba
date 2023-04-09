// Actividad 2

// Dados dos números mostrar por pantalla según corresponda:
//	a. El 1° es mayor que el 2°
//	b. El 1° es menor que el 2°
//	c. Ambos son iguales

Algoritmo Actividad2
	
	Escribir "Ingresar dos numeros: "
	Leer num1, num2
	
	Si num1 = num2 Entonces
		Escribir "Son iguales."
	Sino 
		Si num1 > num2 Entonces
			Escribir "1° es mayor"
		SiNo
			Escribir "1° es menor"
		Fin Si
	Fin Si
	
FinAlgoritmo

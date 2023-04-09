// ACTIVIDAD 1

// Ingresar 2 números y muestre por pantalla un texto que indique si la resta del primero menos el segundo es positiva, negativa o cero.

Algoritmo Actividad1
	
	Escribir "Ingresar dos numeros"
	Leer num1, num2
	
	resta = num1-num2
	
	Si resta = 0 Entonces
		Escribir "Valor es igual a 0"
	Fin Si
	
	Si resta > 0 Entonces
		Escribir "Valor es positivo"
	SiNo
		Escribir "Valor es negativo"
	Fin Si
	
FinAlgoritmo

Funcion ePrimo <- primo (num)
	
	Si num <= 1 Entonces
		ePrimo = Falso
		
	SiNo
		
		divisor <- 2
		resto <- num MOD divisor
		
		Mientras divisor <= num/2 Y resto <> 0 Hacer
			divisor <- divisor + 1
			resto <- num MOD divisor
		Fin Mientras
		
		Si resto = 0 Entonces
			ePrimo = Falso
		Sino
			ePrimo = Verdadero
		Fin Si
		
	FinSi
FinFuncion

Algoritmo actividad_4
	
	// Crear un algoritmo que:
	// -- Lea un número positivo
	// -- Invoque una función llamada primo que termine si el numero leído es un numero primo.
	// -- Muestre el numero leído y un mensaje que diga si es primo o no.
	
	Escribir "Ingresar un numero positivo: "
	Leer num
	
	Si num <= 0 Entonces
		Escribir "El numero ingresado no es valido."
	SiNo
		Si num = 0 Entonces
			Escribir "El número", num, "no es primo."
		Sino
			Si primo(num) Entonces
				Escribir "El numero ", num, " es primo."
			SiNo
				Escribir "El numero ", num, " NO es primo."
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo

Algoritmo Ejemplo_1_azar
	
	// Ejemplo 1: Generar 3 números aleatorios del 1 al 100 e indicar cuál es el mayor
	
	a = azar(100)+1
	b = azar(100)+1
	c = azar(100)+1
	
	Escribir "a=", a, " b=", b, " c=", c
	
	Si a > b Y a > c Entonces
		Escribir "El numero mayor es: ", a
	SiNo
		Si b>a Y b>c Entonces
			Escribir "El numero mayor es: ", b
		SiNo
			Si c>a Y c>b Entonces
				Escribir "El numero mayor es: ", c
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo

Algoritmo menorMultiplo3
	flag = Verdadero
	Leer elemento
	Mientras elemento <> 0 Hacer
		Si elemento % 3 = 0 Entonces
			Si flag Entonces
				menor = elemento
				flag = Falso
			SiNo
				Si elemento < menor Entonces
					menor = elemento
				FinSi
			Fin Si
		Fin Si
		Leer elemento
	Fin Mientras
	
	Si flag Entonces
		Escribir "no se ingreso ningun multiplo de 3"
	SiNo
		Escribir "El menor de los multiplos de 3 es: ", menor
	Fin Si
FinAlgoritmo

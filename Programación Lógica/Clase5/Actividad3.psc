Algoritmo Actividad3
	
	i = 0
	menores = 0
	mayores = 0
	entre = 0
	
	Para i=1 Hasta 20 Hacer
		Escribir "Ingrese un numero:"
		Leer N
		
		Si N < 15 Entonces
			menores = menores+1
		SiNo
			Si N > 25 Y N < 40  Entonces
				entre = entre+1
			SiNo
				Si N > 50 Entonces
					mayores = mayores+1
				FinSi
			Fin Si
		Fin Si
	Fin Para
	
	Escribir "Cantidad de Numeros < 15: ", menores
	Escribir "Cantidad de Numeros > 25 < 40: ", mayores
	Escribir "Cantidad de Numeros > 50: ", entre
	
FinAlgoritmo

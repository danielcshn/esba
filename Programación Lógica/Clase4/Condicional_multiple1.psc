Algoritmo Condicional_multiple
	Escribir 'Ingrese el sueldo b�sico: '
	Leer SB
	Escribir 'Ingrese categor�a: '
	Leer CAT
	Segun CAT Hacer
		1:
			AU <- SB*15/100 // si la categor�a es uno calculamos el 15% del sueldo
		2:
			AU <- SB*10/100 // si la categor�a es uno calculamos el 10% del sueldo
		3:
			AU <- SB*8/100 // si la categor�a es uno calculamos el 8% del sueldo
		4:
			AU <- SB*7/100 // si la categor�a es uno calculamos el 7% del sueldo
		De Otro Modo: // si la categor�a no es 1,2, 3 o 4
			AU <- 0
			Escribir 'Lo sentimos: no hay aumento para Ud.'
	FinSegun
	NS <- SB+AU
	Escribir 'Su aumento es de: ',AU
	Escribir 'Su sueldo ahora es: ',NS
FinAlgoritmo
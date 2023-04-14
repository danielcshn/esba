Algoritmo Condicional_multiple
	Escribir 'Ingrese el número de mes:"
	Leer MES
	Segun MES Hacer
		4,6,9,11: // abril, junio, septiembre, noviembre
			Escribir "Tiene 30 días"
		1,3,5,7,8,10,12: // enero, marzo, mayo, julio, agosto, octubre y diciembre
			Escribir "Tiene 31 días" 
		2: // febrero
			Escribir "Tiene 28 días"
		De Otro Modo:
			Escribir "Ingresón un número de mes incorrecto"
	FinSegun
FinAlgoritmo
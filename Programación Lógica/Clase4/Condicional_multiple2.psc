Algoritmo Condicional_multiple
	Escribir 'Ingrese el n�mero de mes:"
	Leer MES
	Segun MES Hacer
		4,6,9,11: // abril, junio, septiembre, noviembre
			Escribir "Tiene 30 d�as"
		1,3,5,7,8,10,12: // enero, marzo, mayo, julio, agosto, octubre y diciembre
			Escribir "Tiene 31 d�as" 
		2: // febrero
			Escribir "Tiene 28 d�as"
		De Otro Modo:
			Escribir "Ingres�n un n�mero de mes incorrecto"
	FinSegun
FinAlgoritmo
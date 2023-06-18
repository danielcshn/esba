Funcion valorFinal <- ConvertirDolares (dinero)
	valorFinal = dinero * 0.0040
FinFuncion

Funcion valorFinal <- ConvertirLibras (dinero)
	valorFinal = dinero * 0.0031
FinFuncion

Funcion valorFinal <- ConvertirYenes (dinero)
	valorFinal = dinero * 0.57
FinFuncion


Algoritmo actividad_3
	
	// Crear una función que permita convertir una cantidad de dinero dada en dólares, 
	// libras o yenes.
	
	Escribir "Ingrese la cantidad de dinero"
	Leer dinero
	
	Escribir("Seleccione la moneda a la que desea convertir:")
	Escribir("1. Dólares")
	Escribir("2. Libras")
	Escribir("3. Yenes")
	Leer valorMenu
	
	Segun valorMenu Hacer
		1:
			Escribir "El valor de ", dinero, " convertido a Dólares es: ", ConvertirDolares(dinero)
		2:
			Escribir "El valor de ", dinero, " convertido a Libras es: ", ConvertirLibras(dinero)
		3:
			Escribir "El valor de ", dinero, " convertido a Yenes es: ", ConvertirYenes(dinero)
		De Otro Modo:
			Escribir "Error."
	Fin Segun
	
FinAlgoritmo

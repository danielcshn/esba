Algoritmo Actividad_1
	
	// Realizar un diagrama que muestre por pantalla el siguiente menu
	
	Definir num1 Como Real
	seguir = Verdadero
	Mientras seguir Hacer
		Escribir " "
		Escribir "Funciones:"
		Escribir " "
		Escribir "   1) Raiz"
		Escribir "   2) Valor Absoluto"
		Escribir "   3) Parte entera"
		Escribir "   4) Redondear"
		Escribir "   5) Azar"
		Escribir "   6) Salir"
		Escribir " "
		Escribir "Ingresar una opción:"
		Escribir " "
		Leer numop
		
			Segun numop Hacer
				1:
					// Raiz
					Escribir "Ingrese un numero: "
					Leer num1
					Si num1 >= 0 Entonces
						calc1 = raiz(num1)
						Escribir "La raiz de ", num1, " es ", calc1
					SiNo
						Escribir "El numero: ", num1, " no es 0 o mayor."
					Fin Si
				2:
					// Valor Absoluto
					Escribir "Ingrese un numero: "
					Leer num1
					calc2 = abs(num1)
					Escribir "El valor absoluto de ", num1, " es ", calc2
				3:
					// Parte entera
					Escribir "Ingrese un numero float: "
					Leer num1
					calc3 = trunc(num1)
					Escribir "El valor entero de ", num1, " es ", calc3
				4:
					// Redondear
					Escribir "Ingrese un numero float: "
					Leer num1
					calc4 = redon(num1)
					Escribir "El valor redondeado de ", num1, " es ", calc4
				5:
					// Azar
					calc5 = azar(5)
					Escribir "Su numero random es: ", calc5
				6:
					seguir = Falso
				De Otro Modo:
					Escribir "Opción no valida!"
			Fin Segun

	Fin Mientras
FinAlgoritmo

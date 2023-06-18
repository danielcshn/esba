Funcion resultado <- Sumar(a, b)
	resultado = a + b
FinFuncion

Funcion resultado <- Restar(a, b)
	resultado = a - b
FinFuncion

Funcion resultado <- Multiplicar(a, b)
	resultado = a * b
FinFuncion

Funcion resultado <- Dividir(a, b)
	resultado = a / b
FinFuncion

Funcion menu()
	Escribir ""
	Escribir "    Calculadora de Bolsillo    "
	Escribir ""
	Escribir "1. Suma"
	Escribir "2. Resta"	
	Escribir "3. Multiplicación"	
	Escribir "4. División"
	Escribir "5. Salir"
	Escribir ""
	Escribir "Introducir una opción (1-5)"
FinFuncion

Algoritmo actividad_5
	
	// Crear un algoritmo muestre el siguiente menú:
	// Calculadora de Bolsillo
	// 1. Suma
	// 2. Resta
	// 3. Multiplicación
	// 4. División
	// 5. Salir
	// Introducir una opción (1-5)
	// Una vez introducida la opción, el programa pedirá que se introduzcan dos datos por teclado y mostrará en pantalla el resultado. 
	// Una vez mostrado el resultado, el programa mostrará nuevamente el menú y continuará indefinidamente hasta pulsar la opción 5.
	// Crear las funciones para cada una de las opciones.
	
	Mientras valor1 <> 5 Hacer
		menu()
		Leer valorMenu
		
		Segun valorMenu Hacer
			1:
				Escribir "Ingresar el primer numero: "
				Leer num1
				Escribir "Ingresar el segundo numero: "
				Leer num2
				Escribir " "
				Escribir "Resultado de :", num1, "+", num2, " = ", Sumar(num1, num2)
				Escribir " "
			2:
				Escribir "Ingresar el primer numero: "
				Leer num1
				Escribir "Ingresar el segundo numero: "
				Leer num2
				Escribir " "
				Escribir "Resultado de :", num1, "-", num2, " = ", Restar(num1, num2)
				Escribir " "
			3:
				Escribir "Ingresar el primer numero: "
				Leer num1
				Escribir "Ingresar el segundo numero: "
				Leer num2
				Escribir " "
				Escribir "Resultado de :", num1, "*", num2, " = ", Multiplicar(num1, num2)
				Escribir " "
			4:
				Escribir "Ingresar el primer numero: "
				Leer num1
				Escribir "Ingresar el segundo numero: "
				Leer num2
				Escribir " "
				Escribir "Resultado de :", num1, "/", num2, " = ", Dividir(num1, num2)
				Escribir " "
			5:
				valor1 = 5
			De Otro Modo:
				Escribir "Error."
		Fin Segun
	Fin Mientras
	
FinAlgoritmo

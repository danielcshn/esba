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
	Escribir "3. Multiplicaci�n"	
	Escribir "4. Divisi�n"
	Escribir "5. Salir"
	Escribir ""
	Escribir "Introducir una opci�n (1-5)"
FinFuncion

Algoritmo actividad_5
	
	// Crear un algoritmo muestre el siguiente men�:
	// Calculadora de Bolsillo
	// 1. Suma
	// 2. Resta
	// 3. Multiplicaci�n
	// 4. Divisi�n
	// 5. Salir
	// Introducir una opci�n (1-5)
	// Una vez introducida la opci�n, el programa pedir� que se introduzcan dos datos por teclado y mostrar� en pantalla el resultado. 
	// Una vez mostrado el resultado, el programa mostrar� nuevamente el men� y continuar� indefinidamente hasta pulsar la opci�n 5.
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

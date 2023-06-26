// Crear un algoritmo (empleando funciones) que convierta temperaturas introducidas por teclado a otra escala dependiendo de la opci�n escogida por el usuario. 
// Para ello mos-trar� el siguiente men�:
// 
// 1. Convertir Cent�grados a Fahrenheit
// 2. Convertir de Cent�grados a Kelvin
// 3. Convertir Fahrenheit a Kelvin
// 4. Terminar
// Introducir una opci�n (1-4)
// 
// Una vez introducida la opci�n, el programa pedir� que se introduzca una temperatura por teclado y mostrar� en pantalla la temperatura convertida a la escala 
// final, dependiendo de la opci�n escogida (teniendo en cuenta que x �C son (9/5 * x + 32) �F y (x-273)�K). Una vez mostrada la temperatura final, el programa 
// mostrar� nuevamente el men� y continuar� indefinidamente hasta pulsar la opci�n 4. Si el usuario introdujera una opci�n distinta a 1,2,3 y 4, el programa 
// mostrar� en pantalla el mensaje Opci�n Incorrecta.

// F�rmula (x �C � 9/5) + 32 = x �F
Funcion valorfinal <- CelsiusAFahrenheit(temperatura)
    Definir temperaturaConvertida Como Real
    temperaturaConvertida = (9/5 * temperatura) + 32
    valorfinal = temperaturaConvertida
FinFuncion

// F�rmula x �C + 273.15 = x K
Funcion valorfinal <- CelsiusAKelvin(temperatura)
    Definir temperaturaConvertida Como Real
    temperaturaConvertida = temperatura + 273.15
    valorfinal = temperaturaConvertida
FinFuncion

Funcion valorfinal <- FahrenheitAKelvin(temperatura)
    Definir temperaturaConvertida Como Real
    temperaturaConvertida = (temperatura + 459.67) * 5/9
    valorfinal = temperaturaConvertida
FinFuncion

Algoritmo actividad_1
	
	Definir ingreso, grados Como Entero
	
	Mientras ingreso <> 4 Hacer
		
		Escribir ""
		Escribir "1. Convertir Cent�grados a Fahrenheit"
		Escribir "2. Convertir de Cent�grados a Kelvin"
		Escribir "3. Convertir Fahrenheit a Kelvin"
		Escribir "4. Terminar"
		Escribir ""
		Escribir "Introducir una opci�n (1-4):"
		Leer ingreso
		
		Segun ingreso Hacer
			1:
				Escribir "Ingresar la temperatura en Cent�grados: "
				Leer grados
				Escribir "Cent�grados ", grados, " a Fahrenheit son: ", CelsiusAFahrenheit(grados)
				Escribir ""
			2:
				Escribir "Ingresar la temperatura en Cent�grados: "
				Leer grados
				Escribir "Cent�grados ", grados, " a Kelvin son: ", CelsiusAKelvin(grados)
				Escribir ""
			3:
				Escribir "Ingresar la temperatura en Fahrenheit: "
				Leer grados
				Escribir "Fahrenheit ", grados, " a Kelvin son: ", FahrenheitAKelvin(grados)
				Escribir ""
            4:
                Escribir "Programa terminado."
				Escribir ""
            De Otro Modo:
                Escribir "Opci�n incorrecta."
				Escribir ""
		Fin Segun
		
		
	Fin Mientras
	
FinAlgoritmo

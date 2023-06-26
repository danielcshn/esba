// Crear un algoritmo (empleando funciones) que convierta temperaturas introducidas por teclado a otra escala dependiendo de la opción escogida por el usuario. 
// Para ello mos-trará el siguiente menú:
// 
// 1. Convertir Centígrados a Fahrenheit
// 2. Convertir de Centígrados a Kelvin
// 3. Convertir Fahrenheit a Kelvin
// 4. Terminar
// Introducir una opción (1-4)
// 
// Una vez introducida la opción, el programa pedirá que se introduzca una temperatura por teclado y mostrará en pantalla la temperatura convertida a la escala 
// final, dependiendo de la opción escogida (teniendo en cuenta que x °C son (9/5 * x + 32) °F y (x-273)°K). Una vez mostrada la temperatura final, el programa 
// mostrará nuevamente el menú y continuará indefinidamente hasta pulsar la opción 4. Si el usuario introdujera una opción distinta a 1,2,3 y 4, el programa 
// mostrará en pantalla el mensaje Opción Incorrecta.

// Fórmula (x °C × 9/5) + 32 = x °F
Funcion valorfinal <- CelsiusAFahrenheit(temperatura)
    Definir temperaturaConvertida Como Real
    temperaturaConvertida = (9/5 * temperatura) + 32
    valorfinal = temperaturaConvertida
FinFuncion

// Fórmula x °C + 273.15 = x K
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
		Escribir "1. Convertir Centígrados a Fahrenheit"
		Escribir "2. Convertir de Centígrados a Kelvin"
		Escribir "3. Convertir Fahrenheit a Kelvin"
		Escribir "4. Terminar"
		Escribir ""
		Escribir "Introducir una opción (1-4):"
		Leer ingreso
		
		Segun ingreso Hacer
			1:
				Escribir "Ingresar la temperatura en Centígrados: "
				Leer grados
				Escribir "Centígrados ", grados, " a Fahrenheit son: ", CelsiusAFahrenheit(grados)
				Escribir ""
			2:
				Escribir "Ingresar la temperatura en Centígrados: "
				Leer grados
				Escribir "Centígrados ", grados, " a Kelvin son: ", CelsiusAKelvin(grados)
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
                Escribir "Opción incorrecta."
				Escribir ""
		Fin Segun
		
		
	Fin Mientras
	
FinAlgoritmo

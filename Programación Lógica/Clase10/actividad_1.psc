Algoritmo actividad_1
	
	// Cargar un vector con 200 números, luego informar cuantos son negativos,
	// cuántos son positivos y cuántos son cero.
	
	Dimension vector[200]
	
	Definir cPositivos Como Entero
	Definir cNegativos Como Entero
	Definir cCero Como Entero
	
	cPositivos = 0
	cNegativos = 0
	cCero = 0
	
	// Cargar vector Manual
	Para i = 1 Hasta 200 Con Paso 1 Hacer
		Escribir "Ingrese un numero: ", i, "/200"
		Leer vector[i]
	Fin Para
	
	// Cargar vector con Random
	//Para i = 1 Hasta 200 Con Paso 1 Hacer
	//	vector[i] = azar(10)
	//Fin Para
	
	// Leer vector
	Para i = 1 Hasta 200 Con Paso 1 Hacer
		Si vector[i] = 0 Entonces
			cCero = cCero+1
		SiNo
			Si vector[i] > 0 Entonces
				cPositivos = cPositivos+1
			SiNo
				cNegativos = cNegativos+1
			Fin Si
		Fin Si
	Fin Para
	
	Escribir "Cantidad de numeros positivos: ", cPositivos
	Escribir "Cantidad de numeros negativos: ", cNegativos
	Escribir "Cantidad de ceros: ", cCero
	
FinAlgoritmo

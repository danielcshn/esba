Algoritmo Actividad5
	
	positivos = 0
	negativos = 0
	neutros = 0
	sumapositivos = 0
	sumanegativos = 0
	
	Escribir "Quiere ingresar un numero? S=SI o N=NO"
	Leer paso1
	
	Mientras paso1="S" o paso1="s" Hacer
		
		Escribir "Ingrese un numero: "
		Leer num1
		
		Si num1 > 0 Entonces
			// positivo
			positivos = positivos + 1
			sumapositivos = sumapositivos + num1
		SiNo
			Si num1 < 0 Entonces
				// negativo
				negativos = negativos + 1
				sumanegativos = sumanegativos + num1
			SiNo
				//neutro
				neutros = neutros + 1
			Fin Si
		Fin Si
		
		Escribir "Quiere ingresar un numero? S=SI o N=NO"
		Leer paso1
	Fin Mientras
	
	Escribir "Cantidad de positivos: ", positivos
	Escribir "Cantidad de negativos: ", negativos
	Escribir "Cantidad de neutros: ", neutros
	Escribir "Suma de positivos: ", sumapositivos
	Escribir "Suma de negativos: ", sumanegativos
	
FinAlgoritmo

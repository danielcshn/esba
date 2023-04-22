Algoritmo TP1_2
	
	// Que rellene un arreglo de dos dimensiones con números pares, y
	// después que pida una posición X,Y y mostrar el número
	// correspondiente.
	
	Definir columna, fila, i, x, random Como Entero
	columna = 0
	fila = 0
	
	Escribir "Ingrese cantidad de columnas: Ej. 3 " Sin Saltar
	Leer columna
	
	Escribir "Ingrese cantida de filas: Ej. 3 " Sin Saltar
	Leer fila
	
	Definir partest Como Logico
	Definir pausa Como Caracter
	
	Dimension arreglo(columna,fila)
	
	i = 0
	x = 0
	random = 0
	partest = Falso
	pausa = ""
	
	// Rellenar arreglo con numeros pares
	Para i=1 Hasta fila Hacer
		Para x=1 Hasta columna Hacer
			// genera numero random entre 0 y 100 y verifica que sea par
			Repetir
				// genera random entre 0 y 100
				random = azar(100)
				// verifica que sea par
				Si random%2 = 0 Entonces
					partest = Verdadero
				Fin Si
				// Si no es par repite hasta que sea par
			Hasta Que partest = Verdadero
			// si es par lo agrega
			arreglo(x,i) = random
			partest = Falso
		Fin Para
	Fin Para
	
	// Debug: Muestra todos los numeros asignados al arreglo completo
	// Descomentar las siguientes lineas:
	
	//Para i=1 Hasta fila Hacer
	//	Para x=1 Hasta columna Hacer
	//		Escribir x, ",", i, " = ", arreglo(x,i)
	//	Fin Para
	//Fin Para
	
	// Buscar y mostrar un valor: 
	
	Repetir
		Escribir "BUSCAR UN VALOR"
		Escribir "Posición X: (1-", columna, ")"
		Leer posX
		Escribir "Posicion Y: (1-", fila, ")"
		Leer posY
		
		Escribir "El valor de ", posX, ",", posY, " = ", arreglo(posX,posY)
		
		Escribir "Desea buscar otro valor? (Enter = Continuar / No = Salir)"
		Leer pausa
	Hasta Que pausa = "No"
	
FinAlgoritmo
Algoritmo actividad_7
	
	// Almacenar en un vector 10 números enteros ingresados por el usuario y luego, 
	// sin usar un método de ordenamiento, encuentre el elemento menor y la posición 
	// del elemento menor.
	
	Dimension vector[10]
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		Escribir "Ingresar un numero entero: ", i, "/10" 
		Leer vector[i]
	Fin Para
	
	men = vector[1] 
	pos = 1
	
	Para i = 2 hasta 10 Hacer
		Si vector[i] < men Entonces
			men = vector[i] 
			pos = i	
		FinSi
		
	FinPara 
	
	Escribir "El menor número ingresado es : ", men
	Escribir "Fue ingresado en la posición :", pos
	
FinAlgoritmo

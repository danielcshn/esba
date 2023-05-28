Algoritmo ejemplo_4
	
	Escribir "Ingrese la cantidad de alumnos: "
	Leer n
	
	Dimension vec[n]
	
	//Cargo el vector y voy acumulando las estaturas para luego sacar el promedio
	Para i = 1 Hasta n Hacer
		Escribir "Ingrese estatura: " 
		Leer estatura 
		vec[i]=estatura
		suma = suma + vec[i]
	FinPara
	
	promedio=suma/n

	//Recorro el vector nuevamente para contar cuantos tiene estatura mayor o igual al promedio
	// y cuántos tienen estatura menor que la del promedio.
	Para i = 1 Hasta n Hacer
		Si vec[i]<promedio Entonces
			bajos = bajos + 1
		Sino
			altos = altos + 1
		FinSi 
	FinPara
	
		//Muestro los resultados
		Escribir "Estatura promedio:", promedio
		Escribir "Cantidad de alumnos de estatura mayor o igual que la media es de:", altos
		Escribir "Cantidad de alumnos de estatura menor que la media es de:", bajos
		
FinAlgoritmo

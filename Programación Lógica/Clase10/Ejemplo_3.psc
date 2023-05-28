Algoritmo Vec_suma
	suma=0
	Dimension vec[10]
	
	//Realizo la carga del vector
	Para i = 1 Hasta 10 Hacer
		Escribir "Ingrese un numero: "
		Leer n 
		vec[i]=n
		//Voy acumulando a medida que se va cargando el vector
		suma= suma + vec[i]
	FinPara
	
	Escribir suma
	
FinAlgoritmo

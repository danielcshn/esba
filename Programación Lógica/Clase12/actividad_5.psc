Algoritmo actividad_5
	
	// Ingresar 100 apellidos y sus edades, luego ordenar por edad sin perder la 
	// relación con los apellidoidos (mostrar sus datos apellidoido y edad).
	
	N = 5
	Dimension apellido[N]
	Dimension edad[N]
	
	Para i=1 hasta N Hacer
		Escribir "Ingrese el apellidoido:"
		Leer apellido[i] 	
		Escribir "Ingrese la edad:"
		Leer edad[i] 	
	FinPara
	
	Para i<-1 hasta N-1 con paso 1 hacer
		Para j<-1 hasta N-1 con paso 1 hacer
			si apellido[j]>apellido[j+1]
				aux <- apellido[j+1]
				apellido[j+1]<-apellido[j]
				apellido[j]<-aux;
				
				aux2 <- edad[j+1]
				edad[j+1]<-edad[j]
				edad[j]<-aux2;
			FinSi	
		FinPara	
		
	FinPara
	
	Para i=1 hasta N Hacer
		Escribir apellido[i] 
		Escribir edad[i]
		Escribir "<-.-.-.-.-.->"
	FinPara
	
FinAlgoritmo

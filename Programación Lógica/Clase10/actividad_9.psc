Algoritmo actividad_9
	
	// Cargar un vector con 10 números. Luego leer un número y determinar si este 
	// último número está entre los 10 primeros números leídos.
	
	Dimension vector[10]
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		vector[i]=azar(2)
	Fin Para
	
	Escribir "Ingrese un numero:"
	Leer num
	
	s = 0
	i=1
	
	Repetir		
		Si num = vector[i] Entonces
			s = 1
		FinSi
		i = i + 1
	Hasta Que s=1 o i > 4
	
	Si s = 1 Entonces
		Escribir "El nro ingresado se encuentra en el vector"
	Sino 
		Escribir "El nro ingresado no se encuentra en el vector"
	FinSi
	
FinAlgoritmo

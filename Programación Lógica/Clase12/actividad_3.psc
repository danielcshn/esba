Algoritmo actividad_3
	
	// Se ofrece en Bariloche un curso al periodismo deportivo con un cupo máximo de 
	// 35 alumnos. Realizar un programa que tomo el nombre de los interesados y al 
	// finalizar muestre un listado de los mismos en orden alfabético.
	
	Definir N Como Entero
	N = 5 //35
	Dimension nombres[N]
	
	Para i=1 hasta n Hacer
		Escribir "Ingrese un nombre: ", i, "/35"
		Leer nombres[i] 	
	FinPara
	
	Repetir
		intercambiado=Verdadero
		Para j=1 Hasta 4 Hacer
			Si nombres[j] > nombres[j+1] Entonces
				aux = nombres[j]
				nombres[j]=nombres[j+1]
				nombres[j+1]=aux
				intercambiado=Falso
			FinSi
		FinPara
	Hasta Que intercambiado = Verdadero 
	
	Para i=1 hasta n Hacer
		Escribir nombres[i] 	
	FinPara
	
FinAlgoritmo

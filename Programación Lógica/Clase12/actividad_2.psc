Algoritmo actividad_2
	
	// Dados los sueldos y las edades de N empleados de una empresa, se pide cargar 
	// los datos en vectores separados y mostrar:
	// a) Sueldo promedio de los empleados que tengan entre 18 y 20 años, 
	//ambos inclusive.
	// b) Ordenar y mostrar el vector de los sueldos.
	
	Escribir "Ingresar la cantidad de empleados: "
	Leer N
	Dimension edad[N]
	Dimension sueldos[N]
	
	//Cargo simultáneamente los dos vectores
	Para i=1 hasta n Hacer
		Escribir "Empleado " i
		Escribir "Ingrese la edad:"
		Leer edad[i] 	
		Escribir "Ingrese sueldo:"
		Leer sueldos[i] 	
	FinPara
	
	//Proceso calcular el promedio del los empleados cuyas edades esten entre 15 y 20 años.
	
	Para i = 1 Hasta n Hacer
		//si edad de la posicion i esta comprendida entre 15 y 20 entonces acumulo el sueldo de la posición i
		Si edad[n] >= 15 y edad[n] <= 20 Entonces
			suma = suma + sueldos[i]
			c = c + 1 //Uso la variable c para contar la cantidad empleados que cumplen la condicion
		FinSi
	FinPara
	
	//Uso un condicional para saber si hubo empleados que esten comprendidos entre esas dos edades
	
	Si c> 0 Entonces
		promedio = suma / c
		Escribir "El sueldo promedio de los empleados cuyas edades están entre 15 y 20 años es:", promedio
	SiNo
		Escribir "No hay empleados que tengan edades entre 15 y 20 años"
	FinSi
	
	//Proceso ordeno el vector sueldos empleando algún método. En este ejemplo Burbuja
	//Acá ordeno en forma paralela los dos vectores.
	
	Para i<-1 hasta n-1 con paso 1 hacer
		Para j<-1 hasta n-1 con paso 1 hacer
			si sueldos[j]>sueldos[j+1]
				aux <- sueldos[j+1]
				sueldos[j+1]<-sueldos[j]
				sueldos[j]<-aux;
			FinSi	
		FinPara	
	FinPara
	
	//Mostrar el vector
	Para i=1 hasta n Hacer
		Escribir sueldos[i]
	FinPara
	
FinAlgoritmo

Algoritmo actividad_6
	
	// Se requiere crear un algoritmo que permita llenar un vector que contiene 100 elementos. 
	// El llenado debe hacerse de forma automática asignando números aleatorios entre 1 y 100 
	// para cada uno de los elementos del vector. Luego, se debe calcular la suma de los 
	// elementos y el promedio de los números que componen el vector.
	
	Dimension vector[100]
	
	Definir vSuma Como Entero

	vSuma = 0
	
	Para i=1 Hasta 100 Hacer
		vector[i] = azar(100)
		vSuma = vSuma + vector[i]
	FinPara
	
	Escribir "Suma de los elementos es: ", vSuma
	Escribir "Promedio de los elementos es: " vSuma/100
	
FinAlgoritmo

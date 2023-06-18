Funcion carga (vector Por Referencia, tamanio)
	Para i=1 Hasta tamanio Hacer
		vector[i] = azar(100)
	FinPara
FinFuncion

Funcion mostrarVector(vector,tamanio)
	Para i=1 Hasta tamanio Hacer
		Escribir vector[i]
	FinPara
	Escribir " "
FinFuncion

Algoritmo actividad_2
	
	// Crear una función que permita cargar un vector con números aleatorios pasando 
	// por parámetros el vector y el rango de los números aleatorios.
	
	Escribir "Ingrese el tamaño del vector: "
	Leer t
	Dimension vector[t]
	carga(vector,t)
	Escribir ""
	mostrarVector(vector,t)
	
FinAlgoritmo

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
	
	// Crear una funci�n que permita cargar un vector con n�meros aleatorios pasando 
	// por par�metros el vector y el rango de los n�meros aleatorios.
	
	Escribir "Ingrese el tama�o del vector: "
	Leer t
	Dimension vector[t]
	carga(vector,t)
	Escribir ""
	mostrarVector(vector,t)
	
FinAlgoritmo

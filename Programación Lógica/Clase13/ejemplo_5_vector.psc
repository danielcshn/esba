Funcion carga (vector Por Referencia, tamanio)
	Para i=1 Hasta tamanio Hacer
		Escribir "Ingrese un numero: "
		Leer vector[i]
	FinPara
FinFuncion

Funcion mostrarVector(vector,tamanio)
	Para i=1 Hasta tamanio Hacer
		Escribir vector[i] Sin Saltar
	FinPara
	Escribir ""
FinFuncion

Algoritmo principal
	Escribir "Ingrese el tamaño del vector: "
	Leer t
	Dimension vector[t]
	carga(vector,t)
	Escribir ""
	mostrarVector(vector,t)
FinAlgoritmo

Funcion ingreso (base Por Referencia, expo Por Referencia)
	Escribir "Ingrese la base"
	Leer base
	Escribir "Ingrese el exponente"
	Leer expo
FinFuncion

Funcion pot <- potencia(base,expo,pot Por Referencia)
	pot = 1
	Para i = 1 Hasta expo Hacer
		pot = pot * base
	FinPara
FinFuncion

Algoritmo principal
	ingreso(base,expo)
	pot = potencia(base,expo,pot)
	Escribir "La potencia es: ", pot	
FinAlgoritmo

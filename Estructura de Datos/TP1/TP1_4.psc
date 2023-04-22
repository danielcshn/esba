Funcion nuevo_viejo ( pila, nuevo, viejo )
	i=0
	Para i=1 Hasta 5-1 Hacer
		Si pila(i) = nuevo Entonces
			pila(i) = viejo
		Fin Si
	Fin Para
	
Fin Funcion

Algoritmo TP1_4
	
	// Escribir un algoritmo en pseudocódigo que tenga como argumentos
	// una pila con elementos de tipo entero y dos variables de tipo entero:
	// nuevo y viejo de forma que si el primer valor aparece en algún lugar
	// de la pila, sea reemplazado por el segundo.
	
	// pila: pila con elementos de tipo entero
	// nuevo: variable de tipo entero que será reemplazada
	// viejo: variable de tipo entero que reemplazará a nuevo
	Definir _pila, _nuevo, _viejo Como Entero
	// creamos la pila
	
	_nuevo=10
	_viejo=5
	
	Dimension _pila(5)
	_pila(1) = 1
	_pila(2) = 10
	_pila(3) = 5
	_pila(4) = 10
	_pila(5) = 1
	
	i=0
	Para i=1 Hasta 5 Hacer
		Escribir "Pila ", _pila(i)
	Fin Para
	
	Escribir "----"
	
	nuevo_viejo(_pila, _nuevo, _viejo)
	
	i=0
	Para i=1 Hasta 5 Hacer
		Escribir "Pila ", _pila(i)
	Fin Para
	
FinAlgoritmo


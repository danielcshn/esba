// Crear un vector de 10 posiciones, cargarlo con números distintos (no se pueden repetir los números). 
// Luego indicar en que posición se encuentra el número mayor.

Algoritmo actividad_3
	Dimension v[10]
    Definir i, posMayor Como Entero
    Definir numMayor Como Entero

    Para i = 1 Hasta 10 Hacer
        v[i] = azar(200)
    Fin Para
    
    numMayor = v[1]
    posMayor = 1
    
    Para i = 2 Hasta 10 Hacer
        Si v[i] > numMayor Entonces
            numMayor = v[i]
            posMayor = i
        Fin Si
    Fin Para
    
    Escribir "El número mayor es ", numMayor, " y se encuentra en la posición ", posMayor

FinAlgoritmo

// Crear un vector de 10 posiciones, cargarlo con n�meros distintos (no se pueden repetir los n�meros). 
// Luego indicar en que posici�n se encuentra el n�mero mayor.

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
    
    Escribir "El n�mero mayor es ", numMayor, " y se encuentra en la posici�n ", posMayor

FinAlgoritmo

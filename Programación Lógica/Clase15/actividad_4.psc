// Realizar un algoritmo que lea una matriz de n filas y x columnas. Luego calcule la suma de las filas y de las columnas, 
// dejando los resultados en dos vectores, uno con la suma de las filas y otro con la suma de las columnas. 
// Posteriormente muestre los dos vecto-res.

Algoritmo actividad_4
	
	Definir n, x, i, j Como Entero
    Escribir "Ingrese el número de filas: "
    Leer n
    Escribir "Ingrese el número de columnas: "
    Leer x
	
	Dimension matriz[n,x]
    Dimension sumaFilas[n]
    Dimension sumaColumnas[x]
    
    Para i = 1 Hasta n Hacer
        Para j = 1 Hasta x Hacer
            Escribir "Ingrese el valor en la posición (", i, ",", j, "): "
            Leer matriz[i,j]
        Fin Para
    Fin Para
    
    // Calcular la suma de las filas
    Para i = 1 Hasta n Hacer
        sumaFilas[i] = 0
        Para j = 1 Hasta x Hacer
            sumaFilas[i] = sumaFilas[i] + matriz[i,j]
        Fin Para
    Fin Para
    
    // Calcular la suma de las columnas
    Para j = 1 Hasta x Hacer
        sumaColumnas[j] = 0
        Para i = 1 Hasta n Hacer
            sumaColumnas[j] = sumaColumnas[j] + matriz[i,j]
        Fin Para
    Fin Para
    
    // Mostrar los resultados
    Escribir "Suma de las filas:"
    Para i = 1 Hasta n Hacer
        Escribir sumaFilas[i]
    Fin Para
    
    Escribir "Suma de las columnas:"
    Para j = 1 Hasta x Hacer
        Escribir sumaColumnas[j]
    Fin Para
	
FinAlgoritmo

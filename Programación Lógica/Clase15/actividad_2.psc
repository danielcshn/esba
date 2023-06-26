// Se tienen tres vectores: Productos, Cantidad y Precio, cada uno de 30 elementos. Se pide:
// a. Generar y cargar
//  ? El vector Productos que contendrá los nombres de los productos.
//  ? El vector Cantidad que contendrá el stock de cada producto,
//  ? El vector Precio, que contendrá el precio de cada producto.
// b. Mostrar el listado de productos, como se muestra en el ejemplo
// 
// | Producto | Cantidad | Precio Unitario | Total |
// | A        | 4        | 10              |    40 |
// | B        | 2        | 15              |    30 |

Algoritmo actividad_2
	
	Dimension Productos[30]
	Dimension Cantidad[30]
	Dimension Precio[30]
	Dimension Total[30]
	
	Para i=1 Hasta 30 Con Paso 1 Hacer
		Productos[i] = "producto_" + ConvertirATexto(i)
		Cantidad[i] = azar(40)
		Precio[i] = azar(200)
		Total[i] = Cantidad[i] * Precio[i]
	Fin Para
	
	Escribir ""
    Escribir "| Producto | Cantidad | Precio | Total |"
    Escribir "|------------------------------------|"
    
    Para i = 1 Hasta 30 Hacer
        Escribir "| ", Productos[i], " | ", Cantidad[i], " | ", Precio[i], " | ", Total[i], " |"
    Fin Para
	
FinAlgoritmo

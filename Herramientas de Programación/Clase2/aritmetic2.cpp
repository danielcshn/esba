#include <stdio.h>
#include <stdlib.h>

main(){
	int dato1, dato2, resultado;
	dato1 = 20;
	dato2 = 10;
	
	// Suma
	resultado = dato1 + dato2;
	printf("%d + %d = %d\n", dato1, dato2, resultado);
	
	// Resta
	resultado = dato1 - dato2;
	printf("%d - %d = %d\n", dato1, dato2, resultado);
	
	// Producto
	resultado = dato1 * dato2;
	printf("%d * %d = %d\n", dato1, dato2, resultado);
	
	// Cociente
	resultado = dato1 / dato2;
	printf("%d / %d = %d\n", dato1, dato2, resultado);
	
	system("PAUSE");
	return 0;
}

#include <stdio.h>
#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <stdarg.h>

main(){
	
	int nu;
	printf("Introduce un numero: ");
	scanf("%d", &nu);
	printf("El numero es: %d \n", nu);

	char x;
	printf("Introduce un caracter: ");
	scanf("%c", &x);
	printf("El caracter es: %c \n", x);

	char cad[20];
	printf("Introduce una palabra: ");
	scanf("%s", &cad);
	printf("La palabra es: %s \n", cad);

}

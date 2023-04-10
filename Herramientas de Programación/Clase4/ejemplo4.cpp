#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <stdarg.h>

main(){
	char tex[2];
	
	printf("Ingrese un si o no: \n");
	scanf("%2s", &tex); // <- Limitador a 2
	
	printf("El texto es: %s \n", tex);
	system("PAUSE");
}

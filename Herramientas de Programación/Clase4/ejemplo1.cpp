#include <stdio.h>

main() {
	int a=0, b=0, s=0;
	
	printf("Valores de a y b: ");
	
	scanf("%d %d", &a, &b);
	
	// Algunos de los ingresos que se pueden realizar con scanf:

    // scanf("%s", &variable_cadena);	//Para string _ cadena
    // scanf("%d", &variable_int);		//Para entero
    // scanf("%ld", &variable_long);	//Para long
    // scanf("%c", &variable_char);		//Para caracter
    // scanf("%f", &variable_float);	//Para float
    // scanf("%lf", &variable_double);	//Para double (long float)	
	
	s = a + b;
	
	printf("La suma es: %d", s);
	
	getchar();
	getchar();
}

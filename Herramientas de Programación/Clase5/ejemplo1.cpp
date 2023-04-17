#include <stdio.h>
#include <stdlib.h>
#include <iostream>

main(){
	int a;
	printf("Ingrese un numero: ");
	scanf("%d", &a);
	
	if (a <= 12){
		a--;
		a*=10;
	} else {
		a*=10;
		a++;
	}
	printf("El resultado es: %d \n", a);
	
	system("PAUSE");
}

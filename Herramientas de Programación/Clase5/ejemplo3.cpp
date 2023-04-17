#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

main(){
	int nota;
	printf("Ingrese una nota: ");
	scanf("%d", &nota);
	
	if (nota == 9 || nota == 10) {
		printf("Sobresaliente\n\n");
	} else if (nota > 10) {
		printf("SOBREPASA ALGO NO HUELE BIEN\n\n");
	} else if (nota >= 7) {
		printf("Notable\n\n");
	} else if (nota >= 4) {
		printf("Aprobado sobre el limite\n\n");
	} else {
		printf("Desaprobado\n\n");
	}
	
	system("PAUSE");
}

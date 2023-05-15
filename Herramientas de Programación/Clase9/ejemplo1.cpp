#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

main(){
	int n;
	for (n=1; n <= 30; n++) {
		if (n % 5 == 0) {
			printf("_ ");
			continue;
			printf("ESTE TEXTO NO APARECE");
			printf("TAMPOCO ESTE TEXTO");
		}
		printf("%d ", n);
	}
	
	printf("\n\nPrograma terminado se mostraron los numeros NO multiplos de 5 \n\n");
	system("PAUSE");

}

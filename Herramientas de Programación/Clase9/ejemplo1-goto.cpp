#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

#define K 8

main() {
	int f, c, n;
	printf("Ingrese un valor para n: ");
	scanf("%d", &n);
	
	for (f=0;f<K;f++) {
		for (c=0;c<K;c++) {
			if (f*c > n)
			goto salir;
		}
	}
	
	salir:
		if (f<K && c<K)
		printf("(%d, %d) \n\n", f, c);
		system("PAUSE");
}

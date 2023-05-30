#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <conio.h>

#define F 3
#define C 2

using namespace std;

int main(){
	
	int matriz[F][C], i, j, vector[F]={0,0,0,};
	
	for(i=0; i<F; i++){
		for(j=0; j<C; j++){
			printf("Ingrese el elemento F=%d y Columna=%d de la matriz:\n", i,j);
			scanf("%d", &matriz[i][j]);
			vector[i]=vector[i]+matriz[i][j];
		}
	}
	printf("\nLa matriz generada es: \n");
	for(i=0; i<F; i++){
		for(j=0; j<C; j++){
			printf("*%d*", matriz[i][j]);
		}
		printf("\n");
	}
	printf("\nY el vector suma de las filas es: \n");
	for (i=0; i<F; i++){
		printf("%d\t", vector[i]);
		printf("\n\n");
	}
	
	system("PAUSE");
	return 0;
}

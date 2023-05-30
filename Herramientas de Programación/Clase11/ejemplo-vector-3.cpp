#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#define N 5

int suma (int[N]);
void mayor (int[N]);

int main(){
	int numeros[N], i, j, l, limite;
	
	for(i=0; i<N; i++){
		printf("Ingrese el elemento %d del vector:\n", i+1);
		carga:
			scanf("%d", &numeros[i]);
			
			int n=numeros[i];
			limite=i;
			int a=1,b=0;
			if (i>=1){
				do {
					for(j=0;j<limite;j++){
						if(numeros[j]==n){
							printf("El numero %d esta repetido por favor ingrese uno nuevo para %d:\n",n,i+1);
							b=1;
							scanf("%d", &n);
						} else {
							b=0;
							numeros[i]=n;
						}
					}
				} while (a==b);
			}
	}
	
	printf("La suma de todos los elementos del vector es: %d\n", suma(numeros));
	mayor(numeros);
	system("PAUSE");
	return 0;
}

int suma (int numeros[N]){
	int sum=0, i;
	for (i=0; i<N; i++){
		sum=sum+numeros[i];
	}
	return(sum);
}

void mayor (int numeros[N]){
	int pos=0, mayor=numeros[0], i;
	for (i=1; i<N; i++){
		if (numeros[i]>mayor){
			mayor=numeros[i];
			pos=i;
		}		
	}
	printf("El valor mayor es %d y esta en la posicion %d\n\n", mayor, pos+1);
}

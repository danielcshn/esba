#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

#define N 5

int main(){
	
	int x[N];
	int i, rand_int, rand_sig;
	
	srand(time(0)+1);
	
	for (i=0; i<N; i++) {
		rand_int = rand()%100;
		rand_sig = (rand()%2);
		
		if (rand_sig==0){
			rand_int=-rand_int;
		}
		
		x[i]=rand_int;
		printf("El valor %d es: %d\n\n", i+1,x[i]);
	}
	
	printf("\n\n");
	
	for (i=0; i<N; i++) {
		if(x[i]>0){
			printf("La %d posicion es POSITIVA\n\n", i+1);
		}else{
			printf("La %d posicion es NEGATIVA\n\n", i+1);
		}
	}
	
	printf("\n\n");
	
	system("PAUSE");
	return 0;
}

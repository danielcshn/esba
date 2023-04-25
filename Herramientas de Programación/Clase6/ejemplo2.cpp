#include <stdio.h>
#include <stdlib.h>

int main() {
	int x;
	
	for(x=1; x<=100; x=x+9){
		printf("%d \t", x);
	}
	
	printf("\n Fin del programa \n");
	system("PAUSE");
	
	return 0;
}

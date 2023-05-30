#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main(){
	int i, j;
	int mult[10][10];
	
	for (i=1;i<10;i++) {
		for (j=1;j<10;j++) {
			mult[i][j] = i*j;
			printf("%d \t", mult[i][j]);
		}
		printf("\n");
	}
	printf("\n");
	system("PAUSE");
	return 0;
}

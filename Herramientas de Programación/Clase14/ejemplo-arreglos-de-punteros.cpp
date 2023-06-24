#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <time.h>
#include <fstream>

using namespace std;

int main(){
	int x;
	char *mes[] = {"mes ilegal", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"};
	
	srand(time(NULL));
	x = rand()%12;
	printf("El mes %d corresponde a %s \n", x, mes[x]);
	system("PAUSE");
	return 0;
}

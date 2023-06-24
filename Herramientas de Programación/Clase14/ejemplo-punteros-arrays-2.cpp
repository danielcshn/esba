#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

main(){
	static int lista[] = {24,30,15,45,34};
	int ind;
	
	int *plista = &lista[0];
	for (ind = 0; ind < 5; ind++) {
		printf("%d ", *(plista+ind));
		printf("\n");
	}
	
	system("PAUSE");
}

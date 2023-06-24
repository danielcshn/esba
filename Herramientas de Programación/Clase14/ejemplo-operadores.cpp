#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main(){
	int a = 10, b, *p, *q;
	q = &a;
	b = *q;
	
	*p = 20; /* ERROR */
	
	printf("En la dirección %.4X esta el dato %d \n", q, b);
	printf("En la dirección %.4X esta en el dato %d \n", p, *p);
	
	system("PAUSE");
	return 0;
}

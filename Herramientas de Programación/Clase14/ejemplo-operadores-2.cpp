#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main(){
	int a = 10, b, *p, *q, c = 20;
	
	q = &a;
	
	b = *q;
	
	p = &c; /* ERROR */
	
	printf("En la dirección %.4X esta el dato %d \n", q, b);
	printf("En la dirección %.4X esta en el dato %d \n", p, *p);
	
	system("PAUSE");
	return 0;
}

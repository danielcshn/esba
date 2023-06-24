#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

main(){
	int a = 10, *p, *q;
	
	p = &a;
	q = p;
	
	printf("En la dirección %.4X esta el dato %d \n", p, *p);
	printf("En la dirección %.4X esta en el dato %d \n", q, *q);
	
	system("PAUSE");
}

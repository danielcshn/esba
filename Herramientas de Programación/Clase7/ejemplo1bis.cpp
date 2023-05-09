#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

main(){
	char car = 's';
	int a=0, b=0, c=0, d=0;
	
	do{
		printf("Ingrese un valor:  ");
		scanf("%d", &a);
		printf("Ingrese un valor:  ");
		scanf("%d", &b);
		printf("Ingrese un valor:  ");
		scanf("%d", &c);
		
		d=a+b+c;
		printf("El total de los valores %d + %d + %d es: %d \n\n",a,b,c,d);
		
		printf("Desea continuar? ingrese si(s) o no(n): ");
		
		cin>>car;
		
		while(car != 's' && car !='n'){
			printf("\n Por favor ingrese s/n (si o no): ");
			cin>>car;
		}
	}while(car=='s');
	
	system("PAUSE");
	return 0;
}

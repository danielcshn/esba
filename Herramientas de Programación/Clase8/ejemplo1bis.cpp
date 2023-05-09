#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

int main(){
	char cont;
	int a,b,c,min,max,op,SUMA,RESTA;
	
	printf("INTRODUZCA EL PRIMER NUMERO: ");
	scanf("%d", &a);
	printf("\nINTRODUZCA EL SEGUNDO NUMERO: ");
	scanf("%d", &b);
	system("cls");
	
	menu:
		cout<<"\n <-<-<- MENU ->->->";
		cout<<"\n s -> SUMA A+B";
		cout<<"\n r -> RESTA A-B";
		cout<<"\n\n ELIJA SU OPCIÓN ===> ";
		
		cin>>cont;
		system("cls");
		
	switch(cont){
		case 's': 
			SUMA = a+b;
			printf("LA SUMA ES: %d \n\n", SUMA);
			break;
		case 'r':
			RESTA = a-b;
			printf("LA RESTA ES: %d \n\n", RESTA);
			break;
		default:
			 printf("''%d'' NO es una opcion valida presione 1 o 2", cont);
			 goto menu;
	}
}

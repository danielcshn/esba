#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

int main(){
	string sele;
	int a,b,c,min,max,op,SUMA,RESTA;
	
	printf("INTRODUZCA EL PRIMER NUMERO: ");
	scanf("%d", &a);
	printf("\nINTRODUZCA EL SEGUNDO NUMERO: ");
	scanf("%d", &b);
	system("cls");
	
	menu:
		cout<<"\n <-<-<- MENU ->->->";
		cout<<"\n  SUMA A+B";
		cout<<"\n  RESTA A-B";
		cout<<"\n\n ELIJA SU OPCIÓN ===> ";
		cin>>sele;
		
		enum cont{invalido,suma,resta};
		cont sel;
		
		if(sele=="suma"){
			sel=suma;
		} else if (sele=="resta") {
			sel=resta;
		} else {
			sel=invalido;
		}
		
	system("cls");
	
	switch(sel){
		case 1: 
			SUMA = a+b;
			printf("LA SUMA ES: %d \n\n", SUMA);
			break;
		case 2:
			RESTA = a-b;
			printf("LA RESTA ES: %d \n\n", RESTA);
			break;
		default:
			 printf("NO es una opcion validad, escriba suma o resta");
			 goto menu;
	}	
	
	system("PAUSE");
}

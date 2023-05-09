#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

int main(){
	char letra;
	
	let:
		printf("INTRODUZCA UNA LETRA: ");
		scanf("%c",&letra);
		system("cls");
		
	switch(letra){
		case 'a': case 'A':
			printf("Ha escrito la letra %c de Aguila \n\n", letra);
			break;
		case 'b': case 'B':
			printf("Ha escrito la letra %c de Bueno \n\n", letra);
			break;
		default:
			printf("NO es una opcion valida escriba otra letra: \n\n");
			goto let;
	}
	
	system("PAUSE");
}

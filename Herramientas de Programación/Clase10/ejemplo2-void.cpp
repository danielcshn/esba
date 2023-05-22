#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

using namespace std;

void asteriscos();

main(){
	int contco, contdp, contot;
	char d,c='s';
	contco = 0;
	contdp = 0;
	contot = 0;
	
	while(c != 'n'){
		printf("Ingrese el , : o caracter: \n");
		cin >> d;
		switch (d){
			case ',':
				contco++;
				break;
			case ':':
				contdp++;
				break;
			default:
				contot++;
		}
		printf("Desea continuar? ");
		cin >> c;
	}
	
	asteriscos();
	cout << "\n Cantidad de comas: " << contco;
	asteriscos();
	cout << "\n Cantidad de dos puntos: " << contdp;
	asteriscos();
	cout << "\n Cantidad de otros caracteres: " << contot;
	asteriscos();
	
	system("PAUSE");
}

void asteriscos(){
	cout << "\n";
	for (int j = 0; j < 40; j++){
		cout << "*";
		cout << "\n";
	}
}

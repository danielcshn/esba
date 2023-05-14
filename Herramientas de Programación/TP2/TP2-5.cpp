#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <algorithm>

using namespace std;

///////////////////////////////////////////////////
// Muestro nombres de Integrantes del Grupo

nameDisplay(){
	// Cambio color texto consola a verde
	HANDLE hConsole;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 2);
	// Muestro Integrantes
	string integrantes[] = {"Matias X", "Juan X", "Fabian X", "Maximiliano X", "Geraldine X", "Daniel X", "Sergio X", "SergioX X", "Santiago X", "Veronica X"};
	printf(" EQUIPO B N\370 2\n\n");
	for (int i = 0; i < 10; i++){
        cout << " - " << integrantes[i] << endl;
    }
    printf("\n\n");
    // Cambio color texto consola a blanco
    SetConsoleTextAttribute(hConsole, 15);
}

///////////////////////////////////////////////////
// Ejercicio 5:
// El programa debe realizar exactamente lo mismo que el ejercicio 4 pero 
// esta vez antes de terminar debe preguntar si “Desea volver a cargar números:” 
// esta vez en caso de que la respuesta sea “s” o “si” volver a cargar los números 
// y en caso de que sea “n” o “no” terminar el programa, para cualquier otro valor 
// deberá informar que la respuesta ingresada es incorrecta y que el usuario debe
// escribir “s/si” o “n/no”.


int main(){
	nameDisplay();
	
	string resp;
	int valor1=0, valor2=0, suma12=0;
	bool pasa1=true, pasa2=true, pasa3=true;

	do{
		pasa1=true;
		do{
			printf("\nIngrese un primer valor:  ");
			scanf("%d", &valor1);
			
			if ((valor1 % 2 == 0) && valor1 > 0 ) {
				pasa1 = false;
			}
			
		}while( pasa1 );
		
		pasa2=true;
		do{
			printf("\nIngrese un segundo valor:  ");
			scanf("%d", &valor2);
			
			if ((valor2 % 2 == 0) && valor2 > 0 ) {
				pasa2 = false;
			}
			
		}while( pasa2 );
				
		suma12=valor1+valor2;
		cout << "\nEl valor de la suma es : " << valor1 << " + " << valor2 << " = " << suma12 << endl; 
		
		valor1=0, valor2=0, suma12=0;
		pasa1=true, pasa2=true;
		
		printf("\nDesea volver a cargar numeros? ingrese s/si o n/no: ");
		
		cin>>resp;
		
		while(resp != "s" && resp != "si" && resp != "n" && resp != "no"){
			printf("\n Por favor ingrese s/si o n/no: ");
			cin>>resp;
		}
	}while(resp == "si" || resp == "s");
	
	system("PAUSE");
	cin.ignore();
	return 0;
}

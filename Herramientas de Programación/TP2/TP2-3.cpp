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
// Ejercicio 3:
// Teniendo en cuenta el ejemplo 2 de la clase FOR; realizar un programa que 
// me solicite con scanf o cin el ingreso de un numero comprobando con do while
// que este sea >0 y <60 caso contrario deberá volver a ingresar el número, y a
// partir de este número ingresado que el programa realice una cuenta regresiva.

int main(){
	vuelve:
		nameDisplay();
	
		// ingrese numero
		int numero;
		string resp;
		do{
			cout << "Ingrese un numero: " << endl;
			cin >> numero;
		}while( (numero <= 0) || (numero >= 60) );
	
		// cuenta regresiva 
		cout << "\n\nCuenta regresiva: \n" << endl;
		for (int i = numero; i >= 0; i--) {
    	    cout << i << endl;
    	}
    
    	cout << "\n\nQuiere volver a ingresar un numero? (Responde s/si para si o n/no para no)" << endl;
		cin >> resp;
		if (resp == "s" || resp == "S" || resp == "Si" || resp == "SI") {
			system("cls");
			goto vuelve;
		}

	system("PAUSE");
	cin.ignore();
	return 0;
}

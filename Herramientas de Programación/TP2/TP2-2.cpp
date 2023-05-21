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
	string integrantes[] = {"Matias X", "Juan X", "Walter X", "Maximiliano X", "Geraldine X", "Daniel X", "Sergio X", "Veronica X", "Olga X"};
	printf(" EQUIPO B N\370 2\n\n");
	for (int i = 0; i < 9; i++){
        cout << " - " << integrantes[i] << endl;
    }
    printf("\n\n");
    // Cambio color texto consola a blanco
    SetConsoleTextAttribute(hConsole, 15);
}

///////////////////////////////////////////////////
// Ejercicio 2:
// Teniendo en cuenta el ejemplo 1 de la clase FOR, realizar un programa que 
// permita ingresar una cantidad X de ciclos utilizando scanf o cin 
// (por ejemplo 20) y ver los números impares dentro de esa cantidad de números.

int main(){
	vuelve: 
		nameDisplay();
	
		int ciclos;
		string resp;
		cout << "Ingrese una cantidad X de ciclos: " << endl;
		cin >> ciclos;
	
		for(int i=0;i<=ciclos;i++){
			if (i % 2 == 0) {
				cout << i << " >>" << " es par" << endl;
			} else {
				cout << i << " >>" << " NO es par" << endl;
			}
		}

		cout << "\n\nQuiere Ingresar otra cantidad de ciclos? (Responde s/si para si o n/no para no)" << endl;
		cin >> resp;
		transform(resp.begin(), resp.end(), resp.begin(), ::tolower);
		if (resp == "s" || resp == "si") {
			system("cls");
			goto vuelve;
		}

	system("PAUSE");
	cin.ignore();
	return 0;
}

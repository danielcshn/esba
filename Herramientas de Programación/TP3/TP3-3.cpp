//#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <string>
#include <limits>
//#include <algorithm>

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
// Teniendo en cuenta el ejemplo 2 de CONTINUE; realizar un programa que
// solicite ingresar 4 números para luego mostrarlos por pantalla, si alguno
// de los números ingresados es = 0 entonces realiza un CONTINUE y muestra los
// demás valores y luego me muestra por pantalla cuantos 0 habia en mis ingresos.

// Ej: ingreso 4 0 2 0 à entonces se muestra por pantalla los numeros ingresados 
// 4 / 2 y muestra un texto que dice “en los ingresos habían 2 ceros”.


int main(){
	nameDisplay();
	
	int numeros[4];
	int countCeros = 0;
	
	for (int i = 0; i < 4; i++) {
		cout << "\nIngrese numeros: " << i+1 << "/4: \n";
		cin >> numeros[i];
		
		if (numeros[i] == 0) {
			countCeros = countCeros+1;
			continue;
		}
	}
	
	cout << "\nLos numeros ingresados son: \n";
	for (int i=0; i < 4; i++) {
		if (numeros[i] != 0) {
			cout << numeros[i] << " ";
		}
	}
	
	cout << "\n\nSe encontraron " << countCeros << " de ceros.\n";
	
    return 0;
}

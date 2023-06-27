#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <vector>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <cstdlib>
#include <ctime>

using namespace std;

///////////////////////////////////////////////////
// Muestro nombres de Integrantes del Grupo

nameDisplay(){
	// Cambio color texto consola a verde
	HANDLE hConsole;
	hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hConsole, 2);
	// Muestro Integrantes
	string integrantes[] = {"Matias X", "Juan X", "Maximiliano X", "Geraldine X", "Daniel X", "Sergio X", "Veronica X", "Olga X"};
	printf(" EQUIPO B N\370 2\n\n");
	for (int i = 0; i < 8; i++){
        cout << " - " << integrantes[i] << endl;
    }
    printf("\n\n");
    // Cambio color texto consola a blanco
    SetConsoleTextAttribute(hConsole, 15);
}

///////////////////////////////////////////////////
// Mezclar
void mezclar(int vectorOriginal[], int vectorAuxiliar[]) {
    int indices[3] = {0, 1, 2}; // Índices originales
    int numIndices = 3;

    for (int i = 0; i < 3; i++) {
        int randomIndex = std::rand() % numIndices; // Generar índice aleatorio

        vectorAuxiliar[i] = vectorOriginal[indices[randomIndex]];

        // Intercambiar el índice usado con el último índice válido
        indices[randomIndex] = indices[numIndices - 1];
        numIndices--;
    }
}

///////////////////////////////////////////////////
// Valida numero
bool validarNumero(int numero) {
    return numero >= 1 && numero <=3;
}

///////////////////////////////////////////////////
// Valida posicion
bool validarPosicion(int posicion) {
    return posicion >= 0 && posicion < 3;
}


int main(){
	
	nameDisplay();
	
	// Vector Cargado
	int numeros[] = {1, 2, 3};
    int mezclados[3];
    string respuesta;
    
    std::srand(std::time(0));
    
	do {
		mezclar(numeros, mezclados);
		
    	int numero, posicion;
    	cout << "\nPor favor ingrese un NUMERO: ";
   		cin >> numero;

    	// Validar si se ingresó un número válido
    	while (!validarNumero(numero)) {
    	    cout << "\nHa ingresado un numero invalido. Coloque 1, 2 o 3.\n" << endl;
    	    cout << "Por favor ingrese un NUMERO: ";
    	    cin >> numero;
    	}

    	cout << "\nPor favor ingrese una POSICION: ";
    	cin >> posicion;

    	// Validar si se ingresó una posición válida
    	while (!validarPosicion(posicion)) {
    	    cout << "\nHa ingresado una posicion inexistente. Por favor digite 0, 1 o 2\n" << endl;
    	    cout << "Por favor ingrese una POSICION: ";
    	    cin >> posicion;
    	}

    	if (mezclados[posicion] == numero) {
    	    cout << "\nACERTO!" << endl;
    	} else {
    	    cout << "\nEl NUMERO " << numero << " esta en la POSICION " << mezclados[posicion] << endl;
    	}

        // Preguntar si desea jugar de nuevo
        do {
            cout << "\nDeseas volver a jugar? (si/no): ";
            cin >> respuesta;

            if (respuesta == "si" || respuesta == "SI") {
                // Reordenar números
                std::srand(std::time(0));
                mezclar(numeros, mezclados);
            } else if (respuesta != "no" && respuesta != "NO") {
                cout << "La respuesta ingresada es incorrecta. Por favor, escriba si/SI o no/NO." << endl;
            }
        } while (respuesta != "si" && respuesta != "SI" && respuesta != "no" && respuesta != "NO");

	} while (respuesta == "si" || respuesta == "SI");

    cout << "\nGracias por JUGAR!\n" << endl;
    
    system("PAUSE");
	return 0;
}

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
// Teniendo en cuenta el ejemplo de la clase SWITCH 2, realizar un programa 
// que muestre un menú y permita ingresar una letra de la “a” a la “d” y según 
// la letra ingresada mostrar por pantalla una palabra que comience con esa letra, 
// si es cualquier otra letra por DEFAULT se debe ver un mensaje que diga “La letra 
// X(siendo esta la letra ingresada) no es letra habilitada, por favor ingrese a,b,c 
// o d” y vuelva a permitir el ingreso correcto de la letra.
//
// Una vez finalizada la visualización de la palabra,  el programa debe preguntar 
// “Desea volver a ingresar una letra” si la respuesta es s/si se debe volver al 
// menú switch si se ingresa n/no se termina el programa.

int main(){
	nameDisplay();
	
    char letra;
    char respuesta;

    do {
		cout << "\nIngrese una letra (a, b, c, d) para ver una palabra: ";
        cin >> letra;

        switch (letra) {
            case 'a':
                cout << "\nActivo\n" << endl;
                break;
            case 'b':
                cout << "\nBiblia\n" << endl;
                break;
            case 'c':
                cout << "\nCasa\n" << endl;
                break;
            case 'd':
                cout << "\nDedo\n" << endl;
                break;
            default:
                cout << "\nLa letra " << letra << " no es una letra habilitada. Por favor, ingrese a, b, c o d.\n" << endl;
        }
        
        //cin.clear();
        //cin.ignore(numeric_limits<streamsize>::max(), '\n');

        cout << "Desea volver a ingresar una letra? (s/n): ";
        cin.ignore(); // Ignorar cualquier caracter residual en el buffer
        respuesta = cin.get();

        while (respuesta != 's' && respuesta != 'n') {
            cout << "\nRespuesta invalida. Por favor, ingrese 's' (si) o 'n' (no): ";
            cin.ignore();
            respuesta = cin.get();
        }
        
    } while (respuesta == 's');

    return 0;
}

#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <string>
#include <algorithm>
#include <cctype>

using namespace std;

int paso1();

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
// Contador de VOCALES (PASO 1)

int paso1(const std::string& str) {
    int c1 = 0;
    for (string::size_type i = 0; i < str.length(); i++) {
        char cl = std::tolower(str[i]);
        if (cl == 'a' || cl == 'e' || cl == 'i' || cl == 'o' || cl == 'u') {
            c1++;
        }
    }
    return c1;
}

///////////////////////////////////////////////////
// Contador de CONSONANTES (PASO 2)

int paso2(const std::string& str) {
    int c2 = 0;
    for (string::size_type i = 0; i < str.length(); i++) {
        char cl = std::tolower(str[i]);
        if (cl >= 'a' && cl <= 'z' && cl != 'a' && cl != 'e' && cl != 'i' && cl != 'o' && cl != 'u') {
            c2++;
        }
    }
    return c2;
}

///////////////////////////////////////////////////
// Contar NUMEROS. (PASO 3)

int paso3(const std::string& str) {
    int c3 = 0;
    for (std::string::size_type i = 0; i < str.length(); i++) {
        if (std::isdigit(str[i])) {
            c3++;
        }
    }
    return c3;
}

///////////////////////////////////////////////////
// Teniendo en cuenta el ejemplo switch 1 de la clase 8 realizar un programa 
// que permita ingresar una frase STRING, una vez realizado esto que se muestre 
// un menú SWITCH para: contar vocales, consonantes o números dentro de la frase, 
// utilizando un if para que finalmente se muestren una vez seleccionado el ítem 
// del menú.

main(){
	nameDisplay();
	
	string textofrase;
	cout << "Introduzca un Texto:" << endl;
	cin >> textofrase;
	
	int menuint, cVocales, cConsonantes, cNumeros;
	
	menu:
		cout<<"\n-----Menu------";
		cout<<"\n1) Contar VOCALES.";
		cout<<"\n2) Contar CONSONANTES.";
		cout<<"\n3) Contar NUMEROS.";
		cout<<"\n\nElija su opcion ===> ";
		cin>>menuint;
	
	system("cls");
	
	switch(menuint){
		case 1: 
			// Contar VOCALES.
			cout<<"\nEl texto ingresado es: " << textofrase << "\n" << endl;
			cVocales = paso1(textofrase);
			cout<<"\nCuenta con: " << cVocales << " VOCALES\n" << endl;
			break;
		case 2:
			// Contar CONSONANTES.
			cout<<"\nEl texto ingresado es: " << textofrase << "\n" << endl;
			cConsonantes = paso2(textofrase);
			cout<<"\nCuenta con: " << cConsonantes << " CONSONANTES\n" << endl;
			break;
		case 3:
			// Contar NUMEROS.
			cout<<"\nEl texto ingresado es: " << textofrase << "\n" << endl;
			cNumeros = paso3(textofrase);
			cout<<"\nCuenta con: " << cNumeros << " NUMEROS\n" << endl;
			break;
		default:
			 printf("\nEl ingreso es incorrecto por favor seleccione la opcion 1 a 3.\n\n");
			 goto menu;
	}	
	
}


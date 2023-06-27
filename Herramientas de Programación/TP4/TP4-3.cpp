#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <string>
#include <algorithm>
#include <cctype>
#include <stdlib.h>
#include <time.h>
#include <cstdlib>
#include <ctime>

#include <iostream>
#include <fstream>
#include <cstring>

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
// Estructura de Persona
struct Persona {
    int DNI;
    char NombreyApellido[65];
};

///////////////////////////////////////////////////
// Ingreso de Datos:
void ingresarDatos(Persona& persona) {
    cout << "Ingrese el DNI: ";
    cin >> persona.DNI;

    cout << "Ingrese el Nombre y Apellido: ";
    cin.ignore();
    cin.getline(persona.NombreyApellido, 65);
}

///////////////////////////////////////////////////
// Guardado de datos:
void guardarDatos(const Persona& persona, ofstream& archivo) {
    archivo << persona.DNI << endl;
    archivo << persona.NombreyApellido << endl;
}

///////////////////////////////////////////////////
// Busqueda de Persona:
void buscarPersona(int dniBuscado, ifstream& archivo) {
    Persona persona;

    while (!archivo.eof()) {
        archivo >> persona.DNI;
        archivo.ignore();
        archivo.getline(persona.NombreyApellido, 65);

        if (persona.DNI == dniBuscado) {
            cout << "El DNI " << dniBuscado << " pertenece a: " << persona.NombreyApellido << endl;
            return;
        }
    }

    cout << "El DNI " << dniBuscado << " no se encontró en el archivo." << endl;
}

int main(){
	
	nameDisplay();
	
    ofstream archivoSalida("DATOS.txt", ios::app);
    
    if (!archivoSalida) {
        cout << "No se pudo abrir el archivo DATOS.txt" << endl;
        return 1;
    }

    string opcion;
    Persona persona;

    do {
		cout << "Que desea hacer? (ingresar/buscar/terminar): ";
		cin >> opcion;

        if (opcion == "ingresar") {
            ingresarDatos(persona);
            guardarDatos(persona, archivoSalida);
        } else if (opcion == "buscar") {
            ifstream archivoEntrada("DATOS.txt");
                
            if (!archivoEntrada) {
                cout << "No se pudo abrir el archivo DATOS.txt" << endl;
                return 1;
            }

            int dniBuscado;
            cout << "Ingrese el DNI a buscar: ";
            cin >> dniBuscado;

            buscarPersona(dniBuscado, archivoEntrada);
            archivoEntrada.close();
        } else if (opcion == "terminar") {
        	cout << "Saliendo del programa..." << endl;
            break;
        } else {
            cout << "El ingreso es incorrecto. Por favor, escriba 'buscar', 'ingresar' o 'terminar'." << endl;
        }

        cout << endl;

    } while (true);

    archivoSalida.close();

	return 0;
}

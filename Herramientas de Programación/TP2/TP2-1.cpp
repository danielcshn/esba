#include <stdio.h>
#include <windows.h>
#include <iostream>
#include <string>
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
// Ejercicio 1:
// Teniendo en cuenta el ejemplo completo de la clase IF (último ejemplo), 
// realizar un programa que permita ingresar NOMBRE y APELLIDO. Si el nombre 
// y apellido corresponde a alguien del grupo debe mostrar por pantalla el 
// mensaje “Esta persona es parte del grupo X”. Caso contrario debe mostrar 
// “Esta persona NO pertenece al grupo X”.

int main(){
	vuelve:
		nameDisplay();
	
		string nombre, apellido, resp;
		const char* inte[10] = {"matias x", "juan x", "fabian x", "maximiliano x", "geraldine x", "daniel x", "sergio x", "sergio2 x", "santiago x", "vero x"};

		cout << "Ingrese un nombre: " << endl;
		cin >> nombre;
		cout << "Ingrese un apellido: " << endl;
		cin >> apellido;
	
		string mc = nombre + " " + apellido;
		transform(mc.begin(), mc.end(), mc.begin(), ::tolower);

		if ((mc == inte[0]) || (mc == inte[1]) || (mc == inte[2]) || (mc == inte[3]) || (mc == inte[4]) || (mc == inte[5]) || (mc == inte[6]) || (mc == inte[7]) || (mc == inte[8]) || (mc == inte[9])){
			cout << "\n>> Esta persona es parte del grupo 2" << endl;
		} else {
			cout << "\n>> Esta persona NO pertenece al grupo 2" << endl;
		}

	cout << "\n\nQuiere Buscar a otro nombre / apellido? (Responde s/si para si o n/no para no)" << endl;
	cin >> resp;
	if (resp == "s" || resp == "S" || resp == "Si" || resp == "SI") {
		system("cls");
		goto vuelve;
	}

	system("PAUSE");
	cin.ignore();
	return 0;
}


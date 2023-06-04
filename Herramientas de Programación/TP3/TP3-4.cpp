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
// Realizar un programa que permita ingresar 2 valores y luego mostrar por pantalla 
// un menú switch que permita ingresar a:
// 
// -----Menu------
// 1) SUMAR.
// 2) RESTAR.
// 3) MULTIPLICAR.
// 4) DIVIDIR.
// 
// Elija su opcion
// 
// Cualquier otra opción distinta de 1/2/3/4 por default debe mostrar por pantalla 
// un mensaje que diga “El ingreso es incorrecto por favor seleccione la opción 1 a 4”.
// 
// Si entramos a SUMAR se debe mostrar por pantalla la suma de los 2 valores 
// ingresados al principio ej suma= A+B;.
// 
// Una vez finalizada la ecuación aritmética seleccionada el programa debe mostrar 
// un mensaje “Desea volver a operar?” si la respuesta es “menú” entonces goto MENU 
// y vuelve a mostrar las opciones del menú, si la respuesta es “ingresar” entonces 
// goto INGRESO donde se volverán a asignar valores a A y B, o finalmente si la 
// respuesta es “salir” se termina el programa.
// 
// Cualquier otra respuesta el programa debe mostrar un mensaje que diga 
// “ La respuesta ingresada es incorrecta por favor ingrese menu / ingresar / salir”.

int main(){
	nameDisplay();
	
	int valor1, valor2, seleccion;
	string resp;
	
	INGRESO:
		cout << "Ingrese el primer valor: " << endl;
		cin >> valor1;
		cout << "Ingrese el segundo valor: " << endl;
		cin >> valor2;
		
	MENU:
		cout << "\n\n-----Menu------" << endl;
		cout << "1) SUMAR." << endl;
		cout << "2) RESTAR." << endl;
		cout << "3) MULTIPLICAR." << endl;
		cout << "4) DIVIDIR.\n" << endl;
		cout << "Elija su opcion: ";
	    cin >> seleccion;
		
		// Seleccion
		switch (seleccion) {
			case 1:
				cout << "\nSuma = " << valor1 << "+" << valor2 << " = " << valor1 + valor2 << "\n" << endl;
				break;
			case 2:
				cout << "\nResta = " << valor1 << "-" << valor2 << " = " << valor1 - valor2 << "\n" << endl;
				break;
	        case 3:
				cout << "\nMultiplicacion = " << valor1 << "*" << valor2 << " = " << valor1 * valor2 << "\n" << endl;
				break;
			case 4:
				if (valor2 != 0) {
					cout << "\nDivision = " << valor1 << "/" << valor2 << " = " << valor1 / valor2 << "\n" << endl;
				} else {
					cout << "\nNo se puede dividir entre cero." << "\n" << endl;
				}
				break;
			default:
				cout << "\nEl ingreso es incorrecto por favor seleccione la opción 1 a 4.\n" << endl;
				break;
	    }
	    
	    OPERAR:
			// pregunta
    		cout << "Desea volver a operar? (menu/ingresar/salir): ";
    		cin >> resp;

        	if (resp == "menu") {
        		goto MENU;
    		} else if (resp == "ingresar") {
        		goto INGRESO;
    		} else if (resp == "salir") {
        		cout << "Programa finalizado." << endl;
    		} else {
				cout << "La respuesta ingresada es incorrecta. Por favor, ingrese menu/ingresar/salir." << endl;
				goto OPERAR;
    		}
    
    return 0;
}

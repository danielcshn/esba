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

// Se solicita la creación de un programa que permita ingresar a una matriz de 3 x 2, 2 datos en distintas coordenadas, 
// por ejemplo número del 7 en todos las demás espacios matriciales colocare un  “0” (dato: iniciar la matriz con 0 y 
// luego colocar los números 7 en las distintos espacios de la matriz), finalmente voy a tener 3 chances para elegir 
// distintas coordenadas si hay un numero 7 voy a “ACERTAR” y no voy a perder chances pero si hay un 0 voy a perder 
// una chance “AGUA”.

// Voy a ganar el juego si acierto a los a los 2 números 7 o voy a perder si se me acaban las chances de igual forma 
// debe aparecer un cartel luego de seleccionar cada tiro instruyéndome sobre esta situación “HA ACERTADO” “AGUA” 
// “SE LE HAN TERMINADO LAS CHANCES”, al finalizar el juego puedo seleccionar si quiero jugar de nuevo con un “si” 
// y con un “no” acabar el juego, con cualquier otro ingreso de respuesta debe solicitar que vuelva a ingresar “si o no”.

///////////////////////////////////////////////////
// Inicia Matriz en Cero:
void InicioMatriz(int matriz[3][2]) {
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matriz[i][j] = 0;
        }
    }
}

///////////////////////////////////////////////////
// Mostrar Matriz (debug):
void VerMatriz(int matriz[3][2]) {
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            cout << matriz[i][j] << " ";
        }
        cout << endl;
    }
}

int main(){
	nameDisplay();
	
	// Defino matriz
	int m[3][2];
	// Cargo matriz con ceros
    InicioMatriz(m);
	
	// Variable contador de ingresos, max. 2.
	int cont = 0;
	
	// Ingreso 2 datos maximo a la matriz manualmente.
    while (cont < 2) {
    	int fila, columna = 0;
        cout << "Ingrese la posicion en la que desea cargar el numero 7 (ejemplo: 0 1 / fila columna): ";
        cin >> fila >> columna;

        // Verificar si la posición es válida
        if (fila >= 0 && fila < 3 && columna >= 0 && columna < 2) {
            // Verificar si la posición está vacía
            if (m[fila][columna] == 0) {
                m[fila][columna] = 7;
                cont++;
                cout << "Numero 7 cargado en la posicion [" << fila << "][" << columna << "].\n" << endl;
            } else {
                cout << "Ya hay un 7 en la posicion. Por favor, ingrese otra posicion.\n" << endl;
            }
        } else {
            cout << "\nPosicion invalida. Por favor, ingrese una posicion valida 3x2.\n" << endl;
            cout << "Combinaciones posibles: 0 0, 0 1, 1 0, 1 1, 2 0 y 2 1.\n\n" << endl;
        }
    }
	
	string respuesta;
	
	do {
	
	// Cantidad max. oportunidades
    const int maxOportunidades = 3;
    int oportunidades = maxOportunidades;
    int contador = 0;
    int acertado, agua = 0;
	
	// Inicia Juego
    while (contador < 2 && oportunidades > 0) {
    	cout << "---------------" << endl;
        cout << "\nOportunidades restantes: " << oportunidades << endl;
        cout << "HA ACERTADO: " << acertado << endl;
        cout << "AGUA: " << agua << endl;
        cout << "\n---------------\n" << endl;
        int fila, columna = 0;
        cout << "Ingrese la posicion en la que cree que esta el numero 7 (ejemplo: fila columna): ";
        cin >> fila >> columna;

        // Verificar si la posición es válida
        if (fila >= 0 && fila < 3 && columna >= 0 && columna < 2) {
            // Verificar si la posición ya tiene un 7
            if (m[fila][columna] == 7) {
                cout << "ACERTASTE!" << endl;
                contador++;
                acertado++;
            } else {
                cout << "AGUA! Perdiste una chanse." << endl;
                oportunidades--;
                agua++;
            }
        } 
        // Posición inválida
        else {
            cout << "\nPosicion invalida. Por favor, ingrese una posicion valida 3x2.\n" << endl;
            cout << "Combinaciones posibles: 0 0, 0 1, 1 0, 1 1, 2 0 y 2 1.\n\n" << endl;
        }
    }

    // Mostrar el resultado del juego
    if (contador == 2) {
        cout << "\nHA ACERTADO! Has ganado el juego.\n" << endl;
    } else {
        cout << "\nSE LE HAN TERMINADO LAS CHANCES! Has perdido el juego.\n" << endl;
    }


		// Preguntar si desea jugar de nuevo
        do {
            cout << "¿Deseas jugar de nuevo? (si/no): ";
            cin >> respuesta;
        } while (respuesta != "si" && respuesta != "no");

    } while (respuesta == "si");
	
	return 0;
}

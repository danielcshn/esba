#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main() {
	
	char linea[128];
	long contador = 0L;
	ifstream archivo("Pruebas.txt");
	if(archivo.fail()){
		cout << "No se encontro el archivo: Pruebas.txt" << endl;
	} else {
		
		while(!archivo.eof()){
			archivo.getline(linea, sizeof(linea));
			cout << linea << endl;
			if ((++contador % 24) == 0){
				cout << "Continua...";
				cin.get();
			}
		}
	}
	archivo.close();
	
	ofstream arch;
	arch.open("Pruebas.txt");
	arch << "CREE EL ARCHIVO" << endl;
	arch << " A LA SALIDA " << endl;
	arch.close();
	
	system("PAUSE");
	return 0;
}

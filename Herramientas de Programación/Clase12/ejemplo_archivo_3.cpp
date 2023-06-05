#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main() {

	ofstream archivo;
	archivo.open("datos.txt");
	archivo << "Ahora cambie " << endl;
	archivo << "lo que habia escrito " << endl;
	archivo << "en el archivo datos.txt" << endl;
	archivo.close();
	
	char cadena[128];
	long fin=0L;
	ifstream archivo1("datos.txt");
	if (archivo1.fail()){
		cout << "\nEl archivo no se pudo abrir. " << endl;
		system("PAUSE");
		exit(1);
	}
	
	while(!archivo1.eof()){
		archivo1.getline(cadena, sizeof(cadena));
		cout << cadena << endl;
		if((++fin %24) == 0){
			cout << "Siguiente linea -->";
			cin.get();
		}
	}
	
	system("PAUSE");
	return 0;
}

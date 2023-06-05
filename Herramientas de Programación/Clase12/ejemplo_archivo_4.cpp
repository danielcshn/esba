#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main() {

	ofstream archivo;
	archivo.open("datos.txt", ios::app);
	archivo << "Pero si utilizo " << endl;
	archivo << " ios:app " << endl;
	archivo << "puedo agregar datos" << endl;
	archivo.close();
	
	char cadena[128];
	long fin=0L;
	ifstream archivo1("datos.txt");
	if (archivo1.fail()){
		cout << "\nEl archivo no s epudo abrir." << endl;
		system("PAUSE");
		exit(1);
	}
	
	while(!archivo1.eof()){
		archivo1.getline(cadena, sizeof(cadena));
		cout << cadena << endl;
		if ((++fin %24)==0){
			cout << "Siguiente linea -->";
			cin.get();
		}
	}
	
	system("PAUSE");
	return 0;
}

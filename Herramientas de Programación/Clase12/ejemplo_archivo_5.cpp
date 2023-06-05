#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main() {

	string pal, linea;
	
	int a=0;
	bool buscando=true;
	char cadena[128];
	
	ifstream pa("Palabras.txt");
	if (pa.fail()){
		cout << "El archivo no se pudo abrir." << endl;
		system("PAUSE");
		exit(1);
	}
	
	getline(cin,pal);
	while (getline(pa,linea)){
		if (pal==linea){
			cout << "\nLa palabra ''" << pal << "'' ha sido encontrada." << endl;
			a=1;
			break; 
		}
	}
	
	if (a==0) cout << "\nLa palabra ''" << pal << "'' NO ha sido encontrada." << endl;
	pa.close();
	
	system("PAUSE");
	return 0;
}

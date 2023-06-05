#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

int main() {
	ofstream archivo;
	
	archivo.open("datos.txt");
	archivo << "Primera linea de texto" << endl;
	archivo << "Segunda linea de texto" << endl;
	archivo << "Tercera linea de texto" << endl;
	archivo << "Prueba sin ";
	archivo << "endl en el medio" << endl;
	archivo.close();
	
	return 0;
}

#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <stdarg.h>
using namespace std;

int main() {
	
	char nombre[10];
	
	cout << "Cual es tu nombre completo?";
	cin >> nombre;
	cout << "\nSaludos!" << nombre << endl;
	
	fflush(stdin);
	
	cout << "\n\nCual es tu nombre completo?" << endl;
	cin.getline(nombre,10);
	cout << "\nSaludos nuevamente! " << nombre << "\n\n" << endl;
	
	system("PAUSE");
	return 0;
	
}

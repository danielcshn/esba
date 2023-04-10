#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <stdarg.h>
using namespace std;

int main(){
	char letra;
	
	cout << "Escribir una palabra cualquiera \n" << endl;
	
	letra=cin.get();
	
	cout << "\nTu palabra empieza con la letra: " << letra << endl;
	
	system("PAUSE");
	return 0;
}

#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <time.h>
#include <fstream>

using namespace std;

int main(){
	struct COORD {int x,y,z;} punto;
	struct COORD *ap_punto;
	punto.x = punto.y = punto.z = 1;
	
	cout << "Valor Inicial: " << endl;
	cout << punto.x << "\t" << punto.y << "\t" << punto.z << "\t" << endl;
	ap_punto = &punto;
	ap_punto -> x++;
	ap_punto -> y+=2;
	ap_punto -> z=4;
	
	cout << "Valor FINAL: " << endl;
	cout << punto.x << "\t" << punto.y << "\t" << punto.z << "\t" << endl;
	
	system("PAUSE");
	return 0;
}

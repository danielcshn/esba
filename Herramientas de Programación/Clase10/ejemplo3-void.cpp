#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

using namespace std;

void calcularAreas(char, double, double);
double area;

int main(){
	char f;
	double b, a;
	string fig;
	
	cout << "Seleccione el tipo de figura ->\n t (triangulo) o r (rectangulo): ";
	cin >> f;
	while (f!='t' && f!='r'){
		printf("Ha ingreado un dato invalido presione t o r: ");
		cin >> f;
	}
	
	cout << "BASE: ";
	cin >> b;
	cout << "ALTURA: ";
	cin >> a;
	
	calcularAreas(f,b,a);
	
	if (f=='t'){
		fig = "triangulo";
	} else {
		fig = "rectangulo";
	}
	
	printf("\n");
	cout << "El area del " << fig << " es: " << area << "\n" << endl;
	system("PAUSE");
	return 0;
}

void calcularAreas(char fig, double base, double altura) {
	if(fig == 't'){
		area = (base*altura)/2;
	} else if (fig == 'r') {
		area = base*altura;
	}
}

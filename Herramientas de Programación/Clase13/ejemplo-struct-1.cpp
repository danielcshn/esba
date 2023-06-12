#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

// Ejemplo Struct 1

using namespace std;

struct Fecha {
	int dia,mes,anio;
};

int main(){
	Fecha hoy, cumpleanios;
	cout << "Ingrese la fecha de hoy" << endl;
	cout << "Dia: "; cin >> hoy.dia;
	cout << "Mes: "; cin >> hoy.mes;
	cout << "Año: "; cin >> hoy. anio;
	
	cout << "Ingrese su cumpleaños" << endl;
	cout << "Dia: "; cin >> cumpleanios.dia;
	cout << "Mes: "; cin >> cumpleanios.mes;
	cout << "Año: "; cin >> cumpleanios.anio;
	
	if(cumpleanios.dia == hoy.dia) {
		if(cumpleanios.mes == hoy.mes){
			cout << "FELIZ CUMPLEAÑOS. FELICITACIONES!!!" << endl;
		} else {
			cout << "Hoy es el mismo dia de tu cumpleaños." << endl;
			cout << "Pero de diferente mes.";
		}
	} else {
		cout << "Hoy no es tu cumpleaños." << endl;
	}
	
	system("PAUSE");
	return 0;
}


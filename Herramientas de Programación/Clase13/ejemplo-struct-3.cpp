#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

// Ejemplo Struct 3

#define t 2

using namespace std;

struct automovil{
	char marca[20];
	char tipo[20];
	int modelo;
};

struct coche{
	struct automovil info_coche;
	int cant_ruedas;
	char usado[3];
	int km;
} autos[t];

int main(){
	int a,b,c;
	string res;
	
	for (int i=0; i<t; i++){
		fflush(stdin);
		cout << "Ingrese la marca del automovil: " << endl;
		cin.getline(autos[i].info_coche.marca,20,'\n');
		
		mod:
			cout << "Que tipo de auto es 1)SEDAN 2)CUPE 3)CABRIOLET 4) RURAL?: " << endl;
			cin >> a;
			
			if (a==1) {
				strcpy(autos[i].info_coche.tipo,"SEDAN");
			} else if (a==2) {
				strcpy(autos[i].info_coche.tipo, "COUPE");
			} else if (a==3) {
				strcpy(autos[i].info_coche.tipo, "CABRIOLET");
			} else if (a==4) {
				strcpy(autos[i].info_coche.tipo, "RURAL");
			} else {
				printf("%d NO es una opcion valida persione 1 a 4: \n\n");
				goto mod;
			}
			
			cout << "Modelo: " << endl;
			cin >> autos[i].info_coche.modelo;
			cout << "Ruedas: " << endl;
			cin >> autos[i].cant_ruedas;
			
			cout << "Es usado?: " << endl;
			cin >> res;
		
		while (res!="si" && res!="no"){
			cout << "RESPUESTA INCORRECTA INGRESE 'si' o 'no': " << endl;
			cin.ignore();
			cin >> res;
		}
		
		cout << "Cual es el kilometraje: " << endl;
		if (res=="no"){
			strcpy(autos[i].usado, "no");
			autos[i].km=0;
		} else {
			strcpy(autos[i].usado, "si");
			cin >> autos[i].km;
		}
		
		system("CLS");
			
	}
	
	for (int j=0;j<t;j++){
		cout << "Marca: " << autos[j].info_coche.marca << endl;
		cout << "Tipo: " << autos[j].info_coche.tipo << endl;
		cout << "Modelo: " << autos[j].info_coche.modelo << endl;
		cout << "Ruedas: " << autos[j].cant_ruedas << endl;
		cout << "Usado: " << autos[j].usado << endl;
		cout << "Kilometraje: " << autos[j].km << endl;
		cout << "------------------------------------------" << endl;
	}
	
	system("PAUSE");
	return 0;
}

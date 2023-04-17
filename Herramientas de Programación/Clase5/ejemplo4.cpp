#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

main(){
	char nombre[30], apellido[30], alumno;
	int codigo, grado, promedio;
	string alumnon;
	
	cout << "Eres alumno del ESBA? (Responde s para si o n para no): " << endl;
	cin >> alumno;
	cin.sync();
	if (alumno == 's'){
		cout << "\n Bienvenido a ESBA BARRIO NORTE! " << endl;
		goto regi;
	} else {
		cout << "\n Esta es tu oportunidad de anotarte: " << endl;
	}
	
	cout << "\n Estas registrado en ESBA? (Responde s/si para si o n/no para no):";
	regresa: 
	cin >> alumnon;
	
	if (alumnon!="si" && alumnon!="s" && alumnon!="no" && alumnon!="n") {
		cout << "El dato ingresado es incorrecto por favor escriba s/si o n/no: ";
		goto regresa;
	}
	
	if (alumnon == "n") {
		cout << "\n Has dicho que eres un alumno nuevo: ";
		cout << "\n Ingresa tu nombre: ";
		cin >> nombre;
		cout << "\n Ingresa tu apellido: ";
		cin >> apellido;
		cout << "\n Bienvenido: " << nombre << " " << apellido << endl;
	} else if (alumnon == "no") {
		cout << "\n Has dicho que eres un alumno nuevo: ";
		cout << "\n Ingresa tu nombre: ";
		cin >> nombre;
		cout << "\n Ingresa tu apellido: ";
		cin >> apellido;
		cout << "\n Bienvenido: " << nombre << " " << apellido << endl;
	} else if (alumnon == "si" || alumnon == "s"){
		regi:
		cout << "Por favor identificate ingresando tu nombre y apellido: ";
		cin >> nombre;
		cin >> apellido;
		cout << "Bienvenido nuevamente: " << nombre << " " << apellido << endl;
	}
	
	system("PAUSE");
	cin.ignore();
	return EXIT_SUCCESS;
}

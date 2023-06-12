#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

// Ejemplo Struct 4

using namespace std;

struct Fecha{
	int dia,mes,anio;
};

struct Persona{
	char nombre[20];
	int edad,peso;
	Fecha fecha;
} persona = {"Catulo",20,45,2,12,1997};

struct Empleado{
	Persona persona;
	int salario;
} trabajador = {"Anibal",19,60,22,7,1983,62.830};

int main(){
	
	cout << "\n\n---------PERSONA---------" << endl;
	cout << "Persona: " << persona.nombre;
	cout << "\nEdad: " << persona.edad;
	cout << "\nPeso: " << persona.peso;
	cout << "\nDia nacimiento: " << persona.fecha.dia;
	cout << "\nMes nacimiento: " << persona.fecha.mes;
	cout << "\nAnio de nacimiento: " << persona.fecha.anio;
	
	cout << "\n\n---------TRABAJADOR---------" << endl;
	cout << "\nTrabajador: " << trabajador.persona.nombre;
	cout << "\nEdad: " << trabajador.persona.edad;
	cout << "\nPeso: " << trabajador.persona.peso;
	cout << "\nDia nacimiento: " << trabajador.persona.fecha.dia;
	cout << "\nMes nacimiento: " << trabajador.persona.fecha.mes;
	cout << "\nAnio nacimiento: " << trabajador.persona.fecha.anio;
	cout << "\nSalario: " << trabajador.salario << endl;
	
	printf("\n\n");
	
	system("PAUSE");
	return 0;
}

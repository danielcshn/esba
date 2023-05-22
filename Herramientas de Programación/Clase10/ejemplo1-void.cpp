#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

using namespace std;

void calculomh();
int minutos, hora;

int main(){
	cout << "Ingrese los minutos: ";
	cin >> minutos;
	calculomh();
	printf("\nSon hora/s: %d:%02d \n\n", hora, minutos);
	system("PAUSE");
	return 0;
}

void calculomh(){
	hora = minutos/60;
	minutos = minutos%60;
}

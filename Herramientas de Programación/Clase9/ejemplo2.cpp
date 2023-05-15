#include <stdlib.h>
#include <conio.h>
#include <string>
#include <iostream>

using namespace std;

main(){
	int n;
	
	for (int i = 0; i < 10; i++) {
		if (i != 5) continue;
		cout << i << " ";
	}

	cout << "\n\n";
	
	cout << "Ingrese un valor de 1 a 10: \n";
	cin >> n;
	
	while (n>11||n<1) {
		cout << "El valor ingresado es incorrecto, ingrese un valor de 1 a 10: \n";
		cin>>n;
	}
	
	for (n;n<11;n++) {
		if (n==3||n==5||n==7)
		continue;
		printf("Usted ha ingresado: %d \n", n);
	}
	
	system("PAUSE");
}

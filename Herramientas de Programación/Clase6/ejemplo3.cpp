#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

int main() {
	string n[5];
	int x;
	
	for(x=0; x<=4; x++) {
		printf("Ingrese un valor: \n");
		cin >> std::ws;
		getline(cin,n[x]);
	}
	
	printf("\n\n");
	
	for(x=4; x>=0; x--){
		cout << "El n° " << x+1 << " contiene: " << n[x] << endl;
	}
	
	system("PAUSE");
}

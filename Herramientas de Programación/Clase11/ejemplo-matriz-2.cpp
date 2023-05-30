#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

using namespace std;

void asteriscos(){
	cout << "\n";
	for (int j=0;j<40;j++){
		cout << "*";
	}
	cout << "\n";
}

int main(){
	int i[10]={1,2,3,4,5,6,7,8,9,5};
	int j[2][3]={0,1,2,10,11,2};
	int a,b=0,c=0,m,n;
	string respvm="";
	
	asteriscos();
	cout << "--Bienvenido al programa de busqueda--" << endl;
	asteriscos();
	cout << "Por favor ingrese el numero a buscar:" << endl;
	cin >> a;
	cout << "Desea buscar en el vector(v) o en la matriz(m)?" << endl;
	cin >> respvm;
	
	while (respvm!="v" && respvm!="m"){
		printf("\nPor favor ingrese (v) para vector o (m) para matriz:\t");
		cin>>respvm;
	}
	
	if (respvm=="v") {
		for(m=0;m<10;m++){
			if(a==i[m]){
				cout << "El numero " << a << "ha sido encontrado en la posicion: " << m << endl; 
			}
		}
		if(b!=1){
			cout << "No existe el numero " << a << " en el VECTOR." << endl;			
		}
	} else if (respvm=="m"){
		for(m=0;m<3;m++){
			for(n=0;n<4;n++){
				if(a==j[m][n]){
					cout << "El numero " << a << " ha sido encontrado en la posicion " << m << " " << n << " de la MATRIZ" << endl;
					b=1;
				}
			}
		}
		if (b!=1){
			cout << "No existe el numero " << a << " en la MATRIZ." << endl;
		}
	}
	
	system("PAUSE");
	return 0;
}

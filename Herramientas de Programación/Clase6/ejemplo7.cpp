#include "iostream"

using namespace std;

int main () {
	int n[3], suma=0, i,j,k;
	
	for(i=0; i<=2; i++){
		cout << "Ingrese un valor " << i + 1 << ": ";
		cin >> n[i];
	}
	
	cout << "\n Ingrese el primer valor que quiere sumar de: ";
	cin >> j;
	j=j-1;
	suma = suma + n[j];
	
	cout << "\n Ingrese el segundo valor que quiere sumar: ";
	cin >> k;
	k=k-1;
	suma = suma + n[k];
	
	cout << "La suma total de " << n[j] << " + " << n[k] << " es igual a: " << suma << endl;
	
	system("PAUSE");
	return 0;
}

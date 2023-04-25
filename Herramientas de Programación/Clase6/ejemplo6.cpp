#include "iostream"

using namespace std;

int main(){
	
	int contador = 0;
	
	for(int i=0; i<52; i++){
		if(i%13 == 0){
			contador++;
		}
	}
	
	cout << "La cantidad de multiuples de 13 es: " << contador << endl;
	
	system("PAUSE");
	return 0;
}

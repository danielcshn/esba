#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <stdarg.h>
using namespace std;

main(){
	
	int a=0, b=0, s=0;
	
	printf("Valor de a = %d y b = %d", a,b);
	s = a + b;
	
	system("PAUSE");
	
	cout << "Ingrese un valor nuevo para a: \n";
	cin >> a;
	cout << "Ingrese un valor nuevo para b: \n";
	cin >> b;
	cout << "Ahora a vale: " << a << " y b vale: " << b;
	s = a + b;
	cout << "\n\n La suma es: " << s;
	getchar();
	getchar();
}

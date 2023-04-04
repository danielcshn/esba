#include <iostream>
#include <limits>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

int main(){
	bool p, s;
	cout << "OPERADORES LOGICOS" << endl;
	cout << "Escribe un primer booleano ( 0 - 1 ): ";
	cin >> p;
	cout << "Escribe un segundo booleano ( 0 - 1 ): ";
	cin >> s;
	cout << "Tus operandos : p = " << p << " : s = " << s << endl;
	cout << "OPERACIONES : " << endl << endl;
	cout << p << " and " << s << " : " << (p and s) << endl;
	cout << p << " or " << s << " : " << (p or s) << endl;
	cout << p << " xor " << s << " : " << (p xor s) << endl;
	cout << "NOT_primero : " << !p << endl;
	cout << "NOT_segundo : " << !s << endl;
	string v="Verdadero", f="falso";
	cout << "Primer operando : " << (p?v:f) << endl;
	cout << "Segundo operando : " << (s?v:f) << endl;
	system("PAUSE");
	return 0;
}

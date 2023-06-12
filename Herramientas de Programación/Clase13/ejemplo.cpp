#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>

using namespace std;

struct Pareja{
	int A, B;
	int LeeA() { return A; }
	int LeeB() { return B; }
	void GuardaA(int n) { A = n; }
	void GuardaB(int n) { B = n; }
} Par;

int main(){

	Par.GuardaA(15);
	Par.GuardaB(63);
	
	cout << Par.LeeA() << endl;
	cout << Par.LeeB() << endl;
	
	system("PAUSE");
	return 0;
}

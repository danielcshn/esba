#include <stdio.h>
#include <stdlib.h>

int main() {
	bool resultado;
	int a = 2, b = 3, c = 4;
	resultado = a <5;				// 2 < 5  [true]
	printf("%d \n", resultado);
	resultado = a * b + c >= 12;	// 10 >= 12  [false]
	printf("%d \n", resultado);
	resultado = a * (b + c) >= 12;	// 14 >= 12 [true]
	printf("%d \n", resultado);
	resultado = a != b;				// 2!= 3 [true]
	printf("%d \n", resultado);
	resultado = a * b >c + 5;		// 6 > 9 [false]
	printf("%d \n", resultado);
	resultado = a + b == c + 1;		// 5 == 5 [true]
	printf("%d \n", resultado);
}

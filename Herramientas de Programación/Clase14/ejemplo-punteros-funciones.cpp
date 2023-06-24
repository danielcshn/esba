#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

void swap(int *px, int *py);

main() {
	int x, y;
	x = 20;
	y = 20;
	printf("x=%d \t y=%d \n",x,y);
	swap(&x, &y);
	printf("x=%d \t y=%d \n",x,y);
	system("PAUSE");
}

void swap(int *px, int *py) {
	int temp;
	temp = *px;
	*px = *py;
	*py = temp;
}

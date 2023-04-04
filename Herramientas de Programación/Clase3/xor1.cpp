#include <stdio.h>
#include <stdlib.h>

int main(){
	bool v1=true, v2=true, f1=false, f2=false, r;
	
	r = v1 xor v2;
	printf("%d \n", r); // false
	r = v1 xor f1;
	printf("%d \n", r); // true
	r = f1 xor v1;
	printf("%d \n", r); // true
	r = f1 xor f2;
	printf("%d \n", r); // false
}

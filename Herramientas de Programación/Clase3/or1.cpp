#include <stdio.h>
#include <stdlib.h>

int main(){
	bool v1=true, v2=true, f1=false, f2=false, r;
	
	r = v1 || v2;
	printf("%d \n", r); // true
	r= v1 || f1;
	printf("%d \n", r); // true
	r = f1 || v1;
	printf("%d \n", r); // true
	r = f1 || f2;
	printf("%d \n", r); // false
}

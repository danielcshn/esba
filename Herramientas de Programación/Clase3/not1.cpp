#include <stdio.h>
#include <stdlib.h>

int main(){
	bool v1=true, v2=true, f1=false, f2=false, r;
	
	r =! v1;
	printf("%d \n", r); // false
	r =! f1; 
	printf("%d \n", r); // true
}

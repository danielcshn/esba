#include <conio.h>
#include <stdio.h>

main(){ 
	int a, b, c;
	
	a = 5;
	b = a + 1;
	c = ( a + 5 * 2 ) * ( b + 6 / 2 ) + ( a * 2 );

	printf( "a = %i, b = %i, c = %i", a, b, c); 
}

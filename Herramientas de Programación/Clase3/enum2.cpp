#include <stdio.h>
#include <stdlib.h>

int main() {
	enum DiaSemana{
		Lunes=1,
		Martes,
		Miercoles,
		Jueves=10,
		Viernes,
		Sabado,
		Domingo=20
	};
	
	// Se le asigna valor a Lunes = 1, Jueves = 10 y Domingo = 20.
	
printf("El valor para Lunes es %d \n", Lunes);
printf("El valor para Martes es %d \n", Martes);
printf("El valor para Miercoles es %d \n", Miercoles);
printf("El valor para Jueves es %d \n", Jueves);
printf("El valor para Viernes es %d \n", Viernes);
printf("El valor para Sabado es %d \n", Sabado);
printf("El valor para Domingo es %d \n", Domingo);

system("PAUSE");
return 0;
}

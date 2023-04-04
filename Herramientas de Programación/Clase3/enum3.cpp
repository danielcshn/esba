#include <stdio.h>
#include <stdlib.h>

//<-- Recuerden que los valores iran desde el 0 al 5
enum colores { azul, amarillo, rojo, verde, blanco, negro };

//<-- Aqui defino colores como t_colores para utilizarla en el programa
typedef enum colores t_colores;

// La declaración del tipo t_colores puede realizarse también así
// typedef enum colores1 {azul, amarillo, rojo, verde, blanco, negro}  t_colores1;
// typedef enum {azul, amarillo, rojo, verde, blanco, negro,}  t_colores;

int main() {
	t_colores color;
}

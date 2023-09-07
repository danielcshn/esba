
/* Crear un programa que declare una variable A de tipo entero y asignarle un valor. A continuación,
muestra un mensaje indicando si A es par o impar.  */

public class Actividad4 {

	public static void main(String[] args) {
		
		int A = 15;
		
        if (A % 2 == 0) {
            System.out.println("El valor de A (" + A + ") es par.");
        } else {
            System.out.println("El valor de A (" + A + ") es impar.");
        }
		
	}

}

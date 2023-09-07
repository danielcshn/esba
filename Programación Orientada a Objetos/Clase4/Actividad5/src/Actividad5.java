
/* Crear un programa que declare una variable B de tipo entero y asignarle un valor. Mostrar un
mensaje indicando si el valor de B es positivo o negativo. Consideraremos el 0 como positivo.
Utiliza el operador condicional ( ? : ) para resolverlo. */

public class Actividad5 {

	public static void main(String[] args) {

		int B = -10;
        String mensaje = (B >= 0) ? "positivo" : "negativo o cero";
        System.out.println("El valor de B es " + mensaje + ".");

	}

}

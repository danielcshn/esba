
/* Crear un programa que declare 2 variables numéricas inicializándolas con un valor. Indicar cual es
mayor o menor. Si son iguales indicarlo también.  */

public class Actividad2 {

	public static void main(String[] args) {
		
		int var1 = 10, var2 = 20;
		
        if (var1 > var2) {
            System.out.println("El primer número (" + var1 + ") es mayor que el segundo número (" + var2 + ").");
        } else if (var1 < var2){
            System.out.println("El primer número (" + var1 + ") es menor que el segundo número (" + var2 + ").");
        } else {
            System.out.println("Ambos números son iguales.");
        }
		
	}

}

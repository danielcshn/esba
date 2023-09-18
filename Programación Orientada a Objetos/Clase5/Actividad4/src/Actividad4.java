import java.util.Scanner;

public class Actividad4 {

	public static void main(String[] args) {
		// Generar un programa que nos solicite dos números y calcule su suma, su diferencia, su producto, su
		// cociente y su módulo, mostrándolos por pantalla.

		
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese el primer número: ");
        double numero1 = scanner.nextDouble();

        System.out.print("Ingrese el segundo número: ");
        double numero2 = scanner.nextDouble();

        // Calcula la suma, diferencia, producto, cociente y módulo
        double suma = numero1 + numero2;
        double diferencia = numero1 - numero2;
        double producto = numero1 * numero2;
        
        // Asegúrate de que el segundo número no sea cero antes de calcular el cociente
        double cociente = 0;
        if (numero2 != 0) {
            cociente = numero1 / numero2;
        } else {
            System.out.println("No se puede calcular el cociente porque el segundo número es cero.");
        }

        // Asegúrate de que el segundo número no sea cero antes de calcular el módulo
        double modulo = 0;
        if (numero2 != 0) {
            modulo = numero1 % numero2;
        } else {
            System.out.println("No se puede calcular el módulo porque el segundo número es cero.");
        }

        // Muestra los resultados
        System.out.println("Suma: " + suma);
        System.out.println("Diferencia: " + diferencia);
        System.out.println("Producto: " + producto);
        System.out.println("Cociente: " + cociente);
        System.out.println("Módulo: " + modulo);

        scanner.close();
        
	}

}

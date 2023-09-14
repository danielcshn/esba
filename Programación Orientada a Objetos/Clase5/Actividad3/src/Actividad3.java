import java.util.Scanner;

public class Actividad3 {

	public static void main(String[] args) {
		// Generar un programa que solicite los coeficientes de una ecuación de 2º grado y muestre sus soluciones
		// reales. Para hacer la raíz cuadrada use el método “sqrt” de la clase Math- Math.sqrt(numero)-.

        Scanner scanner = new Scanner(System.in);

        System.out.println("Ingrese los coeficientes de la ecuación de segundo grado:");
        System.out.print("a: ");
        double a = scanner.nextDouble();
        
        System.out.print("b: ");
        double b = scanner.nextDouble();
        
        System.out.print("c: ");
        double c = scanner.nextDouble();

        // Calcula el discriminante
        double discriminante = b * b - 4 * a * c;

        if (discriminante > 0) {
            // Dos soluciones reales diferentes
            double x1 = (-b + Math.sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.sqrt(discriminante)) / (2 * a);
            System.out.println("Las soluciones son x1 = " + x1 + " y x2 = " + x2);
        } else if (discriminante == 0) {
            // Una única solución real
            double x = -b / (2 * a);
            System.out.println("La solución es x = " + x);
        } else {
            // No hay soluciones reales
            System.out.println("No hay soluciones reales.");
        }

        scanner.close();
		
	}

}

import java.util.Scanner;

public class Actividad1 {

	public static void main(String[] args) {
		// Generar un programa que solicite la base y la altura de un rectángulo y muestre por pantalla su área y
		// su perímetro

        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese la base del rectángulo: ");
        double base = scanner.nextDouble();

        System.out.print("Ingrese la altura del rectángulo: ");
        double altura = scanner.nextDouble();

        // Calcula el área y el perímetro
        double area = base * altura;
        double perimetro = 2 * (base + altura);

        // Muestra los resultados
        System.out.println("El área del rectángulo es: " + area);
        System.out.println("El perímetro del rectángulo es: " + perimetro);

        scanner.close();
		
	}

}

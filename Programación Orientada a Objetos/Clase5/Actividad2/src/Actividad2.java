import java.util.Scanner;

public class Actividad2 {

	public static void main(String[] args) {
		// Generar un programa que solicite una cantidad de segundos y muestre por pantalla a cuántas horas,
		// minutos y segundos corresponden.

        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de segundos: ");
        int segundos = scanner.nextInt();

        // Calcula las horas, minutos y segundos
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        int segundosRestantes = segundos % 60;

        // Muestra los resultados
        System.out.println("Horas: " + horas + " - Minutos: " + minutos + " - Segundos: " + segundosRestantes);
        scanner.close();
		
	}

}

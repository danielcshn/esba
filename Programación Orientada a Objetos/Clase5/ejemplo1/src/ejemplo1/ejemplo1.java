package ejemplo1;

import java.util.Scanner;

public class ejemplo1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner sc = new Scanner(System.in); //sc se usará para leer los datos
		System.out.print("¿Cuántos años tienes?"); //Preguntar la edad
		int edad= sc.nextInt(); //leer un dato
		System.out.println("pareces de " +(edad-3));
		
	}

}

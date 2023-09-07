
/* Crear un programa que declare cuatro variables enteras A, B, C y D y asignarle un valor a cada
una. Además, B toma el valor de C, C toma el valor de A, A tome el valor de D, D tome el valor de
B. Mostrar los valores iniciales y finales de las variables. */

public class Actividad3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int A=10, B=15, C=20, D=25;
		
		System.out.println("Valor A: " + A + ".");
		System.out.println("Valor B: " + B + ".");
		System.out.println("Valor C: " + C + ".");
		System.out.println("Valor D: " + D + ".");
		
		int tmpB = B;
		B = C;
		C = A;
		A = D;
		D = tmpB;
		
		System.out.println("Valor A: " + A + ".");
		System.out.println("Valor B: " + B + ".");
		System.out.println("Valor C: " + C + ".");
		System.out.println("Valor D: " + D + ".");
		
	}

}

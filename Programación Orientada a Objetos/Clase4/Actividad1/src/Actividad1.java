
/* Crear un programa que declare una variable entera N y asignarle un valor. Se debe incrementar N
en 77, decrementar en 3 y duplicar su valor. Mostrar el valor de N, en cada caso
 */

public class Actividad1 {
	
	public static void main(String[] args) {
		
		int N = 10;
		System.out.println("N: "+N);
		N += 77;
		System.out.println("Resultado es +77: "+N);
		N -= 3;
		System.out.println("Resultado es -3: "+N);
		N *= 2;
		System.out.println("Resultado es X2: "+N);
		
	}
	
}

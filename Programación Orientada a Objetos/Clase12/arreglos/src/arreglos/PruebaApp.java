package arreglos;

public class PruebaApp {

	public static void main(String[] args) {

		int num[] = new int[10];
		
		num[0]=5;
		num[1]=9;
		
		System.out.println(num[0]);
		System.out.println(num[1]);
		
		for (int i=0, multiplo=5;i<num.length;i++, multiplo+=5) {
			num[i]=multiplo;
			System.out.println(num[i]);
		}
		
	}
}
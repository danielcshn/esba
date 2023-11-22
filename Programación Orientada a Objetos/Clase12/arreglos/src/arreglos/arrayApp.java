package arreglos;

public class arrayApp {

	public static void main(String[] args) {
		int num[] = rellenarArrayDesde(5);
		impimirArray(num);
	}

	public static void impimirArray (int lista[]) {
		for(int i=0;i<lista.length;i++) {
			System.out.println(lista[i]);
		}
	}
	
	public static int[] rellenarArrayDesde(int a) {
		int num[]=new int[10];
		for(int i=0;i<num.length;i++) {
			num[i]=a;
			a++;
		}
		return num;
	}
}
